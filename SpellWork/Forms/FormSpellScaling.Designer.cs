namespace SpellWork.Forms
{
    partial class FormSpellScaling
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpellScaling));
            _bOk = new System.Windows.Forms.Button();
            _bCancel = new System.Windows.Forms.Button();
            _tbxLevel = new System.Windows.Forms.TextBox();
            _tbLevel = new System.Windows.Forms.TrackBar();
            _lInfo = new System.Windows.Forms.Label();
            _lIlvl = new System.Windows.Forms.Label();
            _tbItemLevel = new System.Windows.Forms.TrackBar();
            _tbxItemLevel = new System.Windows.Forms.TextBox();
            _lMap = new System.Windows.Forms.Label();
            _tbxMapSearch = new System.Windows.Forms.TextBox();
            _cbMap = new System.Windows.Forms.ComboBox();
            _mapDataBindingSource = new System.Windows.Forms.BindingSource(components);
            _lDifficulty = new System.Windows.Forms.Label();
            _cbDifficulty = new System.Windows.Forms.ComboBox();
            _difficultyDataBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)_tbLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_tbItemLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_mapDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_difficultyDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // _bOk
            // 
            _bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            _bOk.Location = new System.Drawing.Point(135, 313);
            _bOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bOk.Name = "_bOk";
            _bOk.Size = new System.Drawing.Size(88, 27);
            _bOk.TabIndex = 0;
            _bOk.Text = "OK";
            _bOk.UseVisualStyleBackColor = true;
            // 
            // _bCancel
            // 
            _bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            _bCancel.Location = new System.Drawing.Point(230, 313);
            _bCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _bCancel.Name = "_bCancel";
            _bCancel.Size = new System.Drawing.Size(88, 27);
            _bCancel.TabIndex = 1;
            _bCancel.Text = "Cancel";
            _bCancel.UseVisualStyleBackColor = true;
            // 
            // _tbxLevel
            // 
            _tbxLevel.Location = new System.Drawing.Point(285, 29);
            _tbxLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbxLevel.MaxLength = 3;
            _tbxLevel.Name = "_tbxLevel";
            _tbxLevel.Size = new System.Drawing.Size(32, 23);
            _tbxLevel.TabIndex = 2;
            _tbxLevel.Text = "70";
            _tbxLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _tbxLevel.TextChanged += LevelTextChanged;
            _tbxLevel.KeyPress += LevelTextKeyPress;
            // 
            // _tbLevel
            // 
            _tbLevel.Location = new System.Drawing.Point(14, 29);
            _tbLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbLevel.Maximum = 70;
            _tbLevel.Minimum = 1;
            _tbLevel.Name = "_tbLevel";
            _tbLevel.Size = new System.Drawing.Size(264, 45);
            _tbLevel.TabIndex = 3;
            _tbLevel.TickFrequency = 5;
            _tbLevel.Value = 70;
            _tbLevel.ValueChanged += LevelValueChanged;
            // 
            // _lInfo
            // 
            _lInfo.AutoSize = true;
            _lInfo.Location = new System.Drawing.Point(14, 10);
            _lInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _lInfo.Name = "_lInfo";
            _lInfo.Size = new System.Drawing.Size(67, 15);
            _lInfo.TabIndex = 4;
            _lInfo.Text = "Caster level";
            // 
            // _lIlvl
            // 
            _lIlvl.AutoSize = true;
            _lIlvl.Location = new System.Drawing.Point(14, 81);
            _lIlvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _lIlvl.Name = "_lIlvl";
            _lIlvl.Size = new System.Drawing.Size(58, 15);
            _lIlvl.TabIndex = 7;
            _lIlvl.Text = "Item level";
            // 
            // _tbItemLevel
            // 
            _tbItemLevel.LargeChange = 20;
            _tbItemLevel.Location = new System.Drawing.Point(14, 99);
            _tbItemLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbItemLevel.Maximum = 1300;
            _tbItemLevel.Minimum = 1;
            _tbItemLevel.Name = "_tbItemLevel";
            _tbItemLevel.Size = new System.Drawing.Size(264, 45);
            _tbItemLevel.SmallChange = 5;
            _tbItemLevel.TabIndex = 6;
            _tbItemLevel.TickFrequency = 20;
            _tbItemLevel.Value = 475;
            _tbItemLevel.ValueChanged += ItemLevelValueChanged;
            // 
            // _tbxItemLevel
            // 
            _tbxItemLevel.Location = new System.Drawing.Point(285, 99);
            _tbxItemLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbxItemLevel.MaxLength = 3;
            _tbxItemLevel.Name = "_tbxItemLevel";
            _tbxItemLevel.Size = new System.Drawing.Size(32, 23);
            _tbxItemLevel.TabIndex = 5;
            _tbxItemLevel.Text = "475";
            _tbxItemLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            _tbxItemLevel.TextChanged += ItemLevelTextChanged;
            _tbxItemLevel.KeyPress += LevelTextKeyPress;
            // 
            // _lMap
            // 
            _lMap.AutoSize = true;
            _lMap.Location = new System.Drawing.Point(14, 155);
            _lMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _lMap.Name = "_lMap";
            _lMap.Size = new System.Drawing.Size(31, 15);
            _lMap.TabIndex = 8;
            _lMap.Text = "Map";
            // 
            // _tbxMapSearch
            // 
            _tbxMapSearch.Location = new System.Drawing.Point(14, 173);
            _tbxMapSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _tbxMapSearch.Name = "_tbxMapSearch";
            _tbxMapSearch.Size = new System.Drawing.Size(303, 23);
            _tbxMapSearch.TabIndex = 9;
            _tbxMapSearch.TextChanged += MapSearchTextChanged;
            // 
            // _cbMap
            // 
            _cbMap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbMap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbMap.DataSource = _mapDataBindingSource;
            _cbMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbMap.FormattingEnabled = true;
            _cbMap.Location = new System.Drawing.Point(14, 204);
            _cbMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbMap.Name = "_cbMap";
            _cbMap.Size = new System.Drawing.Size(303, 23);
            _cbMap.TabIndex = 11;
            _cbMap.SelectedIndexChanged += MapSelectionChanged;
            // 
            // _lDifficulty
            // 
            _lDifficulty.AutoSize = true;
            _lDifficulty.Location = new System.Drawing.Point(14, 232);
            _lDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            _lDifficulty.Name = "_lDifficulty";
            _lDifficulty.Size = new System.Drawing.Size(55, 15);
            _lDifficulty.TabIndex = 12;
            _lDifficulty.Text = "Difficulty";
            // 
            // _cbDifficulty
            // 
            _cbDifficulty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            _cbDifficulty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            _cbDifficulty.DataSource = _difficultyDataBindingSource;
            _cbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _cbDifficulty.FormattingEnabled = true;
            _cbDifficulty.Location = new System.Drawing.Point(14, 250);
            _cbDifficulty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _cbDifficulty.Name = "_cbDifficulty";
            _cbDifficulty.Size = new System.Drawing.Size(303, 23);
            _cbDifficulty.TabIndex = 13;
            // 
            // FormSpellScaling
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(331, 353);
            Controls.Add(_cbDifficulty);
            Controls.Add(_lDifficulty);
            Controls.Add(_cbMap);
            Controls.Add(_tbxMapSearch);
            Controls.Add(_lMap);
            Controls.Add(_lInfo);
            Controls.Add(_tbLevel);
            Controls.Add(_tbxLevel);
            Controls.Add(_lIlvl);
            Controls.Add(_tbItemLevel);
            Controls.Add(_tbxItemLevel);
            Controls.Add(_bCancel);
            Controls.Add(_bOk);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormSpellScaling";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Spell scaler";
            ((System.ComponentModel.ISupportInitialize)_tbLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)_tbItemLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)_mapDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_difficultyDataBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bOk;
        private System.Windows.Forms.Button _bCancel;
        private System.Windows.Forms.TextBox _tbxLevel;
        private System.Windows.Forms.TrackBar _tbLevel;
        private System.Windows.Forms.Label _lInfo;
        private System.Windows.Forms.Label _lIlvl;
        private System.Windows.Forms.TrackBar _tbItemLevel;
        private System.Windows.Forms.TextBox _tbxItemLevel;
        private System.Windows.Forms.Label _lMap;
        private System.Windows.Forms.TextBox _tbxMapSearch;
        private System.Windows.Forms.ComboBox _cbMap;
        private System.Windows.Forms.BindingSource _mapDataBindingSource;
        private System.Windows.Forms.Label _lDifficulty;
        private System.Windows.Forms.ComboBox _cbDifficulty;
        private System.Windows.Forms.BindingSource _difficultyDataBindingSource;
    }
}