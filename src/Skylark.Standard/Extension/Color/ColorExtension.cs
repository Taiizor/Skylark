using System.Globalization;
using SE = Skylark.Exception;
using SHA = Skylark.Helper.Adaptation;
using SSHCCH = Skylark.Standard.Helper.Color.ColorHelper;
using SSMCCM = Skylark.Standard.Manage.Color.ColorManage;
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
        /// <exception cref="SE"></exception>
        public static string ToHex(SDC Color, bool Upper = SSMCCM.Upper, bool Sharp = SSMCCM.Sharp)
        {
            try
            {
                return $"hex({SSHCCH.ConvertToHex(Color.R, Color.G, Color.B, Upper, Sharp)})";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <param name="Upper"></param>
        /// <param name="Sharp"></param>
        /// <returns></returns>
        public static async Task<string> ToHexAsync(SDC Color, bool Upper = SSMCCM.Upper, bool Sharp = SSMCCM.Sharp)
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
        /// <exception cref="SE"></exception>
        public static string ToHexInteger(SDC Color, bool Upper = SSMCCM.Upper, bool Sharp = SSMCCM.Sharp)
        {
            try
            {
                string Result = $"0x{SSHCCH.ConvertToHex(Color.A, Color.R, Color.G, Color.B, Upper, false)}";

                if (Sharp)
                {
                    Result = $"#{Result}";
                }

                return $"hexi({Result})";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <param name="Upper"></param>
        /// <param name="Sharp"></param>
        /// <returns></returns>
        public static async Task<string> ToHexIntegerAsync(SDC Color, bool Upper = SSMCCM.Upper, bool Sharp = SSMCCM.Sharp)
        {
            return await Task.Run(() => ToHexInteger(Color, Upper, Sharp));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Color"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string ToRGB(SDC Color)
        {
            try
            {
                return $"rgb({Color.R}, {Color.G}, {Color.B})";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string ToARGB(SDC Color)
        {
            try
            {
                return $"argb({Color.A}, {Color.R}, {Color.G}, {Color.B})";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string ToHSB(SDC Color)
        {
            try
            {
                (double Hue, double Saturation, double Brightness) = SSHCCH.ConvertToHSB(Color);

                Hue = Math.Round(Hue);
                Saturation = Math.Round(Saturation * 100);
                Brightness = Math.Round(Brightness * 100);

                return $"hsb({Hue}, {Saturation}%, {Brightness}%)";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string ToHSI(SDC Color)
        {
            try
            {
                (double Hue, double Saturation, double Intensity) = SSHCCH.ConvertToHSI(Color);

                Hue = Math.Round(Hue);
                Saturation = Math.Round(Saturation * 100);
                Intensity = Math.Round(Intensity * 100);

                return $"hsi({Hue}, {Saturation}%, {Intensity}%)";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string ToHSL(SDC Color)
        {
            try
            {
                (double Hue, double Saturation, double Lightness) = SSHCCH.ConvertToHSL(Color);

                Hue = Math.Round(Hue);
                Saturation = Math.Round(Saturation * 100);
                Lightness = Math.Round(Lightness * 100);

                return $"hsl({Hue}, {Saturation}%, {Lightness}%)";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string ToHSV(SDC Color)
        {
            try
            {
                (double Hue, double Saturation, double Value) = SSHCCH.ConvertToHSV(Color);

                Hue = Math.Round(Hue);
                Saturation = Math.Round(Saturation * 100);
                Value = Math.Round(Value * 100);

                return $"hsv({Hue}, {Saturation}%, {Value}%)";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string ToHWB(SDC Color)
        {
            try
            {
                (double Hue, double Whiteness, double Blackness) = SSHCCH.ConvertToHWB(Color);

                Hue = Math.Round(Hue);
                Whiteness = Math.Round(Whiteness * 100);
                Blackness = Math.Round(Blackness * 100);

                return $"hwb({Hue}, {Whiteness}%, {Blackness}%)";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string ToCMYK(SDC Color)
        {
            try
            {
                (double Cyan, double Magenta, double Yellow, double BlackKey) = SSHCCH.ConvertToCMYK(Color);

                Cyan = Math.Round(Cyan * 100);
                Magenta = Math.Round(Magenta * 100);
                Yellow = Math.Round(Yellow * 100);
                BlackKey = Math.Round(BlackKey * 100);

                return $"cmyk({Cyan}%, {Magenta}%, {Yellow}%, {BlackKey}%)";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string ToCIELAB(SDC Color)
        {
            try
            {
                (double Lightness, double ChromaticityA, double ChromaticityB) = SSHCCH.ConvertToCIELAB(Color);

                Lightness = Math.Round(Lightness, 2);
                ChromaticityA = Math.Round(ChromaticityA, 2);
                ChromaticityB = Math.Round(ChromaticityB, 2);

                return $"CIELab({Lightness}, {ChromaticityA}, {ChromaticityB})";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string ToCIEXYZ(SDC Color)
        {
            try
            {
                (double X, double Y, double Z) = SSHCCH.ConvertToCIEXYZ(Color);

                X = Math.Round(X * 100, 4);
                Y = Math.Round(Y * 100, 4);
                Z = Math.Round(Z * 100, 4);

                return $"CIEXYZ({X}, {Y}, {Z})";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string ToFloat(SDC Color)
        {
            try
            {
                (double Red, double Green, double Blue) = SSHCCH.ConvertToDouble(Color);

                const int Precision = 2;
                const string FloatFormat = "0.##";

                return $"float({Math.Round(Red, Precision).ToString(FloatFormat)}f, {Math.Round(Green, Precision).ToString(FloatFormat)}f, {Math.Round(Blue, Precision).ToString(FloatFormat)}f, 1f)";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string ToDecimal(SDC Color)
        {
            try
            {
                return $"decimal({(Color.R * 65536) + (Color.G * 256) + Color.B})";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string ToNatural(SDC Color)
        {
            try
            {
                (string Hue, double Whiteness, double Blackness) = SSHCCH.ConvertToNatural(Color);

                Whiteness = Math.Round(Whiteness * 100);
                Blackness = Math.Round(Blackness * 100);

                return $"ncol({Hue}, {Whiteness}%, {Blackness}%)";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        /// <exception cref="SE"></exception>
        public static string RGBToHex(int R = SSMCCM.Value, int G = SSMCCM.Value, int B = SSMCCM.Value, bool Upper = SSMCCM.Upper, bool Sharp = SSMCCM.Sharp)
        {
            try
            {
                return $"hex({SSHCCH.ConvertToHex(R, G, B, Upper, Sharp)})";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        public static async Task<string> RGBToHexAsync(int R = SSMCCM.Value, int G = SSMCCM.Value, int B = SSMCCM.Value, bool Upper = SSMCCM.Upper, bool Sharp = SSMCCM.Sharp)
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
        /// <exception cref="SE"></exception>
        public static string ARGBToHex(int A = SSMCCM.Value, int R = SSMCCM.Value, int G = SSMCCM.Value, int B = SSMCCM.Value, bool Upper = SSMCCM.Upper, bool Sharp = SSMCCM.Sharp)
        {
            try
            {
                return $"hex({SSHCCH.ConvertToHex(A, R, G, B, Upper, Sharp)})";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        public static async Task<string> ARGBToHexAsync(int A = SSMCCM.Value, int R = SSMCCM.Value, int G = SSMCCM.Value, int B = SSMCCM.Value, bool Upper = SSMCCM.Upper, bool Sharp = SSMCCM.Sharp)
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
        /// <exception cref="SE"></exception>
        public static SDC RGBToColor(int R = SSMCCM.Value, int G = SSMCCM.Value, int B = SSMCCM.Value)
        {
            try
            {
                return SSHCCH.ConvertToColor(R, G, B);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static async Task<SDC> RGBToColorAsync(int R = SSMCCM.Value, int G = SSMCCM.Value, int B = SSMCCM.Value)
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
        /// <exception cref="SE"></exception>
        public static SDC ARGBToColor(int A = SSMCCM.Value, int R = SSMCCM.Value, int G = SSMCCM.Value, int B = SSMCCM.Value)
        {
            try
            {
                return SSHCCH.ConvertToColor(A, R, G, B);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        public static async Task<SDC> ARGBToColorAsync(int A = SSMCCM.Value, int R = SSMCCM.Value, int G = SSMCCM.Value, int B = SSMCCM.Value)
        {
            return await Task.Run(() => ARGBToColor(A, R, G, B));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string HexToRGB(string Hex = SSMCCM.Hex)
        {
            try
            {
                Hex = SHA.Feed(Hex, SSMCCM.Hex, 6, 7);

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
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        public static async Task<string> HexToRGBAsync(string Hex = SSMCCM.Hex)
        {
            return await Task.Run(() => HexToRGB(Hex));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string HexToARGB(string Hex = SSMCCM.HexAlpha)
        {
            try
            {
                Hex = SHA.Feed(Hex, SSMCCM.HexAlpha, 8, 9);

                if (Hex.StartsWith("#"))
                {
                    Hex = Hex.Substring(1);
                }

                int Value = int.Parse(Hex, NumberStyles.HexNumber);

                SDC Color = SDC.FromArgb(Value);

                return $"argb({Color.A}, {Color.R}, {Color.G}, {Color.B})";
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        public static async Task<string> HexToARGBAsync(string Hex = SSMCCM.HexAlpha)
        {
            return await Task.Run(() => HexToARGB(Hex));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static SDC HexToColor(string Hex = SSMCCM.Hex)
        {
            try
            {
                Hex = SHA.Feed(Hex, SSMCCM.Hex, 6, 9);

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
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hex"></param>
        /// <returns></returns>
        public static async Task<SDC> HexToColorAsync(string Hex = SSMCCM.Hex)
        {
            return await Task.Run(() => HexToColor(Hex));
        }
    }
}