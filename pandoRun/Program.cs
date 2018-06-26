using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace pandoRun {
    class Program {
        static void Main(string[] args) {
            if (args.Length == 0) return;

            string file = args[0];

            if (!File.Exists(file)) return;

            Application.EnableVisualStyles();
            try {
                new frmRun(Image.FromFile(file) as Bitmap,
                    file).ShowDialog();
            } catch {
                // Meh.
            }
        }
    }
}
