using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Windows;
using System.Windows.Forms.Integration;

namespace Skylark.WallpaperEngine.UI
{
    public partial class Main : CrownForm
    {
        private Window Engine = null;

        private readonly string Uri1 = "https://www.vegalya.com/3/0wj1biqk.f41/fluid.html";
        private readonly string Uri2 = "https://www.vegalya.com/3/iqdvd4pt.jyo/triangle.html";
        private readonly string Uri3 = "https://www.vegalya.com/3/lgz4xpht.sjn/index.html";
        private readonly string Uri4 = "https://www.vegalya.com/3/mrn3a0m5.0lk/index.html";
        private readonly string Uri5 = "https://www.vegalya.com/3/rtnm43pj.wyl/index.html";
        private readonly string Uri6 = "https://www.vegalya.com/3/xn0quq52.bq2/index.html";
        private readonly string Uri7 = "https://www.vegalya.com/3/wxqfmbno.3vk/index.html";
        private readonly string Uri8 = "https://www.vegalya.com/3/ptpcxvcd.hlz/index.html";
        private readonly string Uri9 = "https://www.vegalya.com/3/nps35xrp.5eh/jellyfish.html";

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
                        ElementHost.EnableModelessKeyboardInterop(Engine);
                        Engine.Show();
                        break;
                    case "Design 2":
                        Engine = new Back(Uri2, true);
                        ElementHost.EnableModelessKeyboardInterop(Engine);
                        Engine.Show();
                        break;
                    case "Design 3":
                        Engine = new Back(Uri3, false);
                        ElementHost.EnableModelessKeyboardInterop(Engine);
                        Engine.Show();
                        break;
                    case "Design 4":
                        Engine = new Back(Uri4, false);
                        ElementHost.EnableModelessKeyboardInterop(Engine);
                        Engine.Show();
                        break;
                    case "Design 5":
                        Engine = new Back(Uri5, false);
                        ElementHost.EnableModelessKeyboardInterop(Engine);
                        Engine.Show();
                        break;
                    case "Design 6":
                        Engine = new Back(Uri6, false);
                        ElementHost.EnableModelessKeyboardInterop(Engine);
                        Engine.Show();
                        break;
                    case "Design 7":
                        Engine = new Back(Uri7, false);
                        ElementHost.EnableModelessKeyboardInterop(Engine);
                        Engine.Show();
                        break;
                    case "Design 8":
                        Engine = new Back(Uri8, false);
                        ElementHost.EnableModelessKeyboardInterop(Engine);
                        Engine.Show();
                        break;
                    case "Design 9":
                        Engine = new Back(Uri9, false);
                        ElementHost.EnableModelessKeyboardInterop(Engine);
                        Engine.Show();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                //Engine.Dispose();
                Engine = null;

                CrownButton_Click(sender, e);
            }
        }
    }
}