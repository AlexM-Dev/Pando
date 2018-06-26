using pandoCommons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pandoRun {
    public partial class frmRun : Form {
        private Bitmap fileCode;
        private string fileName;
        private Bitmap img;

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

        private void btnRun_Click(object sender, EventArgs e) {
            StringBuilder reader = new StringBuilder();

            LockBitmap lRead = new LockBitmap(fileCode);

            for (int y = 0; y < lRead.Height; y++) {
                for (int x = 0; x < lRead.Width; x++) {
                    
                }
            }
        }
    }
}
