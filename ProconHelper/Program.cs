using ProconHelper.Model;
using ProconHelper.Properties;
using ProconHelper.Registry;
using ProconHelper.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProconHelper
{
	static class Program
	{
		public static readonly FileSystemAccessor FileSystem = new FileSystemAccessor(".");

		public static readonly ApplicationSetting Setting = new ApplicationSetting();

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			foreach(var jsonFile in FileSystem.EnumerateFiles(References.ProgrammingLanguagesFolderName, "*.json")) {
				var json = FileSystem.ReadFileToEnd(jsonFile);
				var language = ProgrammingLanguageLoader.LoadFromJson(json);
				try {
					ProgrammingLanguageRegistry.Register(language);
				}
				catch(ArgumentException) {
					MessageBox.Show($"言語処理系「{language.Name}」の定義が重複しています。\r\n\r\nError at \"{jsonFile}\"", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			Setting.ProgrammingLanguage = ProgrammingLanguageRegistry.GetOrNull(Settings.Default.ProgrammingLanguage);
			if(Setting.ProgrammingLanguage == null) {
				MessageBox.Show($"言語処理系「{Settings.Default.ProgrammingLanguage}」の設定ファイルが見つかりません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
