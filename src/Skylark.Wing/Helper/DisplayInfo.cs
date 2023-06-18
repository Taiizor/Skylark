using SRRS = Skylark.Struct.Rectangles.RectanglesStruct;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public class DisplayInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public SRRS WorkArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public SRRS MonitorArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ScreenWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ScreenHeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Availability { get; set; }
    }
}