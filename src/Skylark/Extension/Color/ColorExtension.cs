using System.Drawing;
using System.Globalization;
using E = Skylark.Exception;
using HA = Skylark.Helper.Adaptation;
using HCH = Skylark.Helper.ColorHelper;
using MCM = Skylark.Manage.ColorManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class ColorExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <param name="Upper"></param>
        /// <param name="Sharp"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHex(Color Color, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
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
        public static Task<string> ToHexAsync(Color Color, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
        {
            return Task.FromResult(ToHex(Color, Upper, Sharp));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <param name="Upper"></param>
        /// <param name="Sharp"></param>
        /// <returns></returns>
        public static string ToHexInteger(Color Color, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
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
        public static Task<string> ToHexIntegerAsync(Color Color, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
        {
            return Task.FromResult(ToHexInteger(Color, Upper, Sharp));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToRGB(Color Color)
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
        public static Task<string> ToRGBAsync(Color Color)
        {
            return Task.FromResult(ToRGB(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToARGB(Color Color)
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
        public static Task<string> ToARGBAsync(Color Color)
        {
            return Task.FromResult(ToARGB(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHSB(Color Color)
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
        public static Task<string> ToHSBAsync(Color Color)
        {
            return Task.FromResult(ToHSB(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHSI(Color Color)
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
        public static Task<string> ToHSIAsync(Color Color)
        {
            return Task.FromResult(ToHSI(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHSL(Color Color)
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
        public static Task<string> ToHSLAsync(Color Color)
        {
            return Task.FromResult(ToHSL(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHSV(Color Color)
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
        public static Task<string> ToHSVAsync(Color Color)
        {
            return Task.FromResult(ToHSV(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHWB(Color Color)
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
        public static Task<string> ToHWBAsync(Color Color)
        {
            return Task.FromResult(ToHWB(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToCMYK(Color Color)
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
        public static Task<string> ToCMYKAsync(Color Color)
        {
            return Task.FromResult(ToCMYK(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToCIELAB(Color Color)
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
        public static Task<string> ToCIELABAsync(Color Color)
        {
            return Task.FromResult(ToCIELAB(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToCIEXYZ(Color Color)
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
        public static Task<string> ToCIEXYZAsync(Color Color)
        {
            return Task.FromResult(ToCIEXYZ(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToFloat(Color Color)
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
        public static Task<string> ToFloatAsync(Color Color)
        {
            return Task.FromResult(ToFloat(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToDecimal(Color Color)
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
        public static Task<string> ToDecimalAsync(Color Color)
        {
            return Task.FromResult(ToDecimal(Color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToNatural(Color Color)
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
        public static Task<string> ToNaturalAsync(Color Color)
        {
            return Task.FromResult(ToNatural(Color));
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
            return Task.FromResult(RGBToHex(R, G, B, Upper, Sharp));
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
            return Task.FromResult(ARGBToHex(A, R, G, B, Upper, Sharp));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static Color RGBToColor(int R = MCM.Value, int G = MCM.Value, int B = MCM.Value)
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
        public static Task<Color> RGBToColorAsync(int R = MCM.Value, int G = MCM.Value, int B = MCM.Value)
        {
            return Task.FromResult(RGBToColor(R, G, B));
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
        public static Color ARGBToColor(int A = MCM.Value, int R = MCM.Value, int G = MCM.Value, int B = MCM.Value)
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
        public static Task<Color> ARGBToColorAsync(int A = MCM.Value, int R = MCM.Value, int G = MCM.Value, int B = MCM.Value)
        {
            return Task.FromResult(ARGBToColor(A, R, G, B));
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
            return Task.FromResult(HexToRGB(Hex));
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

                Color Color = Color.FromArgb(Value);

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
            return Task.FromResult(HexToARGB(Hex));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static Color HexToColor(string Hex = MCM.Hex)
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

                    return Color.FromArgb(Red, Green, Blue);
                }
                else
                {
                    int Value = int.Parse(Hex, NumberStyles.HexNumber);

                    return Color.FromArgb(Value);
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
        public static Task<Color> HexToColorAsync(string Hex = MCM.Hex)
        {
            return Task.FromResult(HexToColor(Hex));
        }
    }
}