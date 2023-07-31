using System;
using System.Runtime.InteropServices;

namespace Skylark.Wing.Interface
{
    /// <summary>
    /// 
    /// </summary>
    [ComImport, TypeLibType(0x1040), Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
    public interface IWshShortcut
    {
        /// <summary>
        /// 
        /// </summary>
        [DispId(0)]
        string FullName { [return: MarshalAs(UnmanagedType.BStr)][DispId(0)] get; }

        /// <summary>
        /// 
        /// </summary>
        [DispId(0x3e8)]
        string Arguments { [return: MarshalAs(UnmanagedType.BStr)][DispId(0x3e8)] get; [param: In, MarshalAs(UnmanagedType.BStr)][DispId(0x3e8)] set; }

        /// <summary>
        /// 
        /// </summary>
        [DispId(0x3e9)]
        string Description { [return: MarshalAs(UnmanagedType.BStr)][DispId(0x3e9)] get; [param: In, MarshalAs(UnmanagedType.BStr)][DispId(0x3e9)] set; }

        /// <summary>
        /// 
        /// </summary>
        [DispId(0x3ea)]
        string Hotkey { [return: MarshalAs(UnmanagedType.BStr)][DispId(0x3ea)] get; [param: In, MarshalAs(UnmanagedType.BStr)][DispId(0x3ea)] set; }

        /// <summary>
        /// 
        /// </summary>
        [DispId(0x3eb)]
        string IconLocation { [return: MarshalAs(UnmanagedType.BStr)][DispId(0x3eb)] get; [param: In, MarshalAs(UnmanagedType.BStr)][DispId(0x3eb)] set; }

        /// <summary>
        /// 
        /// </summary>
        [DispId(0x3ec)]
        string RelativePath { [param: In, MarshalAs(UnmanagedType.BStr)][DispId(0x3ec)] set; }

        /// <summary>
        /// 
        /// </summary>
        [DispId(0x3ed)]
        string TargetPath { [return: MarshalAs(UnmanagedType.BStr)][DispId(0x3ed)] get; [param: In, MarshalAs(UnmanagedType.BStr)][DispId(0x3ed)] set; }

        /// <summary>
        /// 
        /// </summary>
        [DispId(0x3ee)]
        int WindowStyle { [DispId(0x3ee)] get; [param: In][DispId(0x3ee)] set; }

        /// <summary>
        /// 
        /// </summary>
        [DispId(0x3ef)]
        string WorkingDirectory { [return: MarshalAs(UnmanagedType.BStr)][DispId(0x3ef)] get; [param: In, MarshalAs(UnmanagedType.BStr)][DispId(0x3ef)] set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PathLink"></param>
        [TypeLibFunc(0x40), DispId(0x7d0)]
        void Load([In, MarshalAs(UnmanagedType.BStr)] string PathLink);

        /// <summary>
        /// 
        /// </summary>
        [DispId(0x7d1)]
        void Save();
    }
}