using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageDrawForms {
    // All methods except save return this to allow method chaining, LINQ style.
    internal class CImage {
        public enum Effects {
            HorizontalMirror,
            VerticalMirror,
            Invert
        }

        public CImage() {
            try {
                Image = new Bitmap(Utils.GetFileFromPrompt());
            }
            catch (Exception) {
                MessageBox.Show("File not found or invalid image file.");
            }
        }

        private List<CImage> History { get; } = new List<CImage>();
        private int          Current { get; set; }


        public Bitmap Image { get; set; }

        // Helper method to add multiple effects at once.
        // This provides another way of applying effects besides method chaining.
        public CImage ApplyEffects(Effects[] effects) {
            History.Add(this);
            Current++;
            foreach (Effects efc in effects) {
                switch (efc) {
                    case Effects.HorizontalMirror:
                        Mirror(ImageProcessor.MirrorType.Horizontal);
                        break;
                    case Effects.VerticalMirror:
                        Mirror(ImageProcessor.MirrorType.Vertical);
                        break;
                    case Effects.Invert:
                        Invert();
                        break;
                }
            }

            return this;
        }

        public CImage Undo() {
            if (Current - 1 <= 0) {
                return this;
            }

            Current--;
            Image = History[Current].Image;
            return this;
        }

        public CImage Save() {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                Image.Save(dialog.FileName);
            }

            return this;
        }

        private CImage Invert() {
            Image = Image.Invert();
            return this;
        }

        private CImage Mirror(ImageProcessor.MirrorType type) {
            switch (type) {
                case ImageProcessor.MirrorType.Vertical:
                    Image = Image.Mirror(ImageProcessor.MirrorType.Vertical);
                    break;
                case ImageProcessor.MirrorType.Horizontal:
                    Image = Image.Mirror(ImageProcessor.MirrorType.Horizontal);
                    break;
            }

            return this;
        }

        public CImage Replace(Color oldColor, Color newColor) {
            Image.Replace(oldColor, newColor);
            return this;
        }
    }
}