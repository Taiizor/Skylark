namespace Skylark.Enum
{
    /// <summary>
    /// MouseMessages type enum
    /// The WM_COMMAND message is sent when the user selects a command item from 
    /// a menu, when a control sends a notification message to its parent window, 
    /// or when an accelerator keystroke is translated.
    /// </summary>
    [Flags]
    public enum MouseMessagesType
    {
        /// <summary>
        /// 
        /// </summary>
        WM_WHEEL = 0x20A,
        /// <summary>
        /// 
        /// </summary>
        WM_KEYDOWN = 0x100,
        /// <summary>
        /// 
        /// </summary>
        WM_KEYUP = 0x101,
        /// <summary>
        /// 
        /// </summary>
        WM_COMMAND = 0x111,
        /// <summary>
        /// 
        /// </summary>
        WM_MOVE = 0x200,
        /// <summary>
        /// 
        /// </summary>
        WM_LBUTTONDOWN = 0x201,
        /// <summary>
        /// 
        /// </summary>
        WM_LBUTTONUP = 0x202,
        /// <summary>
        /// 
        /// </summary>
        WM_LBUTTONDBLCLK = 0x203,
        /// <summary>
        /// 
        /// </summary>
        WM_RBUTTONDOWN = 0x204,
        /// <summary>
        /// 
        /// </summary>
        WM_RBUTTONUP = 0x205,
        /// <summary>
        /// 
        /// </summary>
        WM_RBUTTONDBLCLK = 0x206
    }
}