using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
			Process.Start(RunTextBox.Text);	//	Get text from TextBox and start the process
			ActiveForm.Hide();	//	Close RunDialog
		}

		//	TODO: Fix error when opening Run Dialog
		[STAThread]
		private void Browse_Click(object sender, EventArgs e)
		{
			RunTextBox.Text = RunFileDialog.ShowDialog().ToString();
		}
	}
}
