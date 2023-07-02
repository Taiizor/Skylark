#region Imports

using System.Windows;
using System.Windows.Forms;
using SEEST = Skylark.Enum.ExpandScreenType;
using SEDST = Skylark.Enum.DuplicateScreenType;
using SEST = Skylark.Enum.ScreenType;
using SWHDI = Skylark.Wing.Helper.DesktopIcon;
using SWHSM = Skylark.Wing.Helper.ScreenManage;
using SWHPI = Skylark.Wing.Helper.ProcessInterop;
using SWUS = Skylark.Wing.Utility.Screene;
using System.Windows.Media;
using System.Windows.Controls;
using System.Drawing;
using System;
using System.Diagnostics;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 17.Jun.2023
//     Changed: 02.Jul.2023
//     Version: 3.0.1.220
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
        /// <param name="Form"></param>
        /// <param name="Method"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        [Obsolete("This method is currently unavailable.")]
        public static bool WallpaperForm(Form Form, SEDST Method, SEST Type)
        {
            bool IsFixed = WallpaperForm(Form, 0, Type);

            if (SWUS.Screens.Length > 1)
            {
                switch (Method)
                {
                    default:
                        for (int Count = 1; Count < SWUS.Screens.Length; Count++)
                        {
                            Form Clone = new()
                            {
                                FormBorderStyle = Form.FormBorderStyle
                            };

                            Bitmap BackBuffer = new(Form.Width, Form.Height);

                            //System.Windows.Forms.Application.Idle += (sender, e) =>
                            //{
                            //    Form.DrawToBitmap(BackBuffer, Form.ClientRectangle);

                            //    Clone.BackgroundImage = BackBuffer;
                            //    //Clone.Refresh();
                            //};

                            Clone.Paint += (sender, e) =>
                            {
                                Form.DrawToBitmap(BackBuffer, Form.ClientRectangle);
                                e.Graphics.DrawImage(BackBuffer, new System.Drawing.Point(0, 0));
                            };

                            IsFixed = WallpaperForm(Clone, Count, Type);

                            Clone.Show();
                        }
                        break;
                }
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Window"></param>
        /// <param name="Method"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool WallpaperWindow(Window Window, SEDST Method, SEST Type)
        {
            bool IsFixed = WallpaperWindow(Window, 0, Type);

            if (SWUS.Screens.Length > 1)
            {
                switch (Method)
                {
                    default:
                        VisualBrush VisualBrush = new(Window);

                        for (int Count = 1; Count < SWUS.Screens.Length; Count++)
                        {
                            Window Clone = new();

                            Grid Grid = new()
                            {
                                Background = VisualBrush
                            };

                            Clone.Content = Grid;

                            IsFixed = WallpaperWindow(Clone, Count, Type);

                            Clone.Show();
                        }
                        break;
                }
            }

            return IsFixed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <param name="Index"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool WallpaperProcess(Process Process, int Index, SEST Type)
        {
            IntPtr Handle = SWHPI.MainWindowHandle(Process);

            bool IsFixed = SWHDI.FixHandle(Handle);

            if (IsFixed)
            {
                SWUS.FillScreenHandle(Handle, SWHSM.OwnerScreen(Index), Type);
            }

            return IsFixed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <param name="Method"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool WallpaperProcess(Process Process, SEEST Method, SEST Type)
        {
            IntPtr Handle = SWHPI.MainWindowHandle(Process);

            bool IsFixed = SWHDI.FixHandle(Handle);

            if (IsFixed)
            {
                SWUS.FillScreenHandle(Handle, SWHSM.OwnerScreen(Method), Type);
            }

            return IsFixed;
        }
    }

    #endregion

    #endregion
}