using pandoCommons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pandoRun {
    public partial class frmRun : Form {
        private Bitmap fileCode;
        private string fileName;

        private bool isProcessing = false;

        public frmRun(Bitmap fileCode, string fName) {
            InitializeComponent();

            this.fileCode = fileCode;
            this.fileName = fName;

            thcMain.InitFont();
        }

        private void chkDecrypt_CheckedChanged(object sender) {
            txtKey.Enabled = chkDecrypt.Enabled;
        }

        string tempFile = "";
        private async void btnRun_Click(object sender, EventArgs e) {
            if (btnRun.Text == "Run") {
                // Control values.

                bool decrypt = chkDecrypt.Checked;
                string key = txtKey.Text;
                string extension = txtExt.Text;
                string pattern = txtPattern.Text;

                assignProcessing(true);

                var completed = new Action<string, byte[]>((s, f) => {
                    tempFile = s;
                    File.WriteAllBytes(tempFile, f);

                    this.InvokeEx(c => {
                        btnRun.Text = "Finish";
                        assignProcessing(false);
                    });

                    var psi = new ProcessStartInfo(tempFile);
                    psi.UseShellExecute = true;
                    Process.Start(psi);
                });

                await Processor.BitmapToFile(fileCode, key, decrypt,
                    pattern, extension, completed,
                    () => { this.InvokeEx(f => assignProcessing(false)); });
            } else if (btnRun.Text == "Finish") {
                try {
                    File.Delete(tempFile);
                    this.Close();
                } catch {
                    MessageBox.Show("Unable to delete temporary file. " +
                        "Is it closed yet?", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void assignProcessing(bool processing) {
            isProcessing = processing;

            this.InvokeEx(f => {
                btnRun.Enabled = !processing;
            });
        }
    }
}
