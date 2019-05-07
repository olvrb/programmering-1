namespace ImageDrawForms
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
            this.button1                = new System.Windows.Forms.Button();
            this.pictureBox1            = new System.Windows.Forms.PictureBox();
            this.button2                = new System.Windows.Forms.Button();
            this.mirrorHorizontalButton = new System.Windows.Forms.Button();
            this.invertButton           = new System.Windows.Forms.Button();
            this.mirrorVerticalButton   = new System.Windows.Forms.Button();
            this.colorReplace           = new System.Windows.Forms.Button();
            this.colorReplaceWith       = new System.Windows.Forms.Button();
            this.applyColorButton       = new System.Windows.Forms.Button();
            this.undoButton             = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            this.button1.Location                               =  new System.Drawing.Point(14, 14);
            this.button1.Margin                                 =  new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name                                   =  "button1";
            this.button1.Size                                   =  new System.Drawing.Size(88, 27);
            this.button1.TabIndex                               =  0;
            this.button1.Text                                   =  "Select file...";
            this.button1.UseVisualStyleBackColor                =  true;
            this.button1.Click                                  += new System.EventHandler(this.button1_Click);
            this.pictureBox1.Anchor                             =  ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location                           =  new System.Drawing.Point(425, 33);
            this.pictureBox1.Margin                             =  new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name                               =  "pictureBox1";
            this.pictureBox1.Size                               =  new System.Drawing.Size(495, 472);
            this.pictureBox1.TabIndex                           =  2;
            this.pictureBox1.TabStop                            =  false;
            this.pictureBox1.DoubleClick                        += new System.EventHandler(this.PictureBox1_DoubleClick);
            this.button2.Location                               =  new System.Drawing.Point(110, 12);
            this.button2.Margin                                 =  new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name                                   =  "button2";
            this.button2.Size                                   =  new System.Drawing.Size(88, 27);
            this.button2.TabIndex                               =  3;
            this.button2.Text                                   =  "Save file...";
            this.button2.UseVisualStyleBackColor                =  true;
            this.button2.Click                                  += new System.EventHandler(this.button2_Click);
            this.mirrorHorizontalButton.Location                =  new System.Drawing.Point(14, 58);
            this.mirrorHorizontalButton.Margin                  =  new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mirrorHorizontalButton.Name                    =  "mirrorHorizontalButton";
            this.mirrorHorizontalButton.Size                    =  new System.Drawing.Size(126, 27);
            this.mirrorHorizontalButton.TabIndex                =  4;
            this.mirrorHorizontalButton.Text                    =  "Mirror Horizontal";
            this.mirrorHorizontalButton.UseVisualStyleBackColor =  true;
            this.mirrorHorizontalButton.Click                   += new System.EventHandler(this.MirrorButton_Click);
            this.invertButton.Location                          =  new System.Drawing.Point(14, 125);
            this.invertButton.Margin                            =  new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.invertButton.Name                              =  "invertButton";
            this.invertButton.Size                              =  new System.Drawing.Size(88, 27);
            this.invertButton.TabIndex                          =  5;
            this.invertButton.Text                              =  "Invert";
            this.invertButton.UseVisualStyleBackColor           =  true;
            this.invertButton.Click                             += new System.EventHandler(this.InvertButton_Click);
            this.mirrorVerticalButton.Location                  =  new System.Drawing.Point(14, 91);
            this.mirrorVerticalButton.Margin                    =  new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mirrorVerticalButton.Name                      =  "mirrorVerticalButton";
            this.mirrorVerticalButton.Size                      =  new System.Drawing.Size(126, 27);
            this.mirrorVerticalButton.TabIndex                  =  6;
            this.mirrorVerticalButton.Text                      =  "Mirror Vertical";
            this.mirrorVerticalButton.UseVisualStyleBackColor   =  true;
            this.mirrorVerticalButton.Click                     += new System.EventHandler(this.MirrorVerticalButton_Click);
            this.colorReplace.Location                          =  new System.Drawing.Point(14, 190);
            this.colorReplace.Margin                            =  new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colorReplace.Name                              =  "colorReplace";
            this.colorReplace.Size                              =  new System.Drawing.Size(126, 27);
            this.colorReplace.TabIndex                          =  7;
            this.colorReplace.Text                              =  "Color to replace";
            this.colorReplace.UseVisualStyleBackColor           =  true;
            this.colorReplace.Click                             += new System.EventHandler(this.ColorReplace_Click);
            this.colorReplaceWith.Location                      =  new System.Drawing.Point(147, 190);
            this.colorReplaceWith.Margin                        =  new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.colorReplaceWith.Name                          =  "colorReplaceWith";
            this.colorReplaceWith.Size                          =  new System.Drawing.Size(141, 27);
            this.colorReplaceWith.TabIndex                      =  8;
            this.colorReplaceWith.Text                          =  "Color to replace with";
            this.colorReplaceWith.UseVisualStyleBackColor       =  true;
            this.colorReplaceWith.Click                         += new System.EventHandler(this.ColorReplaceWith_Click);
            this.applyColorButton.Location                      =  new System.Drawing.Point(295, 190);
            this.applyColorButton.Margin                        =  new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.applyColorButton.Name                          =  "applyColorButton";
            this.applyColorButton.Size                          =  new System.Drawing.Size(88, 27);
            this.applyColorButton.TabIndex                      =  9;
            this.applyColorButton.Text                          =  "Apply";
            this.applyColorButton.UseVisualStyleBackColor       =  true;
            this.applyColorButton.Click                         += new System.EventHandler(this.ApplyColorButton_Click);
            this.undoButton.Location                            =  new System.Drawing.Point(15, 479);
            this.undoButton.Margin                              =  new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.undoButton.Name                                =  "undoButton";
            this.undoButton.Size                                =  new System.Drawing.Size(88, 27);
            this.undoButton.TabIndex                            =  10;
            this.undoButton.Text                                =  "Undo";
            this.undoButton.UseVisualStyleBackColor             =  true;
            this.undoButton.Click                               += new System.EventHandler(this.UndoButton_Click);
            this.AutoScaleDimensions                            =  new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode                                  =  System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize                                     =  new System.Drawing.Size(933, 519);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.applyColorButton);
            this.Controls.Add(this.colorReplaceWith);
            this.Controls.Add(this.colorReplace);
            this.Controls.Add(this.mirrorVerticalButton);
            this.Controls.Add(this.invertButton);
            this.Controls.Add(this.mirrorHorizontalButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name   = "Form1";
            this.Text   = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mirrorHorizontalButton;
        private System.Windows.Forms.Button invertButton;
        private System.Windows.Forms.Button mirrorVerticalButton;
        private System.Windows.Forms.Button colorReplace;
        private System.Windows.Forms.Button colorReplaceWith;
        private System.Windows.Forms.Button applyColorButton;
        private System.Windows.Forms.Button undoButton;
    }
}

