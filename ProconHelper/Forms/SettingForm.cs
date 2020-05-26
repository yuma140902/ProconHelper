using ProconHelper.Model;
using ProconHelper.Registry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProconHelper.Forms
{
	partial class SettingForm : Form
	{
		private readonly ApplicationSetting setting;

		public SettingForm(ApplicationSetting setting)
		{
			this.setting = setting;
			InitializeComponent();
			setProgrammingLanguageList(this.plComboBox);
			selectCurrentProgrammingLanguage(this.plComboBox);
		}

		private void setProgrammingLanguageList(ComboBox comboBox)
		{
			comboBox.Items.Clear();
			foreach(string name in ProgrammingLanguageRegistry.EnumerateNames()) {
				comboBox.Items.Add(name);
			}
		}

		private void selectCurrentProgrammingLanguage(ComboBox comboBox)
		{
			if (comboBox.Items.Contains(this.setting.ProgrammingLanguage.Name)) {
				comboBox.SelectedItem = this.setting.ProgrammingLanguage.Name;
			}
		}

		private void plComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedName = (string)this.plComboBox.SelectedItem;
			var pl = ProgrammingLanguageRegistry.GetOrNull(selectedName);
			if(pl != null) {
				this.setting.ProgrammingLanguage = pl;
			}
		}

		private void okBtn_Click(object sender, EventArgs e) => Close();

		private void openPlFolderBtn_Click(object sender, EventArgs e)
		{
			var dir = Program.FileSystem.ToAbsolutePath(References.ProgrammingLanguagesFolderName);
			System.Diagnostics.Process.Start(dir);
		}
	}
}
