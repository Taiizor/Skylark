using System.Drawing;
using SEMST = Skylark.Enum.MouseScreenType;
using SSMMEHS = Skylark.Struct.Mouse.MouseExtraHookStruct;
using SSMMPS = Skylark.Struct.Mouse.MousePointStruct;
using SWMI = Skylark.Wing.Manage.Internal;

namespace Skylark.Wing.Helper
{
    public static class Calculate
    {
        public static SSMMPS MousePosition(SSMMEHS Mouse, SEMST Type)
        {
            if (SWMI.DisplayManager.IsMultiScreen())
            {
                switch (Type)
                {
                    case SEMST.SpanAcross:
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
    }
}
