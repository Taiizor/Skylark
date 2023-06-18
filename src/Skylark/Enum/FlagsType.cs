namespace Skylark.Enum
{
    /// <summary>
    /// AncestorFlags type enum
    /// </summary>
    [Flags]
    public enum AncestorFlags : uint
    {
        /// <summary>
        /// Retrieves the parent window. This does not include the owner, as it does with the GetParent function. 
        /// </summary>
        GetParent = 1,
        /// <summary>
        /// Retrieves the root window by walking the chain of parent windows.
        /// </summary>
        GetRoot = 2,
        /// <summary>
        /// Retrieves the owned root window by walking the chain of parent and owner windows returned by GetParent. 
        /// </summary>
        GetRootOwner = 3
    }

    /// <summary>
    /// TimeoutFlags type enum
    /// </summary>
    [Flags]
    public enum TimeoutFlags : uint
    {
        /// <summary>
        /// 
        /// </summary>
        SMTO_NORMAL = 0x0,
        /// <summary>
        /// 
        /// </summary>
        SMTO_BLOCK = 0x1,
        /// <summary>
        /// 
        /// </summary>
        SMTO_ABORTIFHUNG = 0x2,
        /// <summary>
        /// 
        /// </summary>
        SMTO_NOTIMEOUTIFNOTHUNG = 0x8,
        /// <summary>
        /// 
        /// </summary>
        SMTO_ERRORONEXIT = 0x20
    }

    /// <summary>
    /// WindowPosFlags type enum
    /// </summary>
    [Flags]
    public enum WindowPosFlags : uint
    {
        /// <summary>
        /// 
        /// </summary>
        SWP_ASYNCWINDOWPOS = 0x4000,
        /// <summary>
        /// 
        /// </summary>
        SWP_DEFERERASE = 0x2000,
        /// <summary>
        /// 
        /// </summary>
        SWP_DRAWFRAME = 0x0020,
        /// <summary>
        /// 
        /// </summary>
        SWP_FRAMECHANGED = 0x0020,
        /// <summary>
        /// 
        /// </summary>
        SWP_HIDEWINDOW = 0x0080,
        /// <summary>
        /// 
        /// </summary>
        SWP_NOACTIVATE = 0x0010,
        /// <summary>
        /// 
        /// </summary>
        SWP_NOCOPYBITS = 0x0100,
        /// <summary>
        /// 
        /// </summary>
        SWP_NOMOVE = 0x0002,
        /// <summary>
        /// 
        /// </summary>
        SWP_NOOWNERZORDER = 0x0200,
        /// <summary>
        /// 
        /// </summary>
        SWP_NOREDRAW = 0x0008,
        /// <summary>
        /// 
        /// </summary>
        SWP_NOREPOSITION = 0x0200,
        /// <summary>
        /// 
        /// </summary>
        SWP_NOSENDCHANGING = 0x0400,
        /// <summary>
        /// 
        /// </summary>
        SWP_NOSIZE = 0x0001,
        /// <summary>
        /// 
        /// </summary>
        SWP_NOZORDER = 0x0004,
        /// <summary>
        /// 
        /// </summary>
        SWP_SHOWWINDOW = 0x0040
    }
}