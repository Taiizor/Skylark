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