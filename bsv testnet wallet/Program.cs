using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bsv_testnet_wallet
{
	internal static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new F_wallet());
		}
		internal static Class_wallet bsvTestWallet = null;
		internal static void removeLinkLabel(Control container)
		{
			List<Control> removelist = new List<Control>();
			foreach (Control control in container.Controls)
				if (control is LinkLabel)
					removelist.Add(control);
			foreach (Control control in removelist)
				container.Controls.Remove(control);
		}
		internal static void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// 打开默认浏览器访问指定网页
			Process.Start(e.Link.LinkData.ToString());
		}

	}
}
