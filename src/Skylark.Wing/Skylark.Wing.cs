#region Imports

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using SEDST = Skylark.Enum.DuplicateScreenType;
using SEEST = Skylark.Enum.ExpandScreenType;
using SEST = Skylark.Enum.ScreenType;
using SWHDC = Skylark.Wing.Helper.DesktopCore;
using SWHSM = Skylark.Wing.Helper.ScreenManage;
using SWUS = Skylark.Wing.Utility.Screene;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 17.Jun.2023
//     Changed: 26.May.2024
//     Version: 3.1.4.8
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
            bool IsFixed = SWHDC.FixForm(Form);

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
            bool IsFixed = SWHDC.FixForm(Form);

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
        /// <param name="Handle"></param>
        /// <param name="Index"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool WallpaperHandle(IntPtr Handle, int Index, SEST Type)
        {
            bool IsFixed = SWHDC.FixHandle(Handle);

            if (IsFixed)
            {
                SWUS.FillScreenHandle(Handle, SWHSM.OwnerScreen(Index), Type);
            }

            return IsFixed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="Method"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static bool WallpaperHandle(IntPtr Handle, SEEST Method, SEST Type)
        {
            bool IsFixed = SWHDC.FixHandle(Handle);

            if (IsFixed)
            {
                SWUS.FillScreenHandle(Handle, SWHSM.OwnerScreen(Method), Type);
            }

            return IsFixed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="Method"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        [Obsolete("This method is currently unavailable.")]
        public static bool WallpaperHandle(IntPtr Handle, SEDST Method, SEST Type)
        {
            return false;
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
            bool IsFixed = SWHDC.FixWindow(Window);

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
            bool IsFixed = SWHDC.FixWindow(Window);

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
        [Obsolete("This method is currently unavailable.")]
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
            bool IsFixed = SWHDC.FixProcess(Process);

            if (IsFixed)
            {
                SWUS.FillScreenProcess(Process, SWHSM.OwnerScreen(Index), Type);
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
            bool IsFixed = SWHDC.FixProcess(Process);

            if (IsFixed)
            {
                SWUS.FillScreenProcess(Process, SWHSM.OwnerScreen(Method), Type);
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
        [Obsolete("This method is currently unavailable.")]
        public static bool WallpaperProcess(Process Process, SEDST Method, SEST Type)
        {
            return false;
        }
    }

    #endregion

    #endregion
}