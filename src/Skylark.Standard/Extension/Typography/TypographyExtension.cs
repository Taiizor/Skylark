using E = Skylark.Exception;
using MTTM = Skylark.Standard.Manage.Typography.TypographyManage;

namespace Skylark.Standard.Extension.Typography
{
    /// <summary>
    /// 
    /// </summary>
    public static class TypographyExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        private static decimal PixelToEm(decimal Pixel = MTTM.Value, decimal Coefficient = MTTM.Pixel_Em_Coefficient, decimal Constant = MTTM.Pixel_Em_Constant)
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
        private static Task<decimal> PixelToEmAsync(decimal Pixel = MTTM.Value, decimal Coefficient = MTTM.Pixel_Em_Coefficient, decimal Constant = MTTM.Pixel_Em_Constant)
        {
            return Task.Run(() => PixelToEm(Pixel, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        private static decimal PixelToRem(decimal Pixel = MTTM.Value, decimal Coefficient = MTTM.Pixel_Rem_Coefficient, decimal Constant = MTTM.Pixel_Rem_Constant)
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
        private static Task<decimal> PixelToRemAsync(decimal Pixel = MTTM.Value, decimal Coefficient = MTTM.Pixel_Rem_Coefficient, decimal Constant = MTTM.Pixel_Rem_Constant)
        {
            return Task.Run(() => PixelToRem(Pixel, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal PixelToInch(decimal Pixel = MTTM.Value, decimal Constant = MTTM.Pixel_Inch_Constant)
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
        public static Task<decimal> PixelToInchAsync(decimal Pixel = MTTM.Value, decimal Constant = MTTM.Pixel_Inch_Constant)
        {
            return Task.Run(() => PixelToInch(Pixel, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal PixelToPunto(decimal Pixel = MTTM.Value, decimal Coefficient = MTTM.Pixel_Punto_Coefficient)
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
        public static Task<decimal> PixelToPuntoAsync(decimal Pixel = MTTM.Value, decimal Coefficient = MTTM.Pixel_Punto_Coefficient)
        {
            return Task.Run(() => PixelToPunto(Pixel, Coefficient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal PixelToCentimeter(decimal Pixel = MTTM.Value, decimal Constant = MTTM.Pixel_Centimeter_Constant)
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
        public static Task<decimal> PixelToCentimeterAsync(decimal Pixel = MTTM.Value, decimal Constant = MTTM.Pixel_Centimeter_Constant)
        {
            return Task.Run(() => PixelToCentimeter(Pixel, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal InchToPixel(decimal Inch = MTTM.Value, decimal Constant = MTTM.Inch_Pixel_Constant)
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
        public static Task<decimal> InchToPixelAsync(decimal Inch = MTTM.Value, decimal Constant = MTTM.Inch_Pixel_Constant)
        {
            return Task.Run(() => InchToPixel(Inch, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal InchToPunto(decimal Inch = MTTM.Value, decimal Constant = MTTM.Inch_Punto_Constant)
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
        public static Task<decimal> InchToPuntoAsync(decimal Inch = MTTM.Value, decimal Constant = MTTM.Inch_Punto_Constant)
        {
            return Task.Run(() => InchToPunto(Inch, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal InchToCentimeter(decimal Inch = MTTM.Value, decimal Constant = MTTM.Inch_Centimeter_Constant)
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
        public static Task<decimal> InchToCentimeterAsync(decimal Inch = MTTM.Value, decimal Constant = MTTM.Inch_Centimeter_Constant)
        {
            return Task.Run(() => InchToCentimeter(Inch, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal PuntoToPixel(decimal Punto = MTTM.Value, decimal Coefficient = MTTM.Punto_Pixel_Coefficient)
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
        public static Task<decimal> PuntoToPixelAsync(decimal Punto = MTTM.Value, decimal Coefficient = MTTM.Punto_Pixel_Coefficient)
        {
            return Task.Run(() => PuntoToPixel(Punto, Coefficient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal PuntoToInch(decimal Punto = MTTM.Value, decimal Constant = MTTM.Punto_Inch_Constant)
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
        public static Task<decimal> PuntoToInchAsync(decimal Punto = MTTM.Value, decimal Constant = MTTM.Punto_Inch_Constant)
        {
            return Task.Run(() => PuntoToInch(Punto, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal PuntoToCentimeter(decimal Punto = MTTM.Value, decimal Constant = MTTM.Punto_Centimeter_Constant)
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
        public static Task<decimal> PuntoToCentimeterAsync(decimal Punto = MTTM.Value, decimal Constant = MTTM.Punto_Centimeter_Constant)
        {
            return Task.Run(() => PuntoToCentimeter(Punto, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CentimeterToPixel(decimal Centimeter = MTTM.Value, decimal Coefficient = MTTM.Centimeter_Pixel_Coefficient, decimal Constant = MTTM.Centimeter_Pixel_Constant)
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
        public static Task<decimal> CentimeterToPixelAsync(decimal Centimeter = MTTM.Value, decimal Coefficient = MTTM.Centimeter_Pixel_Coefficient, decimal Constant = MTTM.Centimeter_Pixel_Constant)
        {
            return Task.Run(() => CentimeterToPixel(Centimeter, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CentimeterToInch(decimal Centimeter = MTTM.Value, decimal Constant = MTTM.Centimeter_Inch_Constant)
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
        public static Task<decimal> CentimeterToInchAsync(decimal Centimeter = MTTM.Value, decimal Constant = MTTM.Centimeter_Inch_Constant)
        {
            return Task.Run(() => CentimeterToInch(Centimeter, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CentimeterToPunto(decimal Centimeter = MTTM.Value, decimal Constant = MTTM.Centimeter_Punto_Constant)
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
        public static Task<decimal> CentimeterToPuntoAsync(decimal Centimeter = MTTM.Value, decimal Constant = MTTM.Centimeter_Punto_Constant)
        {
            return Task.Run(() => CentimeterToPunto(Centimeter, Constant));
        }
    }
}