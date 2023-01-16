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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmsToMps(decimal Cms = MSM.Value, decimal Core = MSM.Cms_Mps)
        {
            try
            {
                return Cms / Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmsToKph(decimal Cms = MSM.Value, decimal Core = MSM.Cms_Kph)
        {
            try
            {
                return Cms * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmsToFts(decimal Cms = MSM.Value, decimal Core = MSM.Cms_Fts)
        {
            try
            {
                return Cms / Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmsToMph(decimal Cms = MSM.Value, decimal Core = MSM.Cms_Mph)
        {
            try
            {
                return Cms * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmsToKnot(decimal Cms = MSM.Value, decimal Core = MSM.Cms_Knot)
        {
            try
            {
                return Cms * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmsToMach(decimal Cms = MSM.Value, decimal Core = MSM.Cms_Mach)
        {
            try
            {
                return Cms * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToCms(decimal Mps = MSM.Value, decimal Core = MSM.Mps_Cms)
        {
            try
            {
                return Mps * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToKph(decimal Mps = MSM.Value, decimal Core = MSM.Mps_Kph)
        {
            try
            {
                return Mps * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToFts(decimal Mps = MSM.Value, decimal Core = MSM.Mps_Fts)
        {
            try
            {
                return Mps * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToMph(decimal Mps = MSM.Value, decimal Core = MSM.Mps_Mph)
        {
            try
            {
                return Mps * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToKnot(decimal Mps = MSM.Value, decimal Core = MSM.Mps_Knot)
        {
            try
            {
                return Mps * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToMach(decimal Mps = MSM.Value, decimal Core = MSM.Mps_Mach)
        {
            try
            {
                return Mps * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToCms(decimal Kph = MSM.Value, decimal Core = MSM.Kph_Cms)
        {
            try
            {
                return Kph / Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToMps(decimal Kph = MSM.Value, decimal Core = MSM.Kph_Mps)
        {
            try
            {
                return Kph / Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToFts(decimal Kph = MSM.Value, decimal Core = MSM.Kph_Fts)
        {
            try
            {
                return Kph / Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToMph(decimal Kph = MSM.Value, decimal Core = MSM.Kph_Mph)
        {
            try
            {
                return Kph / Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToKnot(decimal Kph = MSM.Value, decimal Core = MSM.Kph_Knot)
        {
            try
            {
                return Kph / Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToMach(decimal Kph = MSM.Value, decimal Core = MSM.Kph_Mach)
        {
            try
            {
                return Kph * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FtsToCms(decimal Fts = MSM.Value, decimal Core = MSM.Fts_Cms)
        {
            try
            {
                return Fts * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FtsToMps(decimal Fts = MSM.Value, decimal Core = MSM.Fts_Mps)
        {
            try
            {
                return Fts * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FtsToKph(decimal Fts = MSM.Value, decimal Core = MSM.Fts_Kph)
        {
            try
            {
                return Fts * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FtsToMph(decimal Fts = MSM.Value, decimal Core = MSM.Fts_Mph)
        {
            try
            {
                return Fts * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FtsToKnot(decimal Fts = MSM.Value, decimal Core = MSM.Fts_Knot)
        {
            try
            {
                return Fts * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FtsToMach(decimal Fts = MSM.Value, decimal Core = MSM.Fts_Mach)
        {
            try
            {
                return Fts * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToCms(decimal Mph = MSM.Value, decimal Core = MSM.Mph_Cms)
        {
            try
            {
                return Mph * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToMps(decimal Mph = MSM.Value, decimal Core = MSM.Mph_Mps)
        {
            try
            {
                return Mph * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToKph(decimal Mph = MSM.Value, decimal Core = MSM.Mph_Kph)
        {
            try
            {
                return Mph * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToFts(decimal Mph = MSM.Value, decimal Core = MSM.Mph_Fts)
        {
            try
            {
                return Mph * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToKnot(decimal Mph = MSM.Value, decimal Core = MSM.Mph_Knot)
        {
            try
            {
                return Mph * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToMach(decimal Mph = MSM.Value, decimal Core = MSM.Mph_Mach)
        {
            try
            {
                return Mph * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KnotToCms(decimal Knot = MSM.Value, decimal Core = MSM.Knot_Cms)
        {
            try
            {
                return Knot * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KnotToMps(decimal Knot = MSM.Value, decimal Core = MSM.Knot_Mps)
        {
            try
            {
                return Knot * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KnotToKph(decimal Knot = MSM.Value, decimal Core = MSM.Knot_Kph)
        {
            try
            {
                return Knot * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KnotToFts(decimal Knot = MSM.Value, decimal Core = MSM.Knot_Fts)
        {
            try
            {
                return Knot * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KnotToMph(decimal Knot = MSM.Value, decimal Core = MSM.Knot_Mph)
        {
            try
            {
                return Knot * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KnotToMach(decimal Knot = MSM.Value, decimal Core = MSM.Knot_Mach)
        {
            try
            {
                return Knot / Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MachToCms(decimal Mach = MSM.Value, decimal Core = MSM.Mach_Cms)
        {
            try
            {
                return Mach * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MachToMps(decimal Mach = MSM.Value, decimal Core = MSM.Mach_Mps)
        {
            try
            {
                return Mach * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MachToKph(decimal Mach = MSM.Value, decimal Core = MSM.Mach_Kph)
        {
            try
            {
                return Mach * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MachToFts(decimal Mach = MSM.Value, decimal Core = MSM.Mach_Fts)
        {
            try
            {
                return Mach * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MachToMph(decimal Mach = MSM.Value, decimal Core = MSM.Mach_Mph)
        {
            try
            {
                return Mach * Core;
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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MachToKnot(decimal Mach = MSM.Value, decimal Core = MSM.Mach_Knot)
        {
            try
            {
                return Mach * Core;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}