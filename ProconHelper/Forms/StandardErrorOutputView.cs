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
	public partial class StandardErrorOutputView : Form
	{
		public StandardErrorOutputView()
		{
			InitializeComponent();
		}

		public void SetStdError(string stderr)
		{
			stdErrBox.Text = stderr;
		}

		private void StandardErrorOutputView_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Visible = false;
		}
	}
}
