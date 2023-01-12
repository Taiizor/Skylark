using System;
using System.Drawing;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
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
        /// <param name="Upper"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHexInteger(Color Color, bool Upper = MCM.Upper)
        {
            try
            {
                return ToHexInteger(Color.R, Color.G, Color.B, Upper);
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
        public static string ToHex(int R, int G, int B, bool Upper = MCM.Upper, bool Sharp = MCM.Sharp)
        {
            try
            {
                R = HL.Number(R, MCM.Min, MCM.Max);
                G = HL.Number(G, MCM.Min, MCM.Max);
                B = HL.Number(B, MCM.Min, MCM.Max);

                Color Color = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));

                string Result = $"{Color.R:X2}{Color.G:X2}{Color.B:X2}";
                
                if (Upper)
                {
                    Result = Result.ToUpperInvariant();
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        /// <param name="Upper"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToHexInteger(int R, int G, int B, bool Upper = MCM.Upper)
        {
            try
            {
                string Result = ToHex(R, G, B);

                if (Upper)
                {
                    Result = $"0xFF{Result}";
                }
                else
                {
                    Result = $"0xff{Result}";
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