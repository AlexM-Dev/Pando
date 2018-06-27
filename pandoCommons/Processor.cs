using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pandoCommons {
    public class Processor {
        public async static Task FileToBitmap(bool encrypt, string pKey, bool r, bool g, bool b, byte[] fileCode, Bitmap img, Action<Bitmap> onComplete) {
            string key = encrypt ? pKey : "";

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

            await Task.Run(() => {
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

                onComplete.Invoke(output);
                return Task.CompletedTask;
            });
        }
    }
}
