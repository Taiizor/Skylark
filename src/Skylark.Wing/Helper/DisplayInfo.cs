using SRRS = Skylark.Struct.Rectangles.RectanglesStruct;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class DisplayInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public static SRRS WorkArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static SRRS MonitorArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static string ScreenWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static string ScreenHeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static string Availability { get; set; }
    }
}