using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageDrawForms
{

    // All methods except save return this to allow method chaining, LINQ style.
    class CImage
    {
        public enum Effects
        {
            HorizontalMirror,
            VerticalMirror,
            Invert
        }

        // Helper method to add multiple effects at once.
        // This provides another way of applying effects besides method chaining.
        public CImage ApplyEffects(Effects[] effects)
        {
            foreach (Effects efc in effects)
            {
                switch (efc)
                {
                    case Effects.HorizontalMirror:
                        this.Mirror(ImageProcessor.MirrorType.Horizontal);
                        break;
                    case Effects.VerticalMirror:
                        this.Mirror(ImageProcessor.MirrorType.Vertical);
                        break;
                    case Effects.Invert:
                        this.Invert();
                        break;
                    default:
                        break;
                }
            }
            return this;
        }



        public Bitmap Image { get; set; }

        public CImage()
        {
            try
            {
                this.Image = new Bitmap(Utils.GetFileFromPrompt());
            }
            catch (Exception)
            {
                MessageBox.Show("File not found or invalid image file.");
            }
        }
        public CImage Save()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Image.Save(dialog.FileName);
            }
            return this;
        }

        public CImage Invert()
        {
            this.Image = this.Image.Invert();
            return this;
        }
        public CImage Mirror(ImageProcessor.MirrorType type)
        {
            switch (type)
            {
                case ImageProcessor.MirrorType.Vertical:
                    this.Image = this.Image.Mirror(ImageProcessor.MirrorType.Vertical);
                    break;
                case ImageProcessor.MirrorType.Horizontal:
                    this.Image = this.Image.Mirror(ImageProcessor.MirrorType.Horizontal);
                    break;
                default:
                    break;
            }
            return this;
        }

        public CImage Replace(Color oldColor, Color newColor)
        {
            this.Image.Replace(oldColor, newColor);
            return this;
        }
    }
}
