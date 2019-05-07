namespace colorAvg
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.openDir      = new System.Windows.Forms.Button();
            this.dispBox      = new System.Windows.Forms.PictureBox();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.progressBar  = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize) (this.dispBox)).BeginInit();
            this.SuspendLayout();
            this.openDir.Location                =  new System.Drawing.Point(13, 13);
            this.openDir.Name                    =  "openDir";
            this.openDir.Size                    =  new System.Drawing.Size(129, 23);
            this.openDir.TabIndex                =  0;
            this.openDir.Text                    =  "Open directory";
            this.openDir.UseVisualStyleBackColor =  true;
            this.openDir.Click                   += new System.EventHandler(this.OpenDir_Click);
            this.dispBox.Anchor                  =  ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.dispBox.Location                =  new System.Drawing.Point(148, 12);
            this.dispBox.Name                    =  "dispBox";
            this.dispBox.Size                    =  new System.Drawing.Size(640, 397);
            this.dispBox.TabIndex                =  1;
            this.dispBox.TabStop                 =  false;
            this.loadingLabel.AutoSize           =  true;
            this.loadingLabel.Location           =  new System.Drawing.Point(13, 43);
            this.loadingLabel.Name               =  "loadingLabel";
            this.loadingLabel.Size               =  new System.Drawing.Size(54, 13);
            this.loadingLabel.TabIndex           =  2;
            this.loadingLabel.Text               =  "Loading...";
            this.progressBar.Anchor              =  ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location            =  new System.Drawing.Point(12, 415);
            this.progressBar.Name                =  "progressBar";
            this.progressBar.Size                =  new System.Drawing.Size(776, 23);
            this.progressBar.TabIndex            =  3;
            this.AutoScaleDimensions             =  new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode                   =  System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize                      =  new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.dispBox);
            this.Controls.Add(this.openDir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.dispBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button openDir;
        private System.Windows.Forms.PictureBox dispBox;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

