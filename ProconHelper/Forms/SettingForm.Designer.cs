namespace ProconHelper.Forms
{
	partial class SettingForm
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
			this.plComboBox = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.openPlFolderBtn = new System.Windows.Forms.Button();
			this.okBtn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// plComboBox
			// 
			this.plComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.plComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.plComboBox.FormattingEnabled = true;
			this.plComboBox.Location = new System.Drawing.Point(150, 47);
			this.plComboBox.Name = "plComboBox";
			this.plComboBox.Size = new System.Drawing.Size(151, 20);
			this.plComboBox.TabIndex = 0;
			this.plComboBox.SelectedIndexChanged += new System.EventHandler(this.plComboBox_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.openPlFolderBtn);
			this.groupBox1.Controls.Add(this.plComboBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(307, 107);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "プログラミング言語処理系";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "使用するプログラミング言語: ";
			// 
			// openPlFolderBtn
			// 
			this.openPlFolderBtn.Location = new System.Drawing.Point(6, 18);
			this.openPlFolderBtn.Name = "openPlFolderBtn";
			this.openPlFolderBtn.Size = new System.Drawing.Size(145, 23);
			this.openPlFolderBtn.TabIndex = 1;
			this.openPlFolderBtn.Text = "設定フォルダを開く";
			this.openPlFolderBtn.UseVisualStyleBackColor = true;
			this.openPlFolderBtn.Click += new System.EventHandler(this.openPlFolderBtn_Click);
			// 
			// okBtn
			// 
			this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okBtn.Location = new System.Drawing.Point(244, 125);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(75, 23);
			this.okBtn.TabIndex = 2;
			this.okBtn.Text = "OK";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// SettingForm
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 160);
			this.Controls.Add(this.okBtn);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingForm";
			this.ShowIcon = false;
			this.Text = "設定";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox plComboBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button openPlFolderBtn;
	}
}