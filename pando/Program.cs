using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pando {
    class Program {
        [STAThread()]
        static void Main(string[] args) {
            if (args.Length == 0) return;

            string file = args[0];

            if (!File.Exists(file)) return;

            Application.EnableVisualStyles();
            new frmPando(File.ReadAllBytes(file), 
                file).ShowDialog();
        }
    }
}
