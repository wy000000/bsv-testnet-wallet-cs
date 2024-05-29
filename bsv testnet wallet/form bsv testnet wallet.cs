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

		private void button4_Click(object sender, EventArgs e)
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
	}
}
