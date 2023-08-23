
namespace Wesktop
{
	partial class MenuBar
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBar));
			this.AppBar = new System.Windows.Forms.ToolStrip();
			this.Start = new System.Windows.Forms.ToolStripDropDownButton();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wINEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AppBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// AppBar
			// 
			this.AppBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.AppBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.AppBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start,
            this.toolStripSeparator1});
			this.AppBar.Location = new System.Drawing.Point(0, 200);
			this.AppBar.Name = "AppBar";
			this.AppBar.Size = new System.Drawing.Size(686, 25);
			this.AppBar.TabIndex = 0;
			this.AppBar.Text = "toolStrip1";
			// 
			// Start
			// 
			this.Start.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.runToolStripMenuItem,
            this.fileExplorerToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
			this.Start.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(67, 22);
			this.Start.Text = "Menu";
			this.Start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Start.ToolTipText = "Opens the Menu";
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("runToolStripMenuItem.Image")));
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.runToolStripMenuItem.Text = "Run";
			this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
			// 
			// fileExplorerToolStripMenuItem
			// 
			this.fileExplorerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileExplorerToolStripMenuItem.Image")));
			this.fileExplorerToolStripMenuItem.Name = "fileExplorerToolStripMenuItem";
			this.fileExplorerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.fileExplorerToolStripMenuItem.Text = "File Explorer";
			this.fileExplorerToolStripMenuItem.ToolTipText = "Open File Explorer";
			this.fileExplorerToolStripMenuItem.Click += new System.EventHandler(this.fileExplorerToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Shutdown";
			this.exitToolStripMenuItem.ToolTipText = "Exit WINE";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wINEToolStripMenuItem,
            this.wesktopToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// wINEToolStripMenuItem
			// 
			this.wINEToolStripMenuItem.Name = "wINEToolStripMenuItem";
			this.wINEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.wINEToolStripMenuItem.Text = "WINE";
			this.wINEToolStripMenuItem.Click += new System.EventHandler(this.wINEToolStripMenuItem_Click);
			// 
			// wesktopToolStripMenuItem
			// 
			this.wesktopToolStripMenuItem.Name = "wesktopToolStripMenuItem";
			this.wesktopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.wesktopToolStripMenuItem.Text = "Wesktop";
			this.wesktopToolStripMenuItem.Click += new System.EventHandler(this.wesktopToolStripMenuItem_Click);
			// 
			// MenuBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(686, 225);
			this.Controls.Add(this.AppBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MenuBar";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Wesktop";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.OnLoad);
			this.AppBar.ResumeLayout(false);
			this.AppBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip AppBar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripDropDownButton Start;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileExplorerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wINEToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wesktopToolStripMenuItem;
	}
}

