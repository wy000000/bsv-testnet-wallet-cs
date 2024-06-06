using NBitcoin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsv_testnet_wallet
{

	public partial class F_wallet : Form
	{
		public F_wallet()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel1.LinkVisited = true;
			System.Diagnostics.Process.Start("https://scrypt.io/faucet");
		}

		private void F_wallet_Load(object sender, EventArgs e)
		{
			showWalletInfo();
		}

		private void bt_login_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			//Program.bsvTestWallet = null;
			//clearForm();
			Program.showForm("f_login", "F_login", this);
			this.Enabled = true;
		}
		internal void showWalletInfo()
		{
			clearForm();
			if (Program.bsvTestWallet == null)
			{
				bt_send.Enabled = false;
				bt_utxo.Enabled = false;
				bt_tx.Enabled = false;
				bt_refreshBalance.Enabled = false;
			}
			else
			{
				tb_address.BackColor = SystemColors.Control;
				tb_address.ForeColor = Color.Blue;
				tb_ID.Text = Program.bsvTestWallet.ID;
				tb_network.Text = Program.bsvTestWallet.NetWork;
				tb_originalKey.Text = Program.bsvTestWallet.OriginalKeyStr;
				tb_wifKey.Text = Program.bsvTestWallet.WifKeyStr;
				tb_compressedPubkey.Text = Program.bsvTestWallet.CompressedPubKeyStr;
				tb_pubKeyHash.Text = Program.bsvTestWallet.PubKeyHashStr;
				tb_address.Text = Program.bsvTestWallet.AddressStr;
				tb_balance.Text = Program.bsvTestWallet.BalanceSats.ToString();
				tb_changeAddress.Text = Program.bsvTestWallet.AddressStr;
				/////////////////////
				tb_destAddress.Text = Program.bsvTestWallet.AddressStr;
				bt_send.Enabled = true;
				bt_utxo.Enabled=true;
				bt_tx.Enabled=true;
				bt_refreshBalance.Enabled=true;
				if (Program.bsvTestWallet.WalletType == Class_wallet.walletTypeAddress
					|| Program.bsvTestWallet.BalanceSats == 0)
					bt_send.Enabled = false;
			}
		}

		private void bt_utxo_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			if (Program.bsvTestWallet != null)
			{
				Program.showForm("f_utxo", "F_utxo", this);
			}
			this.Enabled = true;
		}
		private void bt_tx_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			if (Program.bsvTestWallet != null)
			{
				Program.showForm("f_tx", "F_tx", this);
			}
			this.Enabled = true;
		}
		private void bt_encryptSign_Click(object sender, EventArgs e)
		{
			Program.showForm("f_s_e", "F_s_e", null);
		}

		void clearForm()
		{
			//Program.bsvTestWallet = null;
			tb_ID.Clear();
			tb_network.Clear();
			tb_originalKey.Clear();
			tb_wifKey.Clear();
			tb_compressedPubkey.Clear();
			tb_pubKeyHash.Clear();
			tb_address.Clear();
			tb_balance.Clear();
			tb_destAddress.Clear();
			tb_changeAddress.Clear();
			tb_opReturn.Clear();
			tb_sats.Clear();
		}

		private void bt_refreshBalance_Click(object sender, EventArgs e)
		{
			this.Enabled=false;
			if (Program.bsvTestWallet != null)
			{
				Program.bsvTestWallet.getUtxosAndRefreshBalance();
				showWalletInfo();
			}
			this.Enabled = true;
		}

		private void bt_send_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			try
			{
				if (tb_sats.Text == "")
				{
					MessageBox.Show("No Amount!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Enabled = true;
					return;
				}
				if (long.Parse(tb_sats.Text) >= long.Parse(tb_balance.Text))
				{
					MessageBox.Show("Insufficient balance!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Enabled = true;
					return;
				}
				string sendInfo = null;
				bool sendSuccess = Program.bsvTestWallet.sendCoins(long.Parse(tb_sats.Text),
					tb_destAddress.Text.Trim(), tb_changeAddress.Text, tb_opReturn.Text.Trim(), out sendInfo);
				tb_balance.Text = Program.bsvTestWallet.BalanceSats.ToString();
				if (sendSuccess)
				{
					sendInfo = "Sent successfully!" + sendInfo;
					MessageBox.Show(sendInfo, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					sendInfo = "Send failed!" + sendInfo;
					MessageBox.Show(sendInfo, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				// Display the exception type and message
				MessageBox.Show(ex.GetType().Name + ", " + ex.Message, "Info", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			this.Enabled = true;
		}

		private void tb_address_DoubleClick(object sender, EventArgs e)
		{
			if (tb_address.Text != null && tb_address.Text != "")
			{
				System.Diagnostics.Process.Start("https://test.whatsonchain.com/address/" + tb_address.Text);
				tb_address.BackColor = SystemColors.Control;
				tb_address.ForeColor = Color.Purple;
			}
		}

		private void tb_address_TextChanged(object sender, EventArgs e)
		{
		}

	}
}
