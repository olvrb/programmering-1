using System.Drawing;

namespace ImageDrawForms {
    internal static class ImageProcessor {
        public enum MirrorType {
            Vertical,
            Horizontal
        }
        
        /// Pseudocode for <see cref="Invert"/>
        ///
        /// för varje pixel i image:
        ///     hämta pixel vid position x, y
        ///     sätt pixel till motsatsen med hjälp av xor
        /// returnera image


        // Extension methods!
        public static Bitmap Invert(this Bitmap image) {
            // We want to iterate over every single pixel
            for (int i = 0; i < image.Width; i++) {
                for (int j = 0; j < image.Height; j++) {
                    Color pixel = image.GetPixel(i, j);

                    // Invert color at pixel i, j...
                    image.SetPixel(i, j, Color.FromArgb(pixel.ToArgb() ^ 0xffffff));
                }
            }
            
            return image;
        }
        

        public static Bitmap Mirror(this Bitmap image, MirrorType type) {
            switch (type) {
                case MirrorType.Vertical: {
                    image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    break;
                }

                case MirrorType.Horizontal: {
                    image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
                }
            }

            return image;
        }
        
        /// Pseudocode for <see cref="Replace"/>
        /// for varje pixel i image:
        ///     hämta pixel vid x, y
        ///     om färg är nära till _old:
        ///         sätt hämtad pixel till _new
        /// returnera image
        ///        

        public static Bitmap Replace(this Bitmap image, Color _old, Color _new) {
            // Iterate over all pixels.
            for (int i = 0; i < image.Width; i++) {
                for (int j = 0; j < image.Height; j++) {
                    Color pxl = image.GetPixel(i, j);
                    if (ColorsAreClose(pxl, _old)) {
                        image.SetPixel(i, j, _new);
                    }
                }
            }

            return image;
        }

        // https://stackoverflow.com/a/25168506/8611114
        private static bool ColorsAreClose(Color a, Color z, int threshold = 175) {
            int r = a.R - z.R;
            int g = a.G - z.G;
            int b = a.B - z.B;
            return r * r + g * g + b * b <= threshold * threshold;
        }
    }
}