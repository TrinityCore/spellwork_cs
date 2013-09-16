namespace SpellWork.Forms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this._gbDbSetting = new System.Windows.Forms.GroupBox();
            this._tbBase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._tbPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._tbUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._tbPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._tbHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._cbUseDBConnect = new System.Windows.Forms.CheckBox();
            this._bTestConnect = new System.Windows.Forms.Button();
            this._bSaveSettings = new System.Windows.Forms.Button();
            this._gbDbSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gbDbSetting
            // 
            this._gbDbSetting.Controls.Add(this._tbBase);
            this._gbDbSetting.Controls.Add(this.label5);
            this._gbDbSetting.Controls.Add(this._tbPass);
            this._gbDbSetting.Controls.Add(this.label4);
            this._gbDbSetting.Controls.Add(this._tbUser);
            this._gbDbSetting.Controls.Add(this.label3);
            this._gbDbSetting.Controls.Add(this._tbPort);
            this._gbDbSetting.Controls.Add(this.label2);
            this._gbDbSetting.Controls.Add(this._tbHost);
            this._gbDbSetting.Controls.Add(this.label1);
            this._gbDbSetting.Location = new System.Drawing.Point(12, 12);
            this._gbDbSetting.Name = "_gbDbSetting";
            this._gbDbSetting.Size = new System.Drawing.Size(217, 158);
            this._gbDbSetting.TabIndex = 0;
            this._gbDbSetting.TabStop = false;
            this._gbDbSetting.Text = "Date Base Connect Settings";
            // 
            // _tbBase
            // 
            this._tbBase.Location = new System.Drawing.Point(54, 126);
            this._tbBase.Name = "_tbBase";
            this._tbBase.Size = new System.Drawing.Size(152, 20);
            this._tbBase.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Base";
            // 
            // _tbPass
            // 
            this._tbPass.Location = new System.Drawing.Point(54, 100);
            this._tbPass.Name = "_tbPass";
            this._tbPass.Size = new System.Drawing.Size(152, 20);
            this._tbPass.TabIndex = 3;
            this._tbPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pass";
            // 
            // _tbUser
            // 
            this._tbUser.Location = new System.Drawing.Point(54, 74);
            this._tbUser.Name = "_tbUser";
            this._tbUser.Size = new System.Drawing.Size(152, 20);
            this._tbUser.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User";
            // 
            // _tbPort
            // 
            this._tbPort.Location = new System.Drawing.Point(54, 48);
            this._tbPort.Name = "_tbPort";
            this._tbPort.Size = new System.Drawing.Size(152, 20);
            this._tbPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port/Pipe";
            // 
            // _tbHost
            // 
            this._tbHost.Location = new System.Drawing.Point(54, 22);
            this._tbHost.Name = "_tbHost";
            this._tbHost.Size = new System.Drawing.Size(152, 20);
            this._tbHost.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // _cbUseDBConnect
            // 
            this._cbUseDBConnect.AutoSize = true;
            this._cbUseDBConnect.Location = new System.Drawing.Point(21, 176);
            this._cbUseDBConnect.Name = "_cbUseDBConnect";
            this._cbUseDBConnect.Size = new System.Drawing.Size(106, 17);
            this._cbUseDBConnect.TabIndex = 5;
            this._cbUseDBConnect.Text = "Use DB Connect";
            this._cbUseDBConnect.UseVisualStyleBackColor = true;
            this._cbUseDBConnect.CheckedChanged += new System.EventHandler(this.CbUseDbConnectCheckedChanged);
            // 
            // _bTestConnect
            // 
            this._bTestConnect.Location = new System.Drawing.Point(12, 199);
            this._bTestConnect.Name = "_bTestConnect";
            this._bTestConnect.Size = new System.Drawing.Size(95, 23);
            this._bTestConnect.TabIndex = 6;
            this._bTestConnect.Text = "Test connect";
            this._bTestConnect.UseVisualStyleBackColor = true;
            this._bTestConnect.Click += new System.EventHandler(this.BSaveSettingsClick);
            // 
            // _bSaveSettings
            // 
            this._bSaveSettings.Location = new System.Drawing.Point(134, 199);
            this._bSaveSettings.Name = "_bSaveSettings";
            this._bSaveSettings.Size = new System.Drawing.Size(95, 23);
            this._bSaveSettings.TabIndex = 7;
            this._bSaveSettings.Text = "Save";
            this._bSaveSettings.UseVisualStyleBackColor = true;
            this._bSaveSettings.Click += new System.EventHandler(this.BSaveSettingsClick);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 229);
            this.Controls.Add(this._bSaveSettings);
            this.Controls.Add(this._bTestConnect);
            this.Controls.Add(this._cbUseDBConnect);
            this.Controls.Add(this._gbDbSetting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 268);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 268);
            this.Name = "FormSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SpellWork Settings";
            this.Load += new System.EventHandler(this.SettingsFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSettings_KeyDown);
            this._gbDbSetting.ResumeLayout(false);
            this._gbDbSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _gbDbSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _tbPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbHost;
        private System.Windows.Forms.CheckBox _cbUseDBConnect;
        private System.Windows.Forms.Button _bTestConnect;
        private System.Windows.Forms.Button _bSaveSettings;
    }
}