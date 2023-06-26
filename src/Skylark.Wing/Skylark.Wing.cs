#region Imports

using System.Windows;
using System.Windows.Forms;
using SEST = Skylark.Enum.ScreenType;
using SEEST = Skylark.Enum.ExpandScreenType;
using SWHSM = Skylark.Wing.Helper.ScreenManage;
using SWHDI = Skylark.Wing.Helper.DesktopIcon;
using SWUS = Skylark.Wing.Utility.Screene;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 17.Jun.2023
//     Changed: 26.Jun.2023
//     Version: 3.0.1.210
//
// |---------DO-NOT-REMOVE---------|

namespace Skylark.Wing
{
    #region Core

    #region Engine

    /// <summary>
    /// Skylark engine class. 
    /// </summary>
    public static class Engine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Form"></param>
        /// <param name="Index"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool WallpaperForm(Form Form, int Index, SEST Type)
        {
            bool IsFixed = SWHDI.FixForm(Form);

            if (IsFixed)
            {
                SWUS.FillScreenForm(Form, SWHSM.OwnerScreen(Index), Type);
            }

            return IsFixed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Form"></param>
        /// <param name="Method"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool WallpaperForm(Form Form, SEEST Method, SEST Type)
        {
            bool IsFixed = SWHDI.FixForm(Form);

            if (IsFixed)
            {
                SWUS.FillScreenForm(Form, SWHSM.OwnerScreen(Method), Type);
            }

            return IsFixed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <param name="Index"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool WallpaperWindow(Window Window, int Index, SEST Type)
        {
            bool IsFixed = SWHDI.FixWindow(Window);

            if (IsFixed)
            {
                SWUS.FillScreenWindow(Window, SWHSM.OwnerScreen(Index), Type);
            }

            return IsFixed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <param name="Method"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool WallpaperWindow(Window Window, SEEST Method, SEST Type)
        {
            bool IsFixed = SWHDI.FixWindow(Window);

            if (IsFixed)
            {
                SWUS.FillScreenWindow(Window, SWHSM.OwnerScreen(Method), Type);
            }

            return IsFixed;
        }
    }

    #endregion

    #endregion
}