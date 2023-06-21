using System.Runtime.InteropServices;

namespace Skylark.Wing.Native
{
    /// <summary>
    /// Summary description for Win32.
    /// </summary>
    public static class Win32
    {
        /// <summary>
        /// The FindWindow function retrieves a handle to the top-level window whose
        /// class name and window name match the specified strings.
        /// This function does not search child windows.
        /// This function does not perform a case-sensitive search.
        /// </summary>
        /// <param name="strClassName"></param>
        /// <param name="strWindowName"></param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        public static extern int FindWindow(string strClassName, string strWindowName);

        /// <summary>
        /// The FindWindowEx function retrieves a handle to a window whose class name 
        /// and window name match the specified strings.
        /// The function searches child windows, beginning with the one following the
        /// specified child window.
        /// This function does not perform a case-sensitive search.
        /// </summary>
        /// <param name="hwndParent"></param>
        /// <param name="hwndChildAfter"></param>
        /// <param name="strClassName"></param>
        /// <param name="strWindowName"></param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        public static extern int FindWindowEx(int hwndParent, int hwndChildAfter, string strClassName, string strWindowName);


        /// <summary>
        /// The SendMessage function sends the specified message to a window or windows. 
        /// It calls the window procedure for the specified window and does not return
        /// until the window procedure has processed the message. 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        public static extern int SendMessage(
            int hWnd,               // handle to destination window
            int Msg,                // message
            int wParam,             // first message parameter
            [MarshalAs(UnmanagedType.LPStr)] string lParam); // second message parameter

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="Msg"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("User32.dll")]
        public static extern int SendMessage(
            int hWnd,               // handle to destination window
            int Msg,                // message
            int wParam,             // first message parameter
            int lParam);            // second message parameter
    }
}