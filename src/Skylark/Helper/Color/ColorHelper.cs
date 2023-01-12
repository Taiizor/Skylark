using System.Drawing;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class ColorHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static (double Hue, double Saturation, double Lightness) ConvertToHSL(Color Color)
        {
            double Min = Math.Min(Math.Min(Color.R, Color.G), Color.B) / 255d;
            double Max = Math.Max(Math.Max(Color.R, Color.G), Color.B) / 255d;

            double Lightness = (Max + Min) / 2d;

            if (Lightness == 0d || Min == Max)
            {
                return (Color.GetHue(), 0d, Lightness);
            }
            else if (Lightness is > 0d and <= 0.5d)
            {
                return (Color.GetHue(), (Max - Min) / (Max + Min), Lightness);
            }

            return (Color.GetHue(), (Max - Min) / (2d - (Max + Min)), Lightness);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static (double Hue, double Saturation, double Value) ConvertToHSV(Color Color)
        {
            var Min = Math.Min(Math.Min(Color.R, Color.G), Color.B) / 255d;
            var Max = Math.Max(Math.Max(Color.R, Color.G), Color.B) / 255d;

            return (Color.GetHue(), Max == 0d ? 0d : (Max - Min) / Max, Max);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static (double Hue, double Whiteness, double Blackness) ConvertToHWB(Color Color)
        {
            var Min = Math.Min(Math.Min(Color.R, Color.G), Color.B) / 255d;
            var Max = Math.Max(Math.Max(Color.R, Color.G), Color.B) / 255d;

            return (Color.GetHue(), Min, 1 - Max);
        }
    }
}