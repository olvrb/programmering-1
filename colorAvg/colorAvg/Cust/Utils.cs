using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace colorAvg.Cust {
    internal static class Utils {
        public static string[] GetFolderFromPrompt() {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                return Directory.GetFiles(dialog.SelectedPath);
            }

            return null;
        }

        public static string[] GetFilesInDirectory(string dir, bool recursive) {
            if (!recursive) return Directory.GetFiles(dir);
            
            List<string> files = new List<string>();

            foreach (string directory in Directory.GetDirectories(dir)) {
                files.AddRange(Directory.GetFiles(directory));

                GetFilesInDirectory(dir, recursive);
            }

            return files.ToArray();
        }

        // Get the color of the entire bitmap
        // To do this, we have three lists, with the pixel's r, g, and b values.
        // From there, we iterate through every single pixel and fill the lists.
        // Finally, get the average of each array and return a color, as expected.
        public static Color Average(this Bitmap bmp) {
            
            List<int> rarr = new List<int>();
            List<int> garr = new List<int>();
            List<int> barr = new List<int>();

            for (int i = 0; i < bmp.Width; i++) {
                for (int j = 0; j < bmp.Height; j++) {
                    Color pxl = bmp.GetPixel(i, j);

                    rarr.Add(pxl.R);
                    garr.Add(pxl.G);
                    barr.Add(pxl.B);
                }
            }

            return Color.FromArgb((int) rarr.Average(), (int) garr.Average(), (int) barr.Average());
        }

        // ReSharper disable once PossibleMultipleEnumeration
        /// This is a more optimized, cleaner, 
        /// and better way of doing something similar to <see cref="Average(Bitmap)"/>.
        /// LINQ ftw.
        public static Color Average(this IEnumerable<Color> colors) {
           
            return Color.FromArgb(
                                  (int) colors
                                        .Select(x => (int) x.R)
                                        .Average(),
                                  (int) colors
                                        .Select(x => (int) x.G)
                                        .Average(),
                                  (int) colors
                                        .Select(x => (int) x.B)
                                        .Average()
                                 );
        }
    }
}