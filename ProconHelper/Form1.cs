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
		private readonly CompilerLogs CompilerLogs;
		private readonly StandardErrorOutputView StdErrorView = new StandardErrorOutputView();
		private Setting Setting;

		public Form1()
		{
			InitializeComponent();
			testCasesComboBox.SelectedIndex = 0;
			this.CompilerLogs = new CompilerLogs(this.compilerOutputBox);
			this.Setting = new Setting()
			{
				CompilerProcess = new ProcessInfo(new EmbedableString("g++ -std=gnu++14 -O2 -I/opt/boost/gcc/include -L/opt/boost/gcc/lib -o a.exe {srcFile}"), RunMode.InCommandLine),
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
			RunProgram();
		}

		private void CompileAndRunBtn_Click(object sender, EventArgs e)
		{
			bool succeeded = RunCompiler(sourceFileBox.Text);
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

		private void UpdateEmbedmentObjects()
		{
			EmbedmentRegistry.UpdateObject("srcFile", sourceFileBox.Text);
		}

		private bool RunCompiler(string srcFileName)
		{
			UpdateEmbedmentObjects();

			var proc = new Process
			{
				StartInfo = Setting.CompilerProcess.CreateProcessStartInfo()
			};
			proc.Start();

			//string stdout = proc.StandardOutput.ReadToEnd();
			string stderr = proc.StandardError.ReadToEnd();

			proc.WaitForExit();
			proc.Close();

			CompilerLogs.SetLog(stderr);
			if (!string.IsNullOrWhiteSpace(stderr)) {
				ForcusCompilerLogTab();
			}
			

			return string.IsNullOrWhiteSpace(stderr);
		}

		private void RunProgram()
		{
			UpdateEmbedmentObjects();

			string stdout = "";
			string stderr = "";
			int terminateMs = 5000;
			var procInfo = new StringBuilder();

			var proc = new Process
			{
				StartInfo = Setting.ExecutionProcess.CreateProcessStartInfo()
			};

			proc.Start();

			proc.StandardInput.Write(stdInBox.Text + Environment.NewLine);
			proc.StandardInput.Flush();

			procInfo.Append("Memory: ").Append(proc.PrivateMemorySize64 / 1024).Append("KB").AppendLine();

			proc.WaitForExit(terminateMs);

			if (proc.HasExited) {
				procInfo.Append("Time: ").Append(proc.UserProcessorTime.TotalMilliseconds).Append("ms").AppendLine();
				procInfo.Append("Return: ").Append(proc.ExitCode).AppendLine();

				stdout = proc.StandardOutput.ReadToEnd();
				stderr = proc.StandardError.ReadToEnd();

				proc.Close();
			}
			else {
				if (!proc.CloseMainWindow()) proc.Kill();
				procInfo.AppendLine($"Time: >= {terminateMs}ms");
				procInfo.AppendLine("Proccess Terminated");
			}

			stdOutBox.Text = stdout;
			StdErrorView.SetStdError(stderr);
			runInfoBox.Text = procInfo.ToString();
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
