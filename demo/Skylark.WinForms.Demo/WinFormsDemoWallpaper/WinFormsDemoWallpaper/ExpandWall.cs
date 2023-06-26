using Skylark.Enum;
using Skylark.Wing;
using System.Windows.Forms;

namespace WinFormsDemoWallpaper
{
    public partial class ExpandWall : Form
    {
        public ExpandWall()
        {
            InitializeComponent();

            // ExpandScreenType.Default is the default screen expansion method.
            // ScreenType.WorkingArea is the screen's working area.
            Engine.WallpaperForm(this, ExpandScreenType.Default, ScreenType.WorkingArea);
        }
    }
}