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
		internal static void showForm(string formName, string formCalssName, F_wallet formp = null)
		{
			//if (Program.bsvTestWallet != null)
			//{
			Form newForm = Application.OpenForms[formName];
			if (newForm != null && !newForm.IsDisposed)
			{
				// 窗体存在且没有被Dispose
				newForm.Activate(); // 将窗体调到前面显示
			}
			else
			{
				// 窗体不存在或已被Dispose，可以创建并显示新窗体
				newForm = (Form)CreateInstance("bsv_testnet_wallet." + formCalssName, formp);
				//newForm = new F_utxo(formp);
				newForm.Show();
			}
			//}
		}
		static object CreateInstance(string className, params object[] args)
		{
			Type type = Type.GetType(className);
			if (type != null)
			{
				return Activator.CreateInstance(type, args);
			}
			else
			{
				// 类型可能在不同的程序集中，你可能需要遍历所有程序集来找到它
				foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
				{
					type = asm.GetType(className);
					if (type != null)
					{
						return Activator.CreateInstance(type, args);
					}
				}
			}
			throw new ArgumentException("No such class exists.");
		}

	}
}
