using E = Skylark.Exception;
using MSM = Skylark.Manage.SpeedManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class SpeedExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmsToMps(decimal Cms = MSM.Value, decimal Constant = MSM.Cms_Mps_Constant)
        {
            try
            {
                return Cms / Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> CmsToMpsAsync(decimal Cms = MSM.Value, decimal Constant = MSM.Cms_Mps_Constant)
        {
            return Task.Run(() => CmsToMps(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmsToKph(decimal Cms = MSM.Value, decimal Constant = MSM.Cms_Kph_Constant)
        {
            try
            {
                return Cms * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> CmsToKphAsync(decimal Cms = MSM.Value, decimal Constant = MSM.Cms_Kph_Constant)
        {
            return Task.Run(() => CmsToKph(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmsToFts(decimal Cms = MSM.Value, decimal Constant = MSM.Cms_Fts_Constant)
        {
            try
            {
                return Cms / Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> CmsToFtsAsync(decimal Cms = MSM.Value, decimal Constant = MSM.Cms_Fts_Constant)
        {
            return Task.Run(() => CmsToFts(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmsToMph(decimal Cms = MSM.Value, decimal Constant = MSM.Cms_Mph_Constant)
        {
            try
            {
                return Cms * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> CmsToMphAsync(decimal Cms = MSM.Value, decimal Constant = MSM.Cms_Mph_Constant)
        {
            return Task.Run(() => CmsToMph(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmsToKnot(decimal Cms = MSM.Value, decimal Constant = MSM.Cms_Knot_Constant)
        {
            try
            {
                return Cms * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> CmsToKnotAsync(decimal Cms = MSM.Value, decimal Constant = MSM.Cms_Knot_Constant)
        {
            return Task.Run(() => CmsToKnot(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmsToMach(decimal Cms = MSM.Value, decimal Constant = MSM.Cms_Mach_Constant)
        {
            try
            {
                return Cms * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cms"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> CmsToMachAsync(decimal Cms = MSM.Value, decimal Constant = MSM.Cms_Mach_Constant)
        {
            return Task.Run(() => CmsToMach(Cms, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToCms(decimal Mps = MSM.Value, decimal Constant = MSM.Mps_Cms_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MpsToCmsAsync(decimal Mps = MSM.Value, decimal Constant = MSM.Mps_Cms_Constant)
        {
            return Task.Run(() => MpsToCms(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToKph(decimal Mps = MSM.Value, decimal Constant = MSM.Mps_Kph_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MpsToKphAsync(decimal Mps = MSM.Value, decimal Constant = MSM.Mps_Kph_Constant)
        {
            return Task.Run(() => MpsToKph(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToFts(decimal Mps = MSM.Value, decimal Constant = MSM.Mps_Fts_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MpsToFtsAsync(decimal Mps = MSM.Value, decimal Constant = MSM.Mps_Fts_Constant)
        {
            return Task.Run(() => MpsToFts(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToMph(decimal Mps = MSM.Value, decimal Constant = MSM.Mps_Mph_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MpsToMphAsync(decimal Mps = MSM.Value, decimal Constant = MSM.Mps_Mph_Constant)
        {
            return Task.Run(() => MpsToMph(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToKnot(decimal Mps = MSM.Value, decimal Constant = MSM.Mps_Knot_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MpsToKnotAsync(decimal Mps = MSM.Value, decimal Constant = MSM.Mps_Knot_Constant)
        {
            return Task.Run(() => MpsToKnot(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToMach(decimal Mps = MSM.Value, decimal Constant = MSM.Mps_Mach_Constant)
        {
            try
            {
                return Mps * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mps"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MpsToMachAsync(decimal Mps = MSM.Value, decimal Constant = MSM.Mps_Mach_Constant)
        {
            return Task.Run(() => MpsToMach(Mps, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToCms(decimal Kph = MSM.Value, decimal Constant = MSM.Kph_Cms_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KphToCmsAsync(decimal Kph = MSM.Value, decimal Constant = MSM.Kph_Cms_Constant)
        {
            return Task.Run(() => KphToCms(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToMps(decimal Kph = MSM.Value, decimal Constant = MSM.Kph_Mps_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KphToMpsAsync(decimal Kph = MSM.Value, decimal Constant = MSM.Kph_Mps_Constant)
        {
            return Task.Run(() => KphToMps(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToFts(decimal Kph = MSM.Value, decimal Constant = MSM.Kph_Fts_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KphToFtsAsync(decimal Kph = MSM.Value, decimal Constant = MSM.Kph_Fts_Constant)
        {
            return Task.Run(() => KphToFts(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToMph(decimal Kph = MSM.Value, decimal Constant = MSM.Kph_Mph_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KphToMphAsync(decimal Kph = MSM.Value, decimal Constant = MSM.Kph_Mph_Constant)
        {
            return Task.Run(() => KphToMph(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToKnot(decimal Kph = MSM.Value, decimal Constant = MSM.Kph_Knot_Constant)
        {
            try
            {
                return Kph / Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KphToKnotAsync(decimal Kph = MSM.Value, decimal Constant = MSM.Kph_Knot_Constant)
        {
            return Task.Run(() => KphToKnot(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToMach(decimal Kph = MSM.Value, decimal Constant = MSM.Kph_Mach_Constant)
        {
            try
            {
                return Kph * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KphToMachAsync(decimal Kph = MSM.Value, decimal Constant = MSM.Kph_Mach_Constant)
        {
            return Task.Run(() => KphToMach(Kph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FtsToCms(decimal Fts = MSM.Value, decimal Constant = MSM.Fts_Cms_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> FtsToCmsAsync(decimal Fts = MSM.Value, decimal Constant = MSM.Fts_Cms_Constant)
        {
            return Task.Run(() => FtsToCms(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FtsToMps(decimal Fts = MSM.Value, decimal Constant = MSM.Fts_Mps_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> FtsToMpsAsync(decimal Fts = MSM.Value, decimal Constant = MSM.Fts_Mps_Constant)
        {
            return Task.Run(() => FtsToMps(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FtsToKph(decimal Fts = MSM.Value, decimal Constant = MSM.Fts_Kph_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> FtsToKphAsync(decimal Fts = MSM.Value, decimal Constant = MSM.Fts_Kph_Constant)
        {
            return Task.Run(() => FtsToKph(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FtsToMph(decimal Fts = MSM.Value, decimal Constant = MSM.Fts_Mph_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> FtsToMphAsync(decimal Fts = MSM.Value, decimal Constant = MSM.Fts_Mph_Constant)
        {
            return Task.Run(() => FtsToMph(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FtsToKnot(decimal Fts = MSM.Value, decimal Constant = MSM.Fts_Knot_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> FtsToKnotAsync(decimal Fts = MSM.Value, decimal Constant = MSM.Fts_Knot_Constant)
        {
            return Task.Run(() => FtsToKnot(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FtsToMach(decimal Fts = MSM.Value, decimal Constant = MSM.Fts_Mach_Constant)
        {
            try
            {
                return Fts * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fts"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> FtsToMachAsync(decimal Fts = MSM.Value, decimal Constant = MSM.Fts_Mach_Constant)
        {
            return Task.Run(() => FtsToMach(Fts, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToCms(decimal Mph = MSM.Value, decimal Constant = MSM.Mph_Cms_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MphToCmsAsync(decimal Mph = MSM.Value, decimal Constant = MSM.Mph_Cms_Constant)
        {
            return Task.Run(() => MphToCms(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToMps(decimal Mph = MSM.Value, decimal Constant = MSM.Mph_Mps_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MphToMpsAsync(decimal Mph = MSM.Value, decimal Constant = MSM.Mph_Mps_Constant)
        {
            return Task.Run(() => MphToMps(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToKph(decimal Mph = MSM.Value, decimal Constant = MSM.Mph_Kph_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MphToKphAsync(decimal Mph = MSM.Value, decimal Constant = MSM.Mph_Kph_Constant)
        {
            return Task.Run(() => MphToKph(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToFts(decimal Mph = MSM.Value, decimal Constant = MSM.Mph_Fts_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MphToFtsAsync(decimal Mph = MSM.Value, decimal Constant = MSM.Mph_Fts_Constant)
        {
            return Task.Run(() => MphToFts(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToKnot(decimal Mph = MSM.Value, decimal Constant = MSM.Mph_Knot_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MphToKnotAsync(decimal Mph = MSM.Value, decimal Constant = MSM.Mph_Knot_Constant)
        {
            return Task.Run(() => MphToKnot(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToMach(decimal Mph = MSM.Value, decimal Constant = MSM.Mph_Mach_Constant)
        {
            try
            {
                return Mph * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mph"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MphToMachAsync(decimal Mph = MSM.Value, decimal Constant = MSM.Mph_Mach_Constant)
        {
            return Task.Run(() => MphToMach(Mph, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KnotToCms(decimal Knot = MSM.Value, decimal Constant = MSM.Knot_Cms_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KnotToCmsAsync(decimal Knot = MSM.Value, decimal Constant = MSM.Knot_Cms_Constant)
        {
            return Task.Run(() => KnotToCms(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KnotToMps(decimal Knot = MSM.Value, decimal Constant = MSM.Knot_Mps_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KnotToMpsAsync(decimal Knot = MSM.Value, decimal Constant = MSM.Knot_Mps_Constant)
        {
            return Task.Run(() => KnotToMps(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KnotToKph(decimal Knot = MSM.Value, decimal Constant = MSM.Knot_Kph_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KnotToKphAsync(decimal Knot = MSM.Value, decimal Constant = MSM.Knot_Kph_Constant)
        {
            return Task.Run(() => KnotToKph(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KnotToFts(decimal Knot = MSM.Value, decimal Constant = MSM.Knot_Fts_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KnotToFtsAsync(decimal Knot = MSM.Value, decimal Constant = MSM.Knot_Fts_Constant)
        {
            return Task.Run(() => KnotToFts(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KnotToMph(decimal Knot = MSM.Value, decimal Constant = MSM.Knot_Mph_Constant)
        {
            try
            {
                return Knot * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KnotToMphAsync(decimal Knot = MSM.Value, decimal Constant = MSM.Knot_Mph_Constant)
        {
            return Task.Run(() => KnotToMph(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KnotToMach(decimal Knot = MSM.Value, decimal Constant = MSM.Knot_Mach_Constant)
        {
            try
            {
                return Knot / Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Knot"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KnotToMachAsync(decimal Knot = MSM.Value, decimal Constant = MSM.Knot_Mach_Constant)
        {
            return Task.Run(() => KnotToMach(Knot, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MachToCms(decimal Mach = MSM.Value, decimal Constant = MSM.Mach_Cms_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MachToCmsAsync(decimal Mach = MSM.Value, decimal Constant = MSM.Mach_Cms_Constant)
        {
            return Task.Run(() => MachToCms(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MachToMps(decimal Mach = MSM.Value, decimal Constant = MSM.Mach_Mps_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MachToMpsAsync(decimal Mach = MSM.Value, decimal Constant = MSM.Mach_Mps_Constant)
        {
            return Task.Run(() => MachToMps(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MachToKph(decimal Mach = MSM.Value, decimal Constant = MSM.Mach_Kph_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MachToKphAsync(decimal Mach = MSM.Value, decimal Constant = MSM.Mach_Kph_Constant)
        {
            return Task.Run(() => MachToKph(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MachToFts(decimal Mach = MSM.Value, decimal Constant = MSM.Mach_Fts_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MachToFtsAsync(decimal Mach = MSM.Value, decimal Constant = MSM.Mach_Fts_Constant)
        {
            return Task.Run(() => MachToFts(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MachToMph(decimal Mach = MSM.Value, decimal Constant = MSM.Mach_Mph_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MachToMphAsync(decimal Mach = MSM.Value, decimal Constant = MSM.Mach_Mph_Constant)
        {
            return Task.Run(() => MachToMph(Mach, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MachToKnot(decimal Mach = MSM.Value, decimal Constant = MSM.Mach_Knot_Constant)
        {
            try
            {
                return Mach * Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mach"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> MachToKnotAsync(decimal Mach = MSM.Value, decimal Constant = MSM.Mach_Knot_Constant)
        {
            return Task.Run(() => MachToKnot(Mach, Constant));
        }
    }
}