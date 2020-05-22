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
			RunCompiler(sourceFileBox.Text);
		}

		private void RunBtn_Click(object sender, EventArgs e)
		{
			RunProgram(sourceFileBox.Text);
		}

		private void CompileAndRunBtn_Click(object sender, EventArgs e)
		{
			bool succeeded = RunCompiler(sourceFileBox.Text);
			if (succeeded) {
				RunProgram(sourceFileBox.Text);
			}
			else {
				mainTabControl.SelectedIndex = 1;
			}
		}

		private void ForcusCompilerLogTab()
		{
			this.mainTabControl.SelectedIndex = 1;
		}

		private bool RunCompiler(string srcPath)
		{
			EmbedmentRegistry.UpdateObject("srcPath", srcPath);

			var proc = new Process
			{
				StartInfo = Setting.CompilerProcess.CreateProcessStartInfo()
			};
			proc.Start();

			//string stdout = proc.StandardOutput.ReadToEnd();
			string stderr = proc.StandardError.ReadToEnd();

			proc.WaitForExit();
			proc.Close();

			this.compilerOutputBox.UpdateTextAndScrollToEnd(stderr.ReplaceN2RN());
			if (!string.IsNullOrWhiteSpace(stderr)) {
				ForcusCompilerLogTab();
			}
			

			return string.IsNullOrWhiteSpace(stderr);
		}

		private void RunProgram(string srcPath)
		{
			EmbedmentRegistry.UpdateObject("srcPath", srcPath);

			string stdout = "";
			string stderr = "";
			int terminateMs = 5000;
			var executionInfo = new ExecutionInfo();

			var proc = new Process
			{
				StartInfo = Setting.ExecutionProcess.CreateProcessStartInfo()
			};

			proc.Start();

			proc.StandardInput.Write(stdInBox.Text + Environment.NewLine);
			proc.StandardInput.Flush();

			try {
				executionInfo.SetMemory(proc.PrivateMemorySize64 / 1024, "KB");
			}
			catch (InvalidOperationException) {
				executionInfo.SetMemory(-1, " (No data)");
			}

			proc.WaitForExit(terminateMs);

			if (proc.HasExited) {
				executionInfo.SetTime(proc.UserProcessorTime.TotalMilliseconds, "ms");
				executionInfo.ExitCode = proc.ExitCode;

				stdout = proc.StandardOutput.ReadToEnd();
				stderr = proc.StandardError.ReadToEnd();

				proc.Close();
			}
			else {
				if (!proc.CloseMainWindow()) proc.Kill();
				executionInfo.SetTerminated(terminateMs, "ms");
			}

			stdOutBox.Text = stdout;
			StdErrorView.SetStdError(stderr);
			runInfoBox.Text = executionInfo.ToString();
		}

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
