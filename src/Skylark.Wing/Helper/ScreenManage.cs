using System;
using System.Windows.Forms;
using Rectangle = System.Drawing.Rectangle;
using SEEST = Skylark.Enum.ExpandScreenType;
using SSMMS = Skylark.Struct.Monitor.MonitorStruct;
using SWUS = Skylark.Wing.Utility.Screene;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal static class ScreenManage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public static SSMMS OwnerScreen(int Index = 0)
        {
            Index = OwnerScreenIndex(Index);

            //SWUS.Initialize(); // Initialize the screens.

            if (Index < SWUS.Screens.Length)
            {
                return SWUS.Screens[Index];
            }

            return new SSMMS()
            {
                rcMonitor = Screen.PrimaryScreen.Bounds,
                rcWork = Screen.PrimaryScreen.WorkingArea
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Method"></param>
        /// <returns></returns>
        public static SSMMS OwnerScreen(SEEST Method)
        {
            if (SWUS.Screens.Length <= 1)
            {
                return OwnerScreen(0);
            }
            else
            {
                switch (Method)
                {
                    default:
                        Screen[] Screens = Screen.AllScreens;

                        Rectangle Work = WorkRectangle(Screens);
                        Rectangle Monitor = MonitorRectangle(Screens);

                        return new()
                        {
                            rcWork = new()
                            {
                                Top = Work.Top,
                                Left = Work.Left,
                                Width = Work.Width,
                                Height = Work.Height,
                            },
                            rcMonitor = new()
                            {
                                Top = Monitor.Top,
                                Left = Monitor.Left,
                                Width = Monitor.Width,
                                Height = Monitor.Height,
                            }
                        };
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        private static int OwnerScreenIndex(int Index = 0)
        {
            if (Index < 0)
            {
                return 0;
            }
            else if (Index >= SWUS.Screens.Length)
            {
                return 0;
            }
            else
            {
                return Index;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Screens"></param>
        /// <returns></returns>
        private static Rectangle WorkRectangle(Screen[] Screens)
        {
            int MinX = int.MaxValue;
            int MinY = int.MaxValue;

            int MaxRight = int.MinValue;
            int MaxBottom = int.MinValue;

            foreach (Screen Screen in Screens)
            {
                Rectangle WorkingArea = Screen.WorkingArea;

                MinX = Math.Min(MinX, WorkingArea.Left);
                MinY = Math.Min(MinY, WorkingArea.Top);

                MaxRight = Math.Max(MaxRight, WorkingArea.Right);
                MaxBottom = Math.Max(MaxBottom, WorkingArea.Bottom);
            }

            return new Rectangle(MinX, MinY, MaxRight - MinX, MaxBottom - MinY);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Screens"></param>
        /// <returns></returns>
        private static Rectangle MonitorRectangle(Screen[] Screens)
        {
            int MinX = int.MaxValue;
            int MinY = int.MaxValue;

            int MaxRight = int.MinValue;
            int MaxBottom = int.MinValue;

            foreach (Screen Screen in Screens)
            {
                Rectangle Bounds = Screen.Bounds;

                MinX = Math.Min(MinX, Bounds.Left);
                MinY = Math.Min(MinY, Bounds.Top);

                MaxRight = Math.Max(MaxRight, Bounds.Right);
                MaxBottom = Math.Max(MaxBottom, Bounds.Bottom);
            }

            return new Rectangle(MinX, MinY, MaxRight - MinX, MaxBottom - MinY);
        }
    }
}