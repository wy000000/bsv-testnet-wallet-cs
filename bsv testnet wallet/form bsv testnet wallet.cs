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
		//internal Class_wallet Program.bsvTestWallet = null;
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
			Program.bsvTestWallet = null;
			clearForm();
			Program.showForm("f_login", "F_login", this);
			//string ID = tb_ID.Text.Trim();
			//if (!(ID == ""))
			//{
			//	Program.bsvTestWallet = new Class_wallet(ID, radioButton_testnet.Checked);
			//}
			//else
			//{
			//	MessageBox.Show("学号为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			//}
			this.Enabled = true;
		}
		internal void showWalletInfo()
		{
			if (Program.bsvTestWallet == null)
			{
				bt_send.Enabled = false;
				bt_utxo.Enabled = false;
				bt_tx.Enabled = false;
				bt_refreshBalance.Enabled = false;
			}
			else
			{
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
				//Form f_utxo = Application.OpenForms["f_utxo"];
				//if (f_utxo != null && !f_utxo.IsDisposed)
				//{
				//	// 窗体存在且没有被Dispose
				//	f_utxo.Activate(); // 将窗体调到前面显示
				//}
				//else
				//{
				//	// 窗体不存在或已被Dispose，可以创建并显示新窗体
				//	f_utxo = new F_utxo(this);
				//	f_utxo.Show();
				//}
			}
			this.Enabled = true;
		}
		private void bt_tx_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			if (Program.bsvTestWallet != null)
			{
				Program.showForm("f_tx", "F_tx", this);
				//Form f_tx = Application.OpenForms["f_tx"];
				//if (f_tx != null && !f_tx.IsDisposed)
				//{
				//	// 窗体存在且没有被Dispose
				//	f_tx.Activate(); // 将窗体调到前面显示
				//}
				//else
				//{
				//	// 窗体不存在或已被Dispose，可以创建并显示新窗体
				//	f_tx = new F_tx(this);
				//	f_tx.Show();
				//}
			}
			this.Enabled = true;
		}

		//private void radioButton_testnet_CheckedChanged(object sender, EventArgs e)
		//{
		//	clearForm();
		//}

		void clearForm()
		{
			Program.bsvTestWallet = null;
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
			//tb_netStatus.Clear();
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
			if(Program.bsvTestWallet==null)
			{
				MessageBox.Show("未登录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Enabled = true;
				return;
			}
			if(tb_sats.Text=="")
			{
				MessageBox.Show("发送数量为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Enabled = true;
				return;
			}
			string sendInfo = null;
			bool sendSuccess = Program.bsvTestWallet.sendCoins(long.Parse(tb_sats.Text), tb_destAddress.Text.Trim(),
				tb_destAddress.Text, tb_opReturn.Text.Trim(), out sendInfo);
			tb_balance.Text = Program.bsvTestWallet.BalanceSats.ToString();
			if (sendSuccess)
			{
				sendInfo = "发送成功！" + sendInfo;
				MessageBox.Show(sendInfo, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				sendInfo = "发送失败！" + sendInfo;
				MessageBox.Show(sendInfo, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			this.Enabled = true;
		}

		//public void changeBalance()
		//{
		//	tb_balance.Text = Program.bsvTestWallet.BalanceSats.ToString();
		//}

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
