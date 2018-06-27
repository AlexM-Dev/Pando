using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using pandoCommons;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace pando {
    public partial class frmPando : Form {
        private byte[] fileCode;
        private string fileName;
        private Bitmap img;

        private bool isProcessing = false;

        public frmPando(byte[] fileCode, string fName) {
            InitializeComponent();

            this.fileCode = fileCode;
            this.fileName = fName;

            thcMain.InitFont();
        }

        private void frmPando_FormClosing(object sender, FormClosingEventArgs e) {
            if (isProcessing) {
                e.Cancel = true;
            }
        }

        private void assignProcessing(bool processing) {
            isProcessing = processing;

            this.InvokeEx(f => {
                btnSave.Enabled = !processing;
                btnCancel.Enabled = !processing;
            });
        }

        private void chkEncrypt_CheckedChanged(object sender) {
            txtKey.Enabled = chkEncrypt.Checked;
        }

        private void btnSelectImage_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    try {
                        var img = Image.FromFile(ofd.FileName);
                        this.img = img as Bitmap;
                    } catch {
                        MessageBox.Show("An error occurred while" +
                            " processing the file!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e) {
            bool encrypt = chkEncrypt.Checked;
            string key = encrypt ? txtKey.Text : "";

            bool r = rdbR.Checked;
            bool g = rdbG.Checked;
            bool b = rdbB.Checked;

            assignProcessing(true);

            var completed = new Action<Bitmap>(s => {
                OutputProcessing.Save(fileName, s, false);
                assignProcessing(false);
                this.InvokeEx(c => this.Close());
            });

            await Processor.FileToBitmap(encrypt,
                txtKey.Text, r, g, b, fileCode, img, completed);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            var mbox = MessageBox.Show("Are you sure you wish to cancel?",
                "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mbox == DialogResult.Yes) this.Close();
        }
    }
}
