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
            this.thcMain = new pandoCommons.Discord_ThemeContainer();
            this.cbxMain = new pandoCommons.Discord_ControlBox();
            this.thcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // thcMain
            // 
            this.thcMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.thcMain.Controls.Add(this.cbxMain);
            this.thcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thcMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.thcMain.Location = new System.Drawing.Point(0, 0);
            this.thcMain.Name = "thcMain";
            this.thcMain.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.thcMain.RoundCorners = false;
            this.thcMain.Sizable = false;
            this.thcMain.Size = new System.Drawing.Size(305, 201);
            this.thcMain.SmartBounds = true;
            this.thcMain.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.thcMain.TabIndex = 0;
            this.thcMain.Text = "Run";
            // 
            // cbxMain
            // 
            this.cbxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMain.EnableHoverHighlight = false;
            this.cbxMain.EnableMaximizeButton = true;
            this.cbxMain.EnableMinimizeButton = true;
            this.cbxMain.Location = new System.Drawing.Point(218, 49);
            this.cbxMain.Name = "cbxMain";
            this.cbxMain.Size = new System.Drawing.Size(100, 25);
            this.cbxMain.TabIndex = 0;
            // 
            // frmRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 201);
            this.Controls.Add(this.thcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.thcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private pandoCommons.Discord_ThemeContainer thcMain;
        private pandoCommons.Discord_ControlBox cbxMain;
    }
}