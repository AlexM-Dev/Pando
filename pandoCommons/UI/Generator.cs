using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;

namespace pandoCommons {
    class Generator {
        private static Image[] images = new Image[100];

        private static PrivateFontCollection pfc
            = new PrivateFontCollection();

        public static FontFamily GetDiscordFont() {
            if (pfc.Families.Count() > 0 && pfc.Families[0] != null)
                return pfc.Families[0];

            // Load the font file, if not loaded.

            string resource = "pandoCommons.DiscordTitle.otf";
            Stream fs = Assembly.GetExecutingAssembly().
                GetManifestResourceStream(resource);
            IntPtr data = Marshal.AllocCoTaskMem((int)fs.Length);
            byte[] byteData = new byte[fs.Length];
            fs.Read(byteData, 0, (int)fs.Length);
            Marshal.Copy(byteData, 0, data, (int)fs.Length);
            pfc.AddMemoryFont(data, (int)fs.Length);
            fs.Close();
            Marshal.FreeCoTaskMem(data);

            return pfc.Families[0];
        }

        public static Image GenerateImage(int i) {
            int index = i;
            if (i >= images.Length) i = 99;

            Image im = new Bitmap(24, 24);
            if (images[index] == null) {
                // Generate image.
                Graphics g = Graphics.FromImage(im);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillEllipse(new SolidBrush(Color.FromArgb(114, 137, 218)),
                    new Rectangle(0, 0, 23, 23));
                //g.Clear(Color.FromArgb(114, 137, 218));

                Font f = new Font(GetDiscordFont(), 12);
                var size = g.MeasureString(index.ToString(), f);
                var point = new PointF((24 - size.Width) / 2,
                    (24 - size.Height) / 2);

                g.DrawString(index.ToString(), f, Brushes.White, point);
            } else im = images[index];

            return im;
        }
    }
}
