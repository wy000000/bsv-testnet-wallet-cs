using BsvSimpleLibrary;
using Newtonsoft.Json;
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
	public partial class F_tx : Form
	{
		F_wallet f_main = null;
		public F_tx(F_wallet F_main)
		{
			InitializeComponent();
			f_main = F_main;
		}

		private void F_tx_Load(object sender, EventArgs e)
		{
			showTx();
		}
		LinkLabel[] linkLabels = null;
		void showTx()
		{
			this.Enabled = false;
			Program.removeLinkLabel(flowLayoutPanel1);
			f_main.Enabled = false;
			if (Program.bsvTestWallet != null)
			{
				RestApiAddressHistoryTx[] txs = Program.bsvTestWallet.getTxs();
				if (txs != null)
				{
					linkLabels = new LinkLabel[txs.Length];
					for (int i = 0; i < linkLabels.Length; i++)
					{
						linkLabels[i] = new LinkLabel();
						linkLabels[i].AutoSize = true;
						linkLabels[i].Text = JsonConvert.SerializeObject(txs[i]);
						string url = "https://test.whatsonchain.com/tx/" + txs[i].TxHash;
						linkLabels[i].Links.Add(0, linkLabels[i].Text.Length, url);
						// 添加LinkClicked事件处理程序
						linkLabels[i].LinkClicked += Program.LinkLabel_LinkClicked;
						flowLayoutPanel1.Controls.Add(linkLabels[i]);
					}
				}
			}
			f_main.Enabled = true;
			this.Enabled = true;
		}

		private void bt_refresh_Click(object sender, EventArgs e)
		{
			showTx();
		}
	}
}
