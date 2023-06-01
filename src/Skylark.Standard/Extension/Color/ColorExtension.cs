using System.Globalization;
using E = Skylark.Exception;
using HA = Skylark.Helper.Adaptation;
using HCCH = Skylark.Standard.Helper.Color.ColorHelper;
using MCCM = Skylark.Standard.Manage.Color.ColorManage;
using SDC = System.Drawing.Color;

namespace Skylark.Standard.Extension.Color
{
    /// <summary>
    /// 
    /// </summary>
    public static class ColorExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <param name="Upper"></param>
        /// <param name="Sharp"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHex(SDC Color, bool Upper = MCCM.Upper, bool Sharp = MCCM.Sharp)
        {
            try
            {
                return $"hex({HCCH.ConvertToHex(Color.R, Color.G, Color.B, Upper, Sharp)})";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <param name="Upper"></param>
        /// <param name="Sharp"></param>
        /// <returns></returns>
        public static async Task<string> ToHexAsync(SDC Color, bool Upper = MCCM.Upper, bool Sharp = MCCM.Sharp)
        {
            return await Task.Run(() => ToHex(Color, Upper, Sharp));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <param name="Upper"></param>
        /// <param name="Sharp"></param>
        /// <returns></returns>
        public static string ToHexInteger(SDC Color, bool Upper = MCCM.Upper, bool Sharp = MCCM.Sharp)
        {
            try
            {
                string Result = $"0x{HCCH.ConvertToHex(Color.A, Color.R, Color.G, Color.B, Upper, false)}";

                if (Sharp)
                {
                    Result = $"#{Result}";
                }

                return $"hexi({Result})";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <param name="Upper"></param>
        /// <param name="Sharp"></param>
        /// <returns></returns>
        public static async Task<string> ToHexIntegerAsync(SDC Color, bool Upper = MCCM.Upper, bool Sharp = MCCM.Sharp)
        {
            return await Task.Run(() => ToHexInteger(Color, Upper, Sharp));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToRGB(SDC Color)
        {
            try
            {
                return $"rgb({Color.R}, {Color.G}, {Color.B})";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToRGBAsync(SDC Color)
        {
            return await Task.Run(() => ToRGB(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToARGB(SDC Color)
        {
            try
            {
                return $"argb({Color.A}, {Color.R}, {Color.G}, {Color.B})";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToARGBAsync(SDC Color)
        {
            return await Task.Run(() => ToARGB(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHSB(SDC Color)
        {
            try
            {
                (double Hue, double Saturation, double Brightness) = HCCH.ConvertToHSB(Color);

                Hue = Math.Round(Hue);
                Saturation = Math.Round(Saturation * 100);
                Brightness = Math.Round(Brightness * 100);

                return $"hsb({Hue}, {Saturation}%, {Brightness}%)";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToHSBAsync(SDC Color)
        {
            return await Task.Run(() => ToHSB(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHSI(SDC Color)
        {
            try
            {
                (double Hue, double Saturation, double Intensity) = HCCH.ConvertToHSI(Color);

                Hue = Math.Round(Hue);
                Saturation = Math.Round(Saturation * 100);
                Intensity = Math.Round(Intensity * 100);

                return $"hsi({Hue}, {Saturation}%, {Intensity}%)";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToHSIAsync(SDC Color)
        {
            return await Task.Run(() => ToHSI(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHSL(SDC Color)
        {
            try
            {
                (double Hue, double Saturation, double Lightness) = HCCH.ConvertToHSL(Color);

                Hue = Math.Round(Hue);
                Saturation = Math.Round(Saturation * 100);
                Lightness = Math.Round(Lightness * 100);

                return $"hsl({Hue}, {Saturation}%, {Lightness}%)";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToHSLAsync(SDC Color)
        {
            return await Task.Run(() => ToHSL(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHSV(SDC Color)
        {
            try
            {
                (double Hue, double Saturation, double Value) = HCCH.ConvertToHSV(Color);

                Hue = Math.Round(Hue);
                Saturation = Math.Round(Saturation * 100);
                Value = Math.Round(Value * 100);

                return $"hsv({Hue}, {Saturation}%, {Value}%)";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToHSVAsync(SDC Color)
        {
            return await Task.Run(() => ToHSV(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHWB(SDC Color)
        {
            try
            {
                (double Hue, double Whiteness, double Blackness) = HCCH.ConvertToHWB(Color);

                Hue = Math.Round(Hue);
                Whiteness = Math.Round(Whiteness * 100);
                Blackness = Math.Round(Blackness * 100);

                return $"hwb({Hue}, {Whiteness}%, {Blackness}%)";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToHWBAsync(SDC Color)
        {
            return await Task.Run(() => ToHWB(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToCMYK(SDC Color)
        {
            try
            {
                (double Cyan, double Magenta, double Yellow, double BlackKey) = HCCH.ConvertToCMYK(Color);

                Cyan = Math.Round(Cyan * 100);
                Magenta = Math.Round(Magenta * 100);
                Yellow = Math.Round(Yellow * 100);
                BlackKey = Math.Round(BlackKey * 100);

                return $"cmyk({Cyan}%, {Magenta}%, {Yellow}%, {BlackKey}%)";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToCMYKAsync(SDC Color)
        {
            return await Task.Run(() => ToCMYK(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToCIELAB(SDC Color)
        {
            try
            {
                (double Lightness, double ChromaticityA, double ChromaticityB) = HCCH.ConvertToCIELAB(Color);

                Lightness = Math.Round(Lightness, 2);
                ChromaticityA = Math.Round(ChromaticityA, 2);
                ChromaticityB = Math.Round(ChromaticityB, 2);

                return $"CIELab({Lightness}, {ChromaticityA}, {ChromaticityB})";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToCIELABAsync(SDC Color)
        {
            return await Task.Run(() => ToCIELAB(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToCIEXYZ(SDC Color)
        {
            try
            {
                (double X, double Y, double Z) = HCCH.ConvertToCIEXYZ(Color);

                X = Math.Round(X * 100, 4);
                Y = Math.Round(Y * 100, 4);
                Z = Math.Round(Z * 100, 4);

                return $"CIEXYZ({X}, {Y}, {Z})";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToCIEXYZAsync(SDC Color)
        {
            return await Task.Run(() => ToCIEXYZ(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToFloat(SDC Color)
        {
            try
            {
                (double Red, double Green, double Blue) = HCCH.ConvertToDouble(Color);

                const int Precision = 2;
                const string FloatFormat = "0.##";

                return $"float({Math.Round(Red, Precision).ToString(FloatFormat)}f, {Math.Round(Green, Precision).ToString(FloatFormat)}f, {Math.Round(Blue, Precision).ToString(FloatFormat)}f, 1f)";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToFloatAsync(SDC Color)
        {
            return await Task.Run(() => ToFloat(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToDecimal(SDC Color)
        {
            try
            {
                return $"decimal({(Color.R * 65536) + (Color.G * 256) + Color.B})";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToDecimalAsync(SDC Color)
        {
            return await Task.Run(() => ToDecimal(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToNatural(SDC Color)
        {
            try
            {
                (string Hue, double Whiteness, double Blackness) = HCCH.ConvertToNatural(Color);

                Whiteness = Math.Round(Whiteness * 100);
                Blackness = Math.Round(Blackness * 100);

                return $"ncol({Hue}, {Whiteness}%, {Blackness}%)";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        public static async Task<string> ToNaturalAsync(SDC Color)
        {
            return await Task.Run(() => ToNatural(Color));
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
        /// <exception cref="E"></exception>
        public static string RGBToHex(int R = MCCM.Value, int G = MCCM.Value, int B = MCCM.Value, bool Upper = MCCM.Upper, bool Sharp = MCCM.Sharp)
        {
            try
            {
                return $"hex({HCCH.ConvertToHex(R, G, B, Upper, Sharp)})";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
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
        public static async Task<string> RGBToHexAsync(int R = MCCM.Value, int G = MCCM.Value, int B = MCCM.Value, bool Upper = MCCM.Upper, bool Sharp = MCCM.Sharp)
        {
            return await Task.Run(() => RGBToHex(R, G, B, Upper, Sharp));
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
        /// <exception cref="E"></exception>
        public static string ARGBToHex(int A = MCCM.Value, int R = MCCM.Value, int G = MCCM.Value, int B = MCCM.Value, bool Upper = MCCM.Upper, bool Sharp = MCCM.Sharp)
        {
            try
            {
                return $"hex({HCCH.ConvertToHex(A, R, G, B, Upper, Sharp)})";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
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
        public static async Task<string> ARGBToHexAsync(int A = MCCM.Value, int R = MCCM.Value, int G = MCCM.Value, int B = MCCM.Value, bool Upper = MCCM.Upper, bool Sharp = MCCM.Sharp)
        {
            return await Task.Run(() => ARGBToHex(A, R, G, B, Upper, Sharp));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static SDC RGBToColor(int R = MCCM.Value, int G = MCCM.Value, int B = MCCM.Value)
        {
            try
            {
                return HCCH.ConvertToColor(R, G, B);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static async Task<SDC> RGBToColorAsync(int R = MCCM.Value, int G = MCCM.Value, int B = MCCM.Value)
        {
            return await Task.Run(() => RGBToColor(R, G, B));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static SDC ARGBToColor(int A = MCCM.Value, int R = MCCM.Value, int G = MCCM.Value, int B = MCCM.Value)
        {
            try
            {
                return HCCH.ConvertToColor(A, R, G, B);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static async Task<SDC> ARGBToColorAsync(int A = MCCM.Value, int R = MCCM.Value, int G = MCCM.Value, int B = MCCM.Value)
        {
            return await Task.Run(() => ARGBToColor(A, R, G, B));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string HexToRGB(string Hex = MCCM.Hex)
        {
            try
            {
                Hex = HA.Feed(Hex, MCCM.Hex, 6, 7);

                if (Hex.StartsWith("#"))
                {
                    Hex = Hex.Substring(1);
                }

                int Value = Convert.ToInt32(Hex, 16);

                int Red = (Value >> 16) & 0xFF;
                int Green = (Value >> 8) & 0xFF;
                int Blue = Value & 0xFF;

                return $"rgb({Red}, {Green}, {Blue})";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        public static async Task<string> HexToRGBAsync(string Hex = MCCM.Hex)
        {
            return await Task.Run(() => HexToRGB(Hex));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string HexToARGB(string Hex = MCCM.HexAlpha)
        {
            try
            {
                Hex = HA.Feed(Hex, MCCM.HexAlpha, 8, 9);

                if (Hex.StartsWith("#"))
                {
                    Hex = Hex.Substring(1);
                }

                int Value = int.Parse(Hex, NumberStyles.HexNumber);

                SDC Color = SDC.FromArgb(Value);

                return $"argb({Color.A}, {Color.R}, {Color.G}, {Color.B})";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        public static async Task<string> HexToARGBAsync(string Hex = MCCM.HexAlpha)
        {
            return await Task.Run(() => HexToARGB(Hex));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static SDC HexToColor(string Hex = MCCM.Hex)
        {
            try
            {
                Hex = HA.Feed(Hex, MCCM.Hex, 6, 9);

                if (Hex.StartsWith("#"))
                {
                    Hex = Hex.Substring(1);
                }

                if (Hex.Length == 6)
                {
                    int Value = Convert.ToInt32(Hex, 16);

                    int Red = (Value >> 16) & 0xFF;
                    int Green = (Value >> 8) & 0xFF;
                    int Blue = Value & 0xFF;

                    return SDC.FromArgb(Red, Green, Blue);
                }
                else
                {
                    int Value = int.Parse(Hex, NumberStyles.HexNumber);

                    return SDC.FromArgb(Value);
                }
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        public static async Task<SDC> HexToColorAsync(string Hex = MCCM.Hex)
        {
            return await Task.Run(() => HexToColor(Hex));
        }
    }
}