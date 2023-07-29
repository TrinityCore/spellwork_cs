namespace SpellWork.Forms
{
    sealed partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._dbConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this._status = new System.Windows.Forms.ToolStripStatusLabel();
            this._ProcStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this._ilPro = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this._tpCompare = new System.Windows.Forms.TabPage();
            this._scCompareRoot = new System.Windows.Forms.SplitContainer();
            this._bCompareSearch1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this._tbCompareFilterSpell1 = new System.Windows.Forms.TextBox();
            this._rtbCompareSpell1 = new System.Windows.Forms.RichTextBox();
            this._bCompareSearch2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this._rtbCompareSpell2 = new System.Windows.Forms.RichTextBox();
            this._tbCompareFilterSpell2 = new System.Windows.Forms.TextBox();
            this._tpSpellInfo = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._rtSpellInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lvSpellList = new System.Windows.Forms.ListView();
            this.chSpellID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSpellName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMiscID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._gSpellFilter = new System.Windows.Forms.GroupBox();
            this._gbAdvansedSearch = new System.Windows.Forms.GroupBox();
            this._cbAdvancedFilter2CompareType = new System.Windows.Forms.ComboBox();
            this._cbAdvancedFilter1CompareType = new System.Windows.Forms.ComboBox();
            this._tbAdvancedFilter2Val = new System.Windows.Forms.TextBox();
            this._tbAdvancedFilter1Val = new System.Windows.Forms.TextBox();
            this._cbAdvancedFilter2 = new System.Windows.Forms.ComboBox();
            this._cbAdvancedFilter1 = new System.Windows.Forms.ComboBox();
            this._cbAdvancedEffectFilter2CompareType = new System.Windows.Forms.ComboBox();
            this._cbAdvancedEffectFilter1CompareType = new System.Windows.Forms.ComboBox();
            this._tbAdvancedEffectFilter2Val = new System.Windows.Forms.TextBox();
            this._tbAdvancedEffectFilter1Val = new System.Windows.Forms.TextBox();
            this._cbAdvancedEffectFilter2 = new System.Windows.Forms.ComboBox();
            this._cbAdvancedEffectFilter1 = new System.Windows.Forms.ComboBox();
            this._cbTarget2 = new System.Windows.Forms.ComboBox();
            this._cbTarget1 = new System.Windows.Forms.ComboBox();
            this._cbSpellEffect = new System.Windows.Forms.ComboBox();
            this._cbSpellAura = new System.Windows.Forms.ComboBox();
            this._cbSpellFamilyName = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._bSearch = new System.Windows.Forms.Button();
            this._tbSearchAttributes = new System.Windows.Forms.TextBox();
            this._tbSearchIcon = new System.Windows.Forms.TextBox();
            this._tbSearchId = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._tpSpellProcInfo = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this._lNewProcSpellId = new System.Windows.Forms.Label();
            this._gProcAttributes = new System.Windows.Forms.GroupBox();
            this._clbProcAttributes = new System.Windows.Forms.CheckedListBox();
            this._gProcFlags = new System.Windows.Forms.GroupBox();
            this._clbProcFlags = new System.Windows.Forms.CheckedListBox();
            this._gProcHitMask = new System.Windows.Forms.GroupBox();
            this._clbProcFlagHit = new System.Windows.Forms.CheckedListBox();
            this._gSpellProcEvent = new System.Windows.Forms.GroupBox();
            this._tbProcCharges = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this._cbProcFitstSpellFamily = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._tbPPM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._tbChance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._tbCooldown = new System.Windows.Forms.TextBox();
            this._gProcSpellSchools = new System.Windows.Forms.GroupBox();
            this._clbSchools = new System.Windows.Forms.CheckedListBox();
            this._gProcSpellTypeMask = new System.Windows.Forms.GroupBox();
            this._clbSpellTypeMask = new System.Windows.Forms.CheckedListBox();
            this._gProcSpellPhaseMask = new System.Windows.Forms.GroupBox();
            this._clbSpellPhaseMask = new System.Windows.Forms.CheckedListBox();
            this._lProcHeader = new System.Windows.Forms.Label();
            this._tbNewProcSpellId = new System.Windows.Forms.TextBox();
            this._bLoadProcFromDB = new System.Windows.Forms.Button();
            this._bNewProcSpellId = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this._cbProcSpellFamilyTree = new System.Windows.Forms.ComboBox();
            this._tvFamilyTree = new System.Windows.Forms.TreeView();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this._rtbProcSpellInfo = new System.Windows.Forms.RichTextBox();
            this._lvProcSpellList = new System.Windows.Forms.ListView();
            this._chProcID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._chProcName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._bProcSearch = new System.Windows.Forms.Button();
            this._tbProcSeach = new System.Windows.Forms.TextBox();
            this._cbProcTarget2 = new System.Windows.Forms.ComboBox();
            this._cbProcTarget1 = new System.Windows.Forms.ComboBox();
            this._cbProcSpellEffect = new System.Windows.Forms.ComboBox();
            this._cbProcSpellAura = new System.Windows.Forms.ComboBox();
            this._cbProcSpellFamilyName = new System.Windows.Forms.ComboBox();
            this._lvProcAdditionalInfo = new System.Windows.Forms.ListView();
            this._chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._tpSpellProcDB = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._cbBinaryCompare = new System.Windows.Forms.CheckBox();
            this._lProcSqlCustomQueryFragment = new System.Windows.Forms.Label();
            this._tbSqlManual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._bSqlProcFlagsHit = new System.Windows.Forms.Button();
            this._bSqlProc = new System.Windows.Forms.Button();
            this._bSqlSchool = new System.Windows.Forms.Button();
            this._tbSqlProcFlagsHit = new System.Windows.Forms.TextBox();
            this._tbSqlProc = new System.Windows.Forms.TextBox();
            this._tbSqlSchool = new System.Windows.Forms.TextBox();
            this._tbLoadProcSpellId = new System.Windows.Forms.TextBox();
            this._cbSqlSpellFamily = new System.Windows.Forms.ComboBox();
            this._bSelect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this._lvDataList = new System.Windows.Forms.ListView();
            this.spellId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schoolmask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilyname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymask0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymask1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymask2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spellfamilymask3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procflag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procFlags2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procSpellTypeMask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procSpellPhaseMask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procHitMask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procAttributesMask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procDisableEffectsMask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ppmRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customchance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cooldown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.procCharges = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._rtbSqlLog = new System.Windows.Forms.RichTextBox();
            this._bSqlToBase = new System.Windows.Forms.Button();
            this._bSqlSave = new System.Windows.Forms.Button();
            this._cbProcFlag = new System.Windows.Forms.CheckBox();
            this._bWrite = new System.Windows.Forms.Button();
            this._bLevelScaling = new System.Windows.Forms.Button();
            this.loadingProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.loadingProgressLabel1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this._tpCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scCompareRoot)).BeginInit();
            this._scCompareRoot.Panel1.SuspendLayout();
            this._scCompareRoot.Panel2.SuspendLayout();
            this._scCompareRoot.SuspendLayout();
            this._tpSpellInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this._gSpellFilter.SuspendLayout();
            this._gbAdvansedSearch.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this._tpSpellProcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this._gProcAttributes.SuspendLayout();
            this._gProcFlags.SuspendLayout();
            this._gProcHitMask.SuspendLayout();
            this._gSpellProcEvent.SuspendLayout();
            this._gProcSpellSchools.SuspendLayout();
            this._gProcSpellTypeMask.SuspendLayout();
            this._gProcSpellPhaseMask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this._tpSpellProcDB.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._dbConnect,
            this._status,
            this._ProcStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 759);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _dbConnect
            // 
            this._dbConnect.Name = "_dbConnect";
            this._dbConnect.Size = new System.Drawing.Size(0, 17);
            // 
            // _status
            // 
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(0, 17);
            // 
            // _ProcStatus
            // 
            this._ProcStatus.Name = "_ProcStatus";
            this._ProcStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _tsmFile
            // 
            this._tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmSettings,
            this._tsmExit});
            this._tsmFile.Name = "_tsmFile";
            this._tsmFile.Size = new System.Drawing.Size(37, 20);
            this._tsmFile.Text = "File";
            // 
            // _tsmSettings
            // 
            this._tsmSettings.Name = "_tsmSettings";
            this._tsmSettings.Size = new System.Drawing.Size(116, 22);
            this._tsmSettings.Text = "Settings";
            this._tsmSettings.Click += new System.EventHandler(this.SettingsClick);
            // 
            // _tsmExit
            // 
            this._tsmExit.Name = "_tsmExit";
            this._tsmExit.Size = new System.Drawing.Size(116, 22);
            this._tsmExit.Text = "Exit";
            this._tsmExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // _ilPro
            // 
            this._ilPro.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_ilPro.ImageStream")));
            this._ilPro.TransparentColor = System.Drawing.Color.Transparent;
            this._ilPro.Images.SetKeyName(0, "info.ico");
            this._ilPro.Images.SetKeyName(1, "ok.ico");
            this._ilPro.Images.SetKeyName(2, "drop.ico");
            this._ilPro.Images.SetKeyName(3, "plus.ico");
            this._ilPro.Images.SetKeyName(4, "family.ico");
            this._ilPro.Images.SetKeyName(5, "munus.ico");
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.splitContainer8);
            this.splitContainer7.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer7.Size = new System.Drawing.Size(858, 429);
            this.splitContainer7.SplitterDistance = 424;
            this.splitContainer7.TabIndex = 0;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.textBox2);
            this.splitContainer8.Size = new System.Drawing.Size(424, 429);
            this.splitContainer8.SplitterDistance = 209;
            this.splitContainer8.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 429);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(430, 429);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // _tpCompare
            // 
            this._tpCompare.Controls.Add(this._scCompareRoot);
            this._tpCompare.Location = new System.Drawing.Point(4, 22);
            this._tpCompare.Name = "_tpCompare";
            this._tpCompare.Padding = new System.Windows.Forms.Padding(3);
            this._tpCompare.Size = new System.Drawing.Size(1176, 709);
            this._tpCompare.TabIndex = 4;
            this._tpCompare.Text = "Compare Spells";
            this._tpCompare.UseVisualStyleBackColor = true;
            // 
            // _scCompareRoot
            // 
            this._scCompareRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scCompareRoot.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._scCompareRoot.Location = new System.Drawing.Point(3, 3);
            this._scCompareRoot.Name = "_scCompareRoot";
            // 
            // _scCompareRoot.Panel1
            // 
            this._scCompareRoot.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this._scCompareRoot.Panel1.Controls.Add(this._bCompareSearch1);
            this._scCompareRoot.Panel1.Controls.Add(this.label13);
            this._scCompareRoot.Panel1.Controls.Add(this._tbCompareFilterSpell1);
            this._scCompareRoot.Panel1.Controls.Add(this._rtbCompareSpell1);
            // 
            // _scCompareRoot.Panel2
            // 
            this._scCompareRoot.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this._scCompareRoot.Panel2.Controls.Add(this._bCompareSearch2);
            this._scCompareRoot.Panel2.Controls.Add(this.label14);
            this._scCompareRoot.Panel2.Controls.Add(this._rtbCompareSpell2);
            this._scCompareRoot.Panel2.Controls.Add(this._tbCompareFilterSpell2);
            this._scCompareRoot.Size = new System.Drawing.Size(1170, 703);
            this._scCompareRoot.SplitterDistance = 583;
            this._scCompareRoot.TabIndex = 0;
            // 
            // _bCompareSearch1
            // 
            this._bCompareSearch1.Location = new System.Drawing.Point(238, 1);
            this._bCompareSearch1.Name = "_bCompareSearch1";
            this._bCompareSearch1.Size = new System.Drawing.Size(51, 23);
            this._bCompareSearch1.TabIndex = 3;
            this._bCompareSearch1.Text = "Search";
            this._bCompareSearch1.UseVisualStyleBackColor = true;
            this._bCompareSearch1.Click += new System.EventHandler(this.CompareSearch1Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "ID or Name";
            // 
            // _tbCompareFilterSpell1
            // 
            this._tbCompareFilterSpell1.Location = new System.Drawing.Point(86, 3);
            this._tbCompareFilterSpell1.Name = "_tbCompareFilterSpell1";
            this._tbCompareFilterSpell1.Size = new System.Drawing.Size(146, 20);
            this._tbCompareFilterSpell1.TabIndex = 1;
            this._tbCompareFilterSpell1.TextChanged += new System.EventHandler(this.CompareFilterSpellTextChanged);
            // 
            // _rtbCompareSpell1
            // 
            this._rtbCompareSpell1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbCompareSpell1.BackColor = System.Drawing.Color.Gainsboro;
            this._rtbCompareSpell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._rtbCompareSpell1.Location = new System.Drawing.Point(0, 29);
            this._rtbCompareSpell1.Name = "_rtbCompareSpell1";
            this._rtbCompareSpell1.Size = new System.Drawing.Size(580, 674);
            this._rtbCompareSpell1.TabIndex = 0;
            this._rtbCompareSpell1.Text = "";
            // 
            // _bCompareSearch2
            // 
            this._bCompareSearch2.Location = new System.Drawing.Point(243, 1);
            this._bCompareSearch2.Name = "_bCompareSearch2";
            this._bCompareSearch2.Size = new System.Drawing.Size(51, 23);
            this._bCompareSearch2.TabIndex = 3;
            this._bCompareSearch2.Text = "Search";
            this._bCompareSearch2.UseVisualStyleBackColor = true;
            this._bCompareSearch2.Click += new System.EventHandler(this.CompareSearch2Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "ID or Name";
            // 
            // _rtbCompareSpell2
            // 
            this._rtbCompareSpell2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbCompareSpell2.BackColor = System.Drawing.Color.Gainsboro;
            this._rtbCompareSpell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._rtbCompareSpell2.Location = new System.Drawing.Point(3, 29);
            this._rtbCompareSpell2.Name = "_rtbCompareSpell2";
            this._rtbCompareSpell2.Size = new System.Drawing.Size(580, 674);
            this._rtbCompareSpell2.TabIndex = 0;
            this._rtbCompareSpell2.Text = "";
            // 
            // _tbCompareFilterSpell2
            // 
            this._tbCompareFilterSpell2.Location = new System.Drawing.Point(91, 3);
            this._tbCompareFilterSpell2.Name = "_tbCompareFilterSpell2";
            this._tbCompareFilterSpell2.Size = new System.Drawing.Size(146, 20);
            this._tbCompareFilterSpell2.TabIndex = 1;
            this._tbCompareFilterSpell2.TextChanged += new System.EventHandler(this.CompareFilterSpellTextChanged);
            // 
            // _tpSpellInfo
            // 
            this._tpSpellInfo.Controls.Add(this.splitContainer1);
            this._tpSpellInfo.Location = new System.Drawing.Point(4, 22);
            this._tpSpellInfo.Name = "_tpSpellInfo";
            this._tpSpellInfo.Padding = new System.Windows.Forms.Padding(3);
            this._tpSpellInfo.Size = new System.Drawing.Size(1176, 709);
            this._tpSpellInfo.TabIndex = 0;
            this._tpSpellInfo.Text = "Spell Info";
            this._tpSpellInfo.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._rtSpellInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1170, 703);
            this.splitContainer1.SplitterDistance = 772;
            this.splitContainer1.TabIndex = 0;
            // 
            // _rtSpellInfo
            // 
            this._rtSpellInfo.BackColor = System.Drawing.Color.Gainsboro;
            this._rtSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtSpellInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rtSpellInfo.Location = new System.Drawing.Point(0, 0);
            this._rtSpellInfo.Name = "_rtSpellInfo";
            this._rtSpellInfo.ReadOnly = true;
            this._rtSpellInfo.Size = new System.Drawing.Size(772, 703);
            this._rtSpellInfo.TabIndex = 0;
            this._rtSpellInfo.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._lvSpellList);
            this.groupBox1.Controls.Add(this._gSpellFilter);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 703);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // _lvSpellList
            // 
            this._lvSpellList.AllowColumnReorder = true;
            this._lvSpellList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lvSpellList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSpellID,
            this.chSpellName,
            this.chMiscID});
            this._lvSpellList.FullRowSelect = true;
            this._lvSpellList.GridLines = true;
            this._lvSpellList.HideSelection = false;
            this._lvSpellList.Location = new System.Drawing.Point(6, 351);
            this._lvSpellList.MultiSelect = false;
            this._lvSpellList.Name = "_lvSpellList";
            this._lvSpellList.Size = new System.Drawing.Size(388, 346);
            this._lvSpellList.TabIndex = 7;
            this._lvSpellList.UseCompatibleStateImageBehavior = false;
            this._lvSpellList.View = System.Windows.Forms.View.Details;
            this._lvSpellList.VirtualMode = true;
            this._lvSpellList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvSpellListRetrieveVirtualItem);
            this._lvSpellList.SelectedIndexChanged += new System.EventHandler(this.LvSpellListSelectedIndexChanged);
            // 
            // chSpellID
            // 
            this.chSpellID.Text = "ID";
            this.chSpellID.Width = 48;
            // 
            // chSpellName
            // 
            this.chSpellName.Text = "Name";
            this.chSpellName.Width = 250;
            // 
            // chMiscID
            // 
            this.chMiscID.Text = "MiscID";
            this.chMiscID.Width = 64;
            // 
            // _gSpellFilter
            // 
            this._gSpellFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gSpellFilter.BackColor = System.Drawing.Color.LightGray;
            this._gSpellFilter.Controls.Add(this._gbAdvansedSearch);
            this._gSpellFilter.Controls.Add(this._cbTarget2);
            this._gSpellFilter.Controls.Add(this._cbTarget1);
            this._gSpellFilter.Controls.Add(this._cbSpellEffect);
            this._gSpellFilter.Controls.Add(this._cbSpellAura);
            this._gSpellFilter.Controls.Add(this._cbSpellFamilyName);
            this._gSpellFilter.Location = new System.Drawing.Point(2, 81);
            this._gSpellFilter.Name = "_gSpellFilter";
            this._gSpellFilter.Size = new System.Drawing.Size(392, 264);
            this._gSpellFilter.TabIndex = 8;
            this._gSpellFilter.TabStop = false;
            this._gSpellFilter.Text = "Spell Filter";
            // 
            // _gbAdvansedSearch
            // 
            this._gbAdvansedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter2CompareType);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter1CompareType);
            this._gbAdvansedSearch.Controls.Add(this._tbAdvancedFilter2Val);
            this._gbAdvansedSearch.Controls.Add(this._tbAdvancedFilter1Val);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter2);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedFilter1);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedEffectFilter2CompareType);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedEffectFilter1CompareType);
            this._gbAdvansedSearch.Controls.Add(this._tbAdvancedEffectFilter2Val);
            this._gbAdvansedSearch.Controls.Add(this._tbAdvancedEffectFilter1Val);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedEffectFilter2);
            this._gbAdvansedSearch.Controls.Add(this._cbAdvancedEffectFilter1);
            this._gbAdvansedSearch.Location = new System.Drawing.Point(3, 135);
            this._gbAdvansedSearch.Name = "_gbAdvansedSearch";
            this._gbAdvansedSearch.Size = new System.Drawing.Size(383, 123);
            this._gbAdvansedSearch.TabIndex = 6;
            this._gbAdvansedSearch.TabStop = false;
            this._gbAdvansedSearch.Text = "Advanced Filter";
            // 
            // _cbAdvancedFilter2CompareType
            // 
            this._cbAdvancedFilter2CompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter2CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter2CompareType.DropDownWidth = 160;
            this._cbAdvancedFilter2CompareType.FormattingEnabled = true;
            this._cbAdvancedFilter2CompareType.Location = new System.Drawing.Point(210, 41);
            this._cbAdvancedFilter2CompareType.Name = "_cbAdvancedFilter2CompareType";
            this._cbAdvancedFilter2CompareType.Size = new System.Drawing.Size(76, 21);
            this._cbAdvancedFilter2CompareType.TabIndex = 3;
            // 
            // _cbAdvancedFilter1CompareType
            // 
            this._cbAdvancedFilter1CompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter1CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter1CompareType.DropDownWidth = 160;
            this._cbAdvancedFilter1CompareType.FormattingEnabled = true;
            this._cbAdvancedFilter1CompareType.Location = new System.Drawing.Point(210, 15);
            this._cbAdvancedFilter1CompareType.Name = "_cbAdvancedFilter1CompareType";
            this._cbAdvancedFilter1CompareType.Size = new System.Drawing.Size(76, 21);
            this._cbAdvancedFilter1CompareType.TabIndex = 2;
            // 
            // _tbAdvancedFilter2Val
            // 
            this._tbAdvancedFilter2Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAdvancedFilter2Val.Location = new System.Drawing.Point(292, 43);
            this._tbAdvancedFilter2Val.Name = "_tbAdvancedFilter2Val";
            this._tbAdvancedFilter2Val.Size = new System.Drawing.Size(85, 20);
            this._tbAdvancedFilter2Val.TabIndex = 1;
            this._tbAdvancedFilter2Val.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAdvansedFilterValKeyDown);
            // 
            // _tbAdvancedFilter1Val
            // 
            this._tbAdvancedFilter1Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAdvancedFilter1Val.Location = new System.Drawing.Point(292, 15);
            this._tbAdvancedFilter1Val.Name = "_tbAdvancedFilter1Val";
            this._tbAdvancedFilter1Val.Size = new System.Drawing.Size(85, 20);
            this._tbAdvancedFilter1Val.TabIndex = 1;
            this._tbAdvancedFilter1Val.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAdvansedFilterValKeyDown);
            // 
            // _cbAdvancedFilter2
            // 
            this._cbAdvancedFilter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter2.DropDownHeight = 500;
            this._cbAdvancedFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter2.FormattingEnabled = true;
            this._cbAdvancedFilter2.IntegralHeight = false;
            this._cbAdvancedFilter2.Location = new System.Drawing.Point(1, 42);
            this._cbAdvancedFilter2.Name = "_cbAdvancedFilter2";
            this._cbAdvancedFilter2.Size = new System.Drawing.Size(203, 21);
            this._cbAdvancedFilter2.TabIndex = 0;
            // 
            // _cbAdvancedFilter1
            // 
            this._cbAdvancedFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedFilter1.DropDownHeight = 500;
            this._cbAdvancedFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter1.FormattingEnabled = true;
            this._cbAdvancedFilter1.IntegralHeight = false;
            this._cbAdvancedFilter1.Location = new System.Drawing.Point(1, 15);
            this._cbAdvancedFilter1.Name = "_cbAdvancedFilter1";
            this._cbAdvancedFilter1.Size = new System.Drawing.Size(203, 21);
            this._cbAdvancedFilter1.TabIndex = 0;
            // 
            // _cbAdvancedEffectFilter2CompareType
            // 
            this._cbAdvancedEffectFilter2CompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedEffectFilter2CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedEffectFilter2CompareType.DropDownWidth = 160;
            this._cbAdvancedEffectFilter2CompareType.FormattingEnabled = true;
            this._cbAdvancedEffectFilter2CompareType.Location = new System.Drawing.Point(209, 95);
            this._cbAdvancedEffectFilter2CompareType.Name = "_cbAdvancedEffectFilter2CompareType";
            this._cbAdvancedEffectFilter2CompareType.Size = new System.Drawing.Size(76, 21);
            this._cbAdvancedEffectFilter2CompareType.TabIndex = 3;
            // 
            // _cbAdvancedEffectFilter1CompareType
            // 
            this._cbAdvancedEffectFilter1CompareType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedEffectFilter1CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedEffectFilter1CompareType.DropDownWidth = 160;
            this._cbAdvancedEffectFilter1CompareType.FormattingEnabled = true;
            this._cbAdvancedEffectFilter1CompareType.Location = new System.Drawing.Point(210, 68);
            this._cbAdvancedEffectFilter1CompareType.Name = "_cbAdvancedEffectFilter1CompareType";
            this._cbAdvancedEffectFilter1CompareType.Size = new System.Drawing.Size(76, 21);
            this._cbAdvancedEffectFilter1CompareType.TabIndex = 2;
            // 
            // _tbAdvancedEffectFilter2Val
            // 
            this._tbAdvancedEffectFilter2Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAdvancedEffectFilter2Val.Location = new System.Drawing.Point(292, 96);
            this._tbAdvancedEffectFilter2Val.Name = "_tbAdvancedEffectFilter2Val";
            this._tbAdvancedEffectFilter2Val.Size = new System.Drawing.Size(85, 20);
            this._tbAdvancedEffectFilter2Val.TabIndex = 1;
            this._tbAdvancedEffectFilter2Val.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAdvansedFilterValKeyDown);
            // 
            // _tbAdvancedEffectFilter1Val
            // 
            this._tbAdvancedEffectFilter1Val.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAdvancedEffectFilter1Val.Location = new System.Drawing.Point(292, 68);
            this._tbAdvancedEffectFilter1Val.Name = "_tbAdvancedEffectFilter1Val";
            this._tbAdvancedEffectFilter1Val.Size = new System.Drawing.Size(85, 20);
            this._tbAdvancedEffectFilter1Val.TabIndex = 1;
            this._tbAdvancedEffectFilter1Val.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAdvansedFilterValKeyDown);
            // 
            // _cbAdvancedEffectFilter2
            // 
            this._cbAdvancedEffectFilter2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedEffectFilter2.DropDownHeight = 500;
            this._cbAdvancedEffectFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedEffectFilter2.FormattingEnabled = true;
            this._cbAdvancedEffectFilter2.IntegralHeight = false;
            this._cbAdvancedEffectFilter2.Location = new System.Drawing.Point(1, 95);
            this._cbAdvancedEffectFilter2.Name = "_cbAdvancedEffectFilter2";
            this._cbAdvancedEffectFilter2.Size = new System.Drawing.Size(203, 21);
            this._cbAdvancedEffectFilter2.TabIndex = 0;
            // 
            // _cbAdvancedEffectFilter1
            // 
            this._cbAdvancedEffectFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbAdvancedEffectFilter1.DropDownHeight = 500;
            this._cbAdvancedEffectFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedEffectFilter1.FormattingEnabled = true;
            this._cbAdvancedEffectFilter1.IntegralHeight = false;
            this._cbAdvancedEffectFilter1.Location = new System.Drawing.Point(1, 68);
            this._cbAdvancedEffectFilter1.Name = "_cbAdvancedEffectFilter1";
            this._cbAdvancedEffectFilter1.Size = new System.Drawing.Size(203, 21);
            this._cbAdvancedEffectFilter1.TabIndex = 0;
            // 
            // _cbTarget2
            // 
            this._cbTarget2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbTarget2.DropDownHeight = 500;
            this._cbTarget2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbTarget2.DropDownWidth = 302;
            this._cbTarget2.FormattingEnabled = true;
            this._cbTarget2.IntegralHeight = false;
            this._cbTarget2.Location = new System.Drawing.Point(4, 111);
            this._cbTarget2.Name = "_cbTarget2";
            this._cbTarget2.Size = new System.Drawing.Size(385, 21);
            this._cbTarget2.TabIndex = 5;
            this._cbTarget2.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // _cbTarget1
            // 
            this._cbTarget1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbTarget1.DropDownHeight = 500;
            this._cbTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbTarget1.DropDownWidth = 302;
            this._cbTarget1.FormattingEnabled = true;
            this._cbTarget1.IntegralHeight = false;
            this._cbTarget1.Location = new System.Drawing.Point(4, 87);
            this._cbTarget1.Name = "_cbTarget1";
            this._cbTarget1.Size = new System.Drawing.Size(385, 21);
            this._cbTarget1.TabIndex = 5;
            this._cbTarget1.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // _cbSpellEffect
            // 
            this._cbSpellEffect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellEffect.DropDownHeight = 500;
            this._cbSpellEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellEffect.DropDownWidth = 302;
            this._cbSpellEffect.FormattingEnabled = true;
            this._cbSpellEffect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._cbSpellEffect.IntegralHeight = false;
            this._cbSpellEffect.Location = new System.Drawing.Point(4, 62);
            this._cbSpellEffect.Name = "_cbSpellEffect";
            this._cbSpellEffect.Size = new System.Drawing.Size(385, 21);
            this._cbSpellEffect.TabIndex = 4;
            this._cbSpellEffect.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // _cbSpellAura
            // 
            this._cbSpellAura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellAura.DropDownHeight = 500;
            this._cbSpellAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellAura.DropDownWidth = 302;
            this._cbSpellAura.FormattingEnabled = true;
            this._cbSpellAura.IntegralHeight = false;
            this._cbSpellAura.Location = new System.Drawing.Point(4, 38);
            this._cbSpellAura.Name = "_cbSpellAura";
            this._cbSpellAura.Size = new System.Drawing.Size(385, 21);
            this._cbSpellAura.TabIndex = 3;
            this._cbSpellAura.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // _cbSpellFamilyName
            // 
            this._cbSpellFamilyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellFamilyName.DropDownHeight = 500;
            this._cbSpellFamilyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellFamilyName.DropDownWidth = 302;
            this._cbSpellFamilyName.FormattingEnabled = true;
            this._cbSpellFamilyName.IntegralHeight = false;
            this._cbSpellFamilyName.ItemHeight = 13;
            this._cbSpellFamilyName.Location = new System.Drawing.Point(4, 14);
            this._cbSpellFamilyName.Name = "_cbSpellFamilyName";
            this._cbSpellFamilyName.Size = new System.Drawing.Size(385, 21);
            this._cbSpellFamilyName.TabIndex = 2;
            this._cbSpellFamilyName.SelectedIndexChanged += new System.EventHandler(this.CbSpellFamilyNamesSelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.Color.LightGray;
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this._bSearch);
            this.groupBox7.Controls.Add(this._tbSearchAttributes);
            this.groupBox7.Controls.Add(this._tbSearchIcon);
            this.groupBox7.Controls.Add(this._tbSearchId);
            this.groupBox7.Location = new System.Drawing.Point(0, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(394, 89);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Spell Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Attributes&&X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "IconFileDataID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID or Name:";
            // 
            // _bSearch
            // 
            this._bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bSearch.Location = new System.Drawing.Point(343, 11);
            this._bSearch.Name = "_bSearch";
            this._bSearch.Size = new System.Drawing.Size(50, 23);
            this._bSearch.TabIndex = 1;
            this._bSearch.Text = "Search";
            this._bSearch.UseVisualStyleBackColor = true;
            this._bSearch.Click += new System.EventHandler(this.BSearchClick);
            // 
            // _tbSearchAttributes
            // 
            this._tbSearchAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSearchAttributes.Location = new System.Drawing.Point(93, 57);
            this._tbSearchAttributes.Name = "_tbSearchAttributes";
            this._tbSearchAttributes.Size = new System.Drawing.Size(245, 20);
            this._tbSearchAttributes.TabIndex = 0;
            this._tbSearchAttributes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearchIdKeyDown);
            // 
            // _tbSearchIcon
            // 
            this._tbSearchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSearchIcon.Location = new System.Drawing.Point(93, 35);
            this._tbSearchIcon.Name = "_tbSearchIcon";
            this._tbSearchIcon.Size = new System.Drawing.Size(245, 20);
            this._tbSearchIcon.TabIndex = 0;
            this._tbSearchIcon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearchIdKeyDown);
            // 
            // _tbSearchId
            // 
            this._tbSearchId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSearchId.Location = new System.Drawing.Point(93, 13);
            this._tbSearchId.Name = "_tbSearchId";
            this._tbSearchId.Size = new System.Drawing.Size(245, 20);
            this._tbSearchId.TabIndex = 0;
            this._tbSearchId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearchIdKeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._tpSpellInfo);
            this.tabControl1.Controls.Add(this._tpSpellProcInfo);
            this.tabControl1.Controls.Add(this._tpSpellProcDB);
            this.tabControl1.Controls.Add(this._tpCompare);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 735);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1SelectedIndexChanged);
            // 
            // _tpSpellProcInfo
            // 
            this._tpSpellProcInfo.Controls.Add(this.splitContainer2);
            this._tpSpellProcInfo.Location = new System.Drawing.Point(4, 22);
            this._tpSpellProcInfo.Name = "_tpSpellProcInfo";
            this._tpSpellProcInfo.Size = new System.Drawing.Size(1176, 709);
            this._tpSpellProcInfo.TabIndex = 2;
            this._tpSpellProcInfo.Text = "Spell Proc";
            this._tpSpellProcInfo.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer2.Panel2.Controls.Add(this._lvProcAdditionalInfo);
            this.splitContainer2.Size = new System.Drawing.Size(1176, 709);
            this.splitContainer2.SplitterDistance = 600;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer3.Panel1.Controls.Add(this._lNewProcSpellId);
            this.splitContainer3.Panel1.Controls.Add(this._gProcAttributes);
            this.splitContainer3.Panel1.Controls.Add(this._gProcFlags);
            this.splitContainer3.Panel1.Controls.Add(this._gProcHitMask);
            this.splitContainer3.Panel1.Controls.Add(this._gSpellProcEvent);
            this.splitContainer3.Panel1.Controls.Add(this._gProcSpellSchools);
            this.splitContainer3.Panel1.Controls.Add(this._gProcSpellTypeMask);
            this.splitContainer3.Panel1.Controls.Add(this._gProcSpellPhaseMask);
            this.splitContainer3.Panel1.Controls.Add(this._lProcHeader);
            this.splitContainer3.Panel1.Controls.Add(this._tbNewProcSpellId);
            this.splitContainer3.Panel1.Controls.Add(this._bLoadProcFromDB);
            this.splitContainer3.Panel1.Controls.Add(this._bNewProcSpellId);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1176, 600);
            this.splitContainer3.SplitterDistance = 270;
            this.splitContainer3.TabIndex = 0;
            // 
            // _lNewProcSpellId
            // 
            this._lNewProcSpellId.AutoSize = true;
            this._lNewProcSpellId.Location = new System.Drawing.Point(933, 7);
            this._lNewProcSpellId.Name = "_lNewProcSpellId";
            this._lNewProcSpellId.Size = new System.Drawing.Size(44, 13);
            this._lNewProcSpellId.TabIndex = 19;
            this._lNewProcSpellId.Text = "Spell ID";
            // 
            // _gProcAttributes
            // 
            this._gProcAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._gProcAttributes.BackColor = System.Drawing.Color.WhiteSmoke;
            this._gProcAttributes.Controls.Add(this._clbProcAttributes);
            this._gProcAttributes.Location = new System.Drawing.Point(588, 95);
            this._gProcAttributes.Name = "_gProcAttributes";
            this._gProcAttributes.Size = new System.Drawing.Size(585, 76);
            this._gProcAttributes.TabIndex = 14;
            this._gProcAttributes.TabStop = false;
            this._gProcAttributes.Text = "Proc Attributes";
            // 
            // _clbProcAttributes
            // 
            this._clbProcAttributes.CheckOnClick = true;
            this._clbProcAttributes.ColumnWidth = 190;
            this._clbProcAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clbProcAttributes.FormattingEnabled = true;
            this._clbProcAttributes.Location = new System.Drawing.Point(3, 16);
            this._clbProcAttributes.MultiColumn = true;
            this._clbProcAttributes.Name = "_clbProcAttributes";
            this._clbProcAttributes.Size = new System.Drawing.Size(579, 57);
            this._clbProcAttributes.TabIndex = 0;
            this._clbProcAttributes.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // _gProcFlags
            // 
            this._gProcFlags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gProcFlags.BackColor = System.Drawing.Color.WhiteSmoke;
            this._gProcFlags.Controls.Add(this._clbProcFlags);
            this._gProcFlags.Location = new System.Drawing.Point(3, 171);
            this._gProcFlags.Name = "_gProcFlags";
            this._gProcFlags.Size = new System.Drawing.Size(1170, 99);
            this._gProcFlags.TabIndex = 10;
            this._gProcFlags.TabStop = false;
            this._gProcFlags.Text = "Spell Proc Flags";
            // 
            // _clbProcFlags
            // 
            this._clbProcFlags.CheckOnClick = true;
            this._clbProcFlags.ColumnWidth = 150;
            this._clbProcFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clbProcFlags.FormattingEnabled = true;
            this._clbProcFlags.Location = new System.Drawing.Point(3, 16);
            this._clbProcFlags.MultiColumn = true;
            this._clbProcFlags.Name = "_clbProcFlags";
            this._clbProcFlags.Size = new System.Drawing.Size(1164, 80);
            this._clbProcFlags.TabIndex = 0;
            this._clbProcFlags.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // _gProcHitMask
            // 
            this._gProcHitMask.BackColor = System.Drawing.Color.WhiteSmoke;
            this._gProcHitMask.Controls.Add(this._clbProcFlagHit);
            this._gProcHitMask.Location = new System.Drawing.Point(4, 95);
            this._gProcHitMask.Name = "_gProcHitMask";
            this._gProcHitMask.Size = new System.Drawing.Size(585, 76);
            this._gProcHitMask.TabIndex = 9;
            this._gProcHitMask.TabStop = false;
            this._gProcHitMask.Text = "Proc Hit Mask";
            // 
            // _clbProcFlagHit
            // 
            this._clbProcFlagHit.CheckOnClick = true;
            this._clbProcFlagHit.ColumnWidth = 110;
            this._clbProcFlagHit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clbProcFlagHit.FormattingEnabled = true;
            this._clbProcFlagHit.Location = new System.Drawing.Point(3, 16);
            this._clbProcFlagHit.MultiColumn = true;
            this._clbProcFlagHit.Name = "_clbProcFlagHit";
            this._clbProcFlagHit.Size = new System.Drawing.Size(579, 57);
            this._clbProcFlagHit.TabIndex = 3;
            this._clbProcFlagHit.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // _gSpellProcEvent
            // 
            this._gSpellProcEvent.BackColor = System.Drawing.Color.WhiteSmoke;
            this._gSpellProcEvent.Controls.Add(this._tbProcCharges);
            this._gSpellProcEvent.Controls.Add(this.label15);
            this._gSpellProcEvent.Controls.Add(this._cbProcFitstSpellFamily);
            this._gSpellProcEvent.Controls.Add(this.label1);
            this._gSpellProcEvent.Controls.Add(this._tbPPM);
            this._gSpellProcEvent.Controls.Add(this.label2);
            this._gSpellProcEvent.Controls.Add(this._tbChance);
            this._gSpellProcEvent.Controls.Add(this.label3);
            this._gSpellProcEvent.Controls.Add(this._tbCooldown);
            this._gSpellProcEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._gSpellProcEvent.Location = new System.Drawing.Point(4, 20);
            this._gSpellProcEvent.Name = "_gSpellProcEvent";
            this._gSpellProcEvent.Size = new System.Drawing.Size(372, 76);
            this._gSpellProcEvent.TabIndex = 8;
            this._gSpellProcEvent.TabStop = false;
            this._gSpellProcEvent.Text = "Spell Proc Event";
            // 
            // _tbProcCharges
            // 
            this._tbProcCharges.Location = new System.Drawing.Point(329, 45);
            this._tbProcCharges.Name = "_tbProcCharges";
            this._tbProcCharges.Size = new System.Drawing.Size(40, 20);
            this._tbProcCharges.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(284, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Charges";
            // 
            // _cbProcFitstSpellFamily
            // 
            this._cbProcFitstSpellFamily.DropDownHeight = 500;
            this._cbProcFitstSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcFitstSpellFamily.FormattingEnabled = true;
            this._cbProcFitstSpellFamily.IntegralHeight = false;
            this._cbProcFitstSpellFamily.Location = new System.Drawing.Point(3, 14);
            this._cbProcFitstSpellFamily.Name = "_cbProcFitstSpellFamily";
            this._cbProcFitstSpellFamily.Size = new System.Drawing.Size(366, 21);
            this._cbProcFitstSpellFamily.TabIndex = 4;
            this._cbProcFitstSpellFamily.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PPM";
            // 
            // _tbPPM
            // 
            this._tbPPM.Location = new System.Drawing.Point(35, 45);
            this._tbPPM.MaxLength = 10;
            this._tbPPM.Name = "_tbPPM";
            this._tbPPM.Size = new System.Drawing.Size(40, 20);
            this._tbPPM.TabIndex = 7;
            this._tbPPM.TextChanged += new System.EventHandler(this.TbCooldownTextChanged);
            this._tbPPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chance";
            // 
            // _tbChance
            // 
            this._tbChance.Location = new System.Drawing.Point(122, 45);
            this._tbChance.MaxLength = 3;
            this._tbChance.Name = "_tbChance";
            this._tbChance.Size = new System.Drawing.Size(30, 20);
            this._tbChance.TabIndex = 7;
            this._tbChance.TextChanged += new System.EventHandler(this.TbCooldownTextChanged);
            this._tbChance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cooldown (ms)";
            // 
            // _tbCooldown
            // 
            this._tbCooldown.Location = new System.Drawing.Point(236, 45);
            this._tbCooldown.MaxLength = 10;
            this._tbCooldown.Name = "_tbCooldown";
            this._tbCooldown.Size = new System.Drawing.Size(45, 20);
            this._tbCooldown.TabIndex = 7;
            this._tbCooldown.TextChanged += new System.EventHandler(this.TbCooldownTextChanged);
            this._tbCooldown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // _gProcSpellSchools
            // 
            this._gProcSpellSchools.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._gProcSpellSchools.BackColor = System.Drawing.Color.WhiteSmoke;
            this._gProcSpellSchools.Controls.Add(this._clbSchools);
            this._gProcSpellSchools.Location = new System.Drawing.Point(375, 20);
            this._gProcSpellSchools.Name = "_gProcSpellSchools";
            this._gProcSpellSchools.Size = new System.Drawing.Size(376, 76);
            this._gProcSpellSchools.TabIndex = 13;
            this._gProcSpellSchools.TabStop = false;
            this._gProcSpellSchools.Text = "School";
            // 
            // _clbSchools
            // 
            this._clbSchools.CheckOnClick = true;
            this._clbSchools.ColumnWidth = 120;
            this._clbSchools.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clbSchools.FormattingEnabled = true;
            this._clbSchools.Location = new System.Drawing.Point(3, 16);
            this._clbSchools.MultiColumn = true;
            this._clbSchools.Name = "_clbSchools";
            this._clbSchools.Size = new System.Drawing.Size(370, 57);
            this._clbSchools.TabIndex = 5;
            this._clbSchools.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // _gProcSpellTypeMask
            // 
            this._gProcSpellTypeMask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._gProcSpellTypeMask.BackColor = System.Drawing.Color.WhiteSmoke;
            this._gProcSpellTypeMask.Controls.Add(this._clbSpellTypeMask);
            this._gProcSpellTypeMask.Location = new System.Drawing.Point(750, 20);
            this._gProcSpellTypeMask.Name = "_gProcSpellTypeMask";
            this._gProcSpellTypeMask.Size = new System.Drawing.Size(213, 76);
            this._gProcSpellTypeMask.TabIndex = 11;
            this._gProcSpellTypeMask.TabStop = false;
            this._gProcSpellTypeMask.Text = "Proc Spell Type Mask";
            // 
            // _clbSpellTypeMask
            // 
            this._clbSpellTypeMask.CheckOnClick = true;
            this._clbSpellTypeMask.ColumnWidth = 100;
            this._clbSpellTypeMask.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clbSpellTypeMask.FormattingEnabled = true;
            this._clbSpellTypeMask.Location = new System.Drawing.Point(3, 16);
            this._clbSpellTypeMask.MultiColumn = true;
            this._clbSpellTypeMask.Name = "_clbSpellTypeMask";
            this._clbSpellTypeMask.Size = new System.Drawing.Size(207, 57);
            this._clbSpellTypeMask.TabIndex = 0;
            this._clbSpellTypeMask.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // _gProcSpellPhaseMask
            // 
            this._gProcSpellPhaseMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._gProcSpellPhaseMask.BackColor = System.Drawing.Color.WhiteSmoke;
            this._gProcSpellPhaseMask.Controls.Add(this._clbSpellPhaseMask);
            this._gProcSpellPhaseMask.Location = new System.Drawing.Point(962, 20);
            this._gProcSpellPhaseMask.Name = "_gProcSpellPhaseMask";
            this._gProcSpellPhaseMask.Size = new System.Drawing.Size(213, 76);
            this._gProcSpellPhaseMask.TabIndex = 12;
            this._gProcSpellPhaseMask.TabStop = false;
            this._gProcSpellPhaseMask.Text = "Proc Spell Phase Mask";
            // 
            // _clbSpellPhaseMask
            // 
            this._clbSpellPhaseMask.CheckOnClick = true;
            this._clbSpellPhaseMask.ColumnWidth = 100;
            this._clbSpellPhaseMask.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clbSpellPhaseMask.FormattingEnabled = true;
            this._clbSpellPhaseMask.Location = new System.Drawing.Point(3, 16);
            this._clbSpellPhaseMask.MultiColumn = true;
            this._clbSpellPhaseMask.Name = "_clbSpellPhaseMask";
            this._clbSpellPhaseMask.Size = new System.Drawing.Size(207, 57);
            this._clbSpellPhaseMask.TabIndex = 0;
            this._clbSpellPhaseMask.SelectedIndexChanged += new System.EventHandler(this.ClbSchoolsSelectedIndexChanged);
            // 
            // _lProcHeader
            // 
            this._lProcHeader.AutoSize = true;
            this._lProcHeader.Location = new System.Drawing.Point(4, 3);
            this._lProcHeader.Name = "_lProcHeader";
            this._lProcHeader.Size = new System.Drawing.Size(16, 13);
            this._lProcHeader.TabIndex = 15;
            this._lProcHeader.Text = "---";
            // 
            // _tbNewProcSpellId
            // 
            this._tbNewProcSpellId.Location = new System.Drawing.Point(980, 3);
            this._tbNewProcSpellId.Name = "_tbNewProcSpellId";
            this._tbNewProcSpellId.Size = new System.Drawing.Size(50, 20);
            this._tbNewProcSpellId.TabIndex = 18;
            this._tbNewProcSpellId.TextChanged += new System.EventHandler(this.NewProcSpellIdTextChanged);
            // 
            // _bLoadProcFromDB
            // 
            this._bLoadProcFromDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bLoadProcFromDB.Location = new System.Drawing.Point(1092, 3);
            this._bLoadProcFromDB.Name = "_bLoadProcFromDB";
            this._bLoadProcFromDB.Size = new System.Drawing.Size(80, 20);
            this._bLoadProcFromDB.TabIndex = 17;
            this._bLoadProcFromDB.Text = "Load from DB";
            this._bLoadProcFromDB.UseVisualStyleBackColor = true;
            this._bLoadProcFromDB.Click += new System.EventHandler(this.LoadProcFromDBClick);
            // 
            // _bNewProcSpellId
            // 
            this._bNewProcSpellId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bNewProcSpellId.Enabled = false;
            this._bNewProcSpellId.Location = new System.Drawing.Point(1036, 3);
            this._bNewProcSpellId.Name = "_bNewProcSpellId";
            this._bNewProcSpellId.Size = new System.Drawing.Size(50, 20);
            this._bNewProcSpellId.TabIndex = 16;
            this._bNewProcSpellId.Text = "New";
            this._bNewProcSpellId.UseVisualStyleBackColor = true;
            this._bNewProcSpellId.Click += new System.EventHandler(this.NewProcSpellIdClick);
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.Color.White;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer4.Panel1.Controls.Add(this._cbProcSpellFamilyTree);
            this.splitContainer4.Panel1.Controls.Add(this._tvFamilyTree);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(1176, 326);
            this.splitContainer4.SplitterDistance = 346;
            this.splitContainer4.TabIndex = 0;
            // 
            // _cbProcSpellFamilyTree
            // 
            this._cbProcSpellFamilyTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellFamilyTree.DropDownHeight = 500;
            this._cbProcSpellFamilyTree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellFamilyTree.FormattingEnabled = true;
            this._cbProcSpellFamilyTree.IntegralHeight = false;
            this._cbProcSpellFamilyTree.Location = new System.Drawing.Point(1, 2);
            this._cbProcSpellFamilyTree.Name = "_cbProcSpellFamilyTree";
            this._cbProcSpellFamilyTree.Size = new System.Drawing.Size(345, 21);
            this._cbProcSpellFamilyTree.TabIndex = 1;
            this._cbProcSpellFamilyTree.SelectedIndexChanged += new System.EventHandler(this.TvFamilyTreeSelectedIndexChanged);
            // 
            // _tvFamilyTree
            // 
            this._tvFamilyTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tvFamilyTree.CheckBoxes = true;
            this._tvFamilyTree.ImageIndex = 0;
            this._tvFamilyTree.ImageList = this._ilPro;
            this._tvFamilyTree.Location = new System.Drawing.Point(1, 23);
            this._tvFamilyTree.Name = "_tvFamilyTree";
            this._tvFamilyTree.SelectedImageIndex = 0;
            this._tvFamilyTree.ShowNodeToolTips = true;
            this._tvFamilyTree.Size = new System.Drawing.Size(345, 301);
            this._tvFamilyTree.TabIndex = 0;
            this._tvFamilyTree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.FamilyTreeAfterCheck);
            this._tvFamilyTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvFamilyTreeAfterSelect);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this._rtbProcSpellInfo);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer5.Panel2.Controls.Add(this._lvProcSpellList);
            this.splitContainer5.Panel2.Controls.Add(this._bProcSearch);
            this.splitContainer5.Panel2.Controls.Add(this._tbProcSeach);
            this.splitContainer5.Panel2.Controls.Add(this._cbProcTarget2);
            this.splitContainer5.Panel2.Controls.Add(this._cbProcTarget1);
            this.splitContainer5.Panel2.Controls.Add(this._cbProcSpellEffect);
            this.splitContainer5.Panel2.Controls.Add(this._cbProcSpellAura);
            this.splitContainer5.Panel2.Controls.Add(this._cbProcSpellFamilyName);
            this.splitContainer5.Size = new System.Drawing.Size(826, 326);
            this.splitContainer5.SplitterDistance = 556;
            this.splitContainer5.TabIndex = 0;
            // 
            // _rtbProcSpellInfo
            // 
            this._rtbProcSpellInfo.BackColor = System.Drawing.SystemColors.MenuBar;
            this._rtbProcSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbProcSpellInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this._rtbProcSpellInfo.Location = new System.Drawing.Point(0, 0);
            this._rtbProcSpellInfo.Name = "_rtbProcSpellInfo";
            this._rtbProcSpellInfo.Size = new System.Drawing.Size(556, 326);
            this._rtbProcSpellInfo.TabIndex = 0;
            this._rtbProcSpellInfo.Text = "";
            // 
            // _lvProcSpellList
            // 
            this._lvProcSpellList.AllowColumnReorder = true;
            this._lvProcSpellList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lvProcSpellList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._chProcID,
            this._chProcName});
            this._lvProcSpellList.FullRowSelect = true;
            this._lvProcSpellList.GridLines = true;
            this._lvProcSpellList.HideSelection = false;
            this._lvProcSpellList.Location = new System.Drawing.Point(2, 117);
            this._lvProcSpellList.MultiSelect = false;
            this._lvProcSpellList.Name = "_lvProcSpellList";
            this._lvProcSpellList.ShowItemToolTips = true;
            this._lvProcSpellList.Size = new System.Drawing.Size(261, 206);
            this._lvProcSpellList.TabIndex = 0;
            this._lvProcSpellList.UseCompatibleStateImageBehavior = false;
            this._lvProcSpellList.View = System.Windows.Forms.View.Details;
            this._lvProcSpellList.VirtualMode = true;
            this._lvProcSpellList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvProcSpellListRetrieveVirtualItem);
            this._lvProcSpellList.SelectedIndexChanged += new System.EventHandler(this.LvProcSpellListSelectedIndexChanged);
            // 
            // _chProcID
            // 
            this._chProcID.Text = "ID";
            this._chProcID.Width = 45;
            // 
            // _chProcName
            // 
            this._chProcName.Text = "Name";
            this._chProcName.Width = 210;
            // 
            // _bProcSearch
            // 
            this._bProcSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bProcSearch.Location = new System.Drawing.Point(206, 2);
            this._bProcSearch.Name = "_bProcSearch";
            this._bProcSearch.Size = new System.Drawing.Size(54, 20);
            this._bProcSearch.TabIndex = 5;
            this._bProcSearch.Text = "Search";
            this._bProcSearch.UseVisualStyleBackColor = true;
            this._bProcSearch.Click += new System.EventHandler(this.BProcSearchClick);
            // 
            // _tbProcSeach
            // 
            this._tbProcSeach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbProcSeach.Location = new System.Drawing.Point(3, 3);
            this._tbProcSeach.Name = "_tbProcSeach";
            this._tbProcSeach.Size = new System.Drawing.Size(197, 20);
            this._tbProcSeach.TabIndex = 4;
            this._tbProcSeach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbSearchKeyDown);
            // 
            // _cbProcTarget2
            // 
            this._cbProcTarget2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcTarget2.DropDownHeight = 500;
            this._cbProcTarget2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcTarget2.FormattingEnabled = true;
            this._cbProcTarget2.IntegralHeight = false;
            this._cbProcTarget2.Location = new System.Drawing.Point(144, 90);
            this._cbProcTarget2.Name = "_cbProcTarget2";
            this._cbProcTarget2.Size = new System.Drawing.Size(119, 21);
            this._cbProcTarget2.TabIndex = 3;
            this._cbProcTarget2.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _cbProcTarget1
            // 
            this._cbProcTarget1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcTarget1.DropDownHeight = 500;
            this._cbProcTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcTarget1.FormattingEnabled = true;
            this._cbProcTarget1.IntegralHeight = false;
            this._cbProcTarget1.Location = new System.Drawing.Point(3, 90);
            this._cbProcTarget1.Name = "_cbProcTarget1";
            this._cbProcTarget1.Size = new System.Drawing.Size(132, 21);
            this._cbProcTarget1.TabIndex = 3;
            this._cbProcTarget1.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _cbProcSpellEffect
            // 
            this._cbProcSpellEffect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellEffect.DropDownHeight = 500;
            this._cbProcSpellEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellEffect.FormattingEnabled = true;
            this._cbProcSpellEffect.IntegralHeight = false;
            this._cbProcSpellEffect.Location = new System.Drawing.Point(3, 68);
            this._cbProcSpellEffect.Name = "_cbProcSpellEffect";
            this._cbProcSpellEffect.Size = new System.Drawing.Size(260, 21);
            this._cbProcSpellEffect.TabIndex = 3;
            this._cbProcSpellEffect.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _cbProcSpellAura
            // 
            this._cbProcSpellAura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellAura.DropDownHeight = 500;
            this._cbProcSpellAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellAura.FormattingEnabled = true;
            this._cbProcSpellAura.IntegralHeight = false;
            this._cbProcSpellAura.Location = new System.Drawing.Point(3, 46);
            this._cbProcSpellAura.Name = "_cbProcSpellAura";
            this._cbProcSpellAura.Size = new System.Drawing.Size(260, 21);
            this._cbProcSpellAura.TabIndex = 2;
            this._cbProcSpellAura.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _cbProcSpellFamilyName
            // 
            this._cbProcSpellFamilyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcSpellFamilyName.DropDownHeight = 500;
            this._cbProcSpellFamilyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProcSpellFamilyName.FormattingEnabled = true;
            this._cbProcSpellFamilyName.IntegralHeight = false;
            this._cbProcSpellFamilyName.Location = new System.Drawing.Point(3, 24);
            this._cbProcSpellFamilyName.Name = "_cbProcSpellFamilyName";
            this._cbProcSpellFamilyName.Size = new System.Drawing.Size(260, 21);
            this._cbProcSpellFamilyName.TabIndex = 1;
            this._cbProcSpellFamilyName.SelectedIndexChanged += new System.EventHandler(this.CbProcSpellFamilyNameSelectedIndexChanged);
            // 
            // _lvProcAdditionalInfo
            // 
            this._lvProcAdditionalInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._chID,
            this._chName,
            this._chDescription});
            this._lvProcAdditionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvProcAdditionalInfo.FullRowSelect = true;
            this._lvProcAdditionalInfo.GridLines = true;
            this._lvProcAdditionalInfo.HideSelection = false;
            this._lvProcAdditionalInfo.Location = new System.Drawing.Point(0, 0);
            this._lvProcAdditionalInfo.Name = "_lvProcAdditionalInfo";
            this._lvProcAdditionalInfo.Size = new System.Drawing.Size(1176, 105);
            this._lvProcAdditionalInfo.SmallImageList = this._ilPro;
            this._lvProcAdditionalInfo.TabIndex = 0;
            this._lvProcAdditionalInfo.UseCompatibleStateImageBehavior = false;
            this._lvProcAdditionalInfo.View = System.Windows.Forms.View.Details;
            this._lvProcAdditionalInfo.SelectedIndexChanged += new System.EventHandler(this.LvProcAdditionalInfoSelectedIndexChanged);
            // 
            // _chID
            // 
            this._chID.Text = "ID";
            // 
            // _chName
            // 
            this._chName.Text = "Name";
            this._chName.Width = 200;
            // 
            // _chDescription
            // 
            this._chDescription.Text = "Description";
            this._chDescription.Width = 582;
            // 
            // _tpSpellProcDB
            // 
            this._tpSpellProcDB.Controls.Add(this.groupBox3);
            this._tpSpellProcDB.Controls.Add(this.groupBox2);
            this._tpSpellProcDB.Location = new System.Drawing.Point(4, 22);
            this._tpSpellProcDB.Name = "_tpSpellProcDB";
            this._tpSpellProcDB.Size = new System.Drawing.Size(1176, 709);
            this._tpSpellProcDB.TabIndex = 3;
            this._tpSpellProcDB.Text = "Load Spell Proc from DB";
            this._tpSpellProcDB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this._cbBinaryCompare);
            this.groupBox3.Controls.Add(this._lProcSqlCustomQueryFragment);
            this.groupBox3.Controls.Add(this._tbSqlManual);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this._bSqlProcFlagsHit);
            this.groupBox3.Controls.Add(this._bSqlProc);
            this.groupBox3.Controls.Add(this._bSqlSchool);
            this.groupBox3.Controls.Add(this._tbSqlProcFlagsHit);
            this.groupBox3.Controls.Add(this._tbSqlProc);
            this.groupBox3.Controls.Add(this._tbSqlSchool);
            this.groupBox3.Controls.Add(this._tbLoadProcSpellId);
            this.groupBox3.Controls.Add(this._cbSqlSpellFamily);
            this.groupBox3.Controls.Add(this._bSelect);
            this.groupBox3.Location = new System.Drawing.Point(6, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1167, 85);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // _cbBinaryCompare
            // 
            this._cbBinaryCompare.AutoSize = true;
            this._cbBinaryCompare.Location = new System.Drawing.Point(752, 55);
            this._cbBinaryCompare.Name = "_cbBinaryCompare";
            this._cbBinaryCompare.Size = new System.Drawing.Size(100, 17);
            this._cbBinaryCompare.TabIndex = 8;
            this._cbBinaryCompare.Text = "Binary Compare";
            this._cbBinaryCompare.UseVisualStyleBackColor = true;
            // 
            // _lProcSqlCustomQueryFragment
            // 
            this._lProcSqlCustomQueryFragment.AutoSize = true;
            this._lProcSqlCustomQueryFragment.Location = new System.Drawing.Point(6, 51);
            this._lProcSqlCustomQueryFragment.MaximumSize = new System.Drawing.Size(80, 0);
            this._lProcSqlCustomQueryFragment.Name = "_lProcSqlCustomQueryFragment";
            this._lProcSqlCustomQueryFragment.Size = new System.Drawing.Size(74, 26);
            this._lProcSqlCustomQueryFragment.TabIndex = 7;
            this._lProcSqlCustomQueryFragment.Text = "Custom query fragment:";
            // 
            // _tbSqlManual
            // 
            this._tbSqlManual.Location = new System.Drawing.Point(81, 53);
            this._tbSqlManual.Name = "_tbSqlManual";
            this._tbSqlManual.Size = new System.Drawing.Size(272, 20);
            this._tbSqlManual.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Family Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Proc Ex:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Proc:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "School:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Spell ID:";
            // 
            // _bSqlProcFlagsHit
            // 
            this._bSqlProcFlagsHit.Location = new System.Drawing.Point(718, 51);
            this._bSqlProcFlagsHit.Name = "_bSqlProcFlagsHit";
            this._bSqlProcFlagsHit.Size = new System.Drawing.Size(28, 23);
            this._bSqlProcFlagsHit.TabIndex = 4;
            this._bSqlProcFlagsHit.Text = "...";
            this._bSqlProcFlagsHit.UseVisualStyleBackColor = true;
            this._bSqlProcFlagsHit.Click += new System.EventHandler(this.CalcProcFlagsClick);
            // 
            // _bSqlProc
            // 
            this._bSqlProc.Location = new System.Drawing.Point(535, 51);
            this._bSqlProc.Name = "_bSqlProc";
            this._bSqlProc.Size = new System.Drawing.Size(28, 23);
            this._bSqlProc.TabIndex = 4;
            this._bSqlProc.Text = "...";
            this._bSqlProc.UseVisualStyleBackColor = true;
            this._bSqlProc.Click += new System.EventHandler(this.CalcProcFlagsClick);
            // 
            // _bSqlSchool
            // 
            this._bSqlSchool.Location = new System.Drawing.Point(718, 16);
            this._bSqlSchool.Name = "_bSqlSchool";
            this._bSqlSchool.Size = new System.Drawing.Size(28, 21);
            this._bSqlSchool.TabIndex = 4;
            this._bSqlSchool.Text = "...";
            this._bSqlSchool.UseVisualStyleBackColor = true;
            this._bSqlSchool.Click += new System.EventHandler(this.CalcProcFlagsClick);
            // 
            // _tbSqlProcFlagsHit
            // 
            this._tbSqlProcFlagsHit.Location = new System.Drawing.Point(620, 53);
            this._tbSqlProcFlagsHit.Name = "_tbSqlProcFlagsHit";
            this._tbSqlProcFlagsHit.Size = new System.Drawing.Size(92, 20);
            this._tbSqlProcFlagsHit.TabIndex = 3;
            // 
            // _tbSqlProc
            // 
            this._tbSqlProc.Location = new System.Drawing.Point(429, 53);
            this._tbSqlProc.Name = "_tbSqlProc";
            this._tbSqlProc.Size = new System.Drawing.Size(100, 20);
            this._tbSqlProc.TabIndex = 3;
            // 
            // _tbSqlSchool
            // 
            this._tbSqlSchool.Location = new System.Drawing.Point(620, 17);
            this._tbSqlSchool.Name = "_tbSqlSchool";
            this._tbSqlSchool.Size = new System.Drawing.Size(92, 20);
            this._tbSqlSchool.TabIndex = 3;
            // 
            // _tbLoadProcSpellId
            // 
            this._tbLoadProcSpellId.Location = new System.Drawing.Point(429, 17);
            this._tbLoadProcSpellId.Name = "_tbLoadProcSpellId";
            this._tbLoadProcSpellId.Size = new System.Drawing.Size(100, 20);
            this._tbLoadProcSpellId.TabIndex = 2;
            // 
            // _cbSqlSpellFamily
            // 
            this._cbSqlSpellFamily.DropDownHeight = 500;
            this._cbSqlSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSqlSpellFamily.FormattingEnabled = true;
            this._cbSqlSpellFamily.IntegralHeight = false;
            this._cbSqlSpellFamily.Location = new System.Drawing.Point(81, 16);
            this._cbSqlSpellFamily.Name = "_cbSqlSpellFamily";
            this._cbSqlSpellFamily.Size = new System.Drawing.Size(272, 21);
            this._cbSqlSpellFamily.TabIndex = 1;
            // 
            // _bSelect
            // 
            this._bSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bSelect.Location = new System.Drawing.Point(1087, 10);
            this._bSelect.Name = "_bSelect";
            this._bSelect.Size = new System.Drawing.Size(75, 21);
            this._bSelect.TabIndex = 0;
            this._bSelect.Text = "Select";
            this._bSelect.UseVisualStyleBackColor = true;
            this._bSelect.Click += new System.EventHandler(this.SelectClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.splitContainer6);
            this.groupBox2.Location = new System.Drawing.Point(0, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1176, 615);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 16);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this._lvDataList);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer6.Panel2.Controls.Add(this._rtbSqlLog);
            this.splitContainer6.Panel2.Controls.Add(this._bSqlToBase);
            this.splitContainer6.Panel2.Controls.Add(this._bSqlSave);
            this.splitContainer6.Size = new System.Drawing.Size(1170, 596);
            this.splitContainer6.SplitterDistance = 307;
            this.splitContainer6.TabIndex = 0;
            // 
            // _lvDataList
            // 
            this._lvDataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.spellId,
            this.spellname,
            this.schoolmask,
            this.spellfamilyname,
            this.spellfamilymask0,
            this.spellfamilymask1,
            this.spellfamilymask2,
            this.spellfamilymask3,
            this.procflag,
            this.procFlags2,
            this.procSpellTypeMask,
            this.procSpellPhaseMask,
            this.procHitMask,
            this.procAttributesMask,
            this.procDisableEffectsMask,
            this.ppmRate,
            this.customchance,
            this.cooldown,
            this.procCharges});
            this._lvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvDataList.FullRowSelect = true;
            this._lvDataList.GridLines = true;
            this._lvDataList.HideSelection = false;
            this._lvDataList.Location = new System.Drawing.Point(0, 0);
            this._lvDataList.MultiSelect = false;
            this._lvDataList.Name = "_lvDataList";
            this._lvDataList.Size = new System.Drawing.Size(1170, 307);
            this._lvDataList.TabIndex = 0;
            this._lvDataList.UseCompatibleStateImageBehavior = false;
            this._lvDataList.View = System.Windows.Forms.View.Details;
            this._lvDataList.VirtualMode = true;
            this._lvDataList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LvSqlDataRetrieveVirtualItem);
            this._lvDataList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SqlDataListKeyDown);
            this._lvDataList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SqlDataListMouseDoubleClick);
            // 
            // spellId
            // 
            this.spellId.Text = "Spell ID";
            this.spellId.Width = 56;
            // 
            // spellname
            // 
            this.spellname.Text = "Spell Name";
            this.spellname.Width = 300;
            // 
            // schoolmask
            // 
            this.schoolmask.Text = "School Mask";
            this.schoolmask.Width = 78;
            // 
            // spellfamilyname
            // 
            this.spellfamilyname.Text = "Spell Family";
            this.spellfamilyname.Width = 90;
            // 
            // spellfamilymask0
            // 
            this.spellfamilymask0.Text = "Family Mask 0";
            this.spellfamilymask0.Width = 80;
            // 
            // spellfamilymask1
            // 
            this.spellfamilymask1.Text = "Family Mask 1";
            this.spellfamilymask1.Width = 80;
            // 
            // spellfamilymask2
            // 
            this.spellfamilymask2.Text = "Family Mask 2";
            this.spellfamilymask2.Width = 80;
            // 
            // spellfamilymask3
            // 
            this.spellfamilymask3.Text = "Family Mask 3";
            this.spellfamilymask3.Width = 80;
            // 
            // procflag
            // 
            this.procflag.Text = "Proc Flags";
            this.procflag.Width = 80;
            // 
            // procFlags2
            // 
            this.procFlags2.Text = "Proc Flags 2";
            this.procFlags2.Width = 80;
            // 
            // procSpellTypeMask
            // 
            this.procSpellTypeMask.Text = "Type Mask";
            this.procSpellTypeMask.Width = 80;
            // 
            // procSpellPhaseMask
            // 
            this.procSpellPhaseMask.Text = "Phase";
            this.procSpellPhaseMask.Width = 50;
            // 
            // procHitMask
            // 
            this.procHitMask.Text = "Hit Mask";
            // 
            // procAttributesMask
            // 
            this.procAttributesMask.Text = "Attributes";
            this.procAttributesMask.Width = 140;
            // 
            // procDisableEffectsMask
            // 
            this.procDisableEffectsMask.Text = "Disabled Effects";
            this.procDisableEffectsMask.Width = 80;
            // 
            // ppmRate
            // 
            this.ppmRate.Text = "PPM Rate";
            this.ppmRate.Width = 65;
            // 
            // customchance
            // 
            this.customchance.Text = "Chance";
            this.customchance.Width = 55;
            // 
            // cooldown
            // 
            this.cooldown.Text = "Cooldown";
            // 
            // procCharges
            // 
            this.procCharges.Text = "Charges";
            this.procCharges.Width = 55;
            // 
            // _rtbSqlLog
            // 
            this._rtbSqlLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbSqlLog.Location = new System.Drawing.Point(0, 32);
            this._rtbSqlLog.Name = "_rtbSqlLog";
            this._rtbSqlLog.Size = new System.Drawing.Size(1170, 256);
            this._rtbSqlLog.TabIndex = 3;
            this._rtbSqlLog.Text = "";
            // 
            // _bSqlToBase
            // 
            this._bSqlToBase.Location = new System.Drawing.Point(84, 3);
            this._bSqlToBase.Name = "_bSqlToBase";
            this._bSqlToBase.Size = new System.Drawing.Size(75, 23);
            this._bSqlToBase.TabIndex = 2;
            this._bSqlToBase.Text = "To DB";
            this._bSqlToBase.UseVisualStyleBackColor = true;
            this._bSqlToBase.Click += new System.EventHandler(this.SqlToBaseClick);
            // 
            // _bSqlSave
            // 
            this._bSqlSave.Location = new System.Drawing.Point(3, 3);
            this._bSqlSave.Name = "_bSqlSave";
            this._bSqlSave.Size = new System.Drawing.Size(75, 23);
            this._bSqlSave.TabIndex = 1;
            this._bSqlSave.Text = "Save";
            this._bSqlSave.UseVisualStyleBackColor = true;
            this._bSqlSave.Click += new System.EventHandler(this.SqlSaveClick);
            // 
            // _cbProcFlag
            // 
            this._cbProcFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbProcFlag.Appearance = System.Windows.Forms.Appearance.Button;
            this._cbProcFlag.AutoSize = true;
            this._cbProcFlag.Location = new System.Drawing.Point(1055, 1);
            this._cbProcFlag.Name = "_cbProcFlag";
            this._cbProcFlag.Size = new System.Drawing.Size(59, 23);
            this._cbProcFlag.TabIndex = 2;
            this._cbProcFlag.Text = "ProcFlag";
            this._cbProcFlag.UseVisualStyleBackColor = true;
            this._cbProcFlag.Visible = false;
            this._cbProcFlag.CheckedChanged += new System.EventHandler(this.CbProcFlagCheckedChanged);
            // 
            // _bWrite
            // 
            this._bWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bWrite.Location = new System.Drawing.Point(998, 1);
            this._bWrite.Name = "_bWrite";
            this._bWrite.Size = new System.Drawing.Size(51, 23);
            this._bWrite.TabIndex = 3;
            this._bWrite.Text = "Write";
            this._bWrite.UseVisualStyleBackColor = true;
            this._bWrite.Visible = false;
            this._bWrite.Click += new System.EventHandler(this.WriteClick);
            // 
            // _bLevelScaling
            // 
            this._bLevelScaling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._bLevelScaling.Location = new System.Drawing.Point(1120, 1);
            this._bLevelScaling.Name = "_bLevelScaling";
            this._bLevelScaling.Size = new System.Drawing.Size(60, 23);
            this._bLevelScaling.TabIndex = 4;
            this._bLevelScaling.Text = "Scaling";
            this._bLevelScaling.UseVisualStyleBackColor = true;
            this._bLevelScaling.Click += new System.EventHandler(this.LevelScalingClick);
            // 
            // loadingProgressBar1
            // 
            this.loadingProgressBar1.Location = new System.Drawing.Point(1076, 758);
            this.loadingProgressBar1.Name = "loadingProgressBar1";
            this.loadingProgressBar1.Size = new System.Drawing.Size(100, 23);
            this.loadingProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadingProgressBar1.TabIndex = 5;
            // 
            // loadingProgressLabel1
            // 
            this.loadingProgressLabel1.AutoSize = true;
            this.loadingProgressLabel1.Location = new System.Drawing.Point(986, 762);
            this.loadingProgressLabel1.Name = "loadingProgressLabel1";
            this.loadingProgressLabel1.Size = new System.Drawing.Size(88, 13);
            this.loadingProgressLabel1.TabIndex = 6;
            this.loadingProgressLabel1.Text = "Loading progress";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 781);
            this.Controls.Add(this.loadingProgressLabel1);
            this.Controls.Add(this.loadingProgressBar1);
            this.Controls.Add(this._bLevelScaling);
            this.Controls.Add(this._bWrite);
            this.Controls.Add(this._cbProcFlag);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1200, 585);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Resize += new System.EventHandler(this.FormMainResize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this._tpCompare.ResumeLayout(false);
            this._scCompareRoot.Panel1.ResumeLayout(false);
            this._scCompareRoot.Panel1.PerformLayout();
            this._scCompareRoot.Panel2.ResumeLayout(false);
            this._scCompareRoot.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scCompareRoot)).EndInit();
            this._scCompareRoot.ResumeLayout(false);
            this._tpSpellInfo.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this._gSpellFilter.ResumeLayout(false);
            this._gbAdvansedSearch.ResumeLayout(false);
            this._gbAdvansedSearch.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this._tpSpellProcInfo.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this._gProcAttributes.ResumeLayout(false);
            this._gProcFlags.ResumeLayout(false);
            this._gProcHitMask.ResumeLayout(false);
            this._gSpellProcEvent.ResumeLayout(false);
            this._gSpellProcEvent.PerformLayout();
            this._gProcSpellSchools.ResumeLayout(false);
            this._gProcSpellTypeMask.ResumeLayout(false);
            this._gProcSpellPhaseMask.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this._tpSpellProcDB.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _status;
        private System.Windows.Forms.ToolStripStatusLabel _ProcStatus;
        private System.Windows.Forms.ToolStripStatusLabel _dbConnect;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ImageList _ilPro;
        private System.Windows.Forms.TabPage _tpCompare;
        private System.Windows.Forms.SplitContainer _scCompareRoot;
        private System.Windows.Forms.Button _bCompareSearch1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox _tbCompareFilterSpell1;
        private System.Windows.Forms.RichTextBox _rtbCompareSpell1;
        private System.Windows.Forms.Button _bCompareSearch2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox _rtbCompareSpell2;
        private System.Windows.Forms.TextBox _tbCompareFilterSpell2;
        private System.Windows.Forms.TabPage _tpSpellInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox _rtSpellInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView _lvSpellList;
        private System.Windows.Forms.ColumnHeader chSpellID;
        private System.Windows.Forms.ColumnHeader chSpellName;
        private System.Windows.Forms.ColumnHeader chMiscID;
        private System.Windows.Forms.GroupBox _gSpellFilter;
        private System.Windows.Forms.GroupBox _gbAdvansedSearch;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter2CompareType;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter1CompareType;
        private System.Windows.Forms.TextBox _tbAdvancedFilter2Val;
        private System.Windows.Forms.TextBox _tbAdvancedFilter1Val;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter2;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter1;
        private System.Windows.Forms.ComboBox _cbAdvancedEffectFilter2CompareType;
        private System.Windows.Forms.ComboBox _cbAdvancedEffectFilter1CompareType;
        private System.Windows.Forms.ComboBox _cbAdvancedEffectFilter2;
        private System.Windows.Forms.ComboBox _cbAdvancedEffectFilter1;
        private System.Windows.Forms.TextBox _tbAdvancedEffectFilter1Val;
        private System.Windows.Forms.TextBox _tbAdvancedEffectFilter2Val;
        private System.Windows.Forms.ComboBox _cbTarget2;
        private System.Windows.Forms.ComboBox _cbTarget1;
        private System.Windows.Forms.ComboBox _cbSpellEffect;
        private System.Windows.Forms.ComboBox _cbSpellAura;
        private System.Windows.Forms.ComboBox _cbSpellFamilyName;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _bSearch;
        private System.Windows.Forms.TextBox _tbSearchAttributes;
        private System.Windows.Forms.TextBox _tbSearchIcon;
        private System.Windows.Forms.TextBox _tbSearchId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage _tpSpellProcInfo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage _tpSpellProcDB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView _lvProcAdditionalInfo;
        private System.Windows.Forms.ColumnHeader _chID;
        private System.Windows.Forms.ColumnHeader _chName;
        private System.Windows.Forms.ColumnHeader _chDescription;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ComboBox _cbProcSpellFamilyName;
        private System.Windows.Forms.ComboBox _cbProcSpellAura;
        private System.Windows.Forms.ComboBox _cbProcSpellEffect;
        private System.Windows.Forms.ComboBox _cbProcTarget1;
        private System.Windows.Forms.ComboBox _cbProcTarget2;
        private System.Windows.Forms.TextBox _tbProcSeach;
        private System.Windows.Forms.Button _bProcSearch;
        private System.Windows.Forms.ListView _lvProcSpellList;
        private System.Windows.Forms.ColumnHeader _chProcID;
        private System.Windows.Forms.ColumnHeader _chProcName;
        private System.Windows.Forms.TreeView _tvFamilyTree;
        private System.Windows.Forms.ComboBox _cbProcSpellFamilyTree;
        private System.Windows.Forms.GroupBox _gSpellProcEvent;
        private System.Windows.Forms.TextBox _tbCooldown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbChance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbPPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbProcFitstSpellFamily;
        private System.Windows.Forms.CheckedListBox _clbSchools;
        private System.Windows.Forms.GroupBox _gProcHitMask;
        private System.Windows.Forms.CheckedListBox _clbProcFlagHit;
        private System.Windows.Forms.GroupBox _gProcFlags;
        private System.Windows.Forms.CheckedListBox _clbProcFlags;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button _bSqlSave;
        private System.Windows.Forms.Button _bSqlToBase;
        private System.Windows.Forms.RichTextBox _rtbSqlLog;
        private System.Windows.Forms.ListView _lvDataList;
        private System.Windows.Forms.ColumnHeader spellId;
        private System.Windows.Forms.ColumnHeader spellname;
        private System.Windows.Forms.ColumnHeader schoolmask;
        private System.Windows.Forms.ColumnHeader spellfamilyname;
        private System.Windows.Forms.ColumnHeader spellfamilymask0;
        private System.Windows.Forms.ColumnHeader spellfamilymask1;
        private System.Windows.Forms.ColumnHeader spellfamilymask2;
        private System.Windows.Forms.ColumnHeader spellfamilymask3;
        private System.Windows.Forms.ColumnHeader procflag;
        private System.Windows.Forms.ColumnHeader procFlags2;
        private System.Windows.Forms.ColumnHeader procSpellTypeMask;
        private System.Windows.Forms.ColumnHeader procSpellPhaseMask;
        private System.Windows.Forms.ColumnHeader procHitMask;
        private System.Windows.Forms.ColumnHeader procAttributesMask;
        private System.Windows.Forms.ColumnHeader procDisableEffectsMask;
        private System.Windows.Forms.ColumnHeader ppmRate;
        private System.Windows.Forms.ColumnHeader customchance;
        private System.Windows.Forms.ColumnHeader cooldown;
        private System.Windows.Forms.ColumnHeader procCharges;
        private System.Windows.Forms.Button _bSelect;
        private System.Windows.Forms.ComboBox _cbSqlSpellFamily;
        private System.Windows.Forms.TextBox _tbLoadProcSpellId;
        private System.Windows.Forms.TextBox _tbSqlSchool;
        private System.Windows.Forms.TextBox _tbSqlProc;
        private System.Windows.Forms.TextBox _tbSqlProcFlagsHit;
        private System.Windows.Forms.Button _bSqlSchool;
        private System.Windows.Forms.Button _bSqlProc;
        private System.Windows.Forms.Button _bSqlProcFlagsHit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _tbSqlManual;
        private System.Windows.Forms.Label _lProcSqlCustomQueryFragment;
        private System.Windows.Forms.CheckBox _cbBinaryCompare;
        private System.Windows.Forms.CheckBox _cbProcFlag;
        private System.Windows.Forms.Button _bWrite;
        private System.Windows.Forms.ToolStripMenuItem _tsmFile;
        private System.Windows.Forms.ToolStripMenuItem _tsmSettings;
        private System.Windows.Forms.ToolStripMenuItem _tsmExit;
        private System.Windows.Forms.Button _bLevelScaling;
        private System.Windows.Forms.RichTextBox _rtbProcSpellInfo;
        private System.Windows.Forms.GroupBox _gProcSpellTypeMask;
        private System.Windows.Forms.GroupBox _gProcSpellPhaseMask;
        private System.Windows.Forms.CheckedListBox _clbSpellTypeMask;
        private System.Windows.Forms.CheckedListBox _clbSpellPhaseMask;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox _tbProcCharges;
        private System.Windows.Forms.GroupBox _gProcSpellSchools;
        private System.Windows.Forms.GroupBox _gProcAttributes;
        private System.Windows.Forms.CheckedListBox _clbProcAttributes;
        private System.Windows.Forms.TextBox _tbNewProcSpellId;
        private System.Windows.Forms.Button _bLoadProcFromDB;
        private System.Windows.Forms.Button _bNewProcSpellId;
        private System.Windows.Forms.Label _lProcHeader;
        private System.Windows.Forms.Label _lNewProcSpellId;
        private System.Windows.Forms.ProgressBar loadingProgressBar1;
        private System.Windows.Forms.Label loadingProgressLabel1;
    }
}