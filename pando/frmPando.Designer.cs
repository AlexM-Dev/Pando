﻿namespace pando {
    partial class frmPando {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPando));
            this.thcMain = new pandoCommons.Discord_ThemeContainer();
            this.txtPattern = new pandoCommons.Discord_TextBox();
            this.lblPattern = new pandoCommons.Discord_Label();
            this.picPando = new System.Windows.Forms.PictureBox();
            this.btnCancel = new pandoCommons.Discord_Button();
            this.btnSave = new pandoCommons.Discord_Button();
            this.btnSelectImage = new pandoCommons.Discord_Button();
            this.txtKey = new pandoCommons.Discord_TextBox();
            this.chkEncrypt = new pandoCommons.Discord_CheckBox();
            this.cbxMain = new pandoCommons.Discord_ControlBox();
            this.thcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPando)).BeginInit();
            this.SuspendLayout();
            // 
            // thcMain
            // 
            this.thcMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.thcMain.Controls.Add(this.txtPattern);
            this.thcMain.Controls.Add(this.lblPattern);
            this.thcMain.Controls.Add(this.picPando);
            this.thcMain.Controls.Add(this.btnCancel);
            this.thcMain.Controls.Add(this.btnSave);
            this.thcMain.Controls.Add(this.btnSelectImage);
            this.thcMain.Controls.Add(this.txtKey);
            this.thcMain.Controls.Add(this.chkEncrypt);
            this.thcMain.Controls.Add(this.cbxMain);
            this.thcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thcMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.thcMain.Location = new System.Drawing.Point(0, 0);
            this.thcMain.Name = "thcMain";
            this.thcMain.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.thcMain.RoundCorners = false;
            this.thcMain.Sizable = false;
            this.thcMain.Size = new System.Drawing.Size(234, 250);
            this.thcMain.SmartBounds = true;
            this.thcMain.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.thcMain.TabIndex = 11;
            this.thcMain.Text = "Pando";
            // 
            // txtPattern
            // 
            this.txtPattern.BackColor = System.Drawing.Color.Transparent;
            this.txtPattern.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPattern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtPattern.Image = null;
            this.txtPattern.Location = new System.Drawing.Point(9, 117);
            this.txtPattern.MaxLength = 32767;
            this.txtPattern.Multiline = false;
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.ReadOnly = false;
            this.txtPattern.Size = new System.Drawing.Size(216, 41);
            this.txtPattern.TabIndex = 22;
            this.txtPattern.Text = "R";
            this.txtPattern.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPattern.UseSystemPasswordChar = false;
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.BackColor = System.Drawing.Color.Transparent;
            this.lblPattern.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPattern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.lblPattern.Location = new System.Drawing.Point(6, 99);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(95, 15);
            this.lblPattern.TabIndex = 21;
            this.lblPattern.Text = "Channel Pattern:";
            // 
            // picPando
            // 
            this.picPando.Image = ((System.Drawing.Image)(resources.GetObject("picPando.Image")));
            this.picPando.Location = new System.Drawing.Point(9, 192);
            this.picPando.Name = "picPando";
            this.picPando.Size = new System.Drawing.Size(48, 48);
            this.picPando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPando.TabIndex = 12;
            this.picPando.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.Image = null;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(63, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 31);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Image = null;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(145, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 31);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectImage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSelectImage.Image = null;
            this.btnSelectImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectImage.Location = new System.Drawing.Point(63, 182);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(162, 24);
            this.btnSelectImage.TabIndex = 17;
            this.btnSelectImage.Text = "Layer Image";
            this.btnSelectImage.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.Transparent;
            this.txtKey.Enabled = false;
            this.txtKey.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtKey.Image = null;
            this.txtKey.Location = new System.Drawing.Point(9, 55);
            this.txtKey.MaxLength = 32767;
            this.txtKey.Multiline = false;
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = false;
            this.txtKey.Size = new System.Drawing.Size(216, 41);
            this.txtKey.TabIndex = 13;
            this.txtKey.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKey.UseSystemPasswordChar = true;
            // 
            // chkEncrypt
            // 
            this.chkEncrypt.Checked = false;
            this.chkEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkEncrypt.Location = new System.Drawing.Point(9, 33);
            this.chkEncrypt.Name = "chkEncrypt";
            this.chkEncrypt.Size = new System.Drawing.Size(79, 16);
            this.chkEncrypt.TabIndex = 12;
            this.chkEncrypt.Text = "Encrypt";
            this.chkEncrypt.CheckedChanged += new pandoCommons.Discord_CheckBox.CheckedChangedEventHandler(this.chkEncrypt_CheckedChanged);
            // 
            // cbxMain
            // 
            this.cbxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMain.EnableHoverHighlight = false;
            this.cbxMain.EnableMaximizeButton = false;
            this.cbxMain.EnableMinimizeButton = false;
            this.cbxMain.Location = new System.Drawing.Point(130, -5);
            this.cbxMain.Name = "cbxMain";
            this.cbxMain.Size = new System.Drawing.Size(100, 25);
            this.cbxMain.TabIndex = 11;
            // 
            // frmPando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 250);
            this.Controls.Add(this.thcMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmPando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pando";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPando_FormClosing);
            this.thcMain.ResumeLayout(false);
            this.thcMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private pandoCommons.Discord_ThemeContainer thcMain;
        private pandoCommons.Discord_ControlBox cbxMain;
        private pandoCommons.Discord_CheckBox chkEncrypt;
        private pandoCommons.Discord_TextBox txtKey;
        private pandoCommons.Discord_Button btnSelectImage;
        private pandoCommons.Discord_Button btnCancel;
        private pandoCommons.Discord_Button btnSave;
        private System.Windows.Forms.PictureBox picPando;
        private pandoCommons.Discord_Label lblPattern;
        private pandoCommons.Discord_TextBox txtPattern;
    }
}