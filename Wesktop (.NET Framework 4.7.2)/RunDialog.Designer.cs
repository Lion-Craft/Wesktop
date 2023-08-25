
namespace Wesktop__.NET_Framework_4._7._2_
{
	partial class RunDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunDialog));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Accept = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.Browse = new System.Windows.Forms.Button();
			this.RunTextBox = new System.Windows.Forms.TextBox();
			this.RunFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter the name of a program, folder or command \r\nin the text field below.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// Accept
			// 
			this.Accept.Location = new System.Drawing.Point(12, 126);
			this.Accept.Name = "Accept";
			this.Accept.Size = new System.Drawing.Size(100, 25);
			this.Accept.TabIndex = 2;
			this.Accept.Text = "Ok";
			this.Accept.UseVisualStyleBackColor = true;
			this.Accept.Click += new System.EventHandler(this.Accept_Click);
			// 
			// Cancel
			// 
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(118, 126);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(100, 25);
			this.Cancel.TabIndex = 3;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			// 
			// Browse
			// 
			this.Browse.Location = new System.Drawing.Point(239, 126);
			this.Browse.Name = "Browse";
			this.Browse.Size = new System.Drawing.Size(100, 25);
			this.Browse.TabIndex = 4;
			this.Browse.Text = "Browse...";
			this.Browse.UseVisualStyleBackColor = true;
			this.Browse.Click += new System.EventHandler(this.Browse_Click);
			// 
			// RunTextBox
			// 
			this.RunTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.RunTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.RunTextBox.Location = new System.Drawing.Point(53, 70);
			this.RunTextBox.Name = "RunTextBox";
			this.RunTextBox.Size = new System.Drawing.Size(234, 20);
			this.RunTextBox.TabIndex = 0;
			// 
			// RunFileDialog
			// 
			this.RunFileDialog.DefaultExt = "exe";
			this.RunFileDialog.FileName = "RunFileDialog";
			this.RunFileDialog.Filter = "Programs|*.exe;*.pif;*.com;*.bat;*.cmd|All Files|*.*";
			this.RunFileDialog.RestoreDirectory = true;
			// 
			// RunDialog
			// 
			this.AcceptButton = this.Accept;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size(365, 171);
			this.Controls.Add(this.RunTextBox);
			this.Controls.Add(this.Browse);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Accept);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RunDialog";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Run";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button Accept;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button Browse;
		private System.Windows.Forms.TextBox RunTextBox;
		private System.Windows.Forms.OpenFileDialog RunFileDialog;
	}
}