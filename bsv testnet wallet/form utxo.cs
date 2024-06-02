using BsvSimpleLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;

namespace bsv_testnet_wallet
{
	public partial class F_utxo : Form
	{
		F_wallet f_main = null;
		public F_utxo(F_wallet F_main)
		{
			InitializeComponent();
			f_main=F_main;
		}

		private void F_utxo_Load(object sender, EventArgs e)
		{
			showUtxos();
		}
		LinkLabel[] linkLabels = null;

		void showUtxos()
		{
			this.Enabled = false;
			Program.removeLinkLabel(flowLayoutPanel1);
			f_main.Enabled = false;

			if (Program.bsvTestWallet != null)
			{
				RestApiUtxo_class[] utxos = Program.bsvTestWallet.GetUtxosForOutside();
				if (utxos != null)
				{
					f_main.changeBalance();
					//= Program.bsvTestWallet.Utxos;
					linkLabels = new LinkLabel[utxos.Length];
					for (int i = 0; i < linkLabels.Length; i++)
					{
						linkLabels[i] = new LinkLabel();
						linkLabels[i].AutoSize = true;
						linkLabels[i].Text = JsonConvert.SerializeObject(utxos[i]);
						string url = "https://test.whatsonchain.com/tx/" + utxos[i].TxId;
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
			showUtxos();
		}
		//private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		//{
		//	// 打开默认浏览器访问指定网页
		//	Process.Start(e.Link.LinkData.ToString());
		//}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
