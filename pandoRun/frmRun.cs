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
        private void btnRun_Click(object sender, EventArgs e) {
            if (btnRun.Text == "Run") {
                // Control values.
                bool r = rdbR.Checked;
                bool g = rdbG.Checked;
                bool b = rdbB.Checked;

                bool decrypt = chkDecrypt.Checked;
                string key = txtKey.Text;
                string extension = txtExt.Text;

                assignProcessing(true);

                Thread processor = new Thread(f => {
                    // StringBuilder for reading the string. (Base64 of File)
                    StringBuilder reader = new StringBuilder();

                    // Bitmap reader of the file.
                    LockBitmap lRead = new LockBitmap(fileCode);

                    lRead.LockBits();
                    for (int y = 0; y < lRead.Height; y++) {
                        for (int x = 0; x < lRead.Width; x++) {
                            char c = InputProcessing.ColorToChar(
                                lRead.GetPixel(x, y), r, g, b);
                            reader.Append(c);
                        }
                    }
                    lRead.UnlockBits();

                    // Decrypt (if necessary) and read file to byte array.
                    byte[] file = InputProcessing.InValue(reader.ToString(),
                        key, decrypt);

                    // Write file down.
                    tempFile = Path.GetTempFileName() + "." + extension;
                    File.WriteAllBytes(tempFile, file);

                    this.InvokeEx(c => {
                        btnRun.Text = "Finish";
                        assignProcessing(false);
                    });

                    var psi = new ProcessStartInfo(tempFile);
                    psi.UseShellExecute = true;

                    Process.Start(psi);
                });
                processor.Start();
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
