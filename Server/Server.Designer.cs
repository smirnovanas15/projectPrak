namespace TestNetServer
{
	partial class Server
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
            this.lblog = new System.Windows.Forms.ListBox();
            this.tbPrivateKeyA = new System.Windows.Forms.TextBox();
            this.lbPrivateKeyA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblog
            // 
            this.lblog.FormattingEnabled = true;
            this.lblog.Location = new System.Drawing.Point(5, 8);
            this.lblog.Name = "lblog";
            this.lblog.Size = new System.Drawing.Size(321, 186);
            this.lblog.TabIndex = 0;
            this.lblog.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbPrivateKeyA
            // 
            this.tbPrivateKeyA.Location = new System.Drawing.Point(63, 200);
            this.tbPrivateKeyA.Name = "tbPrivateKeyA";
            this.tbPrivateKeyA.Size = new System.Drawing.Size(100, 20);
            this.tbPrivateKeyA.TabIndex = 1;
            this.tbPrivateKeyA.Text = "4";
            // 
            // lbPrivateKeyA
            // 
            this.lbPrivateKeyA.AutoSize = true;
            this.lbPrivateKeyA.Location = new System.Drawing.Point(11, 203);
            this.lbPrivateKeyA.Name = "lbPrivateKeyA";
            this.lbPrivateKeyA.Size = new System.Drawing.Size(46, 13);
            this.lbPrivateKeyA.TabIndex = 2;
            this.lbPrivateKeyA.Text = "Ключ-A:";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 229);
            this.Controls.Add(this.lbPrivateKeyA);
            this.Controls.Add(this.tbPrivateKeyA);
            this.Controls.Add(this.lblog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lblog;
		private System.Windows.Forms.TextBox tbPrivateKeyA;
		private System.Windows.Forms.Label lbPrivateKeyA;
	}
}

