using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace makeinp
{
	public partial class main : Form
	{
		// constant
		List<Control> tglEnCtrl = null;
		List<inpformat> outputs = null;

		// variable
		setting myst = new setting();
		molecule inputData = new molecule();
		bool isUseCheckfile = false;
		string UseChkLocation = String.Empty;
		string savLocation = String.Empty;

		// initialize
		public main()
		{
			InitializeComponent();

			// combobox selected
			cmb_memory.SelectedIndex = 4;

			// control defined
			tglEnCtrl = new List<Control>{txb_name, flp_genfile, flp_nproc, tlp_chrspn,
				tlp_saveloc, tlp_memory, tlp_method, btn_next,
				tlp_opt, tlp_freq, tlp_ts, tlp_edit};
			// output defined
			outputs = new List<inpformat>();
			outputs.Add(new optformat());
			outputs.Add(new freqformat());
		}

		// get table-data
		private void btn_getdata_Click(object sender, EventArgs e)
		{
			// text-get
			var clpText = Clipboard.GetText();
			if(clpText == String.Empty || !molecule.IsVariableTextData(clpText)) {
				// no-data
				MessageBox.Show("NoItem", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// add to list
			inputData.DataSet(clpText);
			inpDataToLstView();
			// edit enabled
			toggleControlEnabled(true);
		}

		// set use-checkfile
		private void btn_usechk_Click(object sender, EventArgs e)
		{
			var dedit = new simpleedit();
			dedit.description = "enter filepath:";
			dedit.inputText = myst.scrDir.Replace("%user%", myst.usrName);
			if(dedit.ShowDialog() == DialogResult.OK) {
				isUseCheckfile = true;
				UseChkLocation = dedit.inputText;
				toggleControlEnabled(true);
			}
		}

		// folderOpen
		private void btn_folderopen_Click(object sender, EventArgs e)
		{
			var fd = new FolderBrowserDialog();
			fd.Description = "出力先を指定してください。";
			fd.RootFolder = Environment.SpecialFolder.MyComputer;
			if(fd.ShowDialog(this) == DialogResult.OK) {
				txb_location.Text = savLocation = fd.SelectedPath;
			}
		}

		// click no-assignment
		private void chk_noasgn_CheckedChanged(object sender, EventArgs e)
		{
			nmr_nproc.Enabled = !chk_noasgn.Checked;
		}

		// page move
		private void btn_back_Click(object sender, EventArgs e)
		{
			moveTabpage(-1);
		}
		private void btn_next_Click(object sender, EventArgs e)
		{
			var tpagenum = tabControl1.TabCount;
			var tpagenow = tabControl1.SelectedIndex;
			if (tpagenow >= tpagenum - 1) {
				generateInputFile();
			}
			else {
				moveTabpage(+1);
			}
		}

		// tabcontrol-index changed
		private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
		{
			if(!inputData.IsDataExist && !isUseCheckfile) {
				return;
			}
			var exist_genfile = (chk_isopt.Checked || chk_isfreq.Checked || chk_isirc.Checked);
			var required_item = (txb_name.Text != "" && savLocation != "" && cmb_theory.Text != "" && cmb_basis.Text != "");
			if(!exist_genfile) {
				MessageBox.Show("Please check 'Gen-File' at least one.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;
			}
			else if(!required_item) {
				MessageBox.Show("Please enter required field: (name/location/method)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;
			}
			return;
		}
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// datacheck
			if(!inputData.IsDataExist && !isUseCheckfile) {
				return;
			}
			var tpagenum = tabControl1.TabCount;
			var tpagenow = tabControl1.SelectedIndex;
			var islastpage = (tpagenow >= tpagenum - 1);
			var iseditpage = islastpage;
			btn_back.Enabled = (tpagenow > 0);
			btn_next.Text = islastpage ? "&Generate" : "&Next";
			if(iseditpage) {
				// temp-inpdata create
				makeinpdata mid = new makeinpdata();
				midApply(ref mid);
				// combobox item-add
				cmb_editlist.Items.Clear();
				foreach(var inp in outputs) {
					if(inp.generateCheck(mid)) {
						cmb_editlist.Items.Add(inp.IdentifyName);
					}
				}
				txb_viewfile.Text = "";
				cmb_editlist.SelectedIndex = -1;
			}
		}

		// view-file
		private void cmb_editlist_SelectedIndexChanged(object sender, EventArgs e)
		{
			var issel = (cmb_editlist.SelectedIndex >= 0);
			if(!issel) {
				return;
			}
			foreach(var inp in outputs) {
				if(inp.IdentifyName == cmb_editlist.Text) {
					var mid = new makeinpdata();
					midApply(ref mid);
					var op = inp.output(mid, myst);
					txb_viewfile.Text = op.Replace("\n", "\r\n");
				}
			}
		}

		// form loaded
		private void main_Load(object sender, EventArgs e)
		{
			if(File.Exists("setting.xml")){
				// load setting-data
				var xserial = new XmlSerializer(typeof(setting));
				var sr = new StreamReader("setting.xml");
				myst = (setting)xserial.Deserialize(sr);
				sr.Close();
			}
			// if no-setting username
			if(myst.usrName == string.Empty) {
				var dedit = new simpleedit();
				dedit.description = "input your name";
				if(dedit.ShowDialog(this) == DialogResult.OK) {
					myst.usrName = dedit.inputText;
				}
			}
		}
		// form closed
		private void main_FormClosed(object sender, FormClosedEventArgs e)
		{
			myst.isFirstLaunch = false;
			// save setting-data
			var xserial = new XmlSerializer(typeof(setting));
			var sw = new StreamWriter("setting.xml");
			xserial.Serialize(sw, myst);
			sw.Close();
		}
		// --------------------------
		// inputData -> listview
		private void inpDataToLstView()
		{
			if(inputData.IsDataExist == false) {
				return;
			}
			// clear item
			lsv_Inputdata.Clear();
			// create header
			var fsts = inputData.GetHeaderLine();
			foreach(var t in fsts) {
				lsv_Inputdata.Columns.Add(t);
			}
			// create item
			for(var i = 1; i < inputData.LineDatas.Count; i++) {
				var lsvItem = new ListViewItem();
				var items = inputData.Datas[i];
				lsvItem.Text = items[0];
				for(var j = 1; j < items.Count(); j++) {
					lsvItem.SubItems.Add(items[j]);
				}
				lsv_Inputdata.Items.Add(lsvItem);
			}
			lsv_Inputdata.Enabled = true;
			// end
			return;
		}

		// toggle enable
		private void toggleControlEnabled(bool enb)
		{
			foreach(var ctl in tglEnCtrl) {
				ctl.Enabled = enb;
			}
			chk_noasgn_CheckedChanged(null, null);
		}

		// tabpage move-function
		private bool moveTabpage(int direc)
		{
			var tabOpts = new bool?[tabControl1.TabCount];
			tabOpts[1] = chk_isopt.Checked;
			tabOpts[2] = chk_isfreq.Checked;
			tabOpts[3] = chk_isirc.Checked;

			var nextpage = tabControl1.SelectedIndex + direc;
			while(tabOpts[nextpage] == false){
				if(nextpage >= tabOpts.Length || nextpage < 0) {
					return false;
				}
				nextpage += direc;
			}
			tabControl1.SelectedIndex = nextpage;
			return true;
		}

		// makeinpdata apply
		private void midApply(ref makeinpdata mid)
		{
			// main
			mid.inputdata = inputData;
			mid.isusecheckfile = isUseCheckfile;
			mid.chklocation = UseChkLocation;
			mid.name = txb_name.Text;
			mid.location = savLocation;
			mid.nproc = (int)nmr_nproc.Value;
			mid.no_assgn = chk_noasgn.Checked;
			mid.mem = (int)nmr_memory.Value;
			mid.mem_unit = cmb_memory.Text;
			mid.theory = cmb_theory.Text;
			mid.basis = cmb_basis.Text;
			mid.star = cmb_star.Text;
			mid.istest = chk_mtest.Checked;
			mid.charge = (int)nmr_charge.Value;
			mid.spin = (int)nmr_spin.Value;
			mid.genfile_opt = chk_isopt.Checked;
			mid.genfile_freq = chk_isfreq.Checked;
			mid.genfile_irc = chk_isirc.Checked;
			// opt
			mid.optcyc = (int)nmr_optcyc.Value;
			mid.istransition = chk_transition.Checked;
		}

		// generate .inp file
		private void generateInputFile()
		{
			var rst = true;
			var mid = new makeinpdata();
			midApply(ref mid);
			foreach(var inp in outputs) {
				if(inp.generateCheck(mid)) {
					rst = rst && inp.writefile(mid, myst);
				}
			}
			if(rst) {
				MessageBox.Show("Save Success.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
				myst.latestData = mid;
			}
		}
	}
}
