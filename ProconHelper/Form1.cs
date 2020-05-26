using ProconHelper.Forms;
using ProconHelper.Model;
using ProconHelper.Properties;
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
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProconHelper
{
	public partial class Form1 : Form
	{
		private readonly StandardErrorOutputView StdErrorView = new StandardErrorOutputView();

		private Task CurrentTask = null;

		public Form1()
		{
			InitializeComponent();
			loadSettings();
			setVersionInfo(this.verInfoLabel);
			FocusMainTab();
		}

		private void loadSettings()
		{
			Settings settings = Settings.Default;
			this.sourceFileBox.Text = settings.SourceFile;
			this.openFileDialog.InitialDirectory = settings.SourceFilePickerInitialDirectory;
		}

		private void saveSettings()
		{
			Settings settings = Settings.Default;
			settings.SourceFile = this.sourceFileBox.Text;
			settings.SourceFilePickerInitialDirectory = this.openFileDialog.InitialDirectory;
			settings.ProgrammingLanguage = Program.Setting.ProgrammingLanguage.Name;
			settings.Save();
		}

		private void setVersionInfo(Label label)
		{
			var ver = Assembly.GetExecutingAssembly().GetName().Version;
			label.Text = 
				$"v{ver.Major}.{ver.Minor}.{ver.Build}\r\n" +
				"by yuma140902";
		}

		private void SourceFileRefFsBtn_Click(object sender, EventArgs e)
		{
			openFileDialog.Filter = UIUtils.FilePickFilterWithAllFile(Program.Setting.ProgrammingLanguage.Name, Program.Setting.ProgrammingLanguage.Extensions);
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
			var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
			RunCompiler().ContinueWith(task =>
				{
					if (!task.Result) FocusCompilerLogTab();
				}, uiScheduler);
		}

		private void RunBtn_Click(object sender, EventArgs e) => RunProgram();

		private void CompileAndRunBtn_Click(object sender, EventArgs e)
		{
			var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
			RunCompiler().ContinueWith(task =>
			{
				if (task.Result) {
					RunProgram();
				}
				else {
					FocusCompilerLogTab();
				}
			}, uiScheduler);
		}

		private void FocusMainTab() => this.mainTabControl.SelectedIndex = 0;

		private void FocusCompilerLogTab() => this.mainTabControl.SelectedIndex = 1;

		private void DisableAllTaskRunnerBtn()
		{
			this.runBtn.Enabled = false;
			this.compileBtn.Enabled = false;
			this.compileAndRunBtn.Enabled = false;
		}

		private void EnableAllTaskRunnerBtn()
		{
			this.runBtn.Enabled = true;
			this.compileBtn.Enabled = true;
			this.compileAndRunBtn.Enabled = true;
		}

		/// <returns>他のタスクが実行中ならtrue、そうでなければfalse</returns>
		private bool CheckAndWarnIfOtherTaskIsRunning()
		{
			if (this.CurrentTask != null) {
				MessageBox.Show("前のタスクが実行中です", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;
			}
			return false;
		}

		/// <returns>コンパイルに成功したらtrue、失敗したらfalseを返すようなTask&lt;bool&gt;</returns>
		private Task<bool> RunCompiler()
		{
			this.runInfoBox.Text = "コンパイル中...";
			DisableAllTaskRunnerBtn();
			var context = SynchronizationContext.Current;
			return Task.Run(() =>
			{
				var execInfo = ProcessRunner.RunCompiler(this.sourceFileBox.Text, Program.Setting.ProgrammingLanguage.CompilerProcessInfo);
				context.Post(_ =>
				{
					this.compilerOutputBox.UpdateTextAndScrollToEnd(execInfo.stderr.ReplaceN2RN());
					EnableAllTaskRunnerBtn();
					this.runInfoBox.Text = "";
				}, null);
				return execInfo.ExitCode == 0;
			});
		}

		private void RunProgram()
		{
			if (CheckAndWarnIfOtherTaskIsRunning()) return;

			DisableAllTaskRunnerBtn();
			this.runInfoBox.Text = "実行中...";
			var context = SynchronizationContext.Current;
			this.CurrentTask = Task.Run(() =>
				{
					var execInfo = ProcessRunner.RunProgram(this.sourceFileBox.Text, this.stdInBox.Text + Environment.NewLine, Program.Setting.ProgrammingLanguage.ExecutionProcessInfo);
					context.Post(_ =>
					{
						this.stdOutBox.Text = execInfo.stdout;
						this.StdErrorView.SetStdError(execInfo.stderr);
						this.runInfoBox.Text = execInfo.ToMemoryTimeExitCodeString();
						EnableAllTaskRunnerBtn();
						this.CurrentTask = null;
					}, null);
				});
		}

		private void SettingsBtn_Click(object sender, EventArgs e)
		{
			var settingForm = new SettingForm(Program.Setting);
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

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			saveSettings();
		}
	}
}
