using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pandoCommons {
    public class OutputProcessing {
        public static void Save(string original, Bitmap image, bool open) {
            int index = original.LastIndexOf('.');
            string name = original.Substring(0, index);
            string ext = original.Substring(index + 1, original.Length - index - 1);
            string fn = name + "_" + ext + ".png";
            image.Save(fn, System.Drawing.Imaging.ImageFormat.Png);

            if (open) {
                Process.Start(fn);
            }
        }
    }
}
