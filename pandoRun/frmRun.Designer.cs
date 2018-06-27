namespace pandoRun {
    partial class frmRun {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRun));
            this.thcMain = new pandoCommons.Discord_ThemeContainer();
            this.discord_Label1 = new pandoCommons.Discord_Label();
            this.btnRun = new pandoCommons.Discord_Button();
            this.txtExt = new pandoCommons.Discord_TextBox();
            this.rdbB = new pandoCommons.Discord_RadioButton();
            this.rdbG = new pandoCommons.Discord_RadioButton();
            this.rdbR = new pandoCommons.Discord_RadioButton();
            this.txtKey = new pandoCommons.Discord_TextBox();
            this.chkDecrypt = new pandoCommons.Discord_CheckBox();
            this.picPando = new System.Windows.Forms.PictureBox();
            this.cbxMain = new pandoCommons.Discord_ControlBox();
            this.thcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPando)).BeginInit();
            this.SuspendLayout();
            // 
            // thcMain
            // 
            this.thcMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.thcMain.Controls.Add(this.discord_Label1);
            this.thcMain.Controls.Add(this.btnRun);
            this.thcMain.Controls.Add(this.txtExt);
            this.thcMain.Controls.Add(this.rdbB);
            this.thcMain.Controls.Add(this.rdbG);
            this.thcMain.Controls.Add(this.rdbR);
            this.thcMain.Controls.Add(this.txtKey);
            this.thcMain.Controls.Add(this.chkDecrypt);
            this.thcMain.Controls.Add(this.picPando);
            this.thcMain.Controls.Add(this.cbxMain);
            this.thcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thcMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.thcMain.Location = new System.Drawing.Point(0, 0);
            this.thcMain.Name = "thcMain";
            this.thcMain.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.thcMain.RoundCorners = false;
            this.thcMain.Sizable = false;
            this.thcMain.Size = new System.Drawing.Size(305, 209);
            this.thcMain.SmartBounds = true;
            this.thcMain.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.thcMain.TabIndex = 0;
            this.thcMain.Text = "Run";
            // 
            // discord_Label1
            // 
            this.discord_Label1.AutoSize = true;
            this.discord_Label1.BackColor = System.Drawing.Color.Transparent;
            this.discord_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.discord_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.discord_Label1.Location = new System.Drawing.Point(13, 45);
            this.discord_Label1.Name = "discord_Label1";
            this.discord_Label1.Size = new System.Drawing.Size(60, 15);
            this.discord_Label1.TabIndex = 24;
            this.discord_Label1.Text = "Extension:";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.BackColor = System.Drawing.Color.Transparent;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRun.Image = null;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(212, 166);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(80, 31);
            this.btnRun.TabIndex = 23;
            this.btnRun.Text = "Run";
            this.btnRun.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtExt
            // 
            this.txtExt.BackColor = System.Drawing.Color.Transparent;
            this.txtExt.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtExt.Image = null;
            this.txtExt.Location = new System.Drawing.Point(79, 34);
            this.txtExt.MaxLength = 32767;
            this.txtExt.Multiline = false;
            this.txtExt.Name = "txtExt";
            this.txtExt.ReadOnly = false;
            this.txtExt.Size = new System.Drawing.Size(213, 41);
            this.txtExt.TabIndex = 22;
            this.txtExt.Text = "exe";
            this.txtExt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtExt.UseSystemPasswordChar = false;
            // 
            // rdbB
            // 
            this.rdbB.Checked = false;
            this.rdbB.Location = new System.Drawing.Point(13, 128);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(54, 17);
            this.rdbB.TabIndex = 21;
            this.rdbB.Text = "Blue";
            // 
            // rdbG
            // 
            this.rdbG.Checked = false;
            this.rdbG.Location = new System.Drawing.Point(13, 105);
            this.rdbG.Name = "rdbG";
            this.rdbG.Size = new System.Drawing.Size(63, 17);
            this.rdbG.TabIndex = 20;
            this.rdbG.Text = "Green";
            // 
            // rdbR
            // 
            this.rdbR.Checked = true;
            this.rdbR.Location = new System.Drawing.Point(13, 82);
            this.rdbR.Name = "rdbR";
            this.rdbR.Size = new System.Drawing.Size(52, 17);
            this.rdbR.TabIndex = 19;
            this.rdbR.Text = "Red";
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.Transparent;
            this.txtKey.Enabled = false;
            this.txtKey.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtKey.Image = null;
            this.txtKey.Location = new System.Drawing.Point(98, 104);
            this.txtKey.MaxLength = 32767;
            this.txtKey.Multiline = false;
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = false;
            this.txtKey.Size = new System.Drawing.Size(194, 41);
            this.txtKey.TabIndex = 18;
            this.txtKey.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKey.UseSystemPasswordChar = true;
            // 
            // chkDecrypt
            // 
            this.chkDecrypt.Checked = false;
            this.chkDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkDecrypt.Location = new System.Drawing.Point(98, 83);
            this.chkDecrypt.Name = "chkDecrypt";
            this.chkDecrypt.Size = new System.Drawing.Size(79, 16);
            this.chkDecrypt.TabIndex = 17;
            this.chkDecrypt.Text = "Decrypt";
            this.chkDecrypt.CheckedChanged += new pandoCommons.Discord_CheckBox.CheckedChangedEventHandler(this.chkDecrypt_CheckedChanged);
            // 
            // picPando
            // 
            this.picPando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picPando.Image = ((System.Drawing.Image)(resources.GetObject("picPando.Image")));
            this.picPando.Location = new System.Drawing.Point(13, 153);
            this.picPando.Name = "picPando";
            this.picPando.Size = new System.Drawing.Size(48, 48);
            this.picPando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPando.TabIndex = 13;
            this.picPando.TabStop = false;
            // 
            // cbxMain
            // 
            this.cbxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMain.EnableHoverHighlight = false;
            this.cbxMain.EnableMaximizeButton = false;
            this.cbxMain.EnableMinimizeButton = false;
            this.cbxMain.Location = new System.Drawing.Point(201, -5);
            this.cbxMain.Name = "cbxMain";
            this.cbxMain.Size = new System.Drawing.Size(100, 25);
            this.cbxMain.TabIndex = 0;
            // 
            // frmRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 209);
            this.Controls.Add(this.thcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.thcMain.ResumeLayout(false);
            this.thcMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private pandoCommons.Discord_ThemeContainer thcMain;
        private pandoCommons.Discord_ControlBox cbxMain;
        private System.Windows.Forms.PictureBox picPando;
        private pandoCommons.Discord_RadioButton rdbB;
        private pandoCommons.Discord_RadioButton rdbG;
        private pandoCommons.Discord_RadioButton rdbR;
        private pandoCommons.Discord_TextBox txtKey;
        private pandoCommons.Discord_CheckBox chkDecrypt;
        private pandoCommons.Discord_TextBox txtExt;
        private pandoCommons.Discord_Button btnRun;
        private pandoCommons.Discord_Label discord_Label1;
    }
}