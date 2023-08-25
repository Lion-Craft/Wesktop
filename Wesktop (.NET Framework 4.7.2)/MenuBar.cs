using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Wesktop__.NET_Framework_4._7._2_;

namespace Wesktop
{
	public partial class MenuBar : Form
	{
		
		public MenuBar()
		{
			InitializeComponent();
		}

		//	Size window to appropriate size and hide arrow on load
		private void OnLoad(object sender, EventArgs e)
		{
			Rectangle screen = Screen.FromControl(this).Bounds;
			Width = screen.Width;	//	Sets width of MenuBar
			Height = 25;	//	Sets height of MenuBar		Note: 25 is the correct height for the AppBar
			ActiveForm.Size = new Size(Width, Height);    //	Sets width to screen width
			//ActiveForm.Location = new Point(0, Screen.FromControl(this).Bounds.Bottom);

			Start.ShowDropDownArrow = false;	//	Disable the Arrow on the Menu button
		}

		//	Exit Wesktop
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//	Open Explorer
		private void fileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("explorer");
		}

		//	Create Run dialog
		[STAThread]
		private void runToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Thread(() => new RunDialog().ShowDialog()).Start();
		}

		//	Start winver to display WINE info
		private void wINEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("winver");
		}

		//	Create ShellAbout method for "About Wesktop" menu
		[DllImport("shell32.dll")]
		static extern int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);	

		//	Display info about Wesktop
		private void wesktopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//	Create and write License to variable
			string license = "Wesktop is licensed unter the MIT License.";
			//	Call ShellAbout
			ShellAbout(IntPtr.Zero, "Wesktop " + Assembly.GetExecutingAssembly().GetName().Version.ToString(), "Wesktop v." + Assembly.GetExecutingAssembly().GetName().Version.ToString() + " https://github.com/Lion-Craft/Wesktop" + "\n" + license, Icon.Handle);
		}

		private void MenuBar_KeyUp(object sender, KeyEventArgs e)
		{
			//	Get pressed key and open or close the Menu
			if (e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin)
			{
				if (Start.DropDown.Visible)
				{
					Start.HideDropDown();	//	Close Menu
				}
				else
				{
					Start.ShowDropDown();	//	Open Menu
				}
			}
		}

		private void controlPanelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("control");
		}

		private void wINEConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("winecfg");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n\nThis can be caused due to running either natively on Windows or due to a corrupt WINE install.");
			}
		}
	}
}
