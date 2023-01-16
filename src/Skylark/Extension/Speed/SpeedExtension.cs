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
    }
}