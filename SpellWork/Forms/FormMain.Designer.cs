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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            _dbConnect = new System.Windows.Forms.ToolStripStatusLabel();
            _status = new System.Windows.Forms.ToolStripStatusLabel();
            _ProcStatus = new System.Windows.Forms.ToolStripStatusLabel();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            _tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            _tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            _tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            _ilPro = new System.Windows.Forms.ImageList(components);
            splitContainer7 = new System.Windows.Forms.SplitContainer();
            splitContainer8 = new System.Windows.Forms.SplitContainer();
            textBox2 = new System.Windows.Forms.TextBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            _tpCompare = new System.Windows.Forms.TabPage();
            _scCompareRoot = new System.Windows.Forms.SplitContainer();
            _bCompareSearch1 = new System.Windows.Forms.Button();
            label13 = new System.Windows.Forms.Label();
            _tbCompareFilterSpell1 = new System.Windows.Forms.TextBox();
            _rtbCompareSpell1 = new System.Windows.Forms.RichTextBox();
            _bCompareSearch2 = new System.Windows.Forms.Button();
            label14 = new System.Windows.Forms.Label();
            _rtbCompareSpell2 = new System.Windows.Forms.RichTextBox();
            _tbCompareFilterSpell2 = new System.Windows.Forms.TextBox();
            _tpSpellInfo = new System.Windows.Forms.TabPage();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            _rtSpellInfo = new System.Windows.Forms.RichTextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            _lvSpellList = new System.Windows.Forms.ListView();
            chSpellID = new System.Windows.Forms.ColumnHeader();
            chSpellName = new System.Windows.Forms.ColumnHeader();
            chMiscID = new System.Windows.Forms.ColumnHeader();
            _gSpellFilter = new System.Windows.Forms.GroupBox();
            _gbAdvansedSearch = new System.Windows.Forms.GroupBox();
            _cbAdvancedFilter2CompareType = new System.Windows.Forms.ComboBox();
            _cbAdvancedFilter1CompareType = new System.Windows.Forms.ComboBox();
            _tbAdvancedFilter2Val = new System.Windows.Forms.TextBox();
            _tbAdvancedFilter1Val = new System.Windows.Forms.TextBox();
            _cbAdvancedFilter2 = new System.Windows.Forms.ComboBox();
            _cbAdvancedFilter1 = new System.Windows.Forms.ComboBox();
            _cbAdvancedEffectFilter2CompareType = new System.Windows.Forms.ComboBox();
            _cbAdvancedEffectFilter1CompareType = new System.Windows.Forms.ComboBox();
            _tbAdvancedEffectFilter2Val = new System.Windows.Forms.TextBox();
            _tbAdvancedEffectFilter1Val = new System.Windows.Forms.TextBox();
            _cbAdvancedEffectFilter2 = new System.Windows.Forms.ComboBox();
            _cbAdvancedEffectFilter1 = new System.Windows.Forms.ComboBox();
            _cbTarget2 = new System.Windows.Forms.ComboBox();
            _cbTarget1 = new System.Windows.Forms.ComboBox();
            _cbSpellEffect = new System.Windows.Forms.ComboBox();
            _cbSpellAura = new System.Windows.Forms.ComboBox();
            _cbSpellFamilyName = new System.Windows.Forms.ComboBox();
            groupBox7 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            _bSearch = new System.Windows.Forms.Button();
            _tbSearchAttributes = new System.Windows.Forms.TextBox();
            _tbSearchIcon = new System.Windows.Forms.TextBox();
            _tbSearchId = new System.Windows.Forms.TextBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            _tpSpellProcInfo = new System.Windows.Forms.TabPage();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            _lNewProcSpellId = new System.Windows.Forms.Label();
            _gProcAttributes = new System.Windows.Forms.GroupBox();
            _clbProcAttributes = new System.Windows.Forms.CheckedListBox();
            _gProcFlags = new System.Windows.Forms.GroupBox();
            _clbProcFlags = new System.Windows.Forms.CheckedListBox();
            _gProcHitMask = new System.Windows.Forms.GroupBox();
            _clbProcFlagHit = new System.Windows.Forms.CheckedListBox();
            _gSpellProcEvent = new System.Windows.Forms.GroupBox();
            _tbProcCharges = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            _cbProcFitstSpellFamily = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            _tbPPM = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            _tbChance = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            _tbCooldown = new System.Windows.Forms.TextBox();
            _gProcSpellSchools = new System.Windows.Forms.GroupBox();
            _clbSchools = new System.Windows.Forms.CheckedListBox();
            _gProcSpellTypeMask = new System.Windows.Forms.GroupBox();
            _clbSpellTypeMask = new System.Windows.Forms.CheckedListBox();
            _gProcSpellPhaseMask = new System.Windows.Forms.GroupBox();
            _clbSpellPhaseMask = new System.Windows.Forms.CheckedListBox();
            _lProcHeader = new System.Windows.Forms.Label();
            _tbNewProcSpellId = new System.Windows.Forms.TextBox();
            _bLoadProcFromDB = new System.Windows.Forms.Button();
            _bNewProcSpellId = new System.Windows.Forms.Button();
            splitContainer4 = new System.Windows.Forms.SplitContainer();
            _cbProcSpellFamilyTree = new System.Windows.Forms.ComboBox();
            _tvFamilyTree = new System.Windows.Forms.TreeView();
            splitContainer5 = new System.Windows.Forms.SplitContainer();
            _rtbProcSpellInfo = new System.Windows.Forms.RichTextBox();
            _lvProcSpellList = new System.Windows.Forms.ListView();
            _chProcID = new System.Windows.Forms.ColumnHeader();
            _chProcName = new System.Windows.Forms.ColumnHeader();
            _bProcSearch = new System.Windows.Forms.Button();
            _tbProcSeach = new System.Windows.Forms.TextBox();
            _cbProcTarget2 = new System.Windows.Forms.ComboBox();
            _cbProcTarget1 = new System.Windows.Forms.ComboBox();
            _cbProcSpellEffect = new System.Windows.Forms.ComboBox();
            _cbProcSpellAura = new System.Windows.Forms.ComboBox();
            _cbProcSpellFamilyName = new System.Windows.Forms.ComboBox();
            _lvProcAdditionalInfo = new System.Windows.Forms.ListView();
            _chID = new System.Windows.Forms.ColumnHeader();
            _chName = new System.Windows.Forms.ColumnHeader();
            _chDescription = new System.Windows.Forms.ColumnHeader();
            _tpSpellProcDB = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            _cbBinaryCompare = new System.Windows.Forms.CheckBox();
            _lProcSqlCustomQueryFragment = new System.Windows.Forms.Label();
            _tbSqlManual = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            _bSqlProcFlagsHit = new System.Windows.Forms.Button();
            _bSqlProc = new System.Windows.Forms.Button();
            _bSqlSchool = new System.Windows.Forms.Button();
            _tbSqlProcFlagsHit = new System.Windows.Forms.TextBox();
            _tbSqlProc = new System.Windows.Forms.TextBox();
            _tbSqlSchool = new System.Windows.Forms.TextBox();
            _tbLoadProcSpellId = new System.Windows.Forms.TextBox();
            _cbSqlSpellFamily = new System.Windows.Forms.ComboBox();
            _bSelect = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            splitContainer6 = new System.Windows.Forms.SplitContainer();
            _lvDataList = new System.Windows.Forms.ListView();
            spellId = new System.Windows.Forms.ColumnHeader();
            spellname = new System.Windows.Forms.ColumnHeader();
            schoolmask = new System.Windows.Forms.ColumnHeader();
            spellfamilyname = new System.Windows.Forms.ColumnHeader();
            spellfamilymask0 = new System.Windows.Forms.ColumnHeader();
            spellfamilymask1 = new System.Windows.Forms.ColumnHeader();
            spellfamilymask2 = new System.Windows.Forms.ColumnHeader();
            spellfamilymask3 = new System.Windows.Forms.ColumnHeader();
            procflag = new System.Windows.Forms.ColumnHeader();
            procFlags2 = new System.Windows.Forms.ColumnHeader();
            procSpellTypeMask = new System.Windows.Forms.ColumnHeader();
            procSpellPhaseMask = new System.Windows.Forms.ColumnHeader();
            procHitMask = new System.Windows.Forms.ColumnHeader();
            procAttributesMask = new System.Windows.Forms.ColumnHeader();
            procDisableEffectsMask = new System.Windows.Forms.ColumnHeader();
            ppmRate = new System.Windows.Forms.ColumnHeader();
            customchance = new System.Windows.Forms.ColumnHeader();
            cooldown = new System.Windows.Forms.ColumnHeader();
            procCharges = new System.Windows.Forms.ColumnHeader();
            _rtbSqlLog = new System.Windows.Forms.RichTextBox();
            _bSqlToBase = new System.Windows.Forms.Button();
            _bSqlSave = new System.Windows.Forms.Button();
            _cbProcFlag = new System.Windows.Forms.CheckBox();
            _bWrite = new System.Windows.Forms.Button();
            _bLevelScaling = new System.Windows.Forms.Button();
            loadingProgressBar1 = new System.Windows.Forms.ProgressBar();
            loadingProgressLabel1 = new System.Windows.Forms.Label();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer8).BeginInit();
            splitContainer8.Panel1.SuspendLayout();
            splitContainer8.SuspendLayout();
            _tpCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_scCompareRoot).BeginInit();
            _scCompareRoot.Panel1.SuspendLayout();
            _scCompareRoot.Panel2.SuspendLayout();
            _scCompareRoot.SuspendLayout();
            _tpSpellInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            _gSpellFilter.SuspendLayout();
            _gbAdvansedSearch.SuspendLayout();
            groupBox7.SuspendLayout();
            tabControl1.SuspendLayout();
            _tpSpellProcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            _gProcAttributes.SuspendLayout();
            _gProcFlags.SuspendLayout();
            _gProcHitMask.SuspendLayout();
            _gSpellProcEvent.SuspendLayout();
            _gProcSpellSchools.SuspendLayout();
            _gProcSpellTypeMask.SuspendLayout();
            _gProcSpellPhaseMask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            _tpSpellProcDB.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { _dbConnect, _status, _ProcStatus });
            statusStrip1.Location = new System.Drawing.Point(0, 879);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(1384, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // _dbConnect
            // 
            _dbConnect.Name = "_dbConnect";
            _dbConnect.Size = new System.Drawing.Size(0, 17);
            // 
            // _status
            // 
            _status.Name = "_status";
            _status.Size = new System.Drawing.Size(0, 17);
            // 
            // _ProcStatus
            // 
            _ProcStatus.Name = "_ProcStatus";
            _ProcStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { _tsmFile });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1384, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // _tsmFile
            // 
            _tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { _tsmSettings, _tsmExit });
            _tsmFile.Name = "_tsmFile";
            _tsmFile.Size = new System.Drawing.Size(37, 20);
            _tsmFile.Text = "File";
            // 
            // _tsmSettings
            // 
            _tsmSettings.Name = "_tsmSettings";
            _tsmSettings.Size = new System.Drawing.Size(116, 22);
            _tsmSettings.Text = "Settings";
            _tsmSettings.Click += SettingsClick;
            // 
            // _tsmExit
            // 
            _tsmExit.Name = "_tsmExit";
            _tsmExit.Size = new System.Drawing.Size(116, 22);
            _tsmExit.Text = "Exit";
            _tsmExit.Click += ExitClick;
            // 
            // _ilPro
            // 
            _ilPro.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            _ilPro.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("_ilPro.ImageStream");
            _ilPro.TransparentColor = System.Drawing.Color.Transparent;
            _ilPro.Images.SetKeyName(0, "info.ico");
            _ilPro.Images.SetKeyName(1, "ok.ico");
            _ilPro.Images.SetKeyName(2, "drop.ico");
            _ilPro.Images.SetKeyName(3, "plus.ico");
            _ilPro.Images.SetKeyName(4, "family.ico");
            _ilPro.Images.SetKeyName(5, "munus.ico");
            // 
            // splitContainer7
            // 
            splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer7.Location = new System.Drawing.Point(0, 0);
            splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.Controls.Add(splitContainer8);
            splitContainer7.Panel1.Controls.Add(richTextBox1);
            // 
            // splitContainer7.Panel2
            // 
            splitContainer7.Panel2.Controls.Add(richTextBox2);
            splitContainer7.Size = new System.Drawing.Size(858, 429);
            splitContainer7.SplitterDistance = 424;
            splitContainer7.TabIndex = 0;
            // 
            // splitContainer8
            // 
            splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer8.Location = new System.Drawing.Point(0, 0);
            splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            splitContainer8.Panel1.Controls.Add(textBox2);
            splitContainer8.Size = new System.Drawing.Size(424, 429);
            splitContainer8.SplitterDistance = 209;
            splitContainer8.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(19, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox1.Location = new System.Drawing.Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(424, 429);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBox2.Location = new System.Drawing.Point(0, 0);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new System.Drawing.Size(430, 429);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // _tpCompare
            // 
            _tpCompare.Controls.Add(_scCompareRoot);
            _tpCompare.Location = new System.Drawing.Point(4, 24);
            _tpCompare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tpCompare.Name = "_tpCompare";
            _tpCompare.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tpCompare.Size = new System.Drawing.Size(1376, 827);
            _tpCompare.TabIndex = 4;
            _tpCompare.Text = "Compare Spells";
            _tpCompare.UseVisualStyleBackColor = true;
            // 
            // _scCompareRoot
            // 
            _scCompareRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            _scCompareRoot.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            _scCompareRoot.Location = new System.Drawing.Point(4, 3);
            _scCompareRoot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _scCompareRoot.Name = "_scCompareRoot";
            // 
            // _scCompareRoot.Panel1
            // 
            _scCompareRoot.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            _scCompareRoot.Panel1.Controls.Add(_bCompareSearch1);
            _scCompareRoot.Panel1.Controls.Add(label13);
            _scCompareRoot.Panel1.Controls.Add(_tbCompareFilterSpell1);
            _scCompareRoot.Panel1.Controls.Add(_rtbCompareSpell1);
            // 
            // _scCompareRoot.Panel2
            // 
            _scCompareRoot.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            _scCompareRoot.Panel2.Controls.Add(_bCompareSearch2);
            _scCompareRoot.Panel2.Controls.Add(label14);
            _scCompareRoot.Panel2.Controls.Add(_rtbCompareSpell2);
            _scCompareRoot.Panel2.Controls.Add(_tbCompareFilterSpell2);
            _scCompareRoot.Size = new System.Drawing.Size(1368, 821);
            _scCompareRoot.SplitterDistance = 684;
            _scCompareRoot.SplitterWidth = 5;
            _scCompareRoot.TabIndex = 0;
            // 
            // _bCompareSearch1
            // 
            _bCompareSearch1.Location = new System.Drawing.Point(278, 1);
            _bCompareSearch1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bCompareSearch1.Name = "_bCompareSearch1";
            _bCompareSearch1.Size = new System.Drawing.Size(59, 27);
            _bCompareSearch1.TabIndex = 3;
            _bCompareSearch1.Text = "Search";
            _bCompareSearch1.UseVisualStyleBackColor = true;
            _bCompareSearch1.Click += CompareSearch1Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(6, 7);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(67, 15);
            label13.TabIndex = 2;
            label13.Text = "ID or Name";
            // 
            // _tbCompareFilterSpell1
            // 
            _tbCompareFilterSpell1.Location = new System.Drawing.Point(100, 3);
            _tbCompareFilterSpell1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbCompareFilterSpell1.Name = "_tbCompareFilterSpell1";
            _tbCompareFilterSpell1.Size = new System.Drawing.Size(170, 23);
            _tbCompareFilterSpell1.TabIndex = 1;
            _tbCompareFilterSpell1.TextChanged += CompareFilterSpellTextChanged;
            // 
            // _rtbCompareSpell1
            // 
            _rtbCompareSpell1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _rtbCompareSpell1.BackColor = System.Drawing.Color.Gainsboro;
            _rtbCompareSpell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            _rtbCompareSpell1.Location = new System.Drawing.Point(0, 33);
            _rtbCompareSpell1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _rtbCompareSpell1.Name = "_rtbCompareSpell1";
            _rtbCompareSpell1.Size = new System.Drawing.Size(680, 787);
            _rtbCompareSpell1.TabIndex = 0;
            _rtbCompareSpell1.Text = "";
            // 
            // _bCompareSearch2
            // 
            _bCompareSearch2.Location = new System.Drawing.Point(284, 1);
            _bCompareSearch2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bCompareSearch2.Name = "_bCompareSearch2";
            _bCompareSearch2.Size = new System.Drawing.Size(59, 27);
            _bCompareSearch2.TabIndex = 3;
            _bCompareSearch2.Text = "Search";
            _bCompareSearch2.UseVisualStyleBackColor = true;
            _bCompareSearch2.Click += CompareSearch2Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(12, 7);
            label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(67, 15);
            label14.TabIndex = 2;
            label14.Text = "ID or Name";
            // 
            // _rtbCompareSpell2
            // 
            _rtbCompareSpell2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _rtbCompareSpell2.BackColor = System.Drawing.Color.Gainsboro;
            _rtbCompareSpell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            _rtbCompareSpell2.Location = new System.Drawing.Point(4, 33);
            _rtbCompareSpell2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _rtbCompareSpell2.Name = "_rtbCompareSpell2";
            _rtbCompareSpell2.Size = new System.Drawing.Size(653, 787);
            _rtbCompareSpell2.TabIndex = 0;
            _rtbCompareSpell2.Text = "";
            // 
            // _tbCompareFilterSpell2
            // 
            _tbCompareFilterSpell2.Location = new System.Drawing.Point(106, 3);
            _tbCompareFilterSpell2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbCompareFilterSpell2.Name = "_tbCompareFilterSpell2";
            _tbCompareFilterSpell2.Size = new System.Drawing.Size(170, 23);
            _tbCompareFilterSpell2.TabIndex = 1;
            _tbCompareFilterSpell2.TextChanged += CompareFilterSpellTextChanged;
            // 
            // _tpSpellInfo
            // 
            _tpSpellInfo.Controls.Add(splitContainer1);
            _tpSpellInfo.Location = new System.Drawing.Point(4, 24);
            _tpSpellInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tpSpellInfo.Name = "_tpSpellInfo";
            _tpSpellInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tpSpellInfo.Size = new System.Drawing.Size(1376, 827);
            _tpSpellInfo.TabIndex = 0;
            _tpSpellInfo.Text = "Spell Info";
            _tpSpellInfo.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new System.Drawing.Point(4, 3);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(_rtSpellInfo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new System.Drawing.Size(1368, 821);
            splitContainer1.SplitterDistance = 947;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // _rtSpellInfo
            // 
            _rtSpellInfo.BackColor = System.Drawing.Color.Gainsboro;
            _rtSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            _rtSpellInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            _rtSpellInfo.Location = new System.Drawing.Point(0, 0);
            _rtSpellInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _rtSpellInfo.Name = "_rtSpellInfo";
            _rtSpellInfo.ReadOnly = true;
            _rtSpellInfo.Size = new System.Drawing.Size(947, 821);
            _rtSpellInfo.TabIndex = 0;
            _rtSpellInfo.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(_lvSpellList);
            groupBox1.Controls.Add(_gSpellFilter);
            groupBox1.Controls.Add(groupBox7);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(416, 821);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // _lvSpellList
            // 
            _lvSpellList.AllowColumnReorder = true;
            _lvSpellList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _lvSpellList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chSpellID, chSpellName, chMiscID });
            _lvSpellList.FullRowSelect = true;
            _lvSpellList.GridLines = true;
            _lvSpellList.Location = new System.Drawing.Point(7, 405);
            _lvSpellList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _lvSpellList.MultiSelect = false;
            _lvSpellList.Name = "_lvSpellList";
            _lvSpellList.Size = new System.Drawing.Size(408, 409);
            _lvSpellList.TabIndex = 7;
            _lvSpellList.UseCompatibleStateImageBehavior = false;
            _lvSpellList.View = System.Windows.Forms.View.Details;
            _lvSpellList.VirtualMode = true;
            _lvSpellList.RetrieveVirtualItem += LvSpellListRetrieveVirtualItem;
            _lvSpellList.SelectedIndexChanged += LvSpellListSelectedIndexChanged;
            // 
            // chSpellID
            // 
            chSpellID.Text = "ID";
            chSpellID.Width = 48;
            // 
            // chSpellName
            // 
            chSpellName.Text = "Name";
            chSpellName.Width = 250;
            // 
            // chMiscID
            // 
            chMiscID.Text = "MiscID";
            chMiscID.Width = 64;
            // 
            // _gSpellFilter
            // 
            _gSpellFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _gSpellFilter.BackColor = System.Drawing.Color.LightGray;
            _gSpellFilter.Controls.Add(_gbAdvansedSearch);
            _gSpellFilter.Controls.Add(_cbTarget2);
            _gSpellFilter.Controls.Add(_cbTarget1);
            _gSpellFilter.Controls.Add(_cbSpellEffect);
            _gSpellFilter.Controls.Add(_cbSpellAura);
            _gSpellFilter.Controls.Add(_cbSpellFamilyName);
            _gSpellFilter.Location = new System.Drawing.Point(2, 93);
            _gSpellFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gSpellFilter.Name = "_gSpellFilter";
            _gSpellFilter.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gSpellFilter.Size = new System.Drawing.Size(413, 305);
            _gSpellFilter.TabIndex = 8;
            _gSpellFilter.TabStop = false;
            _gSpellFilter.Text = "Spell Filter";
            // 
            // _gbAdvansedSearch
            // 
            _gbAdvansedSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _gbAdvansedSearch.Controls.Add(_cbAdvancedFilter2CompareType);
            _gbAdvansedSearch.Controls.Add(_cbAdvancedFilter1CompareType);
            _gbAdvansedSearch.Controls.Add(_tbAdvancedFilter2Val);
            _gbAdvansedSearch.Controls.Add(_tbAdvancedFilter1Val);
            _gbAdvansedSearch.Controls.Add(_cbAdvancedFilter2);
            _gbAdvansedSearch.Controls.Add(_cbAdvancedFilter1);
            _gbAdvansedSearch.Controls.Add(_cbAdvancedEffectFilter2CompareType);
            _gbAdvansedSearch.Controls.Add(_cbAdvancedEffectFilter1CompareType);
            _gbAdvansedSearch.Controls.Add(_tbAdvancedEffectFilter2Val);
            _gbAdvansedSearch.Controls.Add(_tbAdvancedEffectFilter1Val);
            _gbAdvansedSearch.Controls.Add(_cbAdvancedEffectFilter2);
            _gbAdvansedSearch.Controls.Add(_cbAdvancedEffectFilter1);
            _gbAdvansedSearch.Location = new System.Drawing.Point(4, 156);
            _gbAdvansedSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gbAdvansedSearch.Name = "_gbAdvansedSearch";
            _gbAdvansedSearch.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gbAdvansedSearch.Size = new System.Drawing.Size(403, 142);
            _gbAdvansedSearch.TabIndex = 6;
            _gbAdvansedSearch.TabStop = false;
            _gbAdvansedSearch.Text = "Advanced Filter";
            // 
            // _cbAdvancedFilter2CompareType
            // 
            _cbAdvancedFilter2CompareType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _cbAdvancedFilter2CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbAdvancedFilter2CompareType.DropDownWidth = 160;
            _cbAdvancedFilter2CompareType.FormattingEnabled = true;
            _cbAdvancedFilter2CompareType.Location = new System.Drawing.Point(201, 47);
            _cbAdvancedFilter2CompareType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbAdvancedFilter2CompareType.Name = "_cbAdvancedFilter2CompareType";
            _cbAdvancedFilter2CompareType.Size = new System.Drawing.Size(88, 23);
            _cbAdvancedFilter2CompareType.TabIndex = 3;
            // 
            // _cbAdvancedFilter1CompareType
            // 
            _cbAdvancedFilter1CompareType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _cbAdvancedFilter1CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbAdvancedFilter1CompareType.DropDownWidth = 160;
            _cbAdvancedFilter1CompareType.FormattingEnabled = true;
            _cbAdvancedFilter1CompareType.Location = new System.Drawing.Point(201, 17);
            _cbAdvancedFilter1CompareType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbAdvancedFilter1CompareType.Name = "_cbAdvancedFilter1CompareType";
            _cbAdvancedFilter1CompareType.Size = new System.Drawing.Size(88, 23);
            _cbAdvancedFilter1CompareType.TabIndex = 2;
            // 
            // _tbAdvancedFilter2Val
            // 
            _tbAdvancedFilter2Val.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _tbAdvancedFilter2Val.Location = new System.Drawing.Point(297, 50);
            _tbAdvancedFilter2Val.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbAdvancedFilter2Val.Name = "_tbAdvancedFilter2Val";
            _tbAdvancedFilter2Val.Size = new System.Drawing.Size(98, 23);
            _tbAdvancedFilter2Val.TabIndex = 1;
            _tbAdvancedFilter2Val.KeyDown += TbAdvansedFilterValKeyDown;
            // 
            // _tbAdvancedFilter1Val
            // 
            _tbAdvancedFilter1Val.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _tbAdvancedFilter1Val.Location = new System.Drawing.Point(297, 17);
            _tbAdvancedFilter1Val.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbAdvancedFilter1Val.Name = "_tbAdvancedFilter1Val";
            _tbAdvancedFilter1Val.Size = new System.Drawing.Size(98, 23);
            _tbAdvancedFilter1Val.TabIndex = 1;
            _tbAdvancedFilter1Val.KeyDown += TbAdvansedFilterValKeyDown;
            // 
            // _cbAdvancedFilter2
            // 
            _cbAdvancedFilter2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbAdvancedFilter2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbAdvancedFilter2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbAdvancedFilter2.DropDownHeight = 500;
            _cbAdvancedFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbAdvancedFilter2.FormattingEnabled = true;
            _cbAdvancedFilter2.IntegralHeight = false;
            _cbAdvancedFilter2.Location = new System.Drawing.Point(1, 48);
            _cbAdvancedFilter2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbAdvancedFilter2.Name = "_cbAdvancedFilter2";
            _cbAdvancedFilter2.Size = new System.Drawing.Size(192, 23);
            _cbAdvancedFilter2.TabIndex = 0;
            // 
            // _cbAdvancedFilter1
            // 
            _cbAdvancedFilter1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbAdvancedFilter1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbAdvancedFilter1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbAdvancedFilter1.DropDownHeight = 500;
            _cbAdvancedFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbAdvancedFilter1.FormattingEnabled = true;
            _cbAdvancedFilter1.IntegralHeight = false;
            _cbAdvancedFilter1.Location = new System.Drawing.Point(1, 17);
            _cbAdvancedFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbAdvancedFilter1.Name = "_cbAdvancedFilter1";
            _cbAdvancedFilter1.Size = new System.Drawing.Size(192, 23);
            _cbAdvancedFilter1.TabIndex = 0;
            // 
            // _cbAdvancedEffectFilter2CompareType
            // 
            _cbAdvancedEffectFilter2CompareType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _cbAdvancedEffectFilter2CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbAdvancedEffectFilter2CompareType.DropDownWidth = 160;
            _cbAdvancedEffectFilter2CompareType.FormattingEnabled = true;
            _cbAdvancedEffectFilter2CompareType.Location = new System.Drawing.Point(200, 110);
            _cbAdvancedEffectFilter2CompareType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbAdvancedEffectFilter2CompareType.Name = "_cbAdvancedEffectFilter2CompareType";
            _cbAdvancedEffectFilter2CompareType.Size = new System.Drawing.Size(88, 23);
            _cbAdvancedEffectFilter2CompareType.TabIndex = 3;
            // 
            // _cbAdvancedEffectFilter1CompareType
            // 
            _cbAdvancedEffectFilter1CompareType.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _cbAdvancedEffectFilter1CompareType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbAdvancedEffectFilter1CompareType.DropDownWidth = 160;
            _cbAdvancedEffectFilter1CompareType.FormattingEnabled = true;
            _cbAdvancedEffectFilter1CompareType.Location = new System.Drawing.Point(201, 78);
            _cbAdvancedEffectFilter1CompareType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbAdvancedEffectFilter1CompareType.Name = "_cbAdvancedEffectFilter1CompareType";
            _cbAdvancedEffectFilter1CompareType.Size = new System.Drawing.Size(88, 23);
            _cbAdvancedEffectFilter1CompareType.TabIndex = 2;
            // 
            // _tbAdvancedEffectFilter2Val
            // 
            _tbAdvancedEffectFilter2Val.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _tbAdvancedEffectFilter2Val.Location = new System.Drawing.Point(297, 111);
            _tbAdvancedEffectFilter2Val.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbAdvancedEffectFilter2Val.Name = "_tbAdvancedEffectFilter2Val";
            _tbAdvancedEffectFilter2Val.Size = new System.Drawing.Size(98, 23);
            _tbAdvancedEffectFilter2Val.TabIndex = 1;
            _tbAdvancedEffectFilter2Val.KeyDown += TbAdvansedFilterValKeyDown;
            // 
            // _tbAdvancedEffectFilter1Val
            // 
            _tbAdvancedEffectFilter1Val.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _tbAdvancedEffectFilter1Val.Location = new System.Drawing.Point(297, 78);
            _tbAdvancedEffectFilter1Val.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbAdvancedEffectFilter1Val.Name = "_tbAdvancedEffectFilter1Val";
            _tbAdvancedEffectFilter1Val.Size = new System.Drawing.Size(98, 23);
            _tbAdvancedEffectFilter1Val.TabIndex = 1;
            _tbAdvancedEffectFilter1Val.KeyDown += TbAdvansedFilterValKeyDown;
            // 
            // _cbAdvancedEffectFilter2
            // 
            _cbAdvancedEffectFilter2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _cbAdvancedEffectFilter2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbAdvancedEffectFilter2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbAdvancedEffectFilter2.DropDownHeight = 500;
            _cbAdvancedEffectFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbAdvancedEffectFilter2.FormattingEnabled = true;
            _cbAdvancedEffectFilter2.IntegralHeight = false;
            _cbAdvancedEffectFilter2.Location = new System.Drawing.Point(22, 110);
            _cbAdvancedEffectFilter2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbAdvancedEffectFilter2.Name = "_cbAdvancedEffectFilter2";
            _cbAdvancedEffectFilter2.Size = new System.Drawing.Size(170, 23);
            _cbAdvancedEffectFilter2.TabIndex = 0;
            // 
            // _cbAdvancedEffectFilter1
            // 
            _cbAdvancedEffectFilter1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _cbAdvancedEffectFilter1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbAdvancedEffectFilter1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbAdvancedEffectFilter1.DropDownHeight = 500;
            _cbAdvancedEffectFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbAdvancedEffectFilter1.FormattingEnabled = true;
            _cbAdvancedEffectFilter1.IntegralHeight = false;
            _cbAdvancedEffectFilter1.Location = new System.Drawing.Point(22, 78);
            _cbAdvancedEffectFilter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbAdvancedEffectFilter1.Name = "_cbAdvancedEffectFilter1";
            _cbAdvancedEffectFilter1.Size = new System.Drawing.Size(170, 23);
            _cbAdvancedEffectFilter1.TabIndex = 0;
            // 
            // _cbTarget2
            // 
            _cbTarget2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbTarget2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbTarget2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbTarget2.DropDownHeight = 500;
            _cbTarget2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbTarget2.DropDownWidth = 302;
            _cbTarget2.FormattingEnabled = true;
            _cbTarget2.IntegralHeight = false;
            _cbTarget2.Location = new System.Drawing.Point(5, 128);
            _cbTarget2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbTarget2.Name = "_cbTarget2";
            _cbTarget2.Size = new System.Drawing.Size(404, 23);
            _cbTarget2.TabIndex = 5;
            _cbTarget2.SelectedIndexChanged += CbSpellFamilyNamesSelectedIndexChanged;
            // 
            // _cbTarget1
            // 
            _cbTarget1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbTarget1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbTarget1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbTarget1.DropDownHeight = 500;
            _cbTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbTarget1.DropDownWidth = 302;
            _cbTarget1.FormattingEnabled = true;
            _cbTarget1.IntegralHeight = false;
            _cbTarget1.Location = new System.Drawing.Point(5, 100);
            _cbTarget1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbTarget1.Name = "_cbTarget1";
            _cbTarget1.Size = new System.Drawing.Size(404, 23);
            _cbTarget1.TabIndex = 5;
            _cbTarget1.SelectedIndexChanged += CbSpellFamilyNamesSelectedIndexChanged;
            // 
            // _cbSpellEffect
            // 
            _cbSpellEffect.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbSpellEffect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbSpellEffect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbSpellEffect.DropDownHeight = 500;
            _cbSpellEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbSpellEffect.DropDownWidth = 302;
            _cbSpellEffect.FormattingEnabled = true;
            _cbSpellEffect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            _cbSpellEffect.IntegralHeight = false;
            _cbSpellEffect.Location = new System.Drawing.Point(5, 72);
            _cbSpellEffect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbSpellEffect.Name = "_cbSpellEffect";
            _cbSpellEffect.Size = new System.Drawing.Size(404, 23);
            _cbSpellEffect.TabIndex = 4;
            _cbSpellEffect.SelectedIndexChanged += CbSpellFamilyNamesSelectedIndexChanged;
            // 
            // _cbSpellAura
            // 
            _cbSpellAura.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbSpellAura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbSpellAura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbSpellAura.DropDownHeight = 500;
            _cbSpellAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbSpellAura.DropDownWidth = 302;
            _cbSpellAura.FormattingEnabled = true;
            _cbSpellAura.IntegralHeight = false;
            _cbSpellAura.Location = new System.Drawing.Point(5, 44);
            _cbSpellAura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbSpellAura.Name = "_cbSpellAura";
            _cbSpellAura.Size = new System.Drawing.Size(404, 23);
            _cbSpellAura.TabIndex = 3;
            _cbSpellAura.SelectedIndexChanged += CbSpellFamilyNamesSelectedIndexChanged;
            // 
            // _cbSpellFamilyName
            // 
            _cbSpellFamilyName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbSpellFamilyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbSpellFamilyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbSpellFamilyName.DropDownHeight = 500;
            _cbSpellFamilyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbSpellFamilyName.DropDownWidth = 302;
            _cbSpellFamilyName.FormattingEnabled = true;
            _cbSpellFamilyName.IntegralHeight = false;
            _cbSpellFamilyName.ItemHeight = 15;
            _cbSpellFamilyName.Location = new System.Drawing.Point(5, 16);
            _cbSpellFamilyName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbSpellFamilyName.Name = "_cbSpellFamilyName";
            _cbSpellFamilyName.Size = new System.Drawing.Size(404, 23);
            _cbSpellFamilyName.TabIndex = 2;
            _cbSpellFamilyName.SelectedIndexChanged += CbSpellFamilyNamesSelectedIndexChanged;
            // 
            // groupBox7
            // 
            groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox7.BackColor = System.Drawing.Color.LightGray;
            groupBox7.Controls.Add(label6);
            groupBox7.Controls.Add(label5);
            groupBox7.Controls.Add(label4);
            groupBox7.Controls.Add(_bSearch);
            groupBox7.Controls.Add(_tbSearchAttributes);
            groupBox7.Controls.Add(_tbSearchIcon);
            groupBox7.Controls.Add(_tbSearchId);
            groupBox7.Location = new System.Drawing.Point(0, 2);
            groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox7.Size = new System.Drawing.Size(416, 103);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "Spell Search";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 69);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(79, 15);
            label6.TabIndex = 2;
            label6.Text = "Attributes&&X:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 44);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(86, 15);
            label5.TabIndex = 2;
            label5.Text = "IconFileDataID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 18);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 15);
            label4.TabIndex = 2;
            label4.Text = "ID or Name:";
            // 
            // _bSearch
            // 
            _bSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _bSearch.Location = new System.Drawing.Point(356, 13);
            _bSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bSearch.Name = "_bSearch";
            _bSearch.Size = new System.Drawing.Size(58, 27);
            _bSearch.TabIndex = 1;
            _bSearch.Text = "Search";
            _bSearch.UseVisualStyleBackColor = true;
            _bSearch.Click += BSearchClick;
            // 
            // _tbSearchAttributes
            // 
            _tbSearchAttributes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _tbSearchAttributes.Location = new System.Drawing.Point(108, 66);
            _tbSearchAttributes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbSearchAttributes.Name = "_tbSearchAttributes";
            _tbSearchAttributes.Size = new System.Drawing.Size(241, 23);
            _tbSearchAttributes.TabIndex = 0;
            _tbSearchAttributes.KeyDown += TbSearchIdKeyDown;
            // 
            // _tbSearchIcon
            // 
            _tbSearchIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _tbSearchIcon.Location = new System.Drawing.Point(108, 40);
            _tbSearchIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbSearchIcon.Name = "_tbSearchIcon";
            _tbSearchIcon.Size = new System.Drawing.Size(241, 23);
            _tbSearchIcon.TabIndex = 0;
            _tbSearchIcon.KeyDown += TbSearchIdKeyDown;
            // 
            // _tbSearchId
            // 
            _tbSearchId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _tbSearchId.Location = new System.Drawing.Point(108, 15);
            _tbSearchId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbSearchId.Name = "_tbSearchId";
            _tbSearchId.Size = new System.Drawing.Size(241, 23);
            _tbSearchId.TabIndex = 0;
            _tbSearchId.KeyDown += TbSearchIdKeyDown;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(_tpSpellInfo);
            tabControl1.Controls.Add(_tpSpellProcInfo);
            tabControl1.Controls.Add(_tpSpellProcDB);
            tabControl1.Controls.Add(_tpCompare);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Enabled = false;
            tabControl1.Location = new System.Drawing.Point(0, 24);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1384, 855);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += TabControl1SelectedIndexChanged;
            // 
            // _tpSpellProcInfo
            // 
            _tpSpellProcInfo.Controls.Add(splitContainer2);
            _tpSpellProcInfo.Location = new System.Drawing.Point(4, 24);
            _tpSpellProcInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tpSpellProcInfo.Name = "_tpSpellProcInfo";
            _tpSpellProcInfo.Size = new System.Drawing.Size(1376, 827);
            _tpSpellProcInfo.TabIndex = 2;
            _tpSpellProcInfo.Text = "Spell Proc";
            _tpSpellProcInfo.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            splitContainer2.Panel2.Controls.Add(_lvProcAdditionalInfo);
            splitContainer2.Size = new System.Drawing.Size(1376, 827);
            splitContainer2.SplitterDistance = 698;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.BackColor = System.Drawing.Color.White;
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer3.Location = new System.Drawing.Point(0, 0);
            splitContainer3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            splitContainer3.Panel1.Controls.Add(_lNewProcSpellId);
            splitContainer3.Panel1.Controls.Add(_gProcAttributes);
            splitContainer3.Panel1.Controls.Add(_gProcFlags);
            splitContainer3.Panel1.Controls.Add(_gProcHitMask);
            splitContainer3.Panel1.Controls.Add(_gSpellProcEvent);
            splitContainer3.Panel1.Controls.Add(_gProcSpellSchools);
            splitContainer3.Panel1.Controls.Add(_gProcSpellTypeMask);
            splitContainer3.Panel1.Controls.Add(_gProcSpellPhaseMask);
            splitContainer3.Panel1.Controls.Add(_lProcHeader);
            splitContainer3.Panel1.Controls.Add(_tbNewProcSpellId);
            splitContainer3.Panel1.Controls.Add(_bLoadProcFromDB);
            splitContainer3.Panel1.Controls.Add(_bNewProcSpellId);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new System.Drawing.Size(1376, 698);
            splitContainer3.SplitterDistance = 310;
            splitContainer3.SplitterWidth = 5;
            splitContainer3.TabIndex = 0;
            // 
            // _lNewProcSpellId
            // 
            _lNewProcSpellId.AutoSize = true;
            _lNewProcSpellId.Location = new System.Drawing.Point(1088, 8);
            _lNewProcSpellId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _lNewProcSpellId.Name = "_lNewProcSpellId";
            _lNewProcSpellId.Size = new System.Drawing.Size(46, 15);
            _lNewProcSpellId.TabIndex = 19;
            _lNewProcSpellId.Text = "Spell ID";
            // 
            // _gProcAttributes
            // 
            _gProcAttributes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _gProcAttributes.BackColor = System.Drawing.Color.WhiteSmoke;
            _gProcAttributes.Controls.Add(_clbProcAttributes);
            _gProcAttributes.Location = new System.Drawing.Point(690, 110);
            _gProcAttributes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gProcAttributes.Name = "_gProcAttributes";
            _gProcAttributes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gProcAttributes.Size = new System.Drawing.Size(682, 88);
            _gProcAttributes.TabIndex = 14;
            _gProcAttributes.TabStop = false;
            _gProcAttributes.Text = "Proc Attributes";
            // 
            // _clbProcAttributes
            // 
            _clbProcAttributes.CheckOnClick = true;
            _clbProcAttributes.ColumnWidth = 190;
            _clbProcAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            _clbProcAttributes.FormattingEnabled = true;
            _clbProcAttributes.Location = new System.Drawing.Point(4, 19);
            _clbProcAttributes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _clbProcAttributes.MultiColumn = true;
            _clbProcAttributes.Name = "_clbProcAttributes";
            _clbProcAttributes.Size = new System.Drawing.Size(674, 66);
            _clbProcAttributes.TabIndex = 0;
            _clbProcAttributes.SelectedIndexChanged += ClbSchoolsSelectedIndexChanged;
            // 
            // _gProcFlags
            // 
            _gProcFlags.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _gProcFlags.BackColor = System.Drawing.Color.WhiteSmoke;
            _gProcFlags.Controls.Add(_clbProcFlags);
            _gProcFlags.Location = new System.Drawing.Point(4, 197);
            _gProcFlags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gProcFlags.Name = "_gProcFlags";
            _gProcFlags.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gProcFlags.Size = new System.Drawing.Size(1369, 114);
            _gProcFlags.TabIndex = 10;
            _gProcFlags.TabStop = false;
            _gProcFlags.Text = "Spell Proc Flags";
            // 
            // _clbProcFlags
            // 
            _clbProcFlags.CheckOnClick = true;
            _clbProcFlags.ColumnWidth = 150;
            _clbProcFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            _clbProcFlags.FormattingEnabled = true;
            _clbProcFlags.Location = new System.Drawing.Point(4, 19);
            _clbProcFlags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _clbProcFlags.MultiColumn = true;
            _clbProcFlags.Name = "_clbProcFlags";
            _clbProcFlags.Size = new System.Drawing.Size(1361, 92);
            _clbProcFlags.TabIndex = 0;
            _clbProcFlags.SelectedIndexChanged += ClbSchoolsSelectedIndexChanged;
            // 
            // _gProcHitMask
            // 
            _gProcHitMask.BackColor = System.Drawing.Color.WhiteSmoke;
            _gProcHitMask.Controls.Add(_clbProcFlagHit);
            _gProcHitMask.Location = new System.Drawing.Point(5, 110);
            _gProcHitMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gProcHitMask.Name = "_gProcHitMask";
            _gProcHitMask.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gProcHitMask.Size = new System.Drawing.Size(682, 88);
            _gProcHitMask.TabIndex = 9;
            _gProcHitMask.TabStop = false;
            _gProcHitMask.Text = "Proc Hit Mask";
            // 
            // _clbProcFlagHit
            // 
            _clbProcFlagHit.CheckOnClick = true;
            _clbProcFlagHit.ColumnWidth = 110;
            _clbProcFlagHit.Dock = System.Windows.Forms.DockStyle.Fill;
            _clbProcFlagHit.FormattingEnabled = true;
            _clbProcFlagHit.Location = new System.Drawing.Point(4, 19);
            _clbProcFlagHit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _clbProcFlagHit.MultiColumn = true;
            _clbProcFlagHit.Name = "_clbProcFlagHit";
            _clbProcFlagHit.Size = new System.Drawing.Size(674, 66);
            _clbProcFlagHit.TabIndex = 3;
            _clbProcFlagHit.SelectedIndexChanged += ClbSchoolsSelectedIndexChanged;
            // 
            // _gSpellProcEvent
            // 
            _gSpellProcEvent.BackColor = System.Drawing.Color.WhiteSmoke;
            _gSpellProcEvent.Controls.Add(_tbProcCharges);
            _gSpellProcEvent.Controls.Add(label15);
            _gSpellProcEvent.Controls.Add(_cbProcFitstSpellFamily);
            _gSpellProcEvent.Controls.Add(label1);
            _gSpellProcEvent.Controls.Add(_tbPPM);
            _gSpellProcEvent.Controls.Add(label2);
            _gSpellProcEvent.Controls.Add(_tbChance);
            _gSpellProcEvent.Controls.Add(label3);
            _gSpellProcEvent.Controls.Add(_tbCooldown);
            _gSpellProcEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            _gSpellProcEvent.Location = new System.Drawing.Point(5, 23);
            _gSpellProcEvent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gSpellProcEvent.Name = "_gSpellProcEvent";
            _gSpellProcEvent.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gSpellProcEvent.Size = new System.Drawing.Size(434, 88);
            _gSpellProcEvent.TabIndex = 8;
            _gSpellProcEvent.TabStop = false;
            _gSpellProcEvent.Text = "Spell Proc Event";
            // 
            // _tbProcCharges
            // 
            _tbProcCharges.Location = new System.Drawing.Point(384, 52);
            _tbProcCharges.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbProcCharges.Name = "_tbProcCharges";
            _tbProcCharges.Size = new System.Drawing.Size(46, 23);
            _tbProcCharges.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(331, 55);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(50, 15);
            label15.TabIndex = 8;
            label15.Text = "Charges";
            // 
            // _cbProcFitstSpellFamily
            // 
            _cbProcFitstSpellFamily.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbProcFitstSpellFamily.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbProcFitstSpellFamily.DropDownHeight = 500;
            _cbProcFitstSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbProcFitstSpellFamily.FormattingEnabled = true;
            _cbProcFitstSpellFamily.IntegralHeight = false;
            _cbProcFitstSpellFamily.Location = new System.Drawing.Point(4, 16);
            _cbProcFitstSpellFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbProcFitstSpellFamily.Name = "_cbProcFitstSpellFamily";
            _cbProcFitstSpellFamily.Size = new System.Drawing.Size(426, 23);
            _cbProcFitstSpellFamily.TabIndex = 4;
            _cbProcFitstSpellFamily.SelectedIndexChanged += ClbSchoolsSelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 55);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 15);
            label1.TabIndex = 6;
            label1.Text = "PPM";
            // 
            // _tbPPM
            // 
            _tbPPM.Location = new System.Drawing.Point(41, 52);
            _tbPPM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbPPM.MaxLength = 10;
            _tbPPM.Name = "_tbPPM";
            _tbPPM.Size = new System.Drawing.Size(46, 23);
            _tbPPM.TabIndex = 7;
            _tbPPM.TextChanged += TbCooldownTextChanged;
            _tbPPM.KeyPress += TextBoxKeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(91, 55);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "Chance";
            // 
            // _tbChance
            // 
            _tbChance.Location = new System.Drawing.Point(142, 52);
            _tbChance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbChance.MaxLength = 3;
            _tbChance.Name = "_tbChance";
            _tbChance.Size = new System.Drawing.Size(34, 23);
            _tbChance.TabIndex = 7;
            _tbChance.TextChanged += TbCooldownTextChanged;
            _tbChance.KeyPress += TextBoxKeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(187, 55);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 15);
            label3.TabIndex = 6;
            label3.Text = "Cooldown (ms)";
            // 
            // _tbCooldown
            // 
            _tbCooldown.Location = new System.Drawing.Point(275, 52);
            _tbCooldown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbCooldown.MaxLength = 10;
            _tbCooldown.Name = "_tbCooldown";
            _tbCooldown.Size = new System.Drawing.Size(52, 23);
            _tbCooldown.TabIndex = 7;
            _tbCooldown.TextChanged += TbCooldownTextChanged;
            _tbCooldown.KeyPress += TextBoxKeyPress;
            // 
            // _gProcSpellSchools
            // 
            _gProcSpellSchools.Anchor = System.Windows.Forms.AnchorStyles.Top;
            _gProcSpellSchools.BackColor = System.Drawing.Color.WhiteSmoke;
            _gProcSpellSchools.Controls.Add(_clbSchools);
            _gProcSpellSchools.Location = new System.Drawing.Point(440, 23);
            _gProcSpellSchools.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gProcSpellSchools.Name = "_gProcSpellSchools";
            _gProcSpellSchools.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gProcSpellSchools.Size = new System.Drawing.Size(439, 88);
            _gProcSpellSchools.TabIndex = 13;
            _gProcSpellSchools.TabStop = false;
            _gProcSpellSchools.Text = "School";
            // 
            // _clbSchools
            // 
            _clbSchools.CheckOnClick = true;
            _clbSchools.ColumnWidth = 120;
            _clbSchools.Dock = System.Windows.Forms.DockStyle.Fill;
            _clbSchools.FormattingEnabled = true;
            _clbSchools.Location = new System.Drawing.Point(4, 19);
            _clbSchools.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _clbSchools.MultiColumn = true;
            _clbSchools.Name = "_clbSchools";
            _clbSchools.Size = new System.Drawing.Size(431, 66);
            _clbSchools.TabIndex = 5;
            _clbSchools.SelectedIndexChanged += ClbSchoolsSelectedIndexChanged;
            // 
            // _gProcSpellTypeMask
            // 
            _gProcSpellTypeMask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            _gProcSpellTypeMask.BackColor = System.Drawing.Color.WhiteSmoke;
            _gProcSpellTypeMask.Controls.Add(_clbSpellTypeMask);
            _gProcSpellTypeMask.Location = new System.Drawing.Point(877, 23);
            _gProcSpellTypeMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gProcSpellTypeMask.Name = "_gProcSpellTypeMask";
            _gProcSpellTypeMask.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gProcSpellTypeMask.Size = new System.Drawing.Size(248, 88);
            _gProcSpellTypeMask.TabIndex = 11;
            _gProcSpellTypeMask.TabStop = false;
            _gProcSpellTypeMask.Text = "Proc Spell Type Mask";
            // 
            // _clbSpellTypeMask
            // 
            _clbSpellTypeMask.CheckOnClick = true;
            _clbSpellTypeMask.ColumnWidth = 100;
            _clbSpellTypeMask.Dock = System.Windows.Forms.DockStyle.Fill;
            _clbSpellTypeMask.FormattingEnabled = true;
            _clbSpellTypeMask.Location = new System.Drawing.Point(4, 19);
            _clbSpellTypeMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _clbSpellTypeMask.MultiColumn = true;
            _clbSpellTypeMask.Name = "_clbSpellTypeMask";
            _clbSpellTypeMask.Size = new System.Drawing.Size(240, 66);
            _clbSpellTypeMask.TabIndex = 0;
            _clbSpellTypeMask.SelectedIndexChanged += ClbSchoolsSelectedIndexChanged;
            // 
            // _gProcSpellPhaseMask
            // 
            _gProcSpellPhaseMask.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _gProcSpellPhaseMask.BackColor = System.Drawing.Color.WhiteSmoke;
            _gProcSpellPhaseMask.Controls.Add(_clbSpellPhaseMask);
            _gProcSpellPhaseMask.Location = new System.Drawing.Point(1126, 23);
            _gProcSpellPhaseMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gProcSpellPhaseMask.Name = "_gProcSpellPhaseMask";
            _gProcSpellPhaseMask.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _gProcSpellPhaseMask.Size = new System.Drawing.Size(248, 88);
            _gProcSpellPhaseMask.TabIndex = 12;
            _gProcSpellPhaseMask.TabStop = false;
            _gProcSpellPhaseMask.Text = "Proc Spell Phase Mask";
            // 
            // _clbSpellPhaseMask
            // 
            _clbSpellPhaseMask.CheckOnClick = true;
            _clbSpellPhaseMask.ColumnWidth = 100;
            _clbSpellPhaseMask.Dock = System.Windows.Forms.DockStyle.Fill;
            _clbSpellPhaseMask.FormattingEnabled = true;
            _clbSpellPhaseMask.Location = new System.Drawing.Point(4, 19);
            _clbSpellPhaseMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _clbSpellPhaseMask.MultiColumn = true;
            _clbSpellPhaseMask.Name = "_clbSpellPhaseMask";
            _clbSpellPhaseMask.Size = new System.Drawing.Size(240, 66);
            _clbSpellPhaseMask.TabIndex = 0;
            _clbSpellPhaseMask.SelectedIndexChanged += ClbSchoolsSelectedIndexChanged;
            // 
            // _lProcHeader
            // 
            _lProcHeader.AutoSize = true;
            _lProcHeader.Location = new System.Drawing.Point(5, 3);
            _lProcHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _lProcHeader.Name = "_lProcHeader";
            _lProcHeader.Size = new System.Drawing.Size(22, 15);
            _lProcHeader.TabIndex = 15;
            _lProcHeader.Text = "---";
            // 
            // _tbNewProcSpellId
            // 
            _tbNewProcSpellId.Location = new System.Drawing.Point(1143, 3);
            _tbNewProcSpellId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbNewProcSpellId.Name = "_tbNewProcSpellId";
            _tbNewProcSpellId.Size = new System.Drawing.Size(58, 23);
            _tbNewProcSpellId.TabIndex = 18;
            _tbNewProcSpellId.TextChanged += NewProcSpellIdTextChanged;
            // 
            // _bLoadProcFromDB
            // 
            _bLoadProcFromDB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _bLoadProcFromDB.Location = new System.Drawing.Point(1278, 3);
            _bLoadProcFromDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bLoadProcFromDB.Name = "_bLoadProcFromDB";
            _bLoadProcFromDB.Size = new System.Drawing.Size(93, 23);
            _bLoadProcFromDB.TabIndex = 17;
            _bLoadProcFromDB.Text = "Load from DB";
            _bLoadProcFromDB.UseVisualStyleBackColor = true;
            _bLoadProcFromDB.Click += LoadProcFromDBClick;
            // 
            // _bNewProcSpellId
            // 
            _bNewProcSpellId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _bNewProcSpellId.Enabled = false;
            _bNewProcSpellId.Location = new System.Drawing.Point(1213, 3);
            _bNewProcSpellId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bNewProcSpellId.Name = "_bNewProcSpellId";
            _bNewProcSpellId.Size = new System.Drawing.Size(58, 23);
            _bNewProcSpellId.TabIndex = 16;
            _bNewProcSpellId.Text = "New";
            _bNewProcSpellId.UseVisualStyleBackColor = true;
            _bNewProcSpellId.Click += NewProcSpellIdClick;
            // 
            // splitContainer4
            // 
            splitContainer4.BackColor = System.Drawing.Color.White;
            splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer4.Location = new System.Drawing.Point(0, 0);
            splitContainer4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            splitContainer4.Panel1.Controls.Add(_cbProcSpellFamilyTree);
            splitContainer4.Panel1.Controls.Add(_tvFamilyTree);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(splitContainer5);
            splitContainer4.Size = new System.Drawing.Size(1376, 383);
            splitContainer4.SplitterDistance = 346;
            splitContainer4.SplitterWidth = 5;
            splitContainer4.TabIndex = 0;
            // 
            // _cbProcSpellFamilyTree
            // 
            _cbProcSpellFamilyTree.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbProcSpellFamilyTree.DropDownHeight = 500;
            _cbProcSpellFamilyTree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbProcSpellFamilyTree.FormattingEnabled = true;
            _cbProcSpellFamilyTree.IntegralHeight = false;
            _cbProcSpellFamilyTree.Location = new System.Drawing.Point(1, 2);
            _cbProcSpellFamilyTree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbProcSpellFamilyTree.Name = "_cbProcSpellFamilyTree";
            _cbProcSpellFamilyTree.Size = new System.Drawing.Size(344, 23);
            _cbProcSpellFamilyTree.TabIndex = 1;
            _cbProcSpellFamilyTree.SelectedIndexChanged += TvFamilyTreeSelectedIndexChanged;
            // 
            // _tvFamilyTree
            // 
            _tvFamilyTree.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _tvFamilyTree.CheckBoxes = true;
            _tvFamilyTree.ImageIndex = 0;
            _tvFamilyTree.ImageList = _ilPro;
            _tvFamilyTree.Location = new System.Drawing.Point(1, 27);
            _tvFamilyTree.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tvFamilyTree.Name = "_tvFamilyTree";
            _tvFamilyTree.SelectedImageIndex = 0;
            _tvFamilyTree.ShowNodeToolTips = true;
            _tvFamilyTree.Size = new System.Drawing.Size(344, 354);
            _tvFamilyTree.TabIndex = 0;
            _tvFamilyTree.AfterCheck += FamilyTreeAfterCheck;
            _tvFamilyTree.AfterSelect += TvFamilyTreeAfterSelect;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer5.Location = new System.Drawing.Point(0, 0);
            splitContainer5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(_rtbProcSpellInfo);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            splitContainer5.Panel2.Controls.Add(_lvProcSpellList);
            splitContainer5.Panel2.Controls.Add(_bProcSearch);
            splitContainer5.Panel2.Controls.Add(_tbProcSeach);
            splitContainer5.Panel2.Controls.Add(_cbProcTarget2);
            splitContainer5.Panel2.Controls.Add(_cbProcTarget1);
            splitContainer5.Panel2.Controls.Add(_cbProcSpellEffect);
            splitContainer5.Panel2.Controls.Add(_cbProcSpellAura);
            splitContainer5.Panel2.Controls.Add(_cbProcSpellFamilyName);
            splitContainer5.Size = new System.Drawing.Size(1025, 383);
            splitContainer5.SplitterDistance = 732;
            splitContainer5.SplitterWidth = 5;
            splitContainer5.TabIndex = 0;
            // 
            // _rtbProcSpellInfo
            // 
            _rtbProcSpellInfo.BackColor = System.Drawing.SystemColors.MenuBar;
            _rtbProcSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            _rtbProcSpellInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            _rtbProcSpellInfo.Location = new System.Drawing.Point(0, 0);
            _rtbProcSpellInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _rtbProcSpellInfo.Name = "_rtbProcSpellInfo";
            _rtbProcSpellInfo.Size = new System.Drawing.Size(732, 383);
            _rtbProcSpellInfo.TabIndex = 0;
            _rtbProcSpellInfo.Text = "";
            // 
            // _lvProcSpellList
            // 
            _lvProcSpellList.AllowColumnReorder = true;
            _lvProcSpellList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _lvProcSpellList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { _chProcID, _chProcName });
            _lvProcSpellList.FullRowSelect = true;
            _lvProcSpellList.GridLines = true;
            _lvProcSpellList.Location = new System.Drawing.Point(2, 135);
            _lvProcSpellList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _lvProcSpellList.MultiSelect = false;
            _lvProcSpellList.Name = "_lvProcSpellList";
            _lvProcSpellList.ShowItemToolTips = true;
            _lvProcSpellList.Size = new System.Drawing.Size(260, 244);
            _lvProcSpellList.TabIndex = 0;
            _lvProcSpellList.UseCompatibleStateImageBehavior = false;
            _lvProcSpellList.View = System.Windows.Forms.View.Details;
            _lvProcSpellList.VirtualMode = true;
            _lvProcSpellList.RetrieveVirtualItem += LvProcSpellListRetrieveVirtualItem;
            _lvProcSpellList.SelectedIndexChanged += LvProcSpellListSelectedIndexChanged;
            // 
            // _chProcID
            // 
            _chProcID.Text = "ID";
            _chProcID.Width = 45;
            // 
            // _chProcName
            // 
            _chProcName.Text = "Name";
            _chProcName.Width = 210;
            // 
            // _bProcSearch
            // 
            _bProcSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _bProcSearch.Location = new System.Drawing.Point(196, 2);
            _bProcSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bProcSearch.Name = "_bProcSearch";
            _bProcSearch.Size = new System.Drawing.Size(63, 23);
            _bProcSearch.TabIndex = 5;
            _bProcSearch.Text = "Search";
            _bProcSearch.UseVisualStyleBackColor = true;
            _bProcSearch.Click += BProcSearchClick;
            // 
            // _tbProcSeach
            // 
            _tbProcSeach.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _tbProcSeach.Location = new System.Drawing.Point(4, 3);
            _tbProcSeach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbProcSeach.Name = "_tbProcSeach";
            _tbProcSeach.Size = new System.Drawing.Size(185, 23);
            _tbProcSeach.TabIndex = 4;
            _tbProcSeach.KeyDown += TbSearchKeyDown;
            // 
            // _cbProcTarget2
            // 
            _cbProcTarget2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _cbProcTarget2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbProcTarget2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbProcTarget2.DropDownHeight = 500;
            _cbProcTarget2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbProcTarget2.FormattingEnabled = true;
            _cbProcTarget2.IntegralHeight = false;
            _cbProcTarget2.Location = new System.Drawing.Point(124, 104);
            _cbProcTarget2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbProcTarget2.Name = "_cbProcTarget2";
            _cbProcTarget2.Size = new System.Drawing.Size(138, 23);
            _cbProcTarget2.TabIndex = 3;
            _cbProcTarget2.SelectedIndexChanged += CbProcSpellFamilyNameSelectedIndexChanged;
            // 
            // _cbProcTarget1
            // 
            _cbProcTarget1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbProcTarget1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbProcTarget1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbProcTarget1.DropDownHeight = 500;
            _cbProcTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbProcTarget1.FormattingEnabled = true;
            _cbProcTarget1.IntegralHeight = false;
            _cbProcTarget1.Location = new System.Drawing.Point(4, 104);
            _cbProcTarget1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbProcTarget1.Name = "_cbProcTarget1";
            _cbProcTarget1.Size = new System.Drawing.Size(109, 23);
            _cbProcTarget1.TabIndex = 3;
            _cbProcTarget1.SelectedIndexChanged += CbProcSpellFamilyNameSelectedIndexChanged;
            // 
            // _cbProcSpellEffect
            // 
            _cbProcSpellEffect.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbProcSpellEffect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbProcSpellEffect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbProcSpellEffect.DropDownHeight = 500;
            _cbProcSpellEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbProcSpellEffect.FormattingEnabled = true;
            _cbProcSpellEffect.IntegralHeight = false;
            _cbProcSpellEffect.Location = new System.Drawing.Point(4, 78);
            _cbProcSpellEffect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbProcSpellEffect.Name = "_cbProcSpellEffect";
            _cbProcSpellEffect.Size = new System.Drawing.Size(259, 23);
            _cbProcSpellEffect.TabIndex = 3;
            _cbProcSpellEffect.SelectedIndexChanged += CbProcSpellFamilyNameSelectedIndexChanged;
            // 
            // _cbProcSpellAura
            // 
            _cbProcSpellAura.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbProcSpellAura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbProcSpellAura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbProcSpellAura.DropDownHeight = 500;
            _cbProcSpellAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbProcSpellAura.FormattingEnabled = true;
            _cbProcSpellAura.IntegralHeight = false;
            _cbProcSpellAura.Location = new System.Drawing.Point(4, 53);
            _cbProcSpellAura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbProcSpellAura.Name = "_cbProcSpellAura";
            _cbProcSpellAura.Size = new System.Drawing.Size(259, 23);
            _cbProcSpellAura.TabIndex = 2;
            _cbProcSpellAura.SelectedIndexChanged += CbProcSpellFamilyNameSelectedIndexChanged;
            // 
            // _cbProcSpellFamilyName
            // 
            _cbProcSpellFamilyName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbProcSpellFamilyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbProcSpellFamilyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbProcSpellFamilyName.DropDownHeight = 500;
            _cbProcSpellFamilyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbProcSpellFamilyName.FormattingEnabled = true;
            _cbProcSpellFamilyName.IntegralHeight = false;
            _cbProcSpellFamilyName.Location = new System.Drawing.Point(4, 28);
            _cbProcSpellFamilyName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbProcSpellFamilyName.Name = "_cbProcSpellFamilyName";
            _cbProcSpellFamilyName.Size = new System.Drawing.Size(259, 23);
            _cbProcSpellFamilyName.TabIndex = 1;
            _cbProcSpellFamilyName.SelectedIndexChanged += CbProcSpellFamilyNameSelectedIndexChanged;
            // 
            // _lvProcAdditionalInfo
            // 
            _lvProcAdditionalInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { _chID, _chName, _chDescription });
            _lvProcAdditionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            _lvProcAdditionalInfo.FullRowSelect = true;
            _lvProcAdditionalInfo.GridLines = true;
            _lvProcAdditionalInfo.Location = new System.Drawing.Point(0, 0);
            _lvProcAdditionalInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _lvProcAdditionalInfo.Name = "_lvProcAdditionalInfo";
            _lvProcAdditionalInfo.Size = new System.Drawing.Size(1376, 124);
            _lvProcAdditionalInfo.SmallImageList = _ilPro;
            _lvProcAdditionalInfo.TabIndex = 0;
            _lvProcAdditionalInfo.UseCompatibleStateImageBehavior = false;
            _lvProcAdditionalInfo.View = System.Windows.Forms.View.Details;
            _lvProcAdditionalInfo.SelectedIndexChanged += LvProcAdditionalInfoSelectedIndexChanged;
            // 
            // _chID
            // 
            _chID.Text = "ID";
            // 
            // _chName
            // 
            _chName.Text = "Name";
            _chName.Width = 200;
            // 
            // _chDescription
            // 
            _chDescription.Text = "Description";
            _chDescription.Width = 582;
            // 
            // _tpSpellProcDB
            // 
            _tpSpellProcDB.Controls.Add(groupBox3);
            _tpSpellProcDB.Controls.Add(groupBox2);
            _tpSpellProcDB.Location = new System.Drawing.Point(4, 24);
            _tpSpellProcDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tpSpellProcDB.Name = "_tpSpellProcDB";
            _tpSpellProcDB.Size = new System.Drawing.Size(1376, 827);
            _tpSpellProcDB.TabIndex = 3;
            _tpSpellProcDB.Text = "Load Spell Proc from DB";
            _tpSpellProcDB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            groupBox3.Controls.Add(_cbBinaryCompare);
            groupBox3.Controls.Add(_lProcSqlCustomQueryFragment);
            groupBox3.Controls.Add(_tbSqlManual);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(_bSqlProcFlagsHit);
            groupBox3.Controls.Add(_bSqlProc);
            groupBox3.Controls.Add(_bSqlSchool);
            groupBox3.Controls.Add(_tbSqlProcFlagsHit);
            groupBox3.Controls.Add(_tbSqlProc);
            groupBox3.Controls.Add(_tbSqlSchool);
            groupBox3.Controls.Add(_tbLoadProcSpellId);
            groupBox3.Controls.Add(_cbSqlSpellFamily);
            groupBox3.Controls.Add(_bSelect);
            groupBox3.Location = new System.Drawing.Point(7, 3);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(1362, 98);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // _cbBinaryCompare
            // 
            _cbBinaryCompare.AutoSize = true;
            _cbBinaryCompare.Location = new System.Drawing.Point(877, 63);
            _cbBinaryCompare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbBinaryCompare.Name = "_cbBinaryCompare";
            _cbBinaryCompare.Size = new System.Drawing.Size(111, 19);
            _cbBinaryCompare.TabIndex = 8;
            _cbBinaryCompare.Text = "Binary Compare";
            _cbBinaryCompare.UseVisualStyleBackColor = true;
            // 
            // _lProcSqlCustomQueryFragment
            // 
            _lProcSqlCustomQueryFragment.AutoSize = true;
            _lProcSqlCustomQueryFragment.Location = new System.Drawing.Point(7, 59);
            _lProcSqlCustomQueryFragment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _lProcSqlCustomQueryFragment.MaximumSize = new System.Drawing.Size(93, 0);
            _lProcSqlCustomQueryFragment.Name = "_lProcSqlCustomQueryFragment";
            _lProcSqlCustomQueryFragment.Size = new System.Drawing.Size(85, 30);
            _lProcSqlCustomQueryFragment.TabIndex = 7;
            _lProcSqlCustomQueryFragment.Text = "Custom query fragment:";
            // 
            // _tbSqlManual
            // 
            _tbSqlManual.Location = new System.Drawing.Point(94, 61);
            _tbSqlManual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbSqlManual.Name = "_tbSqlManual";
            _tbSqlManual.Size = new System.Drawing.Size(317, 23);
            _tbSqlManual.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(7, 23);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(80, 15);
            label8.TabIndex = 5;
            label8.Text = "Family Name:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(666, 65);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(48, 15);
            label12.TabIndex = 5;
            label12.Text = "Proc Ex:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(439, 65);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(34, 15);
            label11.TabIndex = 5;
            label11.Text = "Proc:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(666, 23);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(46, 15);
            label10.TabIndex = 5;
            label10.Text = "School:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(439, 23);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(49, 15);
            label7.TabIndex = 5;
            label7.Text = "Spell ID:";
            // 
            // _bSqlProcFlagsHit
            // 
            _bSqlProcFlagsHit.Location = new System.Drawing.Point(838, 59);
            _bSqlProcFlagsHit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bSqlProcFlagsHit.Name = "_bSqlProcFlagsHit";
            _bSqlProcFlagsHit.Size = new System.Drawing.Size(33, 27);
            _bSqlProcFlagsHit.TabIndex = 4;
            _bSqlProcFlagsHit.Text = "...";
            _bSqlProcFlagsHit.UseVisualStyleBackColor = true;
            _bSqlProcFlagsHit.Click += CalcProcFlagsClick;
            // 
            // _bSqlProc
            // 
            _bSqlProc.Location = new System.Drawing.Point(624, 59);
            _bSqlProc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bSqlProc.Name = "_bSqlProc";
            _bSqlProc.Size = new System.Drawing.Size(33, 27);
            _bSqlProc.TabIndex = 4;
            _bSqlProc.Text = "...";
            _bSqlProc.UseVisualStyleBackColor = true;
            _bSqlProc.Click += CalcProcFlagsClick;
            // 
            // _bSqlSchool
            // 
            _bSqlSchool.Location = new System.Drawing.Point(838, 18);
            _bSqlSchool.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bSqlSchool.Name = "_bSqlSchool";
            _bSqlSchool.Size = new System.Drawing.Size(33, 24);
            _bSqlSchool.TabIndex = 4;
            _bSqlSchool.Text = "...";
            _bSqlSchool.UseVisualStyleBackColor = true;
            _bSqlSchool.Click += CalcProcFlagsClick;
            // 
            // _tbSqlProcFlagsHit
            // 
            _tbSqlProcFlagsHit.Location = new System.Drawing.Point(723, 61);
            _tbSqlProcFlagsHit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbSqlProcFlagsHit.Name = "_tbSqlProcFlagsHit";
            _tbSqlProcFlagsHit.Size = new System.Drawing.Size(107, 23);
            _tbSqlProcFlagsHit.TabIndex = 3;
            // 
            // _tbSqlProc
            // 
            _tbSqlProc.Location = new System.Drawing.Point(500, 61);
            _tbSqlProc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbSqlProc.Name = "_tbSqlProc";
            _tbSqlProc.Size = new System.Drawing.Size(116, 23);
            _tbSqlProc.TabIndex = 3;
            // 
            // _tbSqlSchool
            // 
            _tbSqlSchool.Location = new System.Drawing.Point(723, 20);
            _tbSqlSchool.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbSqlSchool.Name = "_tbSqlSchool";
            _tbSqlSchool.Size = new System.Drawing.Size(107, 23);
            _tbSqlSchool.TabIndex = 3;
            // 
            // _tbLoadProcSpellId
            // 
            _tbLoadProcSpellId.Location = new System.Drawing.Point(500, 20);
            _tbLoadProcSpellId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbLoadProcSpellId.Name = "_tbLoadProcSpellId";
            _tbLoadProcSpellId.Size = new System.Drawing.Size(116, 23);
            _tbLoadProcSpellId.TabIndex = 2;
            // 
            // _cbSqlSpellFamily
            // 
            _cbSqlSpellFamily.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbSqlSpellFamily.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbSqlSpellFamily.DropDownHeight = 500;
            _cbSqlSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbSqlSpellFamily.FormattingEnabled = true;
            _cbSqlSpellFamily.IntegralHeight = false;
            _cbSqlSpellFamily.Location = new System.Drawing.Point(94, 18);
            _cbSqlSpellFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbSqlSpellFamily.Name = "_cbSqlSpellFamily";
            _cbSqlSpellFamily.Size = new System.Drawing.Size(317, 23);
            _cbSqlSpellFamily.TabIndex = 1;
            // 
            // _bSelect
            // 
            _bSelect.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _bSelect.Location = new System.Drawing.Point(1268, 12);
            _bSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bSelect.Name = "_bSelect";
            _bSelect.Size = new System.Drawing.Size(88, 24);
            _bSelect.TabIndex = 0;
            _bSelect.Text = "Select";
            _bSelect.UseVisualStyleBackColor = true;
            _bSelect.Click += SelectClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(splitContainer6);
            groupBox2.Location = new System.Drawing.Point(0, 108);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(1372, 710);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer6.Location = new System.Drawing.Point(4, 19);
            splitContainer6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(_lvDataList);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            splitContainer6.Panel2.Controls.Add(_rtbSqlLog);
            splitContainer6.Panel2.Controls.Add(_bSqlToBase);
            splitContainer6.Panel2.Controls.Add(_bSqlSave);
            splitContainer6.Size = new System.Drawing.Size(1364, 688);
            splitContainer6.SplitterDistance = 354;
            splitContainer6.SplitterWidth = 5;
            splitContainer6.TabIndex = 0;
            // 
            // _lvDataList
            // 
            _lvDataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { spellId, spellname, schoolmask, spellfamilyname, spellfamilymask0, spellfamilymask1, spellfamilymask2, spellfamilymask3, procflag, procFlags2, procSpellTypeMask, procSpellPhaseMask, procHitMask, procAttributesMask, procDisableEffectsMask, ppmRate, customchance, cooldown, procCharges });
            _lvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            _lvDataList.FullRowSelect = true;
            _lvDataList.GridLines = true;
            _lvDataList.Location = new System.Drawing.Point(0, 0);
            _lvDataList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _lvDataList.MultiSelect = false;
            _lvDataList.Name = "_lvDataList";
            _lvDataList.Size = new System.Drawing.Size(1364, 354);
            _lvDataList.TabIndex = 0;
            _lvDataList.UseCompatibleStateImageBehavior = false;
            _lvDataList.View = System.Windows.Forms.View.Details;
            _lvDataList.VirtualMode = true;
            _lvDataList.RetrieveVirtualItem += LvSqlDataRetrieveVirtualItem;
            _lvDataList.KeyDown += SqlDataListKeyDown;
            _lvDataList.MouseDoubleClick += SqlDataListMouseDoubleClick;
            // 
            // spellId
            // 
            spellId.Text = "Spell ID";
            spellId.Width = 56;
            // 
            // spellname
            // 
            spellname.Text = "Spell Name";
            spellname.Width = 300;
            // 
            // schoolmask
            // 
            schoolmask.Text = "School Mask";
            schoolmask.Width = 78;
            // 
            // spellfamilyname
            // 
            spellfamilyname.Text = "Spell Family";
            spellfamilyname.Width = 90;
            // 
            // spellfamilymask0
            // 
            spellfamilymask0.Text = "Family Mask 0";
            spellfamilymask0.Width = 80;
            // 
            // spellfamilymask1
            // 
            spellfamilymask1.Text = "Family Mask 1";
            spellfamilymask1.Width = 80;
            // 
            // spellfamilymask2
            // 
            spellfamilymask2.Text = "Family Mask 2";
            spellfamilymask2.Width = 80;
            // 
            // spellfamilymask3
            // 
            spellfamilymask3.Text = "Family Mask 3";
            spellfamilymask3.Width = 80;
            // 
            // procflag
            // 
            procflag.Text = "Proc Flags";
            procflag.Width = 80;
            // 
            // procFlags2
            // 
            procFlags2.Text = "Proc Flags 2";
            procFlags2.Width = 80;
            // 
            // procSpellTypeMask
            // 
            procSpellTypeMask.Text = "Type Mask";
            procSpellTypeMask.Width = 80;
            // 
            // procSpellPhaseMask
            // 
            procSpellPhaseMask.Text = "Phase";
            procSpellPhaseMask.Width = 50;
            // 
            // procHitMask
            // 
            procHitMask.Text = "Hit Mask";
            // 
            // procAttributesMask
            // 
            procAttributesMask.Text = "Attributes";
            procAttributesMask.Width = 140;
            // 
            // procDisableEffectsMask
            // 
            procDisableEffectsMask.Text = "Disabled Effects";
            procDisableEffectsMask.Width = 80;
            // 
            // ppmRate
            // 
            ppmRate.Text = "PPM Rate";
            ppmRate.Width = 65;
            // 
            // customchance
            // 
            customchance.Text = "Chance";
            customchance.Width = 55;
            // 
            // cooldown
            // 
            cooldown.Text = "Cooldown";
            // 
            // procCharges
            // 
            procCharges.Text = "Charges";
            procCharges.Width = 55;
            // 
            // _rtbSqlLog
            // 
            _rtbSqlLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _rtbSqlLog.Location = new System.Drawing.Point(0, 37);
            _rtbSqlLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _rtbSqlLog.Name = "_rtbSqlLog";
            _rtbSqlLog.Size = new System.Drawing.Size(1363, 273);
            _rtbSqlLog.TabIndex = 3;
            _rtbSqlLog.Text = "";
            // 
            // _bSqlToBase
            // 
            _bSqlToBase.Location = new System.Drawing.Point(98, 3);
            _bSqlToBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bSqlToBase.Name = "_bSqlToBase";
            _bSqlToBase.Size = new System.Drawing.Size(88, 27);
            _bSqlToBase.TabIndex = 2;
            _bSqlToBase.Text = "To DB";
            _bSqlToBase.UseVisualStyleBackColor = true;
            _bSqlToBase.Click += SqlToBaseClick;
            // 
            // _bSqlSave
            // 
            _bSqlSave.Location = new System.Drawing.Point(4, 3);
            _bSqlSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bSqlSave.Name = "_bSqlSave";
            _bSqlSave.Size = new System.Drawing.Size(88, 27);
            _bSqlSave.TabIndex = 1;
            _bSqlSave.Text = "Save";
            _bSqlSave.UseVisualStyleBackColor = true;
            _bSqlSave.Click += SqlSaveClick;
            // 
            // _cbProcFlag
            // 
            _cbProcFlag.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _cbProcFlag.Appearance = System.Windows.Forms.Appearance.Button;
            _cbProcFlag.AutoSize = true;
            _cbProcFlag.Location = new System.Drawing.Point(1240, 1);
            _cbProcFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbProcFlag.Name = "_cbProcFlag";
            _cbProcFlag.Size = new System.Drawing.Size(63, 25);
            _cbProcFlag.TabIndex = 2;
            _cbProcFlag.Text = "ProcFlag";
            _cbProcFlag.UseVisualStyleBackColor = true;
            _cbProcFlag.Visible = false;
            _cbProcFlag.CheckedChanged += CbProcFlagCheckedChanged;
            // 
            // _bWrite
            // 
            _bWrite.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _bWrite.Location = new System.Drawing.Point(1167, 1);
            _bWrite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bWrite.Name = "_bWrite";
            _bWrite.Size = new System.Drawing.Size(59, 27);
            _bWrite.TabIndex = 3;
            _bWrite.Text = "Write";
            _bWrite.UseVisualStyleBackColor = true;
            _bWrite.Visible = false;
            _bWrite.Click += WriteClick;
            // 
            // _bLevelScaling
            // 
            _bLevelScaling.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            _bLevelScaling.Enabled = false;
            _bLevelScaling.Location = new System.Drawing.Point(1310, 1);
            _bLevelScaling.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bLevelScaling.Name = "_bLevelScaling";
            _bLevelScaling.Size = new System.Drawing.Size(70, 27);
            _bLevelScaling.TabIndex = 4;
            _bLevelScaling.Text = "Scaling";
            _bLevelScaling.UseVisualStyleBackColor = true;
            _bLevelScaling.Click += LevelScalingClick;
            // 
            // loadingProgressBar1
            // 
            loadingProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            loadingProgressBar1.Location = new System.Drawing.Point(1263, 879);
            loadingProgressBar1.Name = "loadingProgressBar1";
            loadingProgressBar1.Size = new System.Drawing.Size(100, 23);
            loadingProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            loadingProgressBar1.TabIndex = 5;
            // 
            // loadingProgressLabel1
            // 
            loadingProgressLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            loadingProgressLabel1.AutoSize = true;
            loadingProgressLabel1.Location = new System.Drawing.Point(1163, 883);
            loadingProgressLabel1.Name = "loadingProgressLabel1";
            loadingProgressLabel1.Size = new System.Drawing.Size(98, 15);
            loadingProgressLabel1.TabIndex = 6;
            loadingProgressLabel1.Text = "Loading progress";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1384, 901);
            Controls.Add(loadingProgressLabel1);
            Controls.Add(loadingProgressBar1);
            Controls.Add(_bLevelScaling);
            Controls.Add(_bWrite);
            Controls.Add(_cbProcFlag);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(1400, 670);
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormMain";
            Resize += FormMainResize;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            splitContainer8.Panel1.ResumeLayout(false);
            splitContainer8.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer8).EndInit();
            splitContainer8.ResumeLayout(false);
            _tpCompare.ResumeLayout(false);
            _scCompareRoot.Panel1.ResumeLayout(false);
            _scCompareRoot.Panel1.PerformLayout();
            _scCompareRoot.Panel2.ResumeLayout(false);
            _scCompareRoot.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_scCompareRoot).EndInit();
            _scCompareRoot.ResumeLayout(false);
            _tpSpellInfo.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            _gSpellFilter.ResumeLayout(false);
            _gbAdvansedSearch.ResumeLayout(false);
            _gbAdvansedSearch.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            tabControl1.ResumeLayout(false);
            _tpSpellProcInfo.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            _gProcAttributes.ResumeLayout(false);
            _gProcFlags.ResumeLayout(false);
            _gProcHitMask.ResumeLayout(false);
            _gSpellProcEvent.ResumeLayout(false);
            _gSpellProcEvent.PerformLayout();
            _gProcSpellSchools.ResumeLayout(false);
            _gProcSpellTypeMask.ResumeLayout(false);
            _gProcSpellPhaseMask.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            _tpSpellProcDB.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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