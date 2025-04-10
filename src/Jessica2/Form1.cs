using Skylark.Enum;
using Skylark.Wing;

namespace Jessica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form WF = new WallpaperForm();
            WF.Show();
        }
    }

    public class WallpaperForm : Form
    {
        public WallpaperForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.TopMost = false;

            this.Size = Screen.PrimaryScreen.Bounds.Size;

            this.Opacity = 1.0;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Engine.WallpaperForm(this, 0, ScreenType.DisplayBound);
        }
    }
}