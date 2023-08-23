using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using Wesktop__.NET_Framework_4._7._2_;

namespace Wesktop
{
	public partial class MenuBar : Form
	{
		public MenuBar()
		{
			InitializeComponent();
		}
		private void OnLoad(object sender, EventArgs e)
		{
			Rectangle screen = Screen.FromControl(this).Bounds;
			Width = screen.Width;
			Height = 25;
			ActiveForm.Size = new Size(Width, Height);    //	Sets width to screen width
			//ActiveForm.Location = new Point(0, Screen.FromControl(this).Bounds.Bottom);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("shutdown", "/s /t 0");
		}

		private void fileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("explorer");
		}

		private void runToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Thread(() => new RunDialog().ShowDialog()).Start();
		}

		private void wINEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("winver");
		}

		private void wesktopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show(Assembly.GetExecutingAssembly().GetName().FullName);
		}
	}
}
