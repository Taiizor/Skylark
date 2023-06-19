using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;

namespace Skylark.WallpaperEngine.UI
{
    public partial class Main : CrownForm
    {
        private Form Engine = null;

        private readonly string Uri1 = "https://www.vegalya.com/3/0wj1biqk.f41/fluid.html";
        private readonly string Uri2 = "https://www.vegalya.com/3/iqdvd4pt.jyo/triangle.html";
        private readonly string Uri3 = "https://www.vegalya.com/3/lgz4xpht.sjn/index.html";
        private readonly string Uri4 = "https://www.vegalya.com/3/mrn3a0m5.0lk/index.html";

        public Main()
        {
            InitializeComponent();
        }

        private void CrownButton_Click(object sender, EventArgs e)
        {
            if (Engine == null)
            {
                switch ((sender as CrownButton).Text)
                {
                    case "Design 1":
                        Engine = new Back(Uri1, true);
                        Engine.Show();
                        break;
                    case "Design 2":
                        Engine = new Back(Uri2, true);
                        Engine.Show();
                        break;
                    case "Design 3":
                        Engine = new Back(Uri3, false);
                        Engine.Show();
                        break;
                    case "Design 4":
                        Engine = new Back(Uri4, false);
                        Engine.Show();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Engine.Dispose();
                Engine = null;

                CrownButton_Click(sender, e);
            }
        }
    }
}