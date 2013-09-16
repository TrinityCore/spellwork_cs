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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._rtbSpellInfo = new System.Windows.Forms.RichTextBox();
            this._bOk = new System.Windows.Forms.Button();
            this._bCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._lIDName = new System.Windows.Forms.Label();
            this._tbAttribute = new System.Windows.Forms.TextBox();
            this._tbIcon = new System.Windows.Forms.TextBox();
            this._tbIdName = new System.Windows.Forms.TextBox();
            this._lvSpellList = new System.Windows.Forms.ListView();
            this._chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._cbTarget2 = new System.Windows.Forms.ComboBox();
            this._cbTarget1 = new System.Windows.Forms.ComboBox();
            this._cbSpellEffect = new System.Windows.Forms.ComboBox();
            this._cbSpellAura = new System.Windows.Forms.ComboBox();
            this._cbSpellFamily = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._rtbSpellInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._bOk);
            this.splitContainer1.Panel2.Controls.Add(this._bCancel);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(672, 455);
            this.splitContainer1.SplitterDistance = 381;
            this.splitContainer1.TabIndex = 0;
            // 
            // _rtbSpellInfo
            // 
            this._rtbSpellInfo.BackColor = System.Drawing.Color.Gainsboro;
            this._rtbSpellInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbSpellInfo.Location = new System.Drawing.Point(0, 0);
            this._rtbSpellInfo.Name = "_rtbSpellInfo";
            this._rtbSpellInfo.ReadOnly = true;
            this._rtbSpellInfo.Size = new System.Drawing.Size(381, 455);
            this._rtbSpellInfo.TabIndex = 11;
            this._rtbSpellInfo.Text = "";
            // 
            // _bOk
            // 
            this._bOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bOk.Location = new System.Drawing.Point(209, 425);
            this._bOk.Name = "_bOk";
            this._bOk.Size = new System.Drawing.Size(75, 23);
            this._bOk.TabIndex = 9;
            this._bOk.Text = "OK";
            this._bOk.UseVisualStyleBackColor = true;
            this._bOk.Click += new System.EventHandler(this.OkClick);
            // 
            // _bCancel
            // 
            this._bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._bCancel.Location = new System.Drawing.Point(128, 425);
            this._bCancel.Name = "_bCancel";
            this._bCancel.Size = new System.Drawing.Size(75, 23);
            this._bCancel.TabIndex = 10;
            this._bCancel.Text = "Cancel";
            this._bCancel.UseVisualStyleBackColor = true;
            this._bCancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._lIDName);
            this.groupBox1.Controls.Add(this._tbAttribute);
            this.groupBox1.Controls.Add(this._tbIcon);
            this.groupBox1.Controls.Add(this._tbIdName);
            this.groupBox1.Controls.Add(this._lvSpellList);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spell Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Attribute:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Icon ID:";
            // 
            // _lIDName
            // 
            this._lIDName.AutoSize = true;
            this._lIDName.Location = new System.Drawing.Point(6, 17);
            this._lIDName.Name = "_lIDName";
            this._lIDName.Size = new System.Drawing.Size(64, 13);
            this._lIDName.TabIndex = 3;
            this._lIDName.Text = "ID or Name:";
            // 
            // _tbAttribute
            // 
            this._tbAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbAttribute.Location = new System.Drawing.Point(74, 66);
            this._tbAttribute.Name = "_tbAttribute";
            this._tbAttribute.Size = new System.Drawing.Size(198, 20);
            this._tbAttribute.TabIndex = 2;
            this._tbAttribute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdNameKeyDown);
            // 
            // _tbIcon
            // 
            this._tbIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbIcon.Location = new System.Drawing.Point(74, 40);
            this._tbIcon.Name = "_tbIcon";
            this._tbIcon.Size = new System.Drawing.Size(198, 20);
            this._tbIcon.TabIndex = 1;
            this._tbIcon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdNameKeyDown);
            // 
            // _tbIdName
            // 
            this._tbIdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbIdName.Location = new System.Drawing.Point(74, 14);
            this._tbIdName.Name = "_tbIdName";
            this._tbIdName.Size = new System.Drawing.Size(145, 20);
            this._tbIdName.TabIndex = 0;
            this._tbIdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdNameKeyDown);
            // 
            // _lvSpellList
            // 
            this._lvSpellList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lvSpellList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._chID,
            this._chName});
            this._lvSpellList.FullRowSelect = true;
            this._lvSpellList.GridLines = true;
            this._lvSpellList.HideSelection = false;
            this._lvSpellList.Location = new System.Drawing.Point(0, 235);
            this._lvSpellList.Name = "_lvSpellList";
            this._lvSpellList.Size = new System.Drawing.Size(281, 175);
            this._lvSpellList.TabIndex = 8;
            this._lvSpellList.UseCompatibleStateImageBehavior = false;
            this._lvSpellList.View = System.Windows.Forms.View.Details;
            this._lvSpellList.VirtualMode = true;
            this._lvSpellList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.SpellListRetrieveVirtualItem);
            this._lvSpellList.SelectedIndexChanged += new System.EventHandler(this.SpellListSelectedIndexChanged);
            this._lvSpellList.DoubleClick += new System.EventHandler(this.OkClick);
            // 
            // _chID
            // 
            this._chID.Text = "ID";
            // 
            // _chName
            // 
            this._chName.Text = "Name";
            this._chName.Width = 213;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._cbTarget2);
            this.groupBox2.Controls.Add(this._cbTarget1);
            this.groupBox2.Controls.Add(this._cbSpellEffect);
            this.groupBox2.Controls.Add(this._cbSpellAura);
            this.groupBox2.Controls.Add(this._cbSpellFamily);
            this.groupBox2.Location = new System.Drawing.Point(0, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 141);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spell Filter";
            // 
            // _cbTarget2
            // 
            this._cbTarget2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cbTarget2.DropDownHeight = 500;
            this._cbTarget2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbTarget2.FormattingEnabled = true;
            this._cbTarget2.IntegralHeight = false;
            this._cbTarget2.Location = new System.Drawing.Point(9, 113);
            this._cbTarget2.Name = "_cbTarget2";
            this._cbTarget2.Size = new System.Drawing.Size(263, 21);
            this._cbTarget2.TabIndex = 7;
            this._cbTarget2.SelectedIndexChanged += new System.EventHandler(this.SpellFamilySelectedIndexChanged);
            // 
            // _cbTarget1
            // 
            this._cbTarget1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cbTarget1.DropDownHeight = 500;
            this._cbTarget1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbTarget1.FormattingEnabled = true;
            this._cbTarget1.IntegralHeight = false;
            this._cbTarget1.Location = new System.Drawing.Point(9, 88);
            this._cbTarget1.Name = "_cbTarget1";
            this._cbTarget1.Size = new System.Drawing.Size(263, 21);
            this._cbTarget1.TabIndex = 6;
            this._cbTarget1.SelectedIndexChanged += new System.EventHandler(this.SpellFamilySelectedIndexChanged);
            // 
            // _cbSpellEffect
            // 
            this._cbSpellEffect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellEffect.DropDownHeight = 500;
            this._cbSpellEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellEffect.FormattingEnabled = true;
            this._cbSpellEffect.IntegralHeight = false;
            this._cbSpellEffect.Location = new System.Drawing.Point(9, 63);
            this._cbSpellEffect.Name = "_cbSpellEffect";
            this._cbSpellEffect.Size = new System.Drawing.Size(263, 21);
            this._cbSpellEffect.TabIndex = 5;
            this._cbSpellEffect.SelectedIndexChanged += new System.EventHandler(this.SpellFamilySelectedIndexChanged);
            // 
            // _cbSpellAura
            // 
            this._cbSpellAura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellAura.DropDownHeight = 500;
            this._cbSpellAura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellAura.FormattingEnabled = true;
            this._cbSpellAura.IntegralHeight = false;
            this._cbSpellAura.Location = new System.Drawing.Point(9, 39);
            this._cbSpellAura.Name = "_cbSpellAura";
            this._cbSpellAura.Size = new System.Drawing.Size(263, 21);
            this._cbSpellAura.TabIndex = 4;
            this._cbSpellAura.SelectedIndexChanged += new System.EventHandler(this.SpellFamilySelectedIndexChanged);
            // 
            // _cbSpellFamily
            // 
            this._cbSpellFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cbSpellFamily.DropDownHeight = 500;
            this._cbSpellFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbSpellFamily.FormattingEnabled = true;
            this._cbSpellFamily.IntegralHeight = false;
            this._cbSpellFamily.Location = new System.Drawing.Point(9, 15);
            this._cbSpellFamily.Name = "_cbSpellFamily";
            this._cbSpellFamily.Size = new System.Drawing.Size(263, 21);
            this._cbSpellFamily.TabIndex = 3;
            this._cbSpellFamily.SelectedIndexChanged += new System.EventHandler(this.SpellFamilySelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(219, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(53, 22);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 455);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSearch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spell Search";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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