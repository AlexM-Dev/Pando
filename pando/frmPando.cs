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

        private void btnSave_Click(object sender, EventArgs e) {
            bool encrypt = chkEncrypt.Checked;
            string key = encrypt ? txtKey.Text : "";

            bool r = rdbR.Checked;
            bool g = rdbG.Checked;
            bool b = rdbB.Checked;

            // Encrypts file if needed to be, and returns a base64 value.
            string file = InputProcessing.OutValue(fileCode, key, encrypt);

            // We need to normalise the length of the byte array.
            // I.e., we need to add spaces to get to the closest square number.
            int len = (int)Math.Sqrt(file.Length) + 1;
            len = (len * len) - file.Length;

            // Buffer the string to make it square.
            file += new string(' ', len);

            // This is the final width and height of the image.
            int dim = (int)Math.Sqrt(file.Length);

            // Should we layer an image?
            bool useBmp = img != null;

            assignProcessing(true);

            // If we layer the image, stretch the image to the
            // dimensions of 'dim' x 'dim'. If not, new image.
            Bitmap bmp = useBmp ?
                InputProcessing.ResizeImage(img, new Size(dim, dim), false)
                as Bitmap : new Bitmap(dim, dim);
            Bitmap output = new Bitmap(dim, dim);

            // Lock our bitmaps for faster processing.
            LockBitmap lBmp = new LockBitmap(bmp);
            LockBitmap lOut = new LockBitmap(output);
            lBmp.LockBits();
            lOut.LockBits();

            Thread processor = new Thread(f => {
                for (int i = 0; i < file.Length; i++) {
                    // We need a formula.
                    // i % a (i MOD a) = gets the remainder - index in the line.
                    // i / a (i DIV a) = gets the division - line index.
                    int x = i % dim;
                    int y = i / dim;

                    // Convert character to color.
                    // Basically:
                    //      -> Character in file string.
                    //      -> What channel (r, g, b)
                    //      -> Pixel of image (being used?).
                    var c = InputProcessing.CharToColor(file[i], r, g, b,
                         (useBmp ? lBmp.GetPixel(x, y) : (Color?)null));

                    // Set converted color.
                    lOut.SetPixel(x, y, c);
                }

                // Open images.
                lBmp.UnlockBits();
                lOut.UnlockBits();

                // Save file and open, then set finished.
                OutputProcessing.Save(fileName, output, false);
                assignProcessing(false);

                this.InvokeEx(c => this.Close());
            });
            processor.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            var mbox = MessageBox.Show("Are you sure you wish to cancel?",
                "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mbox == DialogResult.Yes) this.Close();
        }
    }
}
