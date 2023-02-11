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
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        private static decimal PixelToEm(decimal Pixel = MTM.Value, decimal Coefficient = MTM.Pixel_Em_Coefficient, decimal Constant = MTM.Pixel_Em_Constant)
        {
            try
            {
                return Pixel / (Constant / Coefficient);
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
        /// <param name="Constant"></param>
        /// <returns></returns>
        private static Task<decimal> PixelToEmAsync(decimal Pixel = MTM.Value, decimal Coefficient = MTM.Pixel_Em_Coefficient, decimal Constant = MTM.Pixel_Em_Constant)
        {
            return Task.FromResult(PixelToEm(Pixel, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        private static decimal PixelToRem(decimal Pixel = MTM.Value, decimal Coefficient = MTM.Pixel_Rem_Coefficient, decimal Constant = MTM.Pixel_Rem_Constant)
        {
            try
            {
                return Pixel / (Constant / Coefficient);
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
        /// <param name="Constant"></param>
        /// <returns></returns>
        private static Task<decimal> PixelToRemAsync(decimal Pixel = MTM.Value, decimal Coefficient = MTM.Pixel_Rem_Coefficient, decimal Constant = MTM.Pixel_Rem_Constant)
        {
            return Task.FromResult(PixelToRem(Pixel, Coefficient, Constant));
        }

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
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> PixelToInchAsync(decimal Pixel = MTM.Value, decimal Constant = MTM.Pixel_Inch_Constant)
        {
            return Task.FromResult(PixelToInch(Pixel, Constant));
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
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        public static Task<decimal> PixelToPuntoAsync(decimal Pixel = MTM.Value, decimal Coefficient = MTM.Pixel_Punto_Coefficient)
        {
            return Task.FromResult(PixelToPunto(Pixel, Coefficient));
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
        /// <param name="Pixel"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> PixelToCentimeterAsync(decimal Pixel = MTM.Value, decimal Constant = MTM.Pixel_Centimeter_Constant)
        {
            return Task.FromResult(PixelToCentimeter(Pixel, Constant));
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
        public static Task<decimal> InchToPixelAsync(decimal Inch = MTM.Value, decimal Constant = MTM.Inch_Pixel_Constant)
        {
            return Task.FromResult(InchToPixel(Inch, Constant));
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
        public static Task<decimal> InchToPuntoAsync(decimal Inch = MTM.Value, decimal Constant = MTM.Inch_Punto_Constant)
        {
            return Task.FromResult(InchToPunto(Inch, Constant));
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
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> InchToCentimeterAsync(decimal Inch = MTM.Value, decimal Constant = MTM.Inch_Centimeter_Constant)
        {
            return Task.FromResult(InchToCentimeter(Inch, Constant));
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
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        public static Task<decimal> PuntoToPixelAsync(decimal Punto = MTM.Value, decimal Coefficient = MTM.Punto_Pixel_Coefficient)
        {
            return Task.FromResult(PuntoToPixel(Punto, Coefficient));
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
        public static Task<decimal> PuntoToInchAsync(decimal Punto = MTM.Value, decimal Constant = MTM.Punto_Inch_Constant)
        {
            return Task.FromResult(PuntoToInch(Punto, Constant));
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> PuntoToCentimeterAsync(decimal Punto = MTM.Value, decimal Constant = MTM.Punto_Centimeter_Constant)
        {
            return Task.FromResult(PuntoToCentimeter(Punto, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CentimeterToPixel(decimal Centimeter = MTM.Value, decimal Coefficient = MTM.Centimeter_Pixel_Coefficient, decimal Constant = MTM.Centimeter_Pixel_Constant)
        {
            try
            {
                return Centimeter * Constant / Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> CentimeterToPixelAsync(decimal Centimeter = MTM.Value, decimal Coefficient = MTM.Centimeter_Pixel_Coefficient, decimal Constant = MTM.Centimeter_Pixel_Constant)
        {
            return Task.FromResult(CentimeterToPixel(Centimeter, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CentimeterToInch(decimal Centimeter = MTM.Value, decimal Constant = MTM.Centimeter_Inch_Constant)
        {
            try
            {
                return Centimeter * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> CentimeterToInchAsync(decimal Centimeter = MTM.Value, decimal Constant = MTM.Centimeter_Inch_Constant)
        {
            return Task.FromResult(CentimeterToInch(Centimeter, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CentimeterToPunto(decimal Centimeter = MTM.Value, decimal Constant = MTM.Centimeter_Punto_Constant)
        {
            try
            {
                return Centimeter * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> CentimeterToPuntoAsync(decimal Centimeter = MTM.Value, decimal Constant = MTM.Centimeter_Punto_Constant)
        {
            return Task.FromResult(CentimeterToPunto(Centimeter, Constant));
        }
    }
}