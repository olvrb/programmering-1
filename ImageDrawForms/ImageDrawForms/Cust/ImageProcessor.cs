﻿using System.Drawing;

namespace ImageDrawForms {
    internal static class ImageProcessor {
        public enum MirrorType {
            Vertical,
            Horizontal
        }

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
                case MirrorType.Vertical:
                    image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    break;
                case MirrorType.Horizontal:
                    image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
            }

            return image;
        }

        public static Bitmap Replace(this Bitmap image, Color _old, Color _new) {
            // Iterate over all pixels.
            for (int i = 0; i < image.Width; i++) {
                for (int j = 0; j < image.Height; j++) {
                    Color pxl = image.GetPixel(i, j);
                    if (colorsAreClose(pxl, _old)) {
                        image.SetPixel(i, j, _new);
                    }
                }
            }

            return image;
        }

        // https://stackoverflow.com/a/25168506/8611114
        private static bool colorsAreClose(Color a, Color z, int threshold = 50) {
            int r = a.R - z.R;
            int g = a.G - z.G;
            int b = a.B - z.B;
            return r * r + g * g + b * b <= threshold * threshold;
        }
    }
}