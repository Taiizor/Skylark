using System;
using System.Runtime.InteropServices;
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Interface
{
    /// <summary>
    /// 
    /// </summary>
    [ComImport, Guid("B92B56A9-8B55-4E14-9A89-0199BBB6F93B"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDesktopWallpaper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="monitorID"></param>
        /// <param name="wallpaper"></param>
        void SetWallpaper([MarshalAs(UnmanagedType.LPWStr)] string monitorID, [MarshalAs(UnmanagedType.LPWStr)] string wallpaper);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="monitorID"></param>
        /// <returns></returns>
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string GetWallpaper([MarshalAs(UnmanagedType.LPWStr)] string monitorID);

        /// <summary>
        /// Gets the monitor device path.
        /// </summary>
        /// <param name="monitorIndex">Index of the monitor device in the monitor device list.</param>
        /// <returns></returns>
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string GetMonitorDevicePathAt(uint monitorIndex);
        /// <summary>
        /// Gets number of monitor device paths.
        /// </summary>
        /// <returns></returns>
        [return: MarshalAs(UnmanagedType.U4)]
        uint GetMonitorDevicePathCount();

        [return: MarshalAs(UnmanagedType.Struct)]
        SWNM.RECT GetMonitorRECT([MarshalAs(UnmanagedType.LPWStr)] string monitorID);

        void SetBackgroundColor([MarshalAs(UnmanagedType.U4)] uint color);
        [return: MarshalAs(UnmanagedType.U4)]
        uint GetBackgroundColor();

        void SetPosition([MarshalAs(UnmanagedType.I4)] SWNM.DesktopWallpaperPosition position);
        [return: MarshalAs(UnmanagedType.I4)]
        SWNM.DesktopWallpaperPosition GetPosition();

        void SetSlideshow(IntPtr items);
        IntPtr GetSlideshow();

        void SetSlideshowOptions(SWNM.DesktopSlideshowDirection options, uint slideshowTick);
        [PreserveSig]
        uint GetSlideshowOptions(out SWNM.DesktopSlideshowDirection options, out uint slideshowTick);

        void AdvanceSlideshow([MarshalAs(UnmanagedType.LPWStr)] string monitorID, [MarshalAs(UnmanagedType.I4)] SWNM.DesktopSlideshowDirection direction);

        SWNM.DesktopSlideshowDirection GetStatus();

        bool Enable();
    }
}