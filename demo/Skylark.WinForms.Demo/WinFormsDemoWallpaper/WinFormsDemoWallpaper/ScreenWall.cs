using Skylark.Enum;
using Skylark.Wing;
using System.Windows.Forms;

namespace WinFormsDemoWallpaper
{
    public partial class ScreenWall : Form
    {
        public ScreenWall(int Count = 0)
        {
            InitializeComponent();

            // Text is the index of the screen.
            Title.Text += Count;

            // Count is the index of the screen.
            // ScreenType.DisplayBound is the screen's display bound.
            Engine.WallpaperForm(this, Count, ScreenType.DisplayBound);
        }
    }
}