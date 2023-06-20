using Skylark.Struct.Monitor;
using Skylark.Wing.Helper;
using Skylark.Wing.Utility;
using System.Windows.Forms;

namespace WinFormsDemoWallpaper
{
    public partial class Main : Form
    {
        public int ScreenIndex { get; private set; } = 0;

        public bool IsFixed { get; private set; } = false;

        public Main(int Count = 0)
        {
            ScreenIndex = Count;

            InitializeComponent();

            Title.Text += Count;

            PinToBackground();

            for (int C = 0; C < Count; C++)
            {
                Form F1 = new Main(C);
                F1.Show();
            }
        }

        protected bool PinToBackground()
        {
            IsFixed = DesktopIcon.FixForm(this);

            if (IsFixed)
            {
                Screene.FillScreenForm(this, OwnerScreen);
            }

            return IsFixed;
        }

        public int OwnerScreenIndex
        {
            get => ScreenIndex;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value >= Screen.AllScreens.Length)
                {
                    value = 0;
                }

                if (ScreenIndex != value)
                {
                    ScreenIndex = value;

                    PinToBackground();
                }
            }
        }

        public MonitorStruct OwnerScreen
        {
            get
            {
                if (OwnerScreenIndex < Screene.Screens.Length)
                {
                    return Screene.Screens[OwnerScreenIndex];
                }

                return new MonitorStruct()
                {
                    rcMonitor = Screen.PrimaryScreen.Bounds,
                    rcWork = Screen.PrimaryScreen.WorkingArea,
                };
            }
        }
    }
}