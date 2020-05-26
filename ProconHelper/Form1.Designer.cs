namespace ProconHelper
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.mainTabPage = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.pasteTestCaseBtn = new System.Windows.Forms.Button();
			this.settingsBtn = new System.Windows.Forms.Button();
			this.compileAndRunBtn = new System.Windows.Forms.Button();
			this.runBtn = new System.Windows.Forms.Button();
			this.compileBtn = new System.Windows.Forms.Button();
			this.loadTestCasesBtn = new System.Windows.Forms.Button();
			this.openStdErrViewBtn = new System.Windows.Forms.Button();
			this.outputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.answerPanel = new System.Windows.Forms.Panel();
			this.runInfoBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.stdOutPanel = new System.Windows.Forms.Panel();
			this.stdOutBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.stdInBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.testCasesComboBox = new System.Windows.Forms.ComboBox();
			this.sourceFileBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.sourceFileRefFsBtn = new System.Windows.Forms.Button();
			this.compilerTabPage = new System.Windows.Forms.TabPage();
			this.compilerOutputBox = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.mainTabControl.SuspendLayout();
			this.mainTabPage.SuspendLayout();
			this.outputTableLayoutPanel.SuspendLayout();
			this.answerPanel.SuspendLayout();
			this.stdOutPanel.SuspendLayout();
			this.compilerTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.mainTabPage);
			this.mainTabControl.Controls.Add(this.compilerTabPage);
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(573, 570);
			this.mainTabControl.TabIndex = 0;
			// 
			// mainTabPage
			// 
			this.mainTabPage.Controls.Add(this.label3);
			this.mainTabPage.Controls.Add(this.pasteTestCaseBtn);
			this.mainTabPage.Controls.Add(this.settingsBtn);
			this.mainTabPage.Controls.Add(this.compileAndRunBtn);
			this.mainTabPage.Controls.Add(this.runBtn);
			this.mainTabPage.Controls.Add(this.compileBtn);
			this.mainTabPage.Controls.Add(this.loadTestCasesBtn);
			this.mainTabPage.Controls.Add(this.openStdErrViewBtn);
			this.mainTabPage.Controls.Add(this.outputTableLayoutPanel);
			this.mainTabPage.Controls.Add(this.stdInBox);
			this.mainTabPage.Controls.Add(this.label2);
			this.mainTabPage.Controls.Add(this.testCasesComboBox);
			this.mainTabPage.Controls.Add(this.sourceFileBox);
			this.mainTabPage.Controls.Add(this.label1);
			this.mainTabPage.Controls.Add(this.sourceFileRefFsBtn);
			this.mainTabPage.Location = new System.Drawing.Point(4, 22);
			this.mainTabPage.Name = "mainTabPage";
			this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.mainTabPage.Size = new System.Drawing.Size(565, 544);
			this.mainTabPage.TabIndex = 0;
			this.mainTabPage.Text = "メイン";
			this.mainTabPage.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(380, 514);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 24);
			this.label3.TabIndex = 20;
			this.label3.Text = "ver1.4.0\r\nby yuma140902";
			// 
			// pasteTestCaseBtn
			// 
			this.pasteTestCaseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pasteTestCaseBtn.Location = new System.Drawing.Point(482, 54);
			this.pasteTestCaseBtn.Name = "pasteTestCaseBtn";
			this.pasteTestCaseBtn.Size = new System.Drawing.Size(75, 23);
			this.pasteTestCaseBtn.TabIndex = 19;
			this.pasteTestCaseBtn.Text = "ペースト(&P)";
			this.pasteTestCaseBtn.UseVisualStyleBackColor = true;
			this.pasteTestCaseBtn.Click += new System.EventHandler(this.PasteTestCaseBtn_Click);
			// 
			// settingsBtn
			// 
			this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsBtn.Location = new System.Drawing.Point(470, 515);
			this.settingsBtn.Name = "settingsBtn";
			this.settingsBtn.Size = new System.Drawing.Size(89, 23);
			this.settingsBtn.TabIndex = 18;
			this.settingsBtn.Text = "設定";
			this.settingsBtn.UseVisualStyleBackColor = true;
			this.settingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
			// 
			// compileAndRunBtn
			// 
			this.compileAndRunBtn.Location = new System.Drawing.Point(196, 420);
			this.compileAndRunBtn.Name = "compileAndRunBtn";
			this.compileAndRunBtn.Size = new System.Drawing.Size(169, 23);
			this.compileAndRunBtn.TabIndex = 17;
			this.compileAndRunBtn.Text = "コンパイル+実行(&R)";
			this.compileAndRunBtn.UseVisualStyleBackColor = true;
			this.compileAndRunBtn.Click += new System.EventHandler(this.CompileAndRunBtn_Click);
			// 
			// runBtn
			// 
			this.runBtn.Location = new System.Drawing.Point(101, 420);
			this.runBtn.Name = "runBtn";
			this.runBtn.Size = new System.Drawing.Size(89, 23);
			this.runBtn.TabIndex = 16;
			this.runBtn.Text = "実行(&E)";
			this.runBtn.UseVisualStyleBackColor = true;
			this.runBtn.Click += new System.EventHandler(this.RunBtn_Click);
			// 
			// compileBtn
			// 
			this.compileBtn.Location = new System.Drawing.Point(6, 420);
			this.compileBtn.Name = "compileBtn";
			this.compileBtn.Size = new System.Drawing.Size(89, 23);
			this.compileBtn.TabIndex = 15;
			this.compileBtn.Text = "コンパイル(&C)";
			this.compileBtn.UseVisualStyleBackColor = true;
			this.compileBtn.Click += new System.EventHandler(this.CompileBtn_Click);
			// 
			// loadTestCasesBtn
			// 
			this.loadTestCasesBtn.Enabled = false;
			this.loadTestCasesBtn.Location = new System.Drawing.Point(133, 33);
			this.loadTestCasesBtn.Name = "loadTestCasesBtn";
			this.loadTestCasesBtn.Size = new System.Drawing.Size(128, 23);
			this.loadTestCasesBtn.TabIndex = 14;
			this.loadTestCasesBtn.Text = "JOI過去問読み込み";
			this.loadTestCasesBtn.UseVisualStyleBackColor = true;
			// 
			// openStdErrViewBtn
			// 
			this.openStdErrViewBtn.Location = new System.Drawing.Point(6, 449);
			this.openStdErrViewBtn.Name = "openStdErrViewBtn";
			this.openStdErrViewBtn.Size = new System.Drawing.Size(193, 23);
			this.openStdErrViewBtn.TabIndex = 13;
			this.openStdErrViewBtn.Text = "標準エラー出力を表示(&D)";
			this.openStdErrViewBtn.UseVisualStyleBackColor = true;
			this.openStdErrViewBtn.Click += new System.EventHandler(this.OpenStdErrViewBtn_Click);
			// 
			// outputTableLayoutPanel
			// 
			this.outputTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputTableLayoutPanel.ColumnCount = 2;
			this.outputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.outputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.outputTableLayoutPanel.Controls.Add(this.answerPanel, 1, 0);
			this.outputTableLayoutPanel.Controls.Add(this.stdOutPanel, 0, 0);
			this.outputTableLayoutPanel.Location = new System.Drawing.Point(6, 213);
			this.outputTableLayoutPanel.Name = "outputTableLayoutPanel";
			this.outputTableLayoutPanel.RowCount = 1;
			this.outputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.outputTableLayoutPanel.Size = new System.Drawing.Size(551, 201);
			this.outputTableLayoutPanel.TabIndex = 12;
			// 
			// answerPanel
			// 
			this.answerPanel.Controls.Add(this.runInfoBox);
			this.answerPanel.Controls.Add(this.label5);
			this.answerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.answerPanel.Location = new System.Drawing.Point(278, 3);
			this.answerPanel.Name = "answerPanel";
			this.answerPanel.Size = new System.Drawing.Size(270, 195);
			this.answerPanel.TabIndex = 13;
			// 
			// runInfoBox
			// 
			this.runInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.runInfoBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.runInfoBox.Location = new System.Drawing.Point(0, 15);
			this.runInfoBox.Multiline = true;
			this.runInfoBox.Name = "runInfoBox";
			this.runInfoBox.ReadOnly = true;
			this.runInfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.runInfoBox.Size = new System.Drawing.Size(270, 180);
			this.runInfoBox.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 12);
			this.label5.TabIndex = 10;
			this.label5.Text = "実行情報: ";
			// 
			// stdOutPanel
			// 
			this.stdOutPanel.Controls.Add(this.stdOutBox);
			this.stdOutPanel.Controls.Add(this.label4);
			this.stdOutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stdOutPanel.Location = new System.Drawing.Point(3, 3);
			this.stdOutPanel.Name = "stdOutPanel";
			this.stdOutPanel.Size = new System.Drawing.Size(269, 195);
			this.stdOutPanel.TabIndex = 12;
			// 
			// stdOutBox
			// 
			this.stdOutBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stdOutBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stdOutBox.Location = new System.Drawing.Point(0, 15);
			this.stdOutBox.Multiline = true;
			this.stdOutBox.Name = "stdOutBox";
			this.stdOutBox.ReadOnly = true;
			this.stdOutBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.stdOutBox.Size = new System.Drawing.Size(269, 180);
			this.stdOutBox.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 12);
			this.label4.TabIndex = 10;
			this.label4.Text = "標準出力: ";
			// 
			// stdInBox
			// 
			this.stdInBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stdInBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stdInBox.Location = new System.Drawing.Point(6, 80);
			this.stdInBox.Multiline = true;
			this.stdInBox.Name = "stdInBox";
			this.stdInBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.stdInBox.Size = new System.Drawing.Size(551, 127);
			this.stdInBox.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "標準入力: ";
			// 
			// testCasesComboBox
			// 
			this.testCasesComboBox.Cursor = System.Windows.Forms.Cursors.Default;
			this.testCasesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.testCasesComboBox.Enabled = false;
			this.testCasesComboBox.FormattingEnabled = true;
			this.testCasesComboBox.Items.AddRange(new object[] {
            "テストケース1",
            "テストケース2",
            "テストケース3",
            "テストケース4",
            "テストケース5",
            "テストケース6"});
			this.testCasesComboBox.Location = new System.Drawing.Point(6, 33);
			this.testCasesComboBox.Name = "testCasesComboBox";
			this.testCasesComboBox.Size = new System.Drawing.Size(121, 20);
			this.testCasesComboBox.TabIndex = 3;
			// 
			// sourceFileBox
			// 
			this.sourceFileBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceFileBox.Location = new System.Drawing.Point(93, 8);
			this.sourceFileBox.Name = "sourceFileBox";
			this.sourceFileBox.Size = new System.Drawing.Size(383, 19);
			this.sourceFileBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "ソース・ファイル: ";
			// 
			// sourceFileRefFsBtn
			// 
			this.sourceFileRefFsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.sourceFileRefFsBtn.Location = new System.Drawing.Point(482, 6);
			this.sourceFileRefFsBtn.Name = "sourceFileRefFsBtn";
			this.sourceFileRefFsBtn.Size = new System.Drawing.Size(75, 23);
			this.sourceFileRefFsBtn.TabIndex = 0;
			this.sourceFileRefFsBtn.Text = "参照";
			this.sourceFileRefFsBtn.UseVisualStyleBackColor = true;
			this.sourceFileRefFsBtn.Click += new System.EventHandler(this.SourceFileRefFsBtn_Click);
			// 
			// compilerTabPage
			// 
			this.compilerTabPage.Controls.Add(this.compilerOutputBox);
			this.compilerTabPage.Location = new System.Drawing.Point(4, 22);
			this.compilerTabPage.Name = "compilerTabPage";
			this.compilerTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.compilerTabPage.Size = new System.Drawing.Size(565, 544);
			this.compilerTabPage.TabIndex = 1;
			this.compilerTabPage.Text = "コンパイラーの出力";
			this.compilerTabPage.UseVisualStyleBackColor = true;
			// 
			// compilerOutputBox
			// 
			this.compilerOutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.compilerOutputBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.compilerOutputBox.Location = new System.Drawing.Point(3, 3);
			this.compilerOutputBox.Multiline = true;
			this.compilerOutputBox.Name = "compilerOutputBox";
			this.compilerOutputBox.ReadOnly = true;
			this.compilerOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.compilerOutputBox.Size = new System.Drawing.Size(559, 538);
			this.compilerOutputBox.TabIndex = 12;
			// 
			// openFileDialog
			// 
			this.openFileDialog.Title = "ソース・ファイルを選択";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 570);
			this.Controls.Add(this.mainTabControl);
			this.Name = "Form1";
			this.Text = "競技プログラミング・テストヘルパー";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.mainTabControl.ResumeLayout(false);
			this.mainTabPage.ResumeLayout(false);
			this.mainTabPage.PerformLayout();
			this.outputTableLayoutPanel.ResumeLayout(false);
			this.answerPanel.ResumeLayout(false);
			this.answerPanel.PerformLayout();
			this.stdOutPanel.ResumeLayout(false);
			this.stdOutPanel.PerformLayout();
			this.compilerTabPage.ResumeLayout(false);
			this.compilerTabPage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.TabPage mainTabPage;
		private System.Windows.Forms.ComboBox testCasesComboBox;
		private System.Windows.Forms.TextBox sourceFileBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button sourceFileRefFsBtn;
		private System.Windows.Forms.TabPage compilerTabPage;
		private System.Windows.Forms.TableLayoutPanel outputTableLayoutPanel;
		private System.Windows.Forms.Panel stdOutPanel;
		private System.Windows.Forms.TextBox stdOutBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox stdInBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel answerPanel;
		private System.Windows.Forms.TextBox runInfoBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button openStdErrViewBtn;
		private System.Windows.Forms.Button loadTestCasesBtn;
		private System.Windows.Forms.Button compileAndRunBtn;
		private System.Windows.Forms.Button runBtn;
		private System.Windows.Forms.Button compileBtn;
		private System.Windows.Forms.TextBox compilerOutputBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button settingsBtn;
		private System.Windows.Forms.Button pasteTestCaseBtn;
		private System.Windows.Forms.Label label3;
	}
}

