using Skylark.Struct.Mouse;
using System.Drawing;
using SEMST = Skylark.Enum.MouseScreenType;
using SSMMPS = Skylark.Struct.Mouse.MousePointStruct;
using SWIIDM = Skylark.Wing.Interface.IDisplayManager;

namespace Skylark.Wing.Helper
{
    public static class Calculate
    {
        public static SSMMPS MousePosition(MouseExtraHookStruct Mouse, SEMST Type)
        {
            SWIIDM DisplayManager = new DisplayManager();

            if (DisplayManager.IsMultiScreen())
            {
                switch (Type)
                {
                    case SEMST.SpanAcross:
                        Rectangle ScreenArea = DisplayManager.VirtualScreenBounds;

                        Mouse.Point.X -= ScreenArea.Location.X;
                        Mouse.Point.Y -= ScreenArea.Location.Y;
                        break;
                    default: //PerDisplay or SameDuplicate mode.
                        DisplayMonitor DisplayMonitor = DisplayManager.GetDisplayMonitorFromPoint(Mouse);

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
