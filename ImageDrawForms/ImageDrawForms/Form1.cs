using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageDrawForms
{
    public partial class Form1 : Form
    {

        private CImage _image { get; set; }

        private Color _oldColor { get; set; }
        private Color _newColor { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This will also open a file dialog, see constructor.

            this._image = new CImage();
            // In case we're loading a huge file...
            pictureBox1.CreateGraphics().DrawString("Loading...", new Font("Arial", 14), new SolidBrush(Color.Black), 0, 0);

            // Non-blocking, to stop the UI from freezing.
            Utils.DispatchAsync(() => updateImage());            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this._image == null)
            {
                imageIsNull();
                return;
            }
            this._image.Save();
        }

        private void imageIsNull()
        {
            MessageBox.Show("Please select an image before proceeding.");
        }

        private void updateImage()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = _image.Image;
        }

        private void MirrorButton_Click(object sender, EventArgs e)
        {
            this._image.ApplyEffects(new[] { CImage.Effects.HorizontalMirror });
            this.updateImage();
        }

        private void InvertButton_Click(object sender, EventArgs e)
        {
            // Since we're inverting the image manually, calling it will be blocking.
            Utils.DispatchAsync(() =>
            {
                this._image.ApplyEffects(new[] { CImage.Effects.Invert });
                this.updateImage();
            });
        }

        private void MirrorVerticalButton_Click(object sender, EventArgs e)
        {
            this._image.ApplyEffects(new[] { CImage.Effects.VerticalMirror });
            this.updateImage();
        }

        private void ColorReplace_Click(object sender, EventArgs e)
        {
            this._oldColor = Utils.GetColorFromPrompt();
        }

        private void ColorReplaceWith_Click(object sender, EventArgs e)
        {
            this._newColor = Utils.GetColorFromPrompt();
        }

        private void ApplyColorButton_Click(object sender, EventArgs e)
        {
            Utils.DispatchAsync(() =>
            {
                this._image.Replace(this._oldColor, this._newColor);
                this.updateImage();
            });
        }
    }
}
