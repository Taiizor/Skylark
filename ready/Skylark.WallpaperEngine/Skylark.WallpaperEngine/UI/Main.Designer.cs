namespace Skylark.WallpaperEngine.UI
{
    partial class Main
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.crownButton1 = new ReaLTaiizor.Controls.CrownButton();
            this.crownButton2 = new ReaLTaiizor.Controls.CrownButton();
            this.crownButton3 = new ReaLTaiizor.Controls.CrownButton();
            this.crownButton4 = new ReaLTaiizor.Controls.CrownButton();
            this.SuspendLayout();
            // 
            // crownButton1
            // 
            this.crownButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crownButton1.Location = new System.Drawing.Point(12, 12);
            this.crownButton1.Name = "crownButton1";
            this.crownButton1.Padding = new System.Windows.Forms.Padding(5);
            this.crownButton1.Size = new System.Drawing.Size(184, 74);
            this.crownButton1.TabIndex = 0;
            this.crownButton1.TabStop = false;
            this.crownButton1.Text = "Design 1";
            this.crownButton1.Click += new System.EventHandler(this.CrownButton_Click);
            // 
            // crownButton2
            // 
            this.crownButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crownButton2.Location = new System.Drawing.Point(202, 12);
            this.crownButton2.Name = "crownButton2";
            this.crownButton2.Padding = new System.Windows.Forms.Padding(5);
            this.crownButton2.Size = new System.Drawing.Size(184, 74);
            this.crownButton2.TabIndex = 0;
            this.crownButton2.TabStop = false;
            this.crownButton2.Text = "Design 2";
            this.crownButton2.Click += new System.EventHandler(this.CrownButton_Click);
            // 
            // crownButton3
            // 
            this.crownButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crownButton3.Location = new System.Drawing.Point(392, 12);
            this.crownButton3.Name = "crownButton3";
            this.crownButton3.Padding = new System.Windows.Forms.Padding(5);
            this.crownButton3.Size = new System.Drawing.Size(184, 74);
            this.crownButton3.TabIndex = 1;
            this.crownButton3.TabStop = false;
            this.crownButton3.Text = "Design 3";
            this.crownButton3.Click += new System.EventHandler(this.CrownButton_Click);
            // 
            // crownButton4
            // 
            this.crownButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.crownButton4.Location = new System.Drawing.Point(582, 12);
            this.crownButton4.Name = "crownButton4";
            this.crownButton4.Padding = new System.Windows.Forms.Padding(5);
            this.crownButton4.Size = new System.Drawing.Size(184, 74);
            this.crownButton4.TabIndex = 2;
            this.crownButton4.TabStop = false;
            this.crownButton4.Text = "Design 4";
            this.crownButton4.Click += new System.EventHandler(this.CrownButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.crownButton4);
            this.Controls.Add(this.crownButton3);
            this.Controls.Add(this.crownButton2);
            this.Controls.Add(this.crownButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Skylark Wallpaper Engine";
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.CrownButton crownButton1;
        private ReaLTaiizor.Controls.CrownButton crownButton2;
        private ReaLTaiizor.Controls.CrownButton crownButton3;
        private ReaLTaiizor.Controls.CrownButton crownButton4;
    }
}