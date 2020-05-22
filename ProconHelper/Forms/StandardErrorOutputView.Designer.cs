namespace ProconHelper.Forms
{
	partial class StandardErrorOutputView
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
			if (disposing && (components != null)) {
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
			this.stdErrBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// stdErrBox
			// 
			this.stdErrBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stdErrBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stdErrBox.Location = new System.Drawing.Point(10, 24);
			this.stdErrBox.Multiline = true;
			this.stdErrBox.Name = "stdErrBox";
			this.stdErrBox.ReadOnly = true;
			this.stdErrBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.stdErrBox.Size = new System.Drawing.Size(778, 414);
			this.stdErrBox.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 12);
			this.label3.TabIndex = 10;
			this.label3.Text = "標準エラー出力: ";
			// 
			// StandardErrorOutputView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.stdErrBox);
			this.Controls.Add(this.label3);
			this.Name = "StandardErrorOutputView";
			this.Text = "標準エラー出力";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StandardErrorOutputView_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox stdErrBox;
		private System.Windows.Forms.Label label3;
	}
}