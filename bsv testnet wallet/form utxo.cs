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
			removeLinkLabel();
			f_main.Enabled = false;
			if (Program.bsvTestWallet != null && Program.bsvTestWallet.Utxos != null)
			{
				f_main.changeBalance(Program.bsvTestWallet.BalanceSats.ToString());
				RestApiUtxo_class[] utxos = Program.bsvTestWallet.Utxos;
				linkLabels = new LinkLabel[utxos.Length];
				for (int i = 0; i < linkLabels.Length; i++)
				{
					linkLabels[i] = new LinkLabel();
					linkLabels[i].AutoSize = true;
					linkLabels[i].Text = JsonConvert.SerializeObject(utxos[i]);
					flowLayoutPanel1.Controls.Add(linkLabels[i]);
				}
			}
			f_main.Enabled = true;
			this.Enabled = true;
		}
		void removeLinkLabel()
		{
			foreach(Control control in flowLayoutPanel1.Controls)
			{
				if(control is LinkLabel)
				{
					flowLayoutPanel1.Controls.Remove(control);
				}
			}
		}
		private void bt_refresh_Click(object sender, EventArgs e)
		{
			showUtxos();
		}
	}
}
