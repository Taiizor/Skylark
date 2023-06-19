using Skylark.Struct.Monitor;
using Skylark.Wing.Helper;
using Skylark.Wing.Utility;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skylark.WallpaperEngine.UI
{
    public partial class Back : Form, IDisposable
    {
        public int ScreenIndex { get; private set; } = 0;

        public bool IsFixed { get; private set; } = false;

        public bool State { get; private set; } = false;

        private const int WH_MOUSE_LL = 14;
        private const int WM_MOUSEMOVE = 0x0200;

        private static IntPtr MouseHook = IntPtr.Zero;

        public Back(string Uri = "https://www.vegalya.com", bool Hook = false)
        {
            InitializeComponent();

            InitializeWallView();
            WallView.Source = new Uri(Uri);

            PinToBackground();

            if (Hook)
            {
                MouseEventCall = CatchMouseEvent;
                MouseHook = SetWindowsHookEx(WH_MOUSE_LL, MouseEventCall, IntPtr.Zero, 0);
            }
        }

        private async void InitializeWallView()
        {
            await WallView.EnsureCoreWebView2Async(null);
            State = true;
        }

        protected bool PinToBackground()
        {
            IsFixed = DesktopIcon.Fix(Handle);

            if (IsFixed)
            {
                Screene.FillScreen(this, OwnerScreen);
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

        private delegate IntPtr MouseEventCallback(int nCode, IntPtr wParam, IntPtr lParam);

        private static MouseEventCallback MouseEventCall;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr SetWindowsHookEx(int idHook, MouseEventCallback lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        private async Task Test(string Script)
        {
            await WallView.CoreWebView2.ExecuteScriptAsync(Script);
        }

        private IntPtr CatchMouseEvent(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_MOUSEMOVE)
            {
                if (State)
                {
                    // Fare hareketi gerçekleştiğinde yapılacak işlemler
                    MouseHookStruct HookStruct = Marshal.PtrToStructure<MouseHookStruct>(lParam);

                    int X = HookStruct.pt.X;
                    int Y = HookStruct.pt.Y;

                    // Fare koordinatlarıyla yapılacak işlemler
                    Test($"handleMouseMove({X}, {Y});");
                }
            }

            return CallNextHookEx(MouseHook, nCode, wParam, lParam);
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MousePoint
        {
            public int X;
            public int Y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MouseHookStruct
        {
            public MousePoint pt;
            public IntPtr hwnd;
            public uint wHitTestCode;
            public IntPtr dwExtraInfo;
        }

        public new void Dispose()
        {
            UnhookWindowsHookEx(MouseHook);

            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    public class MouseOperations
    {
        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010
        }

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public static void SetCursorPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

        public static void SetCursorPosition(MousePoint point)
        {
            SetCursorPos(point.X, point.Y);
        }

        public static MousePoint GetCursorPosition()
        {
            bool gotPoint = GetCursorPos(out MousePoint currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
            return currentMousePoint;
        }

        public static void MouseEvent(MouseEventFlags value)
        {
            MousePoint position = GetCursorPosition();

            mouse_event
                ((int)value,
                 position.X,
                 position.Y,
                 0,
                 0)
                ;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}