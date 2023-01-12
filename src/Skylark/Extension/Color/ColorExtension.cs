using System.Drawing;
using E = Skylark.Exception;
using HCH = Skylark.Helper.ColorHelper;
using HL = Skylark.Helper.Length;
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
                return ToHex(Color.R, Color.G, Color.B, Upper, Sharp);
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
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <param name="Upper"></param>
        /// <param name="Sharp"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHex(int R = MCM.Integer, int G = MCM.Integer, int B = MCM.Integer, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
        {
            try
            {
                R = HL.Number(R, MCM.IntegerMin, MCM.IntegerMax);
                G = HL.Number(G, MCM.IntegerMin, MCM.IntegerMax);
                B = HL.Number(B, MCM.IntegerMin, MCM.IntegerMax);

                Color Color = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));

                string Result = string.Empty;

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
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}