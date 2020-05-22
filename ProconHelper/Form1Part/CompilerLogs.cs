using ProconHelper.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProconHelper
{
	public class CompilerLogs
	{
		private readonly TextBox logBox;

		public CompilerLogs(TextBox logBox)
		{
			this.logBox = logBox;
		}

		public void SetLog(string log)
		{
			log = log.Replace("\n", "\r\n");
			this.logBox.Text = log;
			this.logBox.Select(this.logBox.TextLength, 0);
		}

	}
}
