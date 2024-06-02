﻿using System;
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
			f_main.Enabled=false;
			if(rb_address.Checked)
			{
				if (tb_address.Text == "")
				{ { MessageBox.Show("地址为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } }
				Program.bsvTestWallet=new Class_wallet(tb_address.Text, )
			}


			if (rb_id.Checked)
			{
				if (tb_ID.Text.Trim() == "")
				{ MessageBox.Show("学号为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
				//Program.bsvTestWallet = new Class_wallet();

			}


			f_main.Enabled = true;
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
