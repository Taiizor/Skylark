using HL = Skylark.Helper.Length;
using MCCM = Skylark.Standard.Manage.Color.ColorManage;
using SDC = System.Drawing.Color;

namespace Skylark.Standard.Helper.Color
{
    /// <summary>
    /// 
    /// </summary>
    internal static class ColorHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static SDC ConvertToColor(int R = MCCM.Value, int G = MCCM.Value, int B = MCCM.Value)
        {
            R = HL.Clamp(R, MCCM.ValueMin, MCCM.ValueMax);
            G = HL.Clamp(G, MCCM.ValueMin, MCCM.ValueMax);
            B = HL.Clamp(B, MCCM.ValueMin, MCCM.ValueMax);

            return SDC.FromArgb(R, G, B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        // TODO: Fix overlapping method signatures
        // Can't use other RGB ConvertToColor method because
        // all parameters have defaults
        public static SDC ConvertToColor(int A = MCCM.Value, int R = MCCM.Value, int G = MCCM.Value, int B = MCCM.Value)
        {
            A = HL.Clamp(A, MCCM.ValueMin, MCCM.ValueMax);
            R = HL.Clamp(R, MCCM.ValueMin, MCCM.ValueMax);
            G = HL.Clamp(G, MCCM.ValueMin, MCCM.ValueMax);
            B = HL.Clamp(B, MCCM.ValueMin, MCCM.ValueMax);

            return SDC.FromArgb(A, R, G, B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <param name="Upper"></param>
        /// <param name="Sharp"></param>
        /// <returns></returns>
        public static string ConvertToHex(int R = MCCM.Value, int G = MCCM.Value, int B = MCCM.Value, bool Upper = MCCM.Upper, bool Sharp = MCCM.Sharp)
        {
            SDC Color = ConvertToColor(R, G, B);

            string Result;

            if (Upper)
            {
                Result = $"{Color.R:X2}{Color.G:X2}{Color.B:X2}";
            }
            else
            {
                Result = $"{Color.R:x2}{Color.G:x2}{Color.B:x2}";
            }

            if (Sharp)
            {
                Result = $"#{Result}";
            }

            return Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <param name="Upper"></param>
        /// <param name="Sharp"></param>
        /// <returns></returns>
        public static string ConvertToHex(int A = MCCM.Value, int R = MCCM.Value, int G = MCCM.Value, int B = MCCM.Value, bool Upper = MCCM.Upper, bool Sharp = MCCM.Sharp)
        {
            SDC Color = ConvertToColor(A, R, G, B);

            string Result;

            if (Upper)
            {
                Result = $"{Color.A:X2}{Color.R:X2}{Color.G:X2}{Color.B:X2}";
            }
            else
            {
                Result = $"{Color.A:x2}{Color.R:x2}{Color.G:x2}{Color.B:x2}";
            }

            if (Sharp)
            {
                Result = $"#{Result}";
            }

            return Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static (double Red, double Green, double Blue) ConvertToDouble(SDC Color)
        {
            return (Color.R / 255d, Color.G / 255d, Color.B / 255d);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static (double Hue, double Saturation, double Brightness) ConvertToHSB(SDC Color)
        {
            return ConvertToHSV(Color);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static (double Hue, double Saturation, double Intensity) ConvertToHSI(SDC Color)
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
        public static (double Hue, double Saturation, double Lightness) ConvertToHSL(SDC Color)
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
        public static (double Hue, double Saturation, double Value) ConvertToHSV(SDC Color)
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
        public static (double Hue, double Whiteness, double Blackness) ConvertToHWB(SDC Color)
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
        public static (double Cyan, double Magenta, double Yellow, double BlackKey) ConvertToCMYK(SDC Color)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static (double Lightness, double ChromaticityA, double ChromaticityB) ConvertToCIELAB(SDC Color)
        {
            (double X, double Y, double Z) = ConvertToCIEXYZ(Color);
            (double Lightness, double ChromaticityA, double ChromaticityB) LAB = GetCIELABColorFromCIEXYZ(X, Y, Z);

            return LAB;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static (double X, double Y, double Z) ConvertToCIEXYZ(SDC Color)
        {
            double R = Color.R / 255d;
            double G = Color.G / 255d;
            double B = Color.B / 255d;

            double RLinear = (R > 0.04045) ? Math.Pow((R + 0.055) / 1.055, 2.4) : (R / 12.92);
            double GLinear = (G > 0.04045) ? Math.Pow((G + 0.055) / 1.055, 2.4) : (G / 12.92);
            double BLinear = (B > 0.04045) ? Math.Pow((B + 0.055) / 1.055, 2.4) : (B / 12.92);

            return (
                (RLinear * 0.41239079926595948) + (GLinear * 0.35758433938387796) + (BLinear * 0.18048078840183429),
                (RLinear * 0.21263900587151036) + (GLinear * 0.71516867876775593) + (BLinear * 0.07219231536073372),
                (RLinear * 0.01933081871559185) + (GLinear * 0.11919477979462599) + (BLinear * 0.95053215224966058)
            );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static (string Hue, double Whiteness, double Blackness) ConvertToNatural(SDC Color)
        {
            double Min = Math.Min(Math.Min(Color.R, Color.G), Color.B) / 255d;
            double Max = Math.Max(Math.Max(Color.R, Color.G), Color.B) / 255d;

            return (GetNaturalColorFromHue(Color.GetHue()), Min, 1 - Max);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hue"></param>
        /// <returns></returns>
        private static string GetNaturalColorFromHue(double Hue)
        {
            if (Hue < 60d)
            {
                return $"R{Math.Round(Hue / 0.6d, 0)}";
            }

            if (Hue < 120d)
            {
                return $"Y{Math.Round((Hue - 60d) / 0.6d, 0)}";
            }

            if (Hue < 180d)
            {
                return $"G{Math.Round((Hue - 120d) / 0.6d, 0)}";
            }

            if (Hue < 240d)
            {
                return $"C{Math.Round((Hue - 180d) / 0.6d, 0)}";
            }

            if (Hue < 300d)
            {
                return $"B{Math.Round((Hue - 240d) / 0.6d, 0)}";
            }

            return $"M{Math.Round((Hue - 300d) / 0.6d, 0)}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <returns></returns>
        private static (double Lightness, double ChromaticityA, double ChromaticityB) GetCIELABColorFromCIEXYZ(double X, double Y, double Z)
        {
            double X_N = 0.9504559270516717;
            double Y_N = 1.0;
            double Z_N = 1.0890577507598784;

            X /= X_N;
            Y /= Y_N;
            Z /= Z_N;

            double Delta = 6d / 29;
            double M = 1d / 3 * Math.Pow(Delta, -2);
            double T = Math.Pow(Delta, 3);

            double FX = (X > T) ? Math.Pow(X, 1.0 / 3.0) : (X * M) + (16.0 / 116.0);
            double FY = (Y > T) ? Math.Pow(Y, 1.0 / 3.0) : (Y * M) + (16.0 / 116.0);
            double FZ = (Z > T) ? Math.Pow(Z, 1.0 / 3.0) : (Z * M) + (16.0 / 116.0);

            double L = (116 * FY) - 16;
            double A = 500 * (FX - FY);
            double B = 200 * (FY - FZ);

            return (L, A, B);
        }
    }
}