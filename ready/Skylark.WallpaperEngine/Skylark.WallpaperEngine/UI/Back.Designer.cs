namespace Skylark.WallpaperEngine.UI
{
    partial class Back
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Back));
            this.WallView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.WallView)).BeginInit();
            this.SuspendLayout();
            // 
            // WallView
            // 
            this.WallView.AllowExternalDrop = true;
            this.WallView.CreationProperties = null;
            this.WallView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.WallView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WallView.Location = new System.Drawing.Point(0, 0);
            this.WallView.Margin = new System.Windows.Forms.Padding(0);
            this.WallView.Name = "WallView";
            this.WallView.Size = new System.Drawing.Size(800, 450);
            this.WallView.TabIndex = 1;
            this.WallView.ZoomFactor = 1D;
            // 
            // Back
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WallView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Back";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Back";
            ((System.ComponentModel.ISupportInitialize)(this.WallView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WallView;
    }
}