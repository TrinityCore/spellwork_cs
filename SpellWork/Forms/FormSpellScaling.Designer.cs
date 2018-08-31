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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpellScaling));
            this._bOk = new System.Windows.Forms.Button();
            this._bCancel = new System.Windows.Forms.Button();
            this._tbxLevel = new System.Windows.Forms.TextBox();
            this._tbLevel = new System.Windows.Forms.TrackBar();
            this._lInfo = new System.Windows.Forms.Label();
            this._lIlvl = new System.Windows.Forms.Label();
            this._tbItemLevel = new System.Windows.Forms.TrackBar();
            this._tbxItemLevel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._tbLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._tbItemLevel)).BeginInit();
            this.SuspendLayout();
            //
            // _bOk
            //
            this._bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._bOk.Location = new System.Drawing.Point(116, 137);
            this._bOk.Name = "_bOk";
            this._bOk.Size = new System.Drawing.Size(75, 23);
            this._bOk.TabIndex = 0;
            this._bOk.Text = "OK";
            this._bOk.UseVisualStyleBackColor = true;
            //
            // _bCancel
            //
            this._bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._bCancel.Location = new System.Drawing.Point(197, 137);
            this._bCancel.Name = "_bCancel";
            this._bCancel.Size = new System.Drawing.Size(75, 23);
            this._bCancel.TabIndex = 1;
            this._bCancel.Text = "Cancel";
            this._bCancel.UseVisualStyleBackColor = true;
            //
            // _tbxLevel
            //
            this._tbxLevel.Location = new System.Drawing.Point(244, 25);
            this._tbxLevel.MaxLength = 3;
            this._tbxLevel.Name = "_tbxLevel";
            this._tbxLevel.Size = new System.Drawing.Size(28, 20);
            this._tbxLevel.TabIndex = 2;
            this._tbxLevel.Text = DBC.DBC.SelectedLevel.ToString();
            this._tbxLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._tbxLevel.TextChanged += new System.EventHandler(this.LevelTextChanged);
            this._tbxLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LevelTextKeyPress);
            //
            // _tbLevel
            //
            this._tbLevel.Location = new System.Drawing.Point(12, 25);
            this._tbLevel.Maximum = 120;
            this._tbLevel.Minimum = 1;
            this._tbLevel.Name = "_tbLevel";
            this._tbLevel.Size = new System.Drawing.Size(226, 45);
            this._tbLevel.TabIndex = 3;
            this._tbLevel.TickFrequency = 5;
            this._tbLevel.Value = (int)DBC.DBC.SelectedLevel;
            this._tbLevel.ValueChanged += new System.EventHandler(this.LevelValueChanged);
            //
            // _lInfo
            //
            this._lInfo.AutoSize = true;
            this._lInfo.Location = new System.Drawing.Point(12, 9);
            this._lInfo.Name = "_lInfo";
            this._lInfo.Size = new System.Drawing.Size(62, 13);
            this._lInfo.TabIndex = 4;
            this._lInfo.Text = "Select level";
            //
            // _lIlvl
            //
            this._lIlvl.AutoSize = true;
            this._lIlvl.Location = new System.Drawing.Point(12, 70);
            this._lIlvl.Name = "_lIlvl";
            this._lIlvl.Size = new System.Drawing.Size(84, 13);
            this._lIlvl.TabIndex = 7;
            this._lIlvl.Text = "Select item level";
            //
            // _tbItemLevel
            //
            this._tbItemLevel.LargeChange = 20;
            this._tbItemLevel.Location = new System.Drawing.Point(12, 86);
            this._tbItemLevel.Maximum = 400;
            this._tbItemLevel.Minimum = 1;
            this._tbItemLevel.Name = "_tbItemLevel";
            this._tbItemLevel.Size = new System.Drawing.Size(226, 45);
            this._tbItemLevel.SmallChange = 5;
            this._tbItemLevel.TabIndex = 6;
            this._tbItemLevel.TickFrequency = 20;
            this._tbItemLevel.Value = (int)DBC.DBC.SelectedItemLevel;
            this._tbItemLevel.ValueChanged += new System.EventHandler(this.ItemLevelValueChanged);
            //
            // _tbxItemLevel
            //
            this._tbxItemLevel.Location = new System.Drawing.Point(244, 86);
            this._tbxItemLevel.MaxLength = 3;
            this._tbxItemLevel.Name = "_tbxItemLevel";
            this._tbxItemLevel.Size = new System.Drawing.Size(28, 20);
            this._tbxItemLevel.TabIndex = 5;
            this._tbxItemLevel.Text = DBC.DBC.SelectedItemLevel.ToString();
            this._tbxItemLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._tbxItemLevel.TextChanged += new System.EventHandler(this.ItemLevelTextChanged);
            this._tbxItemLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LevelTextKeyPress);
            //
            // FormSpellScaling
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this._lInfo);
            this.Controls.Add(this._tbLevel);
            this.Controls.Add(this._tbxLevel);
            this.Controls.Add(this._lIlvl);
            this.Controls.Add(this._tbItemLevel);
            this.Controls.Add(this._tbxItemLevel);
            this.Controls.Add(this._bCancel);
            this.Controls.Add(this._bOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSpellScaling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spell scaler";
            ((System.ComponentModel.ISupportInitialize)(this._tbLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._tbItemLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}