using Skylark.Struct.Monitor;
using Skylark.Enum;
using Skylark.Wing.Helper;
using Skylark.Wing.Utility;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Skylark.WallpaperEngine.UI
{
    public partial class Back : Form, IDisposable
    {
        public int ScreenIndex { get; private set; } = 0;

        public bool IsFixed { get; private set; } = false;

        public bool State { get; private set; } = false;

        private const int WH_MOUSE_LL = 14;

        private static IntPtr MouseHook = IntPtr.Zero;

        private readonly ChromiumWebBrowser WallView;

        public Back(string Uri = "https://www.vegalya.com", bool Hook = false)
        {
            InitializeComponent();

            WallView = new ChromiumWebBrowser(Uri);
            WallView.LoadingStateChanged += WallView_LoadingStateChanged;
            WallView.Dock = DockStyle.Fill;
            Controls.Add(WallView);

            //PinToBackground();

            if (Hook)
            {
                MouseEventCall = CatchMouseEvent;
                MouseHook = WinAPI.SetWindowsHookEx(WH_MOUSE_LL, MouseEventCall, IntPtr.Zero, 0);
            }
        }

        private void WallView_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            //State = true;
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

        private static WinAPI.MouseEventCallback MouseEventCall;

        private IntPtr CatchMouseEvent(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (State)
            {
                IBrowserHost WVHost = WallView.GetBrowser().GetHost();

                MouseExtraHookStruct mouseHookStruct = (MouseExtraHookStruct)Marshal.PtrToStructure(lParam, typeof(MouseExtraHookStruct));
                int X = mouseHookStruct.Point.X;
                int Y = mouseHookStruct.Point.Y;

                if (nCode >= 0 && MouseMessagesType.WM_WHEEL == (MouseMessagesType)wParam)
                {
                    int delta = (mouseHookStruct.MouseData >> 16) & 0xFFFF;
                    bool isScrollDown = (delta & 0x8000) != 0;

                    int deltaX = mouseHookStruct.MouseData & 0xFFFF;
                    int deltaY = (mouseHookStruct.MouseData >> 16) & 0xFFFF;

                    int amount = 120;

                    if (isScrollDown)
                    {
                        //deltaX = -+(delta / amount);
                        deltaY = -amount;
                    }
                    else
                    {
                        //deltaX = delta / amount;
                        deltaY = amount;
                    }

                    MouseEvent mouseEvent = new(deltaX, deltaY, CefEventFlags.None);
                    WVHost.SendMouseWheelEvent(mouseEvent, deltaX, deltaY);
                }
                else if (nCode >= 0 && MouseMessagesType.WM_LBUTTONDOWN == (MouseMessagesType)wParam)
                {
                    // Sol tuşa basma olayı
                    // İlgili işlemleri burada gerçekleştirin
                    WVHost.SendMouseClickEvent(X, Y, MouseButtonType.Left, false, 1, CefEventFlags.None);
                }
                else if (nCode >= 0 && MouseMessagesType.WM_LBUTTONUP == (MouseMessagesType)wParam)
                {
                    // Sol tuştan el çekme olayı
                    // İlgili işlemleri burada gerçekleştirin
                    WVHost.SendMouseClickEvent(X, Y, MouseButtonType.Left, true, 1, CefEventFlags.None);
                }
                else if (nCode >= 0 && MouseMessagesType.WM_RBUTTONDOWN == (MouseMessagesType)wParam)
                {
                    // Sağ tuşa basma olayı
                    // İlgili işlemleri burada gerçekleştirin
                    WVHost.SendMouseClickEvent(X, Y, MouseButtonType.Right, false, 1, CefEventFlags.None);
                }
                else if (nCode >= 0 && MouseMessagesType.WM_RBUTTONUP == (MouseMessagesType)wParam)
                {
                    // Sağ tuştan el çekme olayı
                    // İlgili işlemleri burada gerçekleştirin
                    WVHost.SendMouseClickEvent(X, Y, MouseButtonType.Right, true, 1, CefEventFlags.None);
                }
                else if (nCode >= 0 && MouseMessagesType.WM_MOVE == (MouseMessagesType)wParam)
                {
                    // Fare hareketi olayı
                    // İlgili işlemleri burada gerçekleştirin
                    WVHost.SendMouseMoveEvent(X, Y, false, CefEventFlags.None);
                }
            }

            return WinAPI.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
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

        [StructLayout(LayoutKind.Sequential)]
        private struct MouseExtraHookStruct
        {
            public MousePoint Point;
            public int MouseData;
            public int Flags;
            public int Time;
            public IntPtr ExtraInfo;
        }

        public new void Dispose()
        {
            WinAPI.UnhookWindowsHookEx(MouseHook);

            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    public class MouseOperations
    {
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

        public static void MouseEvent(MouseEventFlagsType value)
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