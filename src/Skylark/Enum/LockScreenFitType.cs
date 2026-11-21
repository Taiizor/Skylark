namespace Skylark.Enum
{
    /// <summary>
    /// Lock screen video fit modes.
    /// </summary>
    public enum LockScreenFitType
    {
        /// <summary>
        /// Uniformly scale to fill the entire screen, cropping edges if aspect ratios differ.
        /// </summary>
        Cover = 0,
        /// <summary>
        /// Non-uniformly stretch to fill the screen dimensions.
        /// </summary>
        Fill = 1,
        /// <summary>
        /// Uniformly scale to fit within screen bounds, adding black letterbox bars.
        /// </summary>
        Fit = 2,
        /// <summary>
        /// 1:1 pixel scaling centered on the screen.
        /// </summary>
        Center = 3
    }
}