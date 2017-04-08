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
	public partial class simpleedit : Form
	{
		public string titleCaption { get; set; }
		public string inputText { get; set; }
		public string description { get; set; }

		public simpleedit()
		{
			InitializeComponent();

			titleCaption = "input this form";
			inputText = "";
			description = "";
		}

		private void simpleedit_Load(object sender, EventArgs e)
		{
			this.Text = titleCaption;
			textBox1.Text = inputText;
			label1.Text = description;
		}

		private void simpleedit_Shown(object sender, EventArgs e)
		{
			textBox1.Select(textBox1.Text.Length, 0);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			inputText = textBox1.Text;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}


	}
}
