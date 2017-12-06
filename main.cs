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
using Microsoft.WindowsAPICodePack.Dialogs;

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
		Dictionary<string, int> dic_symbol = null;
		string scfsetting = "";
		string iopsetting = "";
		string custom_str = "";

		// initialize
		public main()
		{
			InitializeComponent();

			// combobox selected
			cmb_memory.SelectedIndex = 4;

			// control defined
			tglEnCtrl = new List<Control>{txb_name, flp_genfile, flp_nproc, tlp_chrspn,
				tlp_saveloc, tlp_memory, tlp_method, tlp_td, btn_next, tlp_edit};
			// output defined
			outputs = new List<inpformat>();
			outputs.Add(new optformat());
			outputs.Add(new freqformat());
			outputs.Add(new ircformat());
			outputs.Add(new ircfformat());
			outputs.Add(new ircrformat());
			outputs.Add(new nboformat());
			outputs.Add(new tdformat());
			outputs.Add(new ctformat());
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
			inpDataToDetail();
			// edit enabled
			toggleControlEnabled(true);
			txb_lockpos.Enabled = inputData.IsZMatrix();
			isUseCheckfile = false;
		}

		// set use-checkfile
		private void btn_usechk_Click(object sender, EventArgs e)
		{
			var dedit = new simpleedit();
			dedit.description = "enter filepath:";
			dedit.inputText = myst.scrDir.Replace("%user%", myst.usrName);
			if(dedit.ShowDialog() == DialogResult.OK) {
				isUseCheckfile = true;
				var path = dedit.inputText;
				if(path.IndexOf(".") < 0) {
					path += ".chk";
				}
				UseChkLocation = path;
				txb_name.Text = Path.GetFileNameWithoutExtension(dedit.inputText);
				toggleControlEnabled(true);
				txb_lockpos.Enabled = false;
			}
		}

		// folderOpen
		private void btn_folderopen_Click(object sender, EventArgs e)
		{
			var fd = new CommonOpenFileDialog();
			fd.IsFolderPicker = true;
			fd.DefaultDirectory = myst.latestFolder;
			if(fd.ShowDialog() == CommonFileDialogResult.Ok) {
				txb_location.Text = savLocation = fd.FileName;
				myst.latestFolder = fd.FileName;
			}
		}

		// click no-assignment
		private void chk_noasgn_CheckedChanged(object sender, EventArgs e)
		{
			nmr_nproc.Enabled = !chk_noasgn.Checked;
		}

		// scf edit
		private void btn_SCF_Click(object sender, EventArgs e)
		{
			var bedit = new simpleedit();
			bedit.inputText = scfsetting;
			bedit.titleCaption = bedit.description = "SCF Setting";
			if(bedit.ShowDialog() == DialogResult.OK) {
				scfsetting = bedit.inputText;
			}
		}

		// iop edit
		private void btn_iop_Click(object sender, EventArgs e)
		{
			var bedit = new simpleedit();
			bedit.inputText = iopsetting;
			bedit.titleCaption = bedit.description = "IOP Setting";
			if(bedit.ShowDialog() == DialogResult.OK) {
				iopsetting = bedit.inputText;
			}
		}

		// page move
		private void btn_next_Click(object sender, EventArgs e)
		{
			generateInputFile();
		}

		// shellscript generator
		private void btn_selrun_Click(object sender, EventArgs e)
		{
			var fssel = new OpenFileDialog();
			fssel.Multiselect = true;
			fssel.Filter = "Input Files|*.inp|All Files|*.*";
			if(fssel.ShowDialog(this) == DialogResult.OK) {
				var slist = new shlist(fssel.FileNames);
				if(myst.shellrunapp != "") {
					slist.runappname = myst.shellrunapp;
				}
				slist.ShowDialog(this);
				if(slist.runappname != "") {
					myst.shellrunapp = slist.runappname;
				}
			}
		}

		// tabcontrol-index changed
		private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
		{
			e.Cancel = !checkInputData();
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
			// enable check
			tlp_opt.Enabled = chk_isopt.Checked;
			tlp_freq.Enabled = chk_isfreq.Checked;
			tlp_irc.Enabled = chk_isirc.Checked;
			tlp_td.Enabled = chk_td.Checked;
			chk_conopt.Enabled = (chk_isopt.Checked && chk_isfreq.Checked);
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
					fileopen_innotepad.Enabled = inp.isExistGenerateFile(mid);
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
				if(myst.latestData != null) {
					cmb_theory.Text = myst.latestData.theory;
					cmb_basis.Text = myst.latestData.basis;
					cmb_star.Text = myst.latestData.star;
					chk_mnosymm.Checked = myst.latestData.isnosymm;
					scfsetting = myst.latestData.scf;
					iopsetting = myst.latestData.iop;
				}
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

		// inputData -> detail label
		private void inpDataToDetail()
		{
			var ldats = inputData.LineDatas;
			var datasize = ldats.Count - 1;
			// find symbol-index
			var header = inputData.GetHeaderLine();
			var sym_index = Array.IndexOf(header, "Symbol");
			if(sym_index >= 0) {
				dic_symbol = new Dictionary<string, int>();
				for(var i = 1; i < ldats.Count; i++) {
					var items = inputData.Datas[i];
					var item = items[sym_index];
					if(dic_symbol.ContainsKey(item)) {
						dic_symbol[item]++;
					}
					else {
						dic_symbol.Add(item, 1);
					}
				}
			}
			// append
			var rst = "";
			rst += $"Datasize: {datasize}";
			if(dic_symbol != null) {
				rst += ", Symbol: {";
				foreach(var key in dic_symbol.Keys) {
					rst += $"{key}: {dic_symbol[key]}, ";
				}
				rst += "}";
			}
			label_detail.Text = rst;
		}

		// toggle enable
		private void toggleControlEnabled(bool enb)
		{
			foreach(var ctl in tglEnCtrl) {
				ctl.Enabled = enb;
			}
			chk_noasgn_CheckedChanged(null, null);
		}

		// check data-luck
		private bool checkInputData()
		{
			if(!inputData.IsDataExist && !isUseCheckfile) {
				return true;
			}
			var exist_genfile = (
				chk_isopt.Checked || 
				chk_isfreq.Checked || 
				chk_isirc.Checked || 
				chk_isnbo.Checked || 
				chk_td.Checked ||
				chk_iscustom.Checked
			);
			var required_item = (txb_name.Text != "" && savLocation != "" && cmb_theory.Text != "" && cmb_basis.Text != "");
			if(!exist_genfile) {
				MessageBox.Show("Please check 'Gen-File' at least one.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if(!required_item) {
				MessageBox.Show("Please enter required field: (name/location/method)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
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
			mid.isnosymm = chk_mnosymm.Checked;
			mid.charge = (int)nmr_charge.Value;
			mid.spin = (int)nmr_spin.Value;
			mid.genfile_opt = chk_isopt.Checked;
			mid.genfile_freq = chk_isfreq.Checked;
			mid.genfile_irc = chk_isirc.Checked;
			mid.genfile_nbo = chk_isnbo.Checked;
			mid.genfile_td = chk_td.Checked;
			mid.genfile_ct = chk_iscustom.Checked;
			// symbols
			mid.symbols = dic_symbol;
			// scf
			mid.scf = scfsetting;
			// iop
			mid.iop = iopsetting;
			// opt
			mid.lockpos = (txb_lockpos.Text.Split(new char[] { ',', '/' })).ToList();
			mid.optcyc = (int)nmr_optcyc.Value;
			mid.opt_fc = cmb_opt_fc.Text;
			mid.istransition = chk_transition.Checked;
			// freq
			mid.freq_mode = cmb_freqmode.Text;
			mid.freq_containopt = (mid.genfile_opt && mid.genfile_freq && chk_conopt.Checked);
			// irc
			mid.ircforcemode = cmb_ircfcmode.Text;
			mid.ircmaxpoint = (int)nmr_ircmaxpoint.Value;
			mid.ircisgendualfile = chk_gendual.Checked;
			// td
			mid.td_calctype = cmb_td_clmode.Text;
			mid.td_nstate = (int)num_td_nstate.Value;
			mid.td_density = cmb_td_dens.Text;
			// custom
			mid.ct_string = custom_str;
		}

		// generate .inp file
		private void generateInputFile()
		{
			if(!checkInputData()) {
				return;
			}
			var rst = true;
			var mid = new makeinpdata();
			midApply(ref mid);
			foreach(var inp in outputs) {
				if(inp.generateCheck(mid)) {
					if(inp.isExistGenerateFile(mid)) {
						var drst = MessageBox.Show(inp.genfilename(mid) + inp.Extension + "は既に存在するファイルです。上書きしますか？",
							"Warning", MessageBoxButtons.YesNoCancel);
						switch(drst) {
							case DialogResult.Yes:
								rst = rst && inp.writefile(mid, myst);
								break;
							case DialogResult.No:
								continue;
							case DialogResult.Cancel:
								return;
						}
					} else {
						rst = rst && inp.writefile(mid, myst);
					}
				}
			}
			if(rst) {
				MessageBox.Show("Save Success.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
				myst.latestData = mid;
			}
		}

		// wordpad open
		private void fileopen_innotepad_Click(object sender, EventArgs e)
		{
			var issel = (cmb_editlist.SelectedIndex >= 0);
			if(!issel) {
				return;
			}
			foreach(var inp in outputs) {
				if(inp.IdentifyName == cmb_editlist.Text) {
					var mid = new makeinpdata();
					midApply(ref mid);
					System.Diagnostics.Process.Start("wordpad.exe", String.Format("\"{0}\"", inp.outputPath(mid)));					
				}
			}
		}

		// custom edit 
		private void chk_iscustom_CheckedChanged(object sender, EventArgs e)
		{
			if(chk_iscustom.Checked) {
				var bedit = new simpleedit_m();
				bedit.inputText = custom_str;
				bedit.titleCaption = bedit.description = "Custom Input";
				if(bedit.ShowDialog() == DialogResult.OK) {
					custom_str = bedit.inputText;
				} else {
					chk_iscustom.Checked = false;
				}
			}
		}
	}
}
