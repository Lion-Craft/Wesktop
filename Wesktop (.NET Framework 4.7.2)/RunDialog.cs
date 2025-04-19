using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Wesktop__.NET_Framework_4._7._2_
{
	public partial class RunDialog : Form
	{
		public RunDialog()
		{
			InitializeComponent();
		}
		
		//	This is run when either the "Ok" button or accept key is pressed
		private void Accept_Click(object sender, EventArgs e)
		{
			string cmd = RunTextBox.Text;	//	Get command from RunTextBox
			try
			{
				Process.Start(cmd); //	Run start the process pointed to by cmd
				ActiveForm.Hide();  //	Close RunDialog
			}
			catch (Exception ex)
			{
				MessageBox.Show("Wesktop cannot find '" + cmd + "'. Make sure you typed the name correctly, and then try again.", cmd, MessageBoxButtons.OK, MessageBoxIcon.Error);	//	Show error message with explanation
			}
		}

		//	TODO: Fix error when opening Run Dialog
		[STAThread]
		private void Browse_Click(object sender, EventArgs e)
		{
			RunTextBox.Text = RunFileDialog.ShowDialog().ToString();
		}
	}
}
