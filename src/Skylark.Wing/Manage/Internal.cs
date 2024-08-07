using System;
using SWHDM = Skylark.Wing.Helper.DisplayManager;
using SWIIDM = Skylark.Wing.Interface.IDisplayManager;

namespace Skylark.Wing.Manage
{
    /// <summary>
    /// 
    /// </summary>
    internal static class Internal
    {
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_TOPMOST = 0x00000008;
        /// <summary>
        /// 
        /// </summary>
        public const int WS_EX_TOOLWINDOW = 0x00000080;

        /// <summary>
        /// Default shortcut extension
        /// </summary>
        public const string DEFAULT_SHORTCUT_EXTENSION = ".lnk";

        /// <summary>
        /// 
        /// </summary>
        public const string WSCRIPT_SHELL_NAME = "WScript.Shell";

        /// <summary>
        /// 
        /// </summary>
        public static readonly SWIIDM DisplayManager = new SWHDM();

        /// <summary>
        /// 
        /// </summary>
        public static object M_SHELL => Activator.CreateInstance(M_TYPE);
        /// <summary>
        /// 
        /// </summary>
        public static Type M_TYPE => Type.GetTypeFromProgID(WSCRIPT_SHELL_NAME);

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] ClassWhiteList = new string[]
        {
            //StartMeu, TaskView (Win10), action center etc
            "Windows.UI.Core.CoreWindow",
            //Alt+Tab Screen (Win10)
            "MultitaskingViewFrame",
            //TaskView (Win11)
            "XamlExplorerHostIslandWindow",
            //Widget Window (Win11)
            "WindowsDashboard",
            //Taskbar(s)
            "Shell_TrayWnd",
            "Shell_SecondaryTrayWnd",
            //Systray Notifyicon Expanded Popup
            "NotifyIconOverflowWindow",
            //RainMeter Widgets
            "RainmeterMeterWindow",
            //GlassWire Notifyicon Expanded Popup
            "Qt5152QWindowPopupSaveBits",
            //Genshin Impact Notifyicon Expanded Popup
            "Qt5QWindowPopupDropShadowSaveBits",
            //Discord Notifyicon Expanded Popup
            "Chrome_WidgetWin_1",
            //Coodesker
            "_cls_desk_"
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] StartsWithClassWhiteList = new string[]
        {
            //Qt Notifyicon Expanded Popup
            "Qt5",
        };
    }
}