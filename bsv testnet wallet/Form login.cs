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
	public partial class F_login : Form
	{
		F_wallet f_main = null;
		public F_login(F_wallet f_mainp)
		{
			InitializeComponent();
			f_main = f_mainp;
		}

		private void F_login_Load(object sender, EventArgs e)
		{

		}

		private void bt_login_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			f_main.Enabled=false;

			if(rb_address.Checked)
			{
				if (tb_address.Text == "")
					 MessageBox.Show("地址为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
				Program.bsvTestWallet = Class_wallet.createBsvWallet(tb_address.Text, radioButton_testnet.Checked,
					Class_wallet.walletTypeAddress);
			}
			if (rb_wifKey.Checked)
			{
				if (tb_wifKey.Text == "")
					MessageBox.Show("钱包私钥为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					Program.bsvTestWallet = Class_wallet.createBsvWallet(tb_wifKey.Text, radioButton_testnet.Checked,
						Class_wallet.walletTypeWifKey);
			}
			if (rb_id.Checked)
			{
				if (tb_ID.Text == "")
					MessageBox.Show("学号为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					Program.bsvTestWallet = Class_wallet.createBsvWallet(tb_ID.Text, radioButton_testnet.Checked,
						Class_wallet.walletTypeID);
			}
			f_main.Enabled = true;
			this.Enabled = true;
			if (Program.bsvTestWallet != null)
			{
				f_main.showWalletInfo();
				f_main.Activate();
				this.Close();
			}
		}

		private void rb_id_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_id.Checked)
			{
				disableTextBox();
				tb_ID.ReadOnly = false;
			}
		}
		void disableTextBox()
		{
			tb_ID.ReadOnly = true;
			tb_wifKey.ReadOnly = true;
			tb_address.ReadOnly = true;
		}

		private void rb_wifKey_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_wifKey.Checked)
			{
				disableTextBox();
				tb_wifKey.ReadOnly = false;
			}
		}

		private void rb_address_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_address.Checked)
			{
				disableTextBox();
				tb_address.ReadOnly = false;
			}
		}
	}
}
