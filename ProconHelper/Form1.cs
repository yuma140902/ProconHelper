using ProconHelper.Forms;
using ProconHelper.Model;
using ProconHelper.Registry;
using ProconHelper.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProconHelper
{
	public partial class Form1 : Form
	{
		private readonly StandardErrorOutputView StdErrorView = new StandardErrorOutputView();
		private Setting Setting;

		public Form1()
		{
			InitializeComponent();
			testCasesComboBox.SelectedIndex = 0;
			this.Setting = new Setting()
			{
				CompilerProcess = new ProcessInfo(new EmbedableString("g++ -std=gnu++14 -O2 -I/opt/boost/gcc/include -L/opt/boost/gcc/lib -o a.exe {srcPath}"), RunMode.InCommandLine),
				ExecutionProcess = new ProcessInfo(new EmbedableString("a.exe"), RunMode.AsOneProcess)
			};
		}

		private void SourceFileRefFsBtn_Click(object sender, EventArgs e)
		{
			var result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK) {
				sourceFileBox.Text = openFileDialog.FileName;
			}
		}

		private void OpenStdErrViewBtn_Click(object sender, EventArgs e)
		{
			StdErrorView.Show();
			StdErrorView.BringToFront();
		}

		private void CompileBtn_Click(object sender, EventArgs e)
		{
			RunCompiler();
		}

		private void RunBtn_Click(object sender, EventArgs e)
		{
			RunProgram();
		}

		private void CompileAndRunBtn_Click(object sender, EventArgs e)
		{
			bool succeeded = RunCompiler();
			if (succeeded) {
				RunProgram();
			}
			else {
				mainTabControl.SelectedIndex = 1;
			}
		}

		private void ForcusCompilerLogTab()
		{
			this.mainTabControl.SelectedIndex = 1;
		}

		private bool RunCompiler()
		{
			bool result = ProcessRunner.RunCompiler(this.sourceFileBox.Text, this.compilerOutputBox, this.Setting.CompilerProcess);
			if (!string.IsNullOrWhiteSpace(this.compilerOutputBox.Text)) {
				ForcusCompilerLogTab();
			}
			return result;
		}

		private void RunProgram()
			=> ProcessRunner.RunProgram(this.sourceFileBox.Text, this.stdInBox, this.stdOutBox, this.StdErrorView, this.runInfoBox, this.Setting.ExecutionProcess);

		private void SettingsBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show("未実装!");
			var settingForm = new SettingsForm();
			settingForm.ShowDialog();
		}

		private void PasteTestCaseBtn_Click(object sender, EventArgs e)
		{
			if (!Clipboard.ContainsText()) {
				return;
			}
			stdInBox.Clear();
			stdInBox.Text = Clipboard.GetText();
		}
	}
}
