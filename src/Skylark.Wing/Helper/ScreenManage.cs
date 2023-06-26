using System.Windows.Forms;
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
            if (Screen.AllScreens.Length <= 1)
            {
                return OwnerScreen(0);
            }
            else
            {
                switch (Method)
                {
                    default:
                        SSMMS MonitorStruct = new()
                        {
                            rcMonitor = new()
                            {
                                Width = 0,
                                Height = 0,
                                Left = 0,
                                Top = 0
                            },
                            rcWork = new()
                            {
                                Width = 0,
                                Height = 0,
                                Left = 0,
                                Top = 0
                            }
                        };

                        foreach (Screen Screene in Screen.AllScreens)
                        {
                            if (MonitorStruct.rcMonitor.Width < Screene.Bounds.Width)
                            {
                                MonitorStruct.rcMonitor.Width = Screene.Bounds.Width;
                            }
                            if (MonitorStruct.rcWork.Width < Screene.WorkingArea.Width)
                            {
                                MonitorStruct.rcWork.Width = Screene.WorkingArea.Width;
                            }

                            if (MonitorStruct.rcMonitor.Height < Screene.Bounds.Height)
                            {
                                MonitorStruct.rcMonitor.Height = Screene.Bounds.Height;
                            }
                            if (MonitorStruct.rcWork.Height < Screene.WorkingArea.Height)
                            {
                                MonitorStruct.rcWork.Height = Screene.WorkingArea.Height;
                            }

                            //MonitorStruct.rcMonitor.Height += Screene.Bounds.Height;
                            //MonitorStruct.rcWork.Height += Screene.WorkingArea.Height;

                            MonitorStruct.rcMonitor.Width += Screene.Bounds.Width;
                            MonitorStruct.rcWork.Width += Screene.WorkingArea.Width;
                        }

                        return MonitorStruct;
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
            else if (Index >= Screen.AllScreens.Length)
            {
                return 0;
            }
            else
            {
                return Index;
            }
        }
    }
}