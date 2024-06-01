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

		void showUtxos()
		{
			foreach(RestApiUtxo_class utxo in bsv)

		}
	}
}
