namespace SpellWork.Forms
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            _rtbSpellInfo = new System.Windows.Forms.RichTextBox();
            _bOk = new System.Windows.Forms.Button();
            _bCancel = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            buttonSearch = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            _lIDName = new System.Windows.Forms.Label();
            _tbAttribute = new System.Windows.Forms.TextBox();
            _tbIcon = new System.Windows.Forms.TextBox();
            _tbIdName = new System.Windows.Forms.TextBox();
            _lvSpellList = new System.Windows.Forms.ListView();
            _chID = new System.Windows.Forms.ColumnHeader();
            _chName = new System.Windows.Forms.ColumnHeader();
            _chMiscID = new System.Windows.Forms.ColumnHeader();
            groupBox2 = new System.Windows.Forms.GroupBox();
            _cbTarget2 = new System.Windows.Forms.ComboBox();
            _cbTarget1 = new System.Windows.Forms.ComboBox();
            _cbSpellEffect = new System.Windows.Forms.ComboBox();
            _cbSpellAura = new System.Windows.Forms.ComboBox();
            _cbSpellFamily = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(_rtbSpellInfo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(_bOk);
            splitContainer1.Panel2.Controls.Add(_bCancel);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new System.Drawing.Size(853, 525);
            splitContainer1.SplitterDistance = 455;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // _rtbSpellInfo
            // 
            _rtbSpellInfo.BackColor = System.Drawing.Color.Gainsboro;
            _rtbSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            _rtbSpellInfo.Location = new System.Drawing.Point(0, 0);
            _rtbSpellInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _rtbSpellInfo.Name = "_rtbSpellInfo";
            _rtbSpellInfo.ReadOnly = true;
            _rtbSpellInfo.Size = new System.Drawing.Size(455, 525);
            _rtbSpellInfo.TabIndex = 11;
            _rtbSpellInfo.Text = "";
            // 
            // _bOk
            // 
            _bOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            _bOk.Location = new System.Drawing.Point(302, 490);
            _bOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bOk.Name = "_bOk";
            _bOk.Size = new System.Drawing.Size(88, 27);
            _bOk.TabIndex = 9;
            _bOk.Text = "OK";
            _bOk.UseVisualStyleBackColor = true;
            _bOk.Click += OkClick;
            // 
            // _bCancel
            // 
            _bCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            _bCancel.Location = new System.Drawing.Point(208, 490);
            _bCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bCancel.Name = "_bCancel";
            _bCancel.Size = new System.Drawing.Size(88, 27);
            _bCancel.TabIndex = 10;
            _bCancel.Text = "Cancel";
            _bCancel.UseVisualStyleBackColor = true;
            _bCancel.Click += CancelClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(_lIDName);
            groupBox1.Controls.Add(_tbAttribute);
            groupBox1.Controls.Add(_tbIcon);
            groupBox1.Controls.Add(_tbIdName);
            groupBox1.Controls.Add(_lvSpellList);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new System.Drawing.Point(4, 3);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(386, 480);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Spell Search";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new System.Drawing.Point(314, 16);
            buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(62, 25);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 80);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Attribute:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 50);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 15);
            label2.TabIndex = 3;
            label2.Text = "IconFileDataID:";
            // 
            // _lIDName
            // 
            _lIDName.AutoSize = true;
            _lIDName.Location = new System.Drawing.Point(7, 20);
            _lIDName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _lIDName.Name = "_lIDName";
            _lIDName.Size = new System.Drawing.Size(70, 15);
            _lIDName.TabIndex = 3;
            _lIDName.Text = "ID or Name:";
            // 
            // _tbAttribute
            // 
            _tbAttribute.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _tbAttribute.Location = new System.Drawing.Point(105, 76);
            _tbAttribute.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbAttribute.Name = "_tbAttribute";
            _tbAttribute.Size = new System.Drawing.Size(270, 23);
            _tbAttribute.TabIndex = 2;
            _tbAttribute.KeyDown += IdNameKeyDown;
            // 
            // _tbIcon
            // 
            _tbIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _tbIcon.Location = new System.Drawing.Point(105, 46);
            _tbIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbIcon.Name = "_tbIcon";
            _tbIcon.Size = new System.Drawing.Size(270, 23);
            _tbIcon.TabIndex = 1;
            _tbIcon.KeyDown += IdNameKeyDown;
            // 
            // _tbIdName
            // 
            _tbIdName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _tbIdName.Location = new System.Drawing.Point(105, 16);
            _tbIdName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbIdName.Name = "_tbIdName";
            _tbIdName.Size = new System.Drawing.Size(210, 23);
            _tbIdName.TabIndex = 0;
            _tbIdName.KeyDown += IdNameKeyDown;
            // 
            // _lvSpellList
            // 
            _lvSpellList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _lvSpellList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { _chID, _chName, _chMiscID });
            _lvSpellList.FullRowSelect = true;
            _lvSpellList.GridLines = true;
            _lvSpellList.Location = new System.Drawing.Point(0, 271);
            _lvSpellList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _lvSpellList.Name = "_lvSpellList";
            _lvSpellList.Size = new System.Drawing.Size(386, 201);
            _lvSpellList.TabIndex = 8;
            _lvSpellList.UseCompatibleStateImageBehavior = false;
            _lvSpellList.View = System.Windows.Forms.View.Details;
            _lvSpellList.VirtualMode = true;
            _lvSpellList.RetrieveVirtualItem += SpellListRetrieveVirtualItem;
            _lvSpellList.SelectedIndexChanged += SpellListSelectedIndexChanged;
            _lvSpellList.DoubleClick += OkClick;
            // 
            // _chID
            // 
            _chID.Text = "ID";
            _chID.Width = 48;
            // 
            // _chName
            // 
            _chName.Text = "Name";
            _chName.Width = 213;
            // 
            // _chMiscID
            // 
            _chMiscID.Text = "MiscID";
            _chMiscID.Width = 64;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(_cbTarget2);
            groupBox2.Controls.Add(_cbTarget1);
            groupBox2.Controls.Add(_cbSpellEffect);
            groupBox2.Controls.Add(_cbSpellAura);
            groupBox2.Controls.Add(_cbSpellFamily);
            groupBox2.Location = new System.Drawing.Point(0, 102);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(386, 163);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Spell Filter";
            // 
            // _cbTarget2
            // 
            _cbTarget2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbTarget2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbTarget2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbTarget2.DropDownHeight = 500;
            _cbTarget2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbTarget2.FormattingEnabled = true;
            _cbTarget2.IntegralHeight = false;
            _cbTarget2.Location = new System.Drawing.Point(10, 130);
            _cbTarget2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbTarget2.Name = "_cbTarget2";
            _cbTarget2.Size = new System.Drawing.Size(364, 23);
            _cbTarget2.TabIndex = 7;
            _cbTarget2.SelectedIndexChanged += SpellFamilySelectedIndexChanged;
            // 
            // _cbTarget1
            // 
            _cbTarget1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbTarget1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbTarget1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbTarget1.DropDownHeight = 500;
            _cbTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbTarget1.FormattingEnabled = true;
            _cbTarget1.IntegralHeight = false;
            _cbTarget1.Location = new System.Drawing.Point(10, 102);
            _cbTarget1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbTarget1.Name = "_cbTarget1";
            _cbTarget1.Size = new System.Drawing.Size(364, 23);
            _cbTarget1.TabIndex = 6;
            _cbTarget1.SelectedIndexChanged += SpellFamilySelectedIndexChanged;
            // 
            // _cbSpellEffect
            // 
            _cbSpellEffect.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbSpellEffect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbSpellEffect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbSpellEffect.DropDownHeight = 500;
            _cbSpellEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbSpellEffect.FormattingEnabled = true;
            _cbSpellEffect.IntegralHeight = false;
            _cbSpellEffect.Location = new System.Drawing.Point(10, 73);
            _cbSpellEffect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbSpellEffect.Name = "_cbSpellEffect";
            _cbSpellEffect.Size = new System.Drawing.Size(364, 23);
            _cbSpellEffect.TabIndex = 5;
            _cbSpellEffect.SelectedIndexChanged += SpellFamilySelectedIndexChanged;
            // 
            // _cbSpellAura
            // 
            _cbSpellAura.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbSpellAura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbSpellAura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbSpellAura.DropDownHeight = 500;
            _cbSpellAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbSpellAura.FormattingEnabled = true;
            _cbSpellAura.IntegralHeight = false;
            _cbSpellAura.Location = new System.Drawing.Point(10, 45);
            _cbSpellAura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbSpellAura.Name = "_cbSpellAura";
            _cbSpellAura.Size = new System.Drawing.Size(364, 23);
            _cbSpellAura.TabIndex = 4;
            _cbSpellAura.SelectedIndexChanged += SpellFamilySelectedIndexChanged;
            // 
            // _cbSpellFamily
            // 
            _cbSpellFamily.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _cbSpellFamily.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbSpellFamily.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbSpellFamily.DropDownHeight = 500;
            _cbSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbSpellFamily.FormattingEnabled = true;
            _cbSpellFamily.IntegralHeight = false;
            _cbSpellFamily.Location = new System.Drawing.Point(10, 17);
            _cbSpellFamily.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbSpellFamily.Name = "_cbSpellFamily";
            _cbSpellFamily.Size = new System.Drawing.Size(364, 23);
            _cbSpellFamily.TabIndex = 3;
            _cbSpellFamily.SelectedIndexChanged += SpellFamilySelectedIndexChanged;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(853, 525);
            Controls.Add(splitContainer1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormSearch";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Spell Search";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox _rtbSpellInfo;
        private System.Windows.Forms.Button _bOk;
        private System.Windows.Forms.Button _bCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView _lvSpellList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader _chID;
        private System.Windows.Forms.ColumnHeader _chName;
        private System.Windows.Forms.ColumnHeader _chMiscID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lIDName;
        private System.Windows.Forms.TextBox _tbAttribute;
        private System.Windows.Forms.TextBox _tbIcon;
        private System.Windows.Forms.TextBox _tbIdName;
        private System.Windows.Forms.ComboBox _cbTarget2;
        private System.Windows.Forms.ComboBox _cbTarget1;
        private System.Windows.Forms.ComboBox _cbSpellEffect;
        private System.Windows.Forms.ComboBox _cbSpellAura;
        private System.Windows.Forms.ComboBox _cbSpellFamily;
        private System.Windows.Forms.Button buttonSearch;
    }
}