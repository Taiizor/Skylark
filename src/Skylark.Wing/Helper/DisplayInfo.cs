using SSRRS = Skylark.Struct.Rectangles.RectanglesStruct;

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
        public static SSRRS WorkArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static SSRRS MonitorArea { get; set; }

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