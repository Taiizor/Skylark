using SE = Skylark.Exception;
using SSMSSM = Skylark.Standard.Manage.Speed.SpeedManage;

namespace Skylark.Standard.Extension.Speed
{
    /// <summary>
    /// 
    /// </summary>
    public static class SpeedExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CmsToMps(decimal Cms = SSMSSM.Value, decimal Constant = SSMSSM.Cms_Mps_Constant)
        {
            try
            {
                return Cms / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CmsToMpsAsync(decimal Cms = SSMSSM.Value, decimal Constant = SSMSSM.Cms_Mps_Constant)
        {
            return await Task.Run(() => CmsToMps(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CmsToKph(decimal Cms = SSMSSM.Value, decimal Constant = SSMSSM.Cms_Kph_Constant)
        {
            try
            {
                return Cms * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CmsToKphAsync(decimal Cms = SSMSSM.Value, decimal Constant = SSMSSM.Cms_Kph_Constant)
        {
            return await Task.Run(() => CmsToKph(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CmsToFts(decimal Cms = SSMSSM.Value, decimal Constant = SSMSSM.Cms_Fts_Constant)
        {
            try
            {
                return Cms / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CmsToFtsAsync(decimal Cms = SSMSSM.Value, decimal Constant = SSMSSM.Cms_Fts_Constant)
        {
            return await Task.Run(() => CmsToFts(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CmsToMph(decimal Cms = SSMSSM.Value, decimal Constant = SSMSSM.Cms_Mph_Constant)
        {
            try
            {
                return Cms * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CmsToMphAsync(decimal Cms = SSMSSM.Value, decimal Constant = SSMSSM.Cms_Mph_Constant)
        {
            return await Task.Run(() => CmsToMph(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CmsToKnot(decimal Cms = SSMSSM.Value, decimal Constant = SSMSSM.Cms_Knot_Constant)
        {
            try
            {
                return Cms * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CmsToKnotAsync(decimal Cms = SSMSSM.Value, decimal Constant = SSMSSM.Cms_Knot_Constant)
        {
            return await Task.Run(() => CmsToKnot(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CmsToMach(decimal Cms = SSMSSM.Value, decimal Constant = SSMSSM.Cms_Mach_Constant)
        {
            try
            {
                return Cms * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CmsToMachAsync(decimal Cms = SSMSSM.Value, decimal Constant = SSMSSM.Cms_Mach_Constant)
        {
            return await Task.Run(() => CmsToMach(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MpsToCms(decimal Mps = SSMSSM.Value, decimal Constant = SSMSSM.Mps_Cms_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MpsToCmsAsync(decimal Mps = SSMSSM.Value, decimal Constant = SSMSSM.Mps_Cms_Constant)
        {
            return await Task.Run(() => MpsToCms(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MpsToKph(decimal Mps = SSMSSM.Value, decimal Constant = SSMSSM.Mps_Kph_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MpsToKphAsync(decimal Mps = SSMSSM.Value, decimal Constant = SSMSSM.Mps_Kph_Constant)
        {
            return await Task.Run(() => MpsToKph(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MpsToFts(decimal Mps = SSMSSM.Value, decimal Constant = SSMSSM.Mps_Fts_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MpsToFtsAsync(decimal Mps = SSMSSM.Value, decimal Constant = SSMSSM.Mps_Fts_Constant)
        {
            return await Task.Run(() => MpsToFts(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MpsToMph(decimal Mps = SSMSSM.Value, decimal Constant = SSMSSM.Mps_Mph_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MpsToMphAsync(decimal Mps = SSMSSM.Value, decimal Constant = SSMSSM.Mps_Mph_Constant)
        {
            return await Task.Run(() => MpsToMph(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MpsToKnot(decimal Mps = SSMSSM.Value, decimal Constant = SSMSSM.Mps_Knot_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MpsToKnotAsync(decimal Mps = SSMSSM.Value, decimal Constant = SSMSSM.Mps_Knot_Constant)
        {
            return await Task.Run(() => MpsToKnot(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MpsToMach(decimal Mps = SSMSSM.Value, decimal Constant = SSMSSM.Mps_Mach_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MpsToMachAsync(decimal Mps = SSMSSM.Value, decimal Constant = SSMSSM.Mps_Mach_Constant)
        {
            return await Task.Run(() => MpsToMach(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KphToCms(decimal Kph = SSMSSM.Value, decimal Constant = SSMSSM.Kph_Cms_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KphToCmsAsync(decimal Kph = SSMSSM.Value, decimal Constant = SSMSSM.Kph_Cms_Constant)
        {
            return await Task.Run(() => KphToCms(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KphToMps(decimal Kph = SSMSSM.Value, decimal Constant = SSMSSM.Kph_Mps_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KphToMpsAsync(decimal Kph = SSMSSM.Value, decimal Constant = SSMSSM.Kph_Mps_Constant)
        {
            return await Task.Run(() => KphToMps(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KphToFts(decimal Kph = SSMSSM.Value, decimal Constant = SSMSSM.Kph_Fts_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KphToFtsAsync(decimal Kph = SSMSSM.Value, decimal Constant = SSMSSM.Kph_Fts_Constant)
        {
            return await Task.Run(() => KphToFts(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KphToMph(decimal Kph = SSMSSM.Value, decimal Constant = SSMSSM.Kph_Mph_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KphToMphAsync(decimal Kph = SSMSSM.Value, decimal Constant = SSMSSM.Kph_Mph_Constant)
        {
            return await Task.Run(() => KphToMph(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KphToKnot(decimal Kph = SSMSSM.Value, decimal Constant = SSMSSM.Kph_Knot_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KphToKnotAsync(decimal Kph = SSMSSM.Value, decimal Constant = SSMSSM.Kph_Knot_Constant)
        {
            return await Task.Run(() => KphToKnot(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KphToMach(decimal Kph = SSMSSM.Value, decimal Constant = SSMSSM.Kph_Mach_Constant)
        {
            try
            {
                return Kph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KphToMachAsync(decimal Kph = SSMSSM.Value, decimal Constant = SSMSSM.Kph_Mach_Constant)
        {
            return await Task.Run(() => KphToMach(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FtsToCms(decimal Fts = SSMSSM.Value, decimal Constant = SSMSSM.Fts_Cms_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FtsToCmsAsync(decimal Fts = SSMSSM.Value, decimal Constant = SSMSSM.Fts_Cms_Constant)
        {
            return await Task.Run(() => FtsToCms(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FtsToMps(decimal Fts = SSMSSM.Value, decimal Constant = SSMSSM.Fts_Mps_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FtsToMpsAsync(decimal Fts = SSMSSM.Value, decimal Constant = SSMSSM.Fts_Mps_Constant)
        {
            return await Task.Run(() => FtsToMps(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FtsToKph(decimal Fts = SSMSSM.Value, decimal Constant = SSMSSM.Fts_Kph_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FtsToKphAsync(decimal Fts = SSMSSM.Value, decimal Constant = SSMSSM.Fts_Kph_Constant)
        {
            return await Task.Run(() => FtsToKph(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FtsToMph(decimal Fts = SSMSSM.Value, decimal Constant = SSMSSM.Fts_Mph_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FtsToMphAsync(decimal Fts = SSMSSM.Value, decimal Constant = SSMSSM.Fts_Mph_Constant)
        {
            return await Task.Run(() => FtsToMph(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FtsToKnot(decimal Fts = SSMSSM.Value, decimal Constant = SSMSSM.Fts_Knot_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FtsToKnotAsync(decimal Fts = SSMSSM.Value, decimal Constant = SSMSSM.Fts_Knot_Constant)
        {
            return await Task.Run(() => FtsToKnot(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FtsToMach(decimal Fts = SSMSSM.Value, decimal Constant = SSMSSM.Fts_Mach_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FtsToMachAsync(decimal Fts = SSMSSM.Value, decimal Constant = SSMSSM.Fts_Mach_Constant)
        {
            return await Task.Run(() => FtsToMach(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MphToCms(decimal Mph = SSMSSM.Value, decimal Constant = SSMSSM.Mph_Cms_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MphToCmsAsync(decimal Mph = SSMSSM.Value, decimal Constant = SSMSSM.Mph_Cms_Constant)
        {
            return await Task.Run(() => MphToCms(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MphToMps(decimal Mph = SSMSSM.Value, decimal Constant = SSMSSM.Mph_Mps_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MphToMpsAsync(decimal Mph = SSMSSM.Value, decimal Constant = SSMSSM.Mph_Mps_Constant)
        {
            return await Task.Run(() => MphToMps(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MphToKph(decimal Mph = SSMSSM.Value, decimal Constant = SSMSSM.Mph_Kph_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MphToKphAsync(decimal Mph = SSMSSM.Value, decimal Constant = SSMSSM.Mph_Kph_Constant)
        {
            return await Task.Run(() => MphToKph(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MphToFts(decimal Mph = SSMSSM.Value, decimal Constant = SSMSSM.Mph_Fts_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MphToFtsAsync(decimal Mph = SSMSSM.Value, decimal Constant = SSMSSM.Mph_Fts_Constant)
        {
            return await Task.Run(() => MphToFts(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MphToKnot(decimal Mph = SSMSSM.Value, decimal Constant = SSMSSM.Mph_Knot_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MphToKnotAsync(decimal Mph = SSMSSM.Value, decimal Constant = SSMSSM.Mph_Knot_Constant)
        {
            return await Task.Run(() => MphToKnot(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MphToMach(decimal Mph = SSMSSM.Value, decimal Constant = SSMSSM.Mph_Mach_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MphToMachAsync(decimal Mph = SSMSSM.Value, decimal Constant = SSMSSM.Mph_Mach_Constant)
        {
            return await Task.Run(() => MphToMach(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KnotToCms(decimal Knot = SSMSSM.Value, decimal Constant = SSMSSM.Knot_Cms_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KnotToCmsAsync(decimal Knot = SSMSSM.Value, decimal Constant = SSMSSM.Knot_Cms_Constant)
        {
            return await Task.Run(() => KnotToCms(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KnotToMps(decimal Knot = SSMSSM.Value, decimal Constant = SSMSSM.Knot_Mps_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KnotToMpsAsync(decimal Knot = SSMSSM.Value, decimal Constant = SSMSSM.Knot_Mps_Constant)
        {
            return await Task.Run(() => KnotToMps(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KnotToKph(decimal Knot = SSMSSM.Value, decimal Constant = SSMSSM.Knot_Kph_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KnotToKphAsync(decimal Knot = SSMSSM.Value, decimal Constant = SSMSSM.Knot_Kph_Constant)
        {
            return await Task.Run(() => KnotToKph(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KnotToFts(decimal Knot = SSMSSM.Value, decimal Constant = SSMSSM.Knot_Fts_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KnotToFtsAsync(decimal Knot = SSMSSM.Value, decimal Constant = SSMSSM.Knot_Fts_Constant)
        {
            return await Task.Run(() => KnotToFts(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KnotToMph(decimal Knot = SSMSSM.Value, decimal Constant = SSMSSM.Knot_Mph_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KnotToMphAsync(decimal Knot = SSMSSM.Value, decimal Constant = SSMSSM.Knot_Mph_Constant)
        {
            return await Task.Run(() => KnotToMph(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KnotToMach(decimal Knot = SSMSSM.Value, decimal Constant = SSMSSM.Knot_Mach_Constant)
        {
            try
            {
                return Knot / Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KnotToMachAsync(decimal Knot = SSMSSM.Value, decimal Constant = SSMSSM.Knot_Mach_Constant)
        {
            return await Task.Run(() => KnotToMach(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MachToCms(decimal Mach = SSMSSM.Value, decimal Constant = SSMSSM.Mach_Cms_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MachToCmsAsync(decimal Mach = SSMSSM.Value, decimal Constant = SSMSSM.Mach_Cms_Constant)
        {
            return await Task.Run(() => MachToCms(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MachToMps(decimal Mach = SSMSSM.Value, decimal Constant = SSMSSM.Mach_Mps_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MachToMpsAsync(decimal Mach = SSMSSM.Value, decimal Constant = SSMSSM.Mach_Mps_Constant)
        {
            return await Task.Run(() => MachToMps(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MachToKph(decimal Mach = SSMSSM.Value, decimal Constant = SSMSSM.Mach_Kph_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MachToKphAsync(decimal Mach = SSMSSM.Value, decimal Constant = SSMSSM.Mach_Kph_Constant)
        {
            return await Task.Run(() => MachToKph(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MachToFts(decimal Mach = SSMSSM.Value, decimal Constant = SSMSSM.Mach_Fts_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MachToFtsAsync(decimal Mach = SSMSSM.Value, decimal Constant = SSMSSM.Mach_Fts_Constant)
        {
            return await Task.Run(() => MachToFts(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MachToMph(decimal Mach = SSMSSM.Value, decimal Constant = SSMSSM.Mach_Mph_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MachToMphAsync(decimal Mach = SSMSSM.Value, decimal Constant = SSMSSM.Mach_Mph_Constant)
        {
            return await Task.Run(() => MachToMph(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal MachToKnot(decimal Mach = SSMSSM.Value, decimal Constant = SSMSSM.Mach_Knot_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> MachToKnotAsync(decimal Mach = SSMSSM.Value, decimal Constant = SSMSSM.Mach_Knot_Constant)
        {
            return await Task.Run(() => MachToKnot(Mach, Constant));
        }
    }
}