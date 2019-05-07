using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using colorAvg.Cust;

namespace colorAvg {
    public partial class Form1 : Form {
        private readonly BackgroundWorker _worker = new BackgroundWorker();

        public Form1() {
            InitializeComponent();
            loadingLabel.Hide();
        }

        private void OpenDir_Click(object sender, EventArgs e) {
            string[] files = Utils.GetFolderFromPrompt();
            if (files is null) {
                return;
            }
            
            // Initial setup for progress bar.
            loadingLabel.Show();
            progressBar.Maximum = files.Length;
            progressBar.Value = progressBar.Minimum;

            _worker.DoWork += (s, q) => {
                List<Color> colors = new List<Color>();
                foreach (string file in files) {
                    Bitmap bmp  = new Bitmap(file);
                    Color  test = bmp.Average();
                    colors.Add(test);
                    Invoke(new Action(() => { progressBar.Value++; }));
                }

                Invoke(new Action(() => {
                    dispBox.CreateGraphics()
                           .FillRectangle(
                                          new SolidBrush(colors.Average()),
                                          new Rectangle(0, 0, dispBox.Width, dispBox.Height)
                                         );
                }));
            };

            _worker.RunWorkerCompleted += (s, q) => { Invoke(new Action(() => { loadingLabel.Hide(); })); };

            _worker.RunWorkerAsync();
        }
    }
}