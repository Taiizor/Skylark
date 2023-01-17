using E = Skylark.Exception;
using MTM = Skylark.Manage.TypographyManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class TypographyExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal PixelToInch(decimal Pixel = MTM.Value, decimal Constant = MTM.Pixel_Inch_Constant)
        {
            try
            {
                return Pixel * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal PixelToPunto(decimal Pixel = MTM.Value, decimal Coefficient = MTM.Pixel_Punto_Coefficient)
        {
            try
            {
                return Pixel * Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal PixelToCentimeter(decimal Pixel = MTM.Value, decimal Constant = MTM.Pixel_Centimeter_Constant)
        {
            try
            {
                return Pixel * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal InchToPixel(decimal Inch = MTM.Value, decimal Constant = MTM.Inch_Pixel_Constant)
        {
            try
            {
                return Inch * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal InchToPunto(decimal Inch = MTM.Value, decimal Constant = MTM.Inch_Punto_Constant)
        {
            try
            {
                return Inch * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal InchToCentimeter(decimal Inch = MTM.Value, decimal Constant = MTM.Inch_Centimeter_Constant)
        {
            try
            {
                return Inch * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal PuntoToPixel(decimal Punto = MTM.Value, decimal Coefficient = MTM.Punto_Pixel_Coefficient)
        {
            try
            {
                return Punto * Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal PuntoToInch(decimal Punto = MTM.Value, decimal Constant = MTM.Punto_Inch_Constant)
        {
            try
            {
                return Punto / Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal PuntoToCentimeter(decimal Punto = MTM.Value, decimal Constant = MTM.Punto_Centimeter_Constant)
        {
            try
            {
                return Punto * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}