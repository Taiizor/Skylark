using Skylark.Enum;
using Skylark.Wing;
using System.Windows.Forms;

namespace WinFormsDemoWallpaper
{
    public partial class Main : Form
    {
        public Main(int Count = 0)
        {
            InitializeComponent();

            Title.Text += Count;

            Engine.WallpaperForm(this, Count, ScreenType.DisplayBound);
        }
    }
}