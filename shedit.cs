using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace makeinp
{
	public partial class shedit : Form
	{
		public string opfilename = "";
		public ShellTask.NextTaskDo next = ShellTask.NextTaskDo.Nowait;
		public bool islastitem = false;

		public shedit(string opt, ShellTask.NextTaskDo nt, bool islastitem)
		{
			InitializeComponent();

			opfilename = opt;
			next = nt;

			foreach(ShellTask.NextTaskDo n in Enum.GetValues(typeof(ShellTask.NextTaskDo))) {
				if(islastitem && n == ShellTask.NextTaskDo.WaitOnlyNext) {
					continue;
				}
				comboBox1.Items.Add(n.ToString());
			}
		}

		private void shedit_Load(object sender, EventArgs e)
		{
			textBox1.Text = opfilename;
			comboBox1.SelectedIndex = comboBox1.Items.IndexOf(next.ToString());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			opfilename = textBox1.Text;
			next = (ShellTask.NextTaskDo)(comboBox1.SelectedIndex);
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
