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
	public partial class F_utxo : Form
	{
		public F_utxo()
		{
			InitializeComponent();
			
		}

		private void F_utxo_Load(object sender, EventArgs e)
		{

		}

		private void F_utxo_FormClosing(object sender, FormClosingEventArgs e)
		{
			//F_wallet.b_f_utxo_closed = true;
		}
	}
}
