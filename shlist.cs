using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace makeinp
{
	public partial class shlist : Form
	{
		public List<ShellTask> ShellTasks = new List<ShellTask>();
		public string Outputfiles = "";

		public shlist(string[] files)
		{
			InitializeComponent();

			foreach(var f in files) {
				ShellTasks.Add(new ShellTask(f));
			}
		}

		// at first
		private void shlist_Load(object sender, EventArgs e)
		{
			foreach(var sh in ShellTasks) {
				var item = new ListViewItem(new string[]{
					sh.InputFilename, sh.OutputFilename, sh.NextDo.ToString()
				});
				listView1.Items.Add(item);
			}
		}

		// save
		private void button3_Click(object sender, EventArgs e)
		{
			var fsav = new SaveFileDialog();
			fsav.DefaultExt = ".sh";
			fsav.Filter = "Shell Scripts|*.sh|All Files|*.*";
			if(fsav.ShowDialog(this) == DialogResult.OK) {
				var shcmd = "#!/bin/bash\n";
				var savst = new StreamWriter(fsav.FileName);
				foreach(var s in ShellTasks) {
					shcmd += $"g09 < {s.InputFilename} > {s.OutputFilename} {s.TaskDoStr[s.NextDo]}\n";
				}
				savst.Write(shcmd);
				MessageBox.Show("Create Shellscript File:: SUCCESS.");
				savst.Close();
			}
			return;
		}
		// close
		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// listview selected
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var sels = listView1.SelectedItems;
			var isseled = (sels.Count > 0);
			var itempos = isseled ? sels[0].Index : -1;
			button1.Enabled = isseled && (itempos > 0);
			button2.Enabled = isseled && (itempos < listView1.Items.Count - 1);
			button5.Enabled = isseled;
		}

		// up
		private void button1_Click(object sender, EventArgs e)
		{
			var sel = listView1.SelectedItems[0];
			var seled_index = sel.Index;
			listView1.Items.Remove(sel);
			listView1.Items.Insert(seled_index - 1, sel);
			sel.Selected = true;
			listView1.Select();
		}
		// down
		private void button2_Click(object sender, EventArgs e)
		{
			var sel = listView1.SelectedItems[0];
			var seled_index = sel.Index;
			listView1.Items.Remove(sel);
			listView1.Items.Insert(seled_index + 1, sel);
			sel.Selected = true;
			listView1.Select();
		}
		// edit item
		private void button5_Click(object sender, EventArgs e)
		{
			var sel = listView1.SelectedItems[0];
			var seled_index = sel.Index;
			var sh = ShellTasks[seled_index];
			var islast = !(seled_index < listView1.Items.Count - 1);
			var shedit = new shedit(sh.OutputFilename, sh.NextDo, islast);
			if(shedit.ShowDialog(this) == DialogResult.OK) {
				sh.OutputFilename = shedit.opfilename;
				sh.NextDo = shedit.next;
				// listview item replaced
				sel.SubItems[1] = new ListViewItem.ListViewSubItem(sel, sh.OutputFilename);
				sel.SubItems[2] = new ListViewItem.ListViewSubItem(sel, sh.NextDo.ToString());
			}
		}
	}

	public class ShellTask
	{
		public enum NextTaskDo
		{
			WaitAll, WaitOnlyNext, Nowait,
		}
		public ShellTask(string inputPath)
		{
			InputPath = inputPath;
			OutputFilename = InputFilenameWithoutExt + ".log";
			TaskDoStr = new Dictionary<NextTaskDo, string>();
			TaskDoStr.Add(NextTaskDo.WaitAll, "");
			TaskDoStr.Add(NextTaskDo.WaitOnlyNext, "&&");
			TaskDoStr.Add(NextTaskDo.Nowait, "&");
		}
		public Dictionary<NextTaskDo, string> TaskDoStr { get; protected set; }
		public string InputPath = "";
		public string InputFilename
		{
			get { return Path.GetFileName(InputPath); }
		}
		public string InputFilenameWithoutExt
		{
			get { return Path.GetFileNameWithoutExtension(InputPath); }
		}
		public string OutputFilename = "";
		public NextTaskDo NextDo = NextTaskDo.Nowait;
	}

}
