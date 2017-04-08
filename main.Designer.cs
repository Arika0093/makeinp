namespace makeinp
{
	partial class main
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tlp_memory = new System.Windows.Forms.TableLayoutPanel();
			this.nmr_memory = new System.Windows.Forms.NumericUpDown();
			this.cmb_memory = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lsv_Inputdata = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.txb_name = new System.Windows.Forms.TextBox();
			this.flp_nproc = new System.Windows.Forms.FlowLayoutPanel();
			this.nmr_nproc = new System.Windows.Forms.NumericUpDown();
			this.chk_noasgn = new System.Windows.Forms.CheckBox();
			this.tlp_chrspn = new System.Windows.Forms.TableLayoutPanel();
			this.btn_SCF = new System.Windows.Forms.Button();
			this.btn_iop = new System.Windows.Forms.Button();
			this.nmr_spin = new System.Windows.Forms.NumericUpDown();
			this.nmr_charge = new System.Windows.Forms.NumericUpDown();
			this.flp_genfile = new System.Windows.Forms.FlowLayoutPanel();
			this.chk_isopt = new System.Windows.Forms.CheckBox();
			this.chk_isfreq = new System.Windows.Forms.CheckBox();
			this.chk_isirc = new System.Windows.Forms.CheckBox();
			this.tlp_saveloc = new System.Windows.Forms.TableLayoutPanel();
			this.txb_location = new System.Windows.Forms.TextBox();
			this.btn_folderopen = new System.Windows.Forms.Button();
			this.tlp_method = new System.Windows.Forms.TableLayoutPanel();
			this.cmb_theory = new System.Windows.Forms.ComboBox();
			this.cmb_basis = new System.Windows.Forms.ComboBox();
			this.cmb_star = new System.Windows.Forms.ComboBox();
			this.chk_mtest = new System.Windows.Forms.CheckBox();
			this.tlp_input = new System.Windows.Forms.TableLayoutPanel();
			this.btn_getdata = new System.Windows.Forms.Button();
			this.btn_usechk = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tlp_opt = new System.Windows.Forms.TableLayoutPanel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.nmr_optcyc = new System.Windows.Forms.NumericUpDown();
			this.chk_transition = new System.Windows.Forms.CheckBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tlp_freq = new System.Windows.Forms.TableLayoutPanel();
			this.label12 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tlp_ts = new System.Windows.Forms.TableLayoutPanel();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.tlp_edit = new System.Windows.Forms.TableLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.cmb_editlist = new System.Windows.Forms.ComboBox();
			this.txb_viewfile = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_next = new System.Windows.Forms.Button();
			this.btn_back = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tlp_memory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmr_memory)).BeginInit();
			this.flp_nproc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmr_nproc)).BeginInit();
			this.tlp_chrspn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmr_spin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmr_charge)).BeginInit();
			this.flp_genfile.SuspendLayout();
			this.tlp_saveloc.SuspendLayout();
			this.tlp_method.SuspendLayout();
			this.tlp_input.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tlp_opt.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmr_optcyc)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.tlp_freq.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tlp_edit.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 536);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(632, 482);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			this.tabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Deselecting);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tableLayoutPanel2);
			this.tabPage1.Location = new System.Drawing.Point(4, 27);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(624, 451);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Main";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.tlp_memory, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.lsv_Inputdata, 0, 8);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.txb_name, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.flp_nproc, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.tlp_chrspn, 1, 6);
			this.tableLayoutPanel2.Controls.Add(this.flp_genfile, 1, 7);
			this.tableLayoutPanel2.Controls.Add(this.tlp_saveloc, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.tlp_method, 1, 5);
			this.tableLayoutPanel2.Controls.Add(this.tlp_input, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 9;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(618, 445);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// tlp_memory
			// 
			this.tlp_memory.ColumnCount = 2;
			this.tlp_memory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_memory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_memory.Controls.Add(this.nmr_memory, 0, 0);
			this.tlp_memory.Controls.Add(this.cmb_memory, 1, 0);
			this.tlp_memory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_memory.Enabled = false;
			this.tlp_memory.Location = new System.Drawing.Point(160, 166);
			this.tlp_memory.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
			this.tlp_memory.Name = "tlp_memory";
			this.tlp_memory.RowCount = 1;
			this.tlp_memory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_memory.Size = new System.Drawing.Size(455, 30);
			this.tlp_memory.TabIndex = 8;
			// 
			// nmr_memory
			// 
			this.nmr_memory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nmr_memory.Location = new System.Drawing.Point(3, 3);
			this.nmr_memory.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
			this.nmr_memory.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmr_memory.Name = "nmr_memory";
			this.nmr_memory.Size = new System.Drawing.Size(221, 25);
			this.nmr_memory.TabIndex = 0;
			this.nmr_memory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nmr_memory.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
			// 
			// cmb_memory
			// 
			this.cmb_memory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmb_memory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_memory.FormattingEnabled = true;
			this.cmb_memory.Items.AddRange(new object[] {
            "KB",
            "MB",
            "GB",
            "KW",
            "MW",
            "GW"});
			this.cmb_memory.Location = new System.Drawing.Point(230, 3);
			this.cmb_memory.Name = "cmb_memory";
			this.cmb_memory.Size = new System.Drawing.Size(222, 26);
			this.cmb_memory.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Location = new System.Drawing.Point(3, 166);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(154, 33);
			this.label8.TabIndex = 7;
			this.label8.Text = "Memory(%mem):";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(3, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(154, 37);
			this.label6.TabIndex = 3;
			this.label6.Text = "Gen. Location:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 264);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(154, 33);
			this.label5.TabIndex = 8;
			this.label5.Text = "Generate File:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(154, 33);
			this.label4.TabIndex = 11;
			this.label4.Text = "Charge/Spin/SCF/IOp:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 199);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 32);
			this.label3.TabIndex = 9;
			this.label3.Text = "Used-Method(#p):";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 37);
			this.label2.TabIndex = 5;
			this.label2.Text = "Used-Process(%nproc):";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lsv_Inputdata
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.lsv_Inputdata, 2);
			this.lsv_Inputdata.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsv_Inputdata.Enabled = false;
			this.lsv_Inputdata.FullRowSelect = true;
			this.lsv_Inputdata.GridLines = true;
			this.lsv_Inputdata.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lsv_Inputdata.Location = new System.Drawing.Point(3, 300);
			this.lsv_Inputdata.MultiSelect = false;
			this.lsv_Inputdata.Name = "lsv_Inputdata";
			this.lsv_Inputdata.Size = new System.Drawing.Size(612, 142);
			this.lsv_Inputdata.TabIndex = 12;
			this.lsv_Inputdata.UseCompatibleStateImageBehavior = false;
			this.lsv_Inputdata.View = System.Windows.Forms.View.Details;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txb_name
			// 
			this.txb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txb_name.Enabled = false;
			this.txb_name.Location = new System.Drawing.Point(163, 63);
			this.txb_name.Name = "txb_name";
			this.txb_name.Size = new System.Drawing.Size(452, 25);
			this.txb_name.TabIndex = 2;
			// 
			// flp_nproc
			// 
			this.flp_nproc.Controls.Add(this.nmr_nproc);
			this.flp_nproc.Controls.Add(this.chk_noasgn);
			this.flp_nproc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flp_nproc.Enabled = false;
			this.flp_nproc.Location = new System.Drawing.Point(160, 132);
			this.flp_nproc.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.flp_nproc.Name = "flp_nproc";
			this.flp_nproc.Size = new System.Drawing.Size(455, 31);
			this.flp_nproc.TabIndex = 6;
			// 
			// nmr_nproc
			// 
			this.nmr_nproc.Location = new System.Drawing.Point(3, 3);
			this.nmr_nproc.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.nmr_nproc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nmr_nproc.Name = "nmr_nproc";
			this.nmr_nproc.Size = new System.Drawing.Size(224, 25);
			this.nmr_nproc.TabIndex = 0;
			this.nmr_nproc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nmr_nproc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// chk_noasgn
			// 
			this.chk_noasgn.AutoSize = true;
			this.chk_noasgn.Checked = true;
			this.chk_noasgn.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_noasgn.Location = new System.Drawing.Point(233, 3);
			this.chk_noasgn.Name = "chk_noasgn";
			this.chk_noasgn.Size = new System.Drawing.Size(112, 22);
			this.chk_noasgn.TabIndex = 1;
			this.chk_noasgn.Text = "no assignment";
			this.chk_noasgn.UseVisualStyleBackColor = true;
			this.chk_noasgn.CheckedChanged += new System.EventHandler(this.chk_noasgn_CheckedChanged);
			// 
			// tlp_chrspn
			// 
			this.tlp_chrspn.ColumnCount = 4;
			this.tlp_chrspn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_chrspn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_chrspn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
			this.tlp_chrspn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
			this.tlp_chrspn.Controls.Add(this.btn_SCF, 2, 0);
			this.tlp_chrspn.Controls.Add(this.btn_iop, 3, 0);
			this.tlp_chrspn.Controls.Add(this.nmr_spin, 1, 0);
			this.tlp_chrspn.Controls.Add(this.nmr_charge, 0, 0);
			this.tlp_chrspn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_chrspn.Enabled = false;
			this.tlp_chrspn.Location = new System.Drawing.Point(160, 231);
			this.tlp_chrspn.Margin = new System.Windows.Forms.Padding(0);
			this.tlp_chrspn.Name = "tlp_chrspn";
			this.tlp_chrspn.RowCount = 1;
			this.tlp_chrspn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_chrspn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tlp_chrspn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
			this.tlp_chrspn.Size = new System.Drawing.Size(458, 33);
			this.tlp_chrspn.TabIndex = 10;
			// 
			// btn_SCF
			// 
			this.btn_SCF.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_SCF.Enabled = false;
			this.btn_SCF.Location = new System.Drawing.Point(361, 3);
			this.btn_SCF.Name = "btn_SCF";
			this.btn_SCF.Size = new System.Drawing.Size(46, 27);
			this.btn_SCF.TabIndex = 3;
			this.btn_SCF.Text = "SCF";
			this.btn_SCF.UseVisualStyleBackColor = true;
			// 
			// btn_iop
			// 
			this.btn_iop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_iop.Enabled = false;
			this.btn_iop.Location = new System.Drawing.Point(413, 3);
			this.btn_iop.Name = "btn_iop";
			this.btn_iop.Size = new System.Drawing.Size(42, 27);
			this.btn_iop.TabIndex = 0;
			this.btn_iop.Text = "iop";
			this.btn_iop.UseVisualStyleBackColor = true;
			// 
			// nmr_spin
			// 
			this.nmr_spin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nmr_spin.Location = new System.Drawing.Point(182, 3);
			this.nmr_spin.Name = "nmr_spin";
			this.nmr_spin.Size = new System.Drawing.Size(173, 25);
			this.nmr_spin.TabIndex = 1;
			this.nmr_spin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nmr_spin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// nmr_charge
			// 
			this.nmr_charge.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nmr_charge.Location = new System.Drawing.Point(3, 3);
			this.nmr_charge.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nmr_charge.Name = "nmr_charge";
			this.nmr_charge.Size = new System.Drawing.Size(173, 25);
			this.nmr_charge.TabIndex = 0;
			this.nmr_charge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// flp_genfile
			// 
			this.flp_genfile.Controls.Add(this.chk_isopt);
			this.flp_genfile.Controls.Add(this.chk_isfreq);
			this.flp_genfile.Controls.Add(this.chk_isirc);
			this.flp_genfile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flp_genfile.Enabled = false;
			this.flp_genfile.Location = new System.Drawing.Point(163, 267);
			this.flp_genfile.Name = "flp_genfile";
			this.flp_genfile.Size = new System.Drawing.Size(452, 27);
			this.flp_genfile.TabIndex = 11;
			// 
			// chk_isopt
			// 
			this.chk_isopt.AutoSize = true;
			this.chk_isopt.Checked = true;
			this.chk_isopt.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_isopt.Location = new System.Drawing.Point(3, 3);
			this.chk_isopt.Name = "chk_isopt";
			this.chk_isopt.Size = new System.Drawing.Size(77, 22);
			this.chk_isopt.TabIndex = 1;
			this.chk_isopt.Text = "optimize";
			this.chk_isopt.UseVisualStyleBackColor = true;
			// 
			// chk_isfreq
			// 
			this.chk_isfreq.AutoSize = true;
			this.chk_isfreq.Location = new System.Drawing.Point(86, 3);
			this.chk_isfreq.Name = "chk_isfreq";
			this.chk_isfreq.Size = new System.Drawing.Size(84, 22);
			this.chk_isfreq.TabIndex = 2;
			this.chk_isfreq.Text = "frequency";
			this.chk_isfreq.UseVisualStyleBackColor = true;
			// 
			// chk_isirc
			// 
			this.chk_isirc.AutoSize = true;
			this.chk_isirc.Enabled = false;
			this.chk_isirc.Location = new System.Drawing.Point(176, 3);
			this.chk_isirc.Name = "chk_isirc";
			this.chk_isirc.Size = new System.Drawing.Size(48, 22);
			this.chk_isirc.TabIndex = 0;
			this.chk_isirc.Text = "IRC";
			this.chk_isirc.UseVisualStyleBackColor = true;
			// 
			// tlp_saveloc
			// 
			this.tlp_saveloc.ColumnCount = 2;
			this.tlp_saveloc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_saveloc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
			this.tlp_saveloc.Controls.Add(this.txb_location, 0, 0);
			this.tlp_saveloc.Controls.Add(this.btn_folderopen, 1, 0);
			this.tlp_saveloc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_saveloc.Enabled = false;
			this.tlp_saveloc.Location = new System.Drawing.Point(160, 92);
			this.tlp_saveloc.Margin = new System.Windows.Forms.Padding(0);
			this.tlp_saveloc.Name = "tlp_saveloc";
			this.tlp_saveloc.RowCount = 1;
			this.tlp_saveloc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_saveloc.Size = new System.Drawing.Size(458, 37);
			this.tlp_saveloc.TabIndex = 4;
			// 
			// txb_location
			// 
			this.txb_location.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txb_location.Location = new System.Drawing.Point(3, 6);
			this.txb_location.Name = "txb_location";
			this.txb_location.ReadOnly = true;
			this.txb_location.Size = new System.Drawing.Size(408, 25);
			this.txb_location.TabIndex = 0;
			// 
			// btn_folderopen
			// 
			this.btn_folderopen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_folderopen.Location = new System.Drawing.Point(417, 3);
			this.btn_folderopen.Name = "btn_folderopen";
			this.btn_folderopen.Size = new System.Drawing.Size(38, 31);
			this.btn_folderopen.TabIndex = 1;
			this.btn_folderopen.Text = "...";
			this.btn_folderopen.UseVisualStyleBackColor = true;
			this.btn_folderopen.Click += new System.EventHandler(this.btn_folderopen_Click);
			// 
			// tlp_method
			// 
			this.tlp_method.ColumnCount = 4;
			this.tlp_method.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_method.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_method.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
			this.tlp_method.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tlp_method.Controls.Add(this.cmb_theory, 0, 0);
			this.tlp_method.Controls.Add(this.cmb_basis, 1, 0);
			this.tlp_method.Controls.Add(this.cmb_star, 2, 0);
			this.tlp_method.Controls.Add(this.chk_mtest, 3, 0);
			this.tlp_method.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_method.Enabled = false;
			this.tlp_method.Location = new System.Drawing.Point(160, 199);
			this.tlp_method.Margin = new System.Windows.Forms.Padding(0);
			this.tlp_method.Name = "tlp_method";
			this.tlp_method.RowCount = 1;
			this.tlp_method.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_method.Size = new System.Drawing.Size(458, 32);
			this.tlp_method.TabIndex = 9;
			// 
			// cmb_theory
			// 
			this.cmb_theory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmb_theory.FormattingEnabled = true;
			this.cmb_theory.Items.AddRange(new object[] {
            "HF",
            "CASSCF",
            "GVB",
            "MP2",
            "MP3",
            "MP4",
            "MP5",
            "CIS",
            "CISD",
            "QCISD",
            "CCSD",
            "Slater",
            "Xalpha",
            "HFB",
            "VWN",
            "VWN5",
            "LYP",
            "PL",
            "P86",
            "PW91",
            "Becke3"});
			this.cmb_theory.Location = new System.Drawing.Point(3, 3);
			this.cmb_theory.Name = "cmb_theory";
			this.cmb_theory.Size = new System.Drawing.Size(135, 26);
			this.cmb_theory.TabIndex = 0;
			this.cmb_theory.Text = "HF";
			// 
			// cmb_basis
			// 
			this.cmb_basis.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmb_basis.FormattingEnabled = true;
			this.cmb_basis.Items.AddRange(new object[] {
            "STO-3G",
            "3-21G",
            "6-21G",
            "4-31G",
            "6-31G",
            "6-311G",
            "D95V",
            "D95",
            "SHC",
            "CEP-4G",
            "CEP-31G",
            "CEP-121G",
            "LANL2MB",
            "LANL2DZ",
            "cc-pVDZ",
            "cc-pVTZ",
            "cc-pVQZ",
            "cc-pV5Z",
            "cc-pV6Z"});
			this.cmb_basis.Location = new System.Drawing.Point(144, 3);
			this.cmb_basis.Name = "cmb_basis";
			this.cmb_basis.Size = new System.Drawing.Size(135, 26);
			this.cmb_basis.TabIndex = 1;
			this.cmb_basis.Text = "6-31G";
			// 
			// cmb_star
			// 
			this.cmb_star.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmb_star.FormattingEnabled = true;
			this.cmb_star.Items.AddRange(new object[] {
            "",
            "*",
            "**",
            "+",
            "++"});
			this.cmb_star.Location = new System.Drawing.Point(285, 3);
			this.cmb_star.Name = "cmb_star";
			this.cmb_star.Size = new System.Drawing.Size(50, 26);
			this.cmb_star.TabIndex = 2;
			this.cmb_star.Text = "*";
			// 
			// chk_mtest
			// 
			this.chk_mtest.AutoSize = true;
			this.chk_mtest.Checked = true;
			this.chk_mtest.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_mtest.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chk_mtest.Location = new System.Drawing.Point(341, 3);
			this.chk_mtest.Name = "chk_mtest";
			this.chk_mtest.Size = new System.Drawing.Size(114, 26);
			this.chk_mtest.TabIndex = 3;
			this.chk_mtest.Text = "test";
			this.chk_mtest.UseVisualStyleBackColor = true;
			// 
			// tlp_input
			// 
			this.tlp_input.ColumnCount = 2;
			this.tableLayoutPanel2.SetColumnSpan(this.tlp_input, 2);
			this.tlp_input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_input.Controls.Add(this.btn_getdata, 0, 0);
			this.tlp_input.Controls.Add(this.btn_usechk, 1, 0);
			this.tlp_input.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_input.Location = new System.Drawing.Point(0, 0);
			this.tlp_input.Margin = new System.Windows.Forms.Padding(0);
			this.tlp_input.Name = "tlp_input";
			this.tlp_input.RowCount = 1;
			this.tlp_input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_input.Size = new System.Drawing.Size(618, 60);
			this.tlp_input.TabIndex = 0;
			// 
			// btn_getdata
			// 
			this.btn_getdata.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_getdata.Location = new System.Drawing.Point(3, 3);
			this.btn_getdata.Name = "btn_getdata";
			this.btn_getdata.Size = new System.Drawing.Size(303, 54);
			this.btn_getdata.TabIndex = 0;
			this.btn_getdata.Text = "Paste from Clipboard";
			this.btn_getdata.UseVisualStyleBackColor = true;
			this.btn_getdata.Click += new System.EventHandler(this.btn_getdata_Click);
			// 
			// btn_usechk
			// 
			this.btn_usechk.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_usechk.Location = new System.Drawing.Point(312, 3);
			this.btn_usechk.Name = "btn_usechk";
			this.btn_usechk.Size = new System.Drawing.Size(303, 54);
			this.btn_usechk.TabIndex = 1;
			this.btn_usechk.Text = "Use Checkpoint File...";
			this.btn_usechk.UseVisualStyleBackColor = true;
			this.btn_usechk.Click += new System.EventHandler(this.btn_usechk_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tlp_opt);
			this.tabPage2.Location = new System.Drawing.Point(4, 27);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(624, 451);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Optimize";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tlp_opt
			// 
			this.tlp_opt.ColumnCount = 2;
			this.tlp_opt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
			this.tlp_opt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_opt.Controls.Add(this.label10, 0, 1);
			this.tlp_opt.Controls.Add(this.label9, 0, 0);
			this.tlp_opt.Controls.Add(this.nmr_optcyc, 1, 0);
			this.tlp_opt.Controls.Add(this.chk_transition, 1, 1);
			this.tlp_opt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_opt.Enabled = false;
			this.tlp_opt.Location = new System.Drawing.Point(0, 0);
			this.tlp_opt.Name = "tlp_opt";
			this.tlp_opt.RowCount = 3;
			this.tlp_opt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tlp_opt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tlp_opt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_opt.Size = new System.Drawing.Size(624, 451);
			this.tlp_opt.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.Location = new System.Drawing.Point(3, 32);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 32);
			this.label10.TabIndex = 16;
			this.label10.Text = "Transition:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Location = new System.Drawing.Point(3, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 32);
			this.label9.TabIndex = 14;
			this.label9.Text = "MaxCycle:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nmr_optcyc
			// 
			this.nmr_optcyc.Location = new System.Drawing.Point(121, 3);
			this.nmr_optcyc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nmr_optcyc.Name = "nmr_optcyc";
			this.nmr_optcyc.Size = new System.Drawing.Size(115, 25);
			this.nmr_optcyc.TabIndex = 15;
			this.nmr_optcyc.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// chk_transition
			// 
			this.chk_transition.AutoSize = true;
			this.chk_transition.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chk_transition.Location = new System.Drawing.Point(121, 35);
			this.chk_transition.Name = "chk_transition";
			this.chk_transition.Size = new System.Drawing.Size(500, 26);
			this.chk_transition.TabIndex = 17;
			this.chk_transition.Text = "Calc Transition Mode";
			this.chk_transition.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.tlp_freq);
			this.tabPage3.Location = new System.Drawing.Point(4, 27);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(624, 451);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Frequency";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tlp_freq
			// 
			this.tlp_freq.ColumnCount = 2;
			this.tlp_freq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
			this.tlp_freq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_freq.Controls.Add(this.label12, 0, 0);
			this.tlp_freq.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_freq.Enabled = false;
			this.tlp_freq.Location = new System.Drawing.Point(0, 0);
			this.tlp_freq.Name = "tlp_freq";
			this.tlp_freq.RowCount = 3;
			this.tlp_freq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tlp_freq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tlp_freq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_freq.Size = new System.Drawing.Size(624, 451);
			this.tlp_freq.TabIndex = 1;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.tlp_freq.SetColumnSpan(this.label12, 2);
			this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label12.Location = new System.Drawing.Point(3, 0);
			this.label12.Name = "label12";
			this.tlp_freq.SetRowSpan(this.label12, 3);
			this.label12.Size = new System.Drawing.Size(618, 451);
			this.label12.TabIndex = 14;
			this.label12.Text = "(no-option)";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.tlp_ts);
			this.tabPage4.Location = new System.Drawing.Point(4, 27);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(624, 451);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "IRC";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tlp_ts
			// 
			this.tlp_ts.ColumnCount = 2;
			this.tlp_ts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_ts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_ts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_ts.Enabled = false;
			this.tlp_ts.Location = new System.Drawing.Point(0, 0);
			this.tlp_ts.Name = "tlp_ts";
			this.tlp_ts.RowCount = 2;
			this.tlp_ts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_ts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_ts.Size = new System.Drawing.Size(624, 451);
			this.tlp_ts.TabIndex = 1;
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.tlp_edit);
			this.tabPage6.Location = new System.Drawing.Point(4, 27);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(624, 451);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "View File";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// tlp_edit
			// 
			this.tlp_edit.ColumnCount = 4;
			this.tlp_edit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
			this.tlp_edit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_edit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.tlp_edit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
			this.tlp_edit.Controls.Add(this.label7, 0, 0);
			this.tlp_edit.Controls.Add(this.cmb_editlist, 1, 0);
			this.tlp_edit.Controls.Add(this.txb_viewfile, 0, 1);
			this.tlp_edit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_edit.Enabled = false;
			this.tlp_edit.Location = new System.Drawing.Point(0, 0);
			this.tlp_edit.Name = "tlp_edit";
			this.tlp_edit.RowCount = 2;
			this.tlp_edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tlp_edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_edit.Size = new System.Drawing.Size(624, 451);
			this.tlp_edit.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 31);
			this.label7.TabIndex = 0;
			this.label7.Text = "View:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmb_editlist
			// 
			this.tlp_edit.SetColumnSpan(this.cmb_editlist, 3);
			this.cmb_editlist.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmb_editlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_editlist.FormattingEnabled = true;
			this.cmb_editlist.Items.AddRange(new object[] {
            "optimize",
            "frequency",
            "transition-forward",
            "transition-reverse"});
			this.cmb_editlist.Location = new System.Drawing.Point(76, 3);
			this.cmb_editlist.Name = "cmb_editlist";
			this.cmb_editlist.Size = new System.Drawing.Size(545, 26);
			this.cmb_editlist.TabIndex = 1;
			this.cmb_editlist.SelectedIndexChanged += new System.EventHandler(this.cmb_editlist_SelectedIndexChanged);
			// 
			// txb_viewfile
			// 
			this.tlp_edit.SetColumnSpan(this.txb_viewfile, 4);
			this.txb_viewfile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_viewfile.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_viewfile.Location = new System.Drawing.Point(3, 34);
			this.txb_viewfile.Multiline = true;
			this.txb_viewfile.Name = "txb_viewfile";
			this.txb_viewfile.ReadOnly = true;
			this.txb_viewfile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txb_viewfile.Size = new System.Drawing.Size(618, 414);
			this.txb_viewfile.TabIndex = 2;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 4;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel5.Controls.Add(this.btn_next, 3, 0);
			this.tableLayoutPanel5.Controls.Add(this.btn_back, 2, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 488);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(632, 45);
			this.tableLayoutPanel5.TabIndex = 3;
			// 
			// btn_next
			// 
			this.btn_next.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_next.Enabled = false;
			this.btn_next.Location = new System.Drawing.Point(495, 3);
			this.btn_next.Name = "btn_next";
			this.btn_next.Size = new System.Drawing.Size(134, 39);
			this.btn_next.TabIndex = 1;
			this.btn_next.Text = "&Next";
			this.btn_next.UseVisualStyleBackColor = true;
			this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
			// 
			// btn_back
			// 
			this.btn_back.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_back.Enabled = false;
			this.btn_back.Location = new System.Drawing.Point(397, 3);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(92, 39);
			this.btn_back.TabIndex = 0;
			this.btn_back.Text = "&Back";
			this.btn_back.UseVisualStyleBackColor = true;
			this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
			// 
			// main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 536);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "make input file";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
			this.Load += new System.EventHandler(this.main_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tlp_memory.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmr_memory)).EndInit();
			this.flp_nproc.ResumeLayout(false);
			this.flp_nproc.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmr_nproc)).EndInit();
			this.tlp_chrspn.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmr_spin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmr_charge)).EndInit();
			this.flp_genfile.ResumeLayout(false);
			this.flp_genfile.PerformLayout();
			this.tlp_saveloc.ResumeLayout(false);
			this.tlp_saveloc.PerformLayout();
			this.tlp_method.ResumeLayout(false);
			this.tlp_method.PerformLayout();
			this.tlp_input.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tlp_opt.ResumeLayout(false);
			this.tlp_opt.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmr_optcyc)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tlp_freq.ResumeLayout(false);
			this.tlp_freq.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.tlp_edit.ResumeLayout(false);
			this.tlp_edit.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_getdata;
		private System.Windows.Forms.ListView lsv_Inputdata;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txb_name;
		private System.Windows.Forms.FlowLayoutPanel flp_nproc;
		private System.Windows.Forms.NumericUpDown nmr_nproc;
		private System.Windows.Forms.CheckBox chk_noasgn;
		private System.Windows.Forms.TableLayoutPanel tlp_chrspn;
		private System.Windows.Forms.NumericUpDown nmr_charge;
		private System.Windows.Forms.FlowLayoutPanel flp_genfile;
		private System.Windows.Forms.CheckBox chk_isopt;
		private System.Windows.Forms.CheckBox chk_isfreq;
		private System.Windows.Forms.CheckBox chk_isirc;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TableLayoutPanel tlp_saveloc;
		private System.Windows.Forms.Button btn_folderopen;
		private System.Windows.Forms.TableLayoutPanel tlp_edit;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmb_editlist;
		private System.Windows.Forms.TextBox txb_viewfile;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Button btn_next;
		private System.Windows.Forms.Button btn_back;
		private System.Windows.Forms.TextBox txb_location;
		private System.Windows.Forms.TableLayoutPanel tlp_opt;
		private System.Windows.Forms.TableLayoutPanel tlp_ts;
		private System.Windows.Forms.NumericUpDown nmr_spin;
		private System.Windows.Forms.TableLayoutPanel tlp_memory;
		private System.Windows.Forms.NumericUpDown nmr_memory;
		private System.Windows.Forms.ComboBox cmb_memory;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TableLayoutPanel tlp_method;
		private System.Windows.Forms.ComboBox cmb_theory;
		private System.Windows.Forms.ComboBox cmb_basis;
		private System.Windows.Forms.ComboBox cmb_star;
		private System.Windows.Forms.CheckBox chk_mtest;
		private System.Windows.Forms.TableLayoutPanel tlp_input;
		private System.Windows.Forms.Button btn_usechk;
		private System.Windows.Forms.Button btn_SCF;
		private System.Windows.Forms.Button btn_iop;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown nmr_optcyc;
		private System.Windows.Forms.CheckBox chk_transition;
		private System.Windows.Forms.TableLayoutPanel tlp_freq;
		private System.Windows.Forms.Label label12;



	}
}

