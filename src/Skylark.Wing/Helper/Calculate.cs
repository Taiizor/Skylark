using System.Drawing;
using SEDST = Skylark.Enum.DisplayScreenType;
using SSMMEHS = Skylark.Struct.Mouse.MouseExtraHookStruct;
using SSMMPS = Skylark.Struct.Mouse.MousePointStruct;
using SWHDM = Skylark.Wing.Helper.DisplayManager;
using SWIIDM = Skylark.Wing.Interface.IDisplayManager;
using SWMI = Skylark.Wing.Manage.Internal;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Calculate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static Point MousePosition(int X, int Y, SEDST Type)
        {
            if (SWMI.DisplayManager.IsMultiScreen())
            {
                switch (Type)
                {
                    case SEDST.SpanAcross:
                        Rectangle ScreenArea = SWMI.DisplayManager.VirtualScreenBounds;

                        X -= ScreenArea.Location.X;
                        Y -= ScreenArea.Location.Y;
                        break;
                    default: //PerDisplay or SameDuplicate mode.
                        DisplayMonitor DisplayMonitor = SWMI.DisplayManager.GetDisplayMonitorFromPoint(new Point(X, Y));

                        X += -1 * DisplayMonitor.Bounds.X;
                        Y += -1 * DisplayMonitor.Bounds.Y;
                        break;
                }
            }

            return new(X, Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mouse"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static SSMMPS MousePosition(SSMMEHS Mouse, SEDST Type)
        {
            if (SWMI.DisplayManager.IsMultiScreen())
            {
                switch (Type)
                {
                    case SEDST.SpanAcross:
                        Rectangle ScreenArea = SWMI.DisplayManager.VirtualScreenBounds;

                        Mouse.Point.X -= ScreenArea.Location.X;
                        Mouse.Point.Y -= ScreenArea.Location.Y;
                        break;
                    default: //PerDisplay or SameDuplicate mode.
                        DisplayMonitor DisplayMonitor = SWMI.DisplayManager.GetDisplayMonitorFromPoint(Mouse);

                        Mouse.Point.X += -1 * DisplayMonitor.Bounds.X;
                        Mouse.Point.Y += -1 * DisplayMonitor.Bounds.Y;
                        break;
                }
            }

            return new()
            {
                X = Mouse.Point.X,
                Y = Mouse.Point.Y
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Display"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static Point MousePosition(int X, int Y, SWHDM Display, SEDST Type)
        {
            if (Display.IsMultiScreen())
            {
                switch (Type)
                {
                    case SEDST.SpanAcross:
                        Rectangle ScreenArea = Display.VirtualScreenBounds;

                        X -= ScreenArea.Location.X;
                        Y -= ScreenArea.Location.Y;
                        break;
                    default: //PerDisplay or SameDuplicate mode.
                        DisplayMonitor DisplayMonitor = Display.GetDisplayMonitorFromPoint(new Point(X, Y));

                        X += -1 * DisplayMonitor.Bounds.X;
                        Y += -1 * DisplayMonitor.Bounds.Y;
                        break;
                }
            }

            return new(X, Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Display"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static Point MousePosition(int X, int Y, SWIIDM Display, SEDST Type)
        {
            if (Display.IsMultiScreen())
            {
                switch (Type)
                {
                    case SEDST.SpanAcross:
                        Rectangle ScreenArea = Display.VirtualScreenBounds;

                        X -= ScreenArea.Location.X;
                        Y -= ScreenArea.Location.Y;
                        break;
                    default: //PerDisplay or SameDuplicate mode.
                        DisplayMonitor DisplayMonitor = Display.GetDisplayMonitorFromPoint(new Point(X, Y));

                        X += -1 * DisplayMonitor.Bounds.X;
                        Y += -1 * DisplayMonitor.Bounds.Y;
                        break;
                }
            }

            return new(X, Y);
        }
    }
}