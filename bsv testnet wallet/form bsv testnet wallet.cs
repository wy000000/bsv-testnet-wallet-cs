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
		internal Class_wallet bsvTestWallet = null;

		public F_wallet()
		{
			InitializeComponent();
		}


		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://scrypt.io/faucet");
		}

		private void F_wallet_Load(object sender, EventArgs e)
		{

		}

		private void bt_login_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			clearForm();
			string ID = tb_ID.Text.Trim();
			if (!(ID == ""))
			{
				bsvTestWallet = new Class_wallet(ID, radioButton_testnet.Checked);
				tb_originalKey.Text = bsvTestWallet.OriginalKeyStr;
				tb_wifKey.Text=bsvTestWallet.WifKeyStr;
				tb_compressedPubkey.Text = bsvTestWallet.CompressedPubKeyStr;
				tb_pubKeyHash.Text = bsvTestWallet.PubKeyHashStr;
				tb_address.Text = bsvTestWallet.AddressStr;
				tb_balance.Text = bsvTestWallet.BalanceSats.ToString();

			}
			else
			{
				MessageBox.Show("学号为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			this.Enabled = true;
		}

		private void bt_utxo_Click(object sender, EventArgs e)
		{
			Form f_utxo = Application.OpenForms["f_utxo"];
			if (f_utxo != null && !f_utxo.IsDisposed)
			{
				// 窗体存在且没有被Dispose
				f_utxo.Activate(); // 将窗体调到前面显示
			}
			else
			{
				// 窗体不存在或已被Dispose，可以创建并显示新窗体
				f_utxo = new F_utxo();
				f_utxo.Show();
			}
		}

		private void radioButton_testnet_CheckedChanged(object sender, EventArgs e)
		{
			clearForm();
		}
		void clearForm()
		{
			bsvTestWallet = null;
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
			tb_netStatus.Clear();
		}
	}
}
