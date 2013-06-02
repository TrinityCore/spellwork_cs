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
            this._bOk = new System.Windows.Forms.Button();
            this._bCancel = new System.Windows.Forms.Button();
            this._tbxLevel = new System.Windows.Forms.TextBox();
            this._tbLevel = new System.Windows.Forms.TrackBar();
            this._lInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._tbLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // _bOk
            // 
            this._bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._bOk.Location = new System.Drawing.Point(52, 76);
            this._bOk.Name = "_bOk";
            this._bOk.Size = new System.Drawing.Size(75, 23);
            this._bOk.TabIndex = 0;
            this._bOk.Text = "OK";
            this._bOk.UseVisualStyleBackColor = true;
            // 
            // _bCancel
            // 
            this._bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._bCancel.Location = new System.Drawing.Point(163, 76);
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
            this._tbLevel.Maximum = 100;
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
            // FormSpellScaling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.ControlBox = false;
            this.Controls.Add(this._lInfo);
            this.Controls.Add(this._tbLevel);
            this.Controls.Add(this._tbxLevel);
            this.Controls.Add(this._bCancel);
            this.Controls.Add(this._bOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 151);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 151);
            this.Name = "FormSpellScaling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spell scaler";
            ((System.ComponentModel.ISupportInitialize)(this._tbLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _bOk;
        private System.Windows.Forms.Button _bCancel;
        private System.Windows.Forms.TextBox _tbxLevel;
        private System.Windows.Forms.TrackBar _tbLevel;
        private System.Windows.Forms.Label _lInfo;
    }
}