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
        public static (double Hue, double Saturation, double Brightness) ConvertToHSB(Color Color)
        {
            return ConvertToHSV(Color);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static (double Hue, double Saturation, double Intensity) ConvertToHSI(Color Color)
        {
            if (Color.R == 0 && Color.G == 0 && Color.B == 0)
            {
                return (0d, 0d, 0d);
            }

            double Red = Color.R / 255d;
            double Green = Color.G / 255d;
            double Blue = Color.B / 255d;

            double Intensity = (Red + Green + Blue) / 3d;

            double Min = Math.Min(Math.Min(Color.R, Color.G), Color.B) / 255d;

            return (Color.GetHue(), 1d - (Min / Intensity), Intensity);
        }

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
            double Min = Math.Min(Math.Min(Color.R, Color.G), Color.B) / 255d;
            double Max = Math.Max(Math.Max(Color.R, Color.G), Color.B) / 255d;

            return (Color.GetHue(), Max == 0d ? 0d : (Max - Min) / Max, Max);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static (double Hue, double Whiteness, double Blackness) ConvertToHWB(Color Color)
        {
            double Min = Math.Min(Math.Min(Color.R, Color.G), Color.B) / 255d;
            double Max = Math.Max(Math.Max(Color.R, Color.G), Color.B) / 255d;

            return (Color.GetHue(), Min, 1 - Max);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static (double Cyan, double Magenta, double Yellow, double BlackKey) ConvertToCMYK(Color Color)
        {
            if (Color.R == 0 && Color.G == 0 && Color.B == 0)
            {
                return (0d, 0d, 0d, 1d);
            }

            double Red = Color.R / 255d;
            double Green = Color.G / 255d;
            double Blue = Color.B / 255d;

            double BlackKey = 1d - Math.Max(Math.Max(Red, Green), Blue);

            if (1d - BlackKey == 0d)
            {
                return (0d, 0d, 0d, 1d);
            }

            double Cyan = (1d - Red - BlackKey) / (1d - BlackKey);
            double Magenta = (1d - Green - BlackKey) / (1d - BlackKey);
            double Yellow = (1d - Blue - BlackKey) / (1d - BlackKey);

            return (Cyan, Magenta, Yellow, BlackKey);
        }
    }
}