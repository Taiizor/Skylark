using Skylark.Enum;
using Skylark.Wing;
using System.Windows.Forms;

namespace WinFormsDemoWallpaper
{
    public partial class DuplicateWall : Form
    {
        public DuplicateWall()
        {
            InitializeComponent();

            // DuplicateScreenType.Default is the default screen duplication method.
            // ScreenType.DisplayBound is the screen's display bound.
            Engine.WallpaperForm(this, DuplicateScreenType.Default, ScreenType.DisplayBound);
        }
    }
}