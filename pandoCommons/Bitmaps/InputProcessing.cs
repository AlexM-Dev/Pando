using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pandoCommons {
    public class InputProcessing {
        private static Random random = new Random();
        public static string OutValue(byte[] byteFile, string key, bool enc) {
            string baseFile = Convert.ToBase64String(byteFile);

            baseFile = enc ? Encryption.Encrypt(baseFile, key) : baseFile;
            return baseFile;
        }

        public static byte[] InValue(string encoded, string key, bool enc) {
            string input = encoded.Trim(); // Remove any buffer.

            if (enc) input = Encryption.Decrypt(input, key);

            return Convert.FromBase64String(input);
        }

        public static Color CharToColor(char c, bool r, bool g, bool b, Color? p2 = null) {
            // This function should only be called with radiobutton
            // outputs. But oh well.

            Color cl;

            // Check which channel to use for data.
            // Basically; order = r, then g, then b.
            // If none selected, then same as c. (gray)
            if (p2 == null) {
                // Substitute for random values.
                int r1 = random.Next(26) * 10;
                int r2 = random.Next(26) * 10;

                cl = r ? Color.FromArgb(c, r1, r2) :
                     g ? Color.FromArgb(r1, c, r2) :
                     b ? Color.FromArgb(r1, r2, c) :
                     Color.FromArgb(c, c, c);
            } else {
                // Substitute for existing image pixels.
                Color p2c = p2.Value;
                cl = r ? Color.FromArgb(c, p2c.G, p2c.B) :
                     g ? Color.FromArgb(p2c.R, c, p2c.B) :
                     b ? Color.FromArgb(p2c.R, p2c.G, c) :
                     Color.FromArgb(c, c, c);
            }

            return cl;
        }

        public static char ColorToChar(Color c, bool r, bool g, bool b) {
            int i = r ? c.R :
                g ? c.G :
                b ? c.B : 0;
            return (char)i;
        }

        // https://www.codeproject.com/Articles/191424/Resizing-an-Image-On-The-Fly-using-NET
        public static Image ResizeImage(Image image, Size size,
            bool preserveAspectRatio = true) {
            int newWidth;
            int newHeight;
            if (preserveAspectRatio) {
                int originalWidth = image.Width;
                int originalHeight = image.Height;
                float percentWidth = (float)size.Width / (float)originalWidth;
                float percentHeight = (float)size.Height / (float)originalHeight;
                float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
                newWidth = (int)(originalWidth * percent);
                newHeight = (int)(originalHeight * percent);
            } else {
                newWidth = size.Width;
                newHeight = size.Height;
            }
            Image newImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphicsHandle = Graphics.FromImage(newImage)) {
                graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        public static List<Tuple<bool, bool, bool>> GetChannels(string pattern, string data) {
            var channels = new List<Tuple<bool, bool, bool>>();
            int len = pattern.Length;
            pattern = pattern.ToUpper();
            for (int i = 0; i < data.Length; i++) {
                char c = pattern[i % len];
                channels.Add(new Tuple<bool, bool, bool>(
                    c == 'R', c == 'G', c == 'B'));
            }
            return channels;
        }

        public static Tuple<bool, bool, bool> GetChannel(string pattern, int pos) {
            int len = pattern.Length;
            char c = pattern[pos % len];
            return new Tuple<bool, bool, bool>(c == 'R', c == 'G', c == 'B');
        }
    }
}
