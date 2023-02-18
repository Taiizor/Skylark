using System.Globalization;
using E = Skylark.Exception;
using HA = Skylark.Helper.Adaptation;
using HCH = Skylark.Helper.Color.ColorHelper;
using MCM = Skylark.Manage.Color.ColorManage;
using SDC = System.Drawing.Color;

namespace Skylark.Extension.Color
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
        public static string ToHex(SDC Color, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
        {
            try
            {
                return $"hex({HCH.ConvertToHex(Color.R, Color.G, Color.B, Upper, Sharp)})";
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
        public static Task<string> ToHexAsync(SDC Color, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
        {
            return Task.Run(() => ToHex(Color, Upper, Sharp));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <param name="Upper"></param>
        /// <param name="Sharp"></param>
        /// <returns></returns>
        public static string ToHexInteger(SDC Color, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
        {
            try
            {
                string Result = $"0x{HCH.ConvertToHex(Color.A, Color.R, Color.G, Color.B, Upper, false)}";

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
        public static Task<string> ToHexIntegerAsync(SDC Color, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
        {
            return Task.Run(() => ToHexInteger(Color, Upper, Sharp));
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
        public static Task<string> ToRGBAsync(SDC Color)
        {
            return Task.Run(() => ToRGB(Color));
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
        public static Task<string> ToARGBAsync(SDC Color)
        {
            return Task.Run(() => ToARGB(Color));
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
                (double Hue, double Saturation, double Brightness) = HCH.ConvertToHSB(Color);

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
        public static Task<string> ToHSBAsync(SDC Color)
        {
            return Task.Run(() => ToHSB(Color));
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
                (double Hue, double Saturation, double Intensity) = HCH.ConvertToHSI(Color);

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
        public static Task<string> ToHSIAsync(SDC Color)
        {
            return Task.Run(() => ToHSI(Color));
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
                (double Hue, double Saturation, double Lightness) = HCH.ConvertToHSL(Color);

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
        public static Task<string> ToHSLAsync(SDC Color)
        {
            return Task.Run(() => ToHSL(Color));
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
                (double Hue, double Saturation, double Value) = HCH.ConvertToHSV(Color);

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
        public static Task<string> ToHSVAsync(SDC Color)
        {
            return Task.Run(() => ToHSV(Color));
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
                (double Hue, double Whiteness, double Blackness) = HCH.ConvertToHWB(Color);

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
        public static Task<string> ToHWBAsync(SDC Color)
        {
            return Task.Run(() => ToHWB(Color));
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
                (double Cyan, double Magenta, double Yellow, double BlackKey) = HCH.ConvertToCMYK(Color);

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
        public static Task<string> ToCMYKAsync(SDC Color)
        {
            return Task.Run(() => ToCMYK(Color));
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
                (double Lightness, double ChromaticityA, double ChromaticityB) = HCH.ConvertToCIELAB(Color);

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
        public static Task<string> ToCIELABAsync(SDC Color)
        {
            return Task.Run(() => ToCIELAB(Color));
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
                (double X, double Y, double Z) = HCH.ConvertToCIEXYZ(Color);

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
        public static Task<string> ToCIEXYZAsync(SDC Color)
        {
            return Task.Run(() => ToCIEXYZ(Color));
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
                (double Red, double Green, double Blue) = HCH.ConvertToDouble(Color);

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
        public static Task<string> ToFloatAsync(SDC Color)
        {
            return Task.Run(() => ToFloat(Color));
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
        public static Task<string> ToDecimalAsync(SDC Color)
        {
            return Task.Run(() => ToDecimal(Color));
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
                (string Hue, double Whiteness, double Blackness) = HCH.ConvertToNatural(Color);

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
        public static Task<string> ToNaturalAsync(SDC Color)
        {
            return Task.Run(() => ToNatural(Color));
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
        public static string RGBToHex(int R = MCM.Value, int G = MCM.Value, int B = MCM.Value, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
        {
            try
            {
                return $"hex({HCH.ConvertToHex(R, G, B, Upper, Sharp)})";
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
        public static Task<string> RGBToHexAsync(int R = MCM.Value, int G = MCM.Value, int B = MCM.Value, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
        {
            return Task.Run(() => RGBToHex(R, G, B, Upper, Sharp));
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
        public static string ARGBToHex(int A = MCM.Value, int R = MCM.Value, int G = MCM.Value, int B = MCM.Value, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
        {
            try
            {
                return $"hex({HCH.ConvertToHex(A, R, G, B, Upper, Sharp)})";
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
        public static Task<string> ARGBToHexAsync(int A = MCM.Value, int R = MCM.Value, int G = MCM.Value, int B = MCM.Value, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
        {
            return Task.Run(() => ARGBToHex(A, R, G, B, Upper, Sharp));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static SDC RGBToColor(int R = MCM.Value, int G = MCM.Value, int B = MCM.Value)
        {
            try
            {
                return HCH.ConvertToColor(R, G, B);
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
        public static Task<SDC> RGBToColorAsync(int R = MCM.Value, int G = MCM.Value, int B = MCM.Value)
        {
            return Task.Run(() => RGBToColor(R, G, B));
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
        public static SDC ARGBToColor(int A = MCM.Value, int R = MCM.Value, int G = MCM.Value, int B = MCM.Value)
        {
            try
            {
                return HCH.ConvertToColor(A, R, G, B);
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
        public static Task<SDC> ARGBToColorAsync(int A = MCM.Value, int R = MCM.Value, int G = MCM.Value, int B = MCM.Value)
        {
            return Task.Run(() => ARGBToColor(A, R, G, B));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string HexToRGB(string Hex = MCM.Hex)
        {
            try
            {
                Hex = HA.Feed(Hex, MCM.Hex, 6, 7);

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
        public static Task<string> HexToRGBAsync(string Hex = MCM.Hex)
        {
            return Task.Run(() => HexToRGB(Hex));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string HexToARGB(string Hex = MCM.HexAlpha)
        {
            try
            {
                Hex = HA.Feed(Hex, MCM.HexAlpha, 8, 9);

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
        public static Task<string> HexToARGBAsync(string Hex = MCM.HexAlpha)
        {
            return Task.Run(() => HexToARGB(Hex));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static SDC HexToColor(string Hex = MCM.Hex)
        {
            try
            {
                Hex = HA.Feed(Hex, MCM.Hex, 6, 9);

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
        public static Task<SDC> HexToColorAsync(string Hex = MCM.Hex)
        {
            return Task.Run(() => HexToColor(Hex));
        }
    }
}