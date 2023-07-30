using SE = Skylark.Exception;
using SSMTTM = Skylark.Standard.Manage.Typography.TypographyManage;

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
        /// <exception cref="SE"></exception>
        private static decimal PixelToEm(decimal Pixel = SSMTTM.Value, decimal Coefficient = SSMTTM.Pixel_Em_Coefficient, decimal Constant = SSMTTM.Pixel_Em_Constant)
        {
            try
            {
                return Pixel / (Constant / Coefficient);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        private static async Task<decimal> PixelToEmAsync(decimal Pixel = SSMTTM.Value, decimal Coefficient = SSMTTM.Pixel_Em_Coefficient, decimal Constant = SSMTTM.Pixel_Em_Constant)
        {
            return await Task.Run(() => PixelToEm(Pixel, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        private static decimal PixelToRem(decimal Pixel = SSMTTM.Value, decimal Coefficient = SSMTTM.Pixel_Rem_Coefficient, decimal Constant = SSMTTM.Pixel_Rem_Constant)
        {
            try
            {
                return Pixel / (Constant / Coefficient);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        private static async Task<decimal> PixelToRemAsync(decimal Pixel = SSMTTM.Value, decimal Coefficient = SSMTTM.Pixel_Rem_Coefficient, decimal Constant = SSMTTM.Pixel_Rem_Constant)
        {
            return await Task.Run(() => PixelToRem(Pixel, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal PixelToInch(decimal Pixel = SSMTTM.Value, decimal Constant = SSMTTM.Pixel_Inch_Constant)
        {
            try
            {
                return Pixel * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> PixelToInchAsync(decimal Pixel = SSMTTM.Value, decimal Constant = SSMTTM.Pixel_Inch_Constant)
        {
            return await Task.Run(() => PixelToInch(Pixel, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal PixelToPunto(decimal Pixel = SSMTTM.Value, decimal Coefficient = SSMTTM.Pixel_Punto_Coefficient)
        {
            try
            {
                return Pixel * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        public static async Task<decimal> PixelToPuntoAsync(decimal Pixel = SSMTTM.Value, decimal Coefficient = SSMTTM.Pixel_Punto_Coefficient)
        {
            return await Task.Run(() => PixelToPunto(Pixel, Coefficient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal PixelToCentimeter(decimal Pixel = SSMTTM.Value, decimal Constant = SSMTTM.Pixel_Centimeter_Constant)
        {
            try
            {
                return Pixel * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pixel"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> PixelToCentimeterAsync(decimal Pixel = SSMTTM.Value, decimal Constant = SSMTTM.Pixel_Centimeter_Constant)
        {
            return await Task.Run(() => PixelToCentimeter(Pixel, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal InchToPixel(decimal Inch = SSMTTM.Value, decimal Constant = SSMTTM.Inch_Pixel_Constant)
        {
            try
            {
                return Inch * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> InchToPixelAsync(decimal Inch = SSMTTM.Value, decimal Constant = SSMTTM.Inch_Pixel_Constant)
        {
            return await Task.Run(() => InchToPixel(Inch, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal InchToPunto(decimal Inch = SSMTTM.Value, decimal Constant = SSMTTM.Inch_Punto_Constant)
        {
            try
            {
                return Inch * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> InchToPuntoAsync(decimal Inch = SSMTTM.Value, decimal Constant = SSMTTM.Inch_Punto_Constant)
        {
            return await Task.Run(() => InchToPunto(Inch, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal InchToCentimeter(decimal Inch = SSMTTM.Value, decimal Constant = SSMTTM.Inch_Centimeter_Constant)
        {
            try
            {
                return Inch * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Inch"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> InchToCentimeterAsync(decimal Inch = SSMTTM.Value, decimal Constant = SSMTTM.Inch_Centimeter_Constant)
        {
            return await Task.Run(() => InchToCentimeter(Inch, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal PuntoToPixel(decimal Punto = SSMTTM.Value, decimal Coefficient = SSMTTM.Punto_Pixel_Coefficient)
        {
            try
            {
                return Punto * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        public static async Task<decimal> PuntoToPixelAsync(decimal Punto = SSMTTM.Value, decimal Coefficient = SSMTTM.Punto_Pixel_Coefficient)
        {
            return await Task.Run(() => PuntoToPixel(Punto, Coefficient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal PuntoToInch(decimal Punto = SSMTTM.Value, decimal Constant = SSMTTM.Punto_Inch_Constant)
        {
            try
            {
                return Punto / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> PuntoToInchAsync(decimal Punto = SSMTTM.Value, decimal Constant = SSMTTM.Punto_Inch_Constant)
        {
            return await Task.Run(() => PuntoToInch(Punto, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal PuntoToCentimeter(decimal Punto = SSMTTM.Value, decimal Constant = SSMTTM.Punto_Centimeter_Constant)
        {
            try
            {
                return Punto * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Punto"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> PuntoToCentimeterAsync(decimal Punto = SSMTTM.Value, decimal Constant = SSMTTM.Punto_Centimeter_Constant)
        {
            return await Task.Run(() => PuntoToCentimeter(Punto, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CentimeterToPixel(decimal Centimeter = SSMTTM.Value, decimal Coefficient = SSMTTM.Centimeter_Pixel_Coefficient, decimal Constant = SSMTTM.Centimeter_Pixel_Constant)
        {
            try
            {
                return Centimeter * Constant / Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CentimeterToPixelAsync(decimal Centimeter = SSMTTM.Value, decimal Coefficient = SSMTTM.Centimeter_Pixel_Coefficient, decimal Constant = SSMTTM.Centimeter_Pixel_Constant)
        {
            return await Task.Run(() => CentimeterToPixel(Centimeter, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CentimeterToInch(decimal Centimeter = SSMTTM.Value, decimal Constant = SSMTTM.Centimeter_Inch_Constant)
        {
            try
            {
                return Centimeter * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CentimeterToInchAsync(decimal Centimeter = SSMTTM.Value, decimal Constant = SSMTTM.Centimeter_Inch_Constant)
        {
            return await Task.Run(() => CentimeterToInch(Centimeter, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CentimeterToPunto(decimal Centimeter = SSMTTM.Value, decimal Constant = SSMTTM.Centimeter_Punto_Constant)
        {
            try
            {
                return Centimeter * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Centimeter"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CentimeterToPuntoAsync(decimal Centimeter = SSMTTM.Value, decimal Constant = SSMTTM.Centimeter_Punto_Constant)
        {
            return await Task.Run(() => CentimeterToPunto(Centimeter, Constant));
        }
    }
}