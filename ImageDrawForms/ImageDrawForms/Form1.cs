using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageDrawForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private CImage _image { get; set; }

        private Color _oldColor { get; set; }
        private Color _newColor { get; set; }

        private void button1_Click(object sender, EventArgs e) {
            // This will also open a file dialog, see constructor.
            _image = new CImage();

            // In case we're loading a huge file...
            pictureBox1.CreateGraphics().DrawString("Loading...", new Font("Arial", 14), new SolidBrush(Color.Black), 0, 0);

            // Non-blocking, to stop the UI from freezing.
            Utils.DispatchAsync(() => UpdateImage());
        }

        private void button2_Click(object sender, EventArgs e) {
            if (_image == null) {
                imageIsNull();
                return;
            }

            _image.Save();
        }

        private void imageIsNull() {
            MessageBox.Show("Please select an image before proceeding.");
        }

        private void UpdateImage() {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image    = _image.Image;
        }

        private void MirrorButton_Click(object sender, EventArgs e) {
            _image.ApplyEffects(new[] {CImage.Effects.HorizontalMirror});
            UpdateImage();
        }

        private void InvertButton_Click(object sender, EventArgs e) {
            // Since we're inverting the image manually, calling it will be blocking.
            Utils.DispatchAsync(() => {
                _image.ApplyEffects(new[] {CImage.Effects.Invert});
                UpdateImage();
            });
        }

        private void MirrorVerticalButton_Click(object sender, EventArgs e) {
            _image.ApplyEffects(new[] {CImage.Effects.VerticalMirror});
            UpdateImage();
        }

        private void ColorReplace_Click(object sender, EventArgs e) {
            _oldColor = Utils.GetColorFromPrompt();
        }

        private void ColorReplaceWith_Click(object sender, EventArgs e) {
            _newColor = Utils.GetColorFromPrompt();
        }

        private void ApplyColorButton_Click(object sender, EventArgs e) {
            Utils.DispatchAsync(() => {
                _image.Replace(_oldColor, _newColor);
                UpdateImage();
            });
        }

        private void UndoButton_Click(object sender, EventArgs e) {
            Utils.DispatchAsync(() => {
                _image.Undo();
                UpdateImage();
            });
        }

        private void PictureBox1_DoubleClick(object sender, EventArgs e) {
            int  zoom    = 2;
            Size newSize = new Size(_image.Image.Width * zoom, _image.Image.Height * zoom);
            _image.Image = new Bitmap(_image.Image, newSize);
        }
    }
}