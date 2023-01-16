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
        /// <param name="Cmps"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmpsToMps(decimal Cmps = MSM.Value)
        {
            try
            {
                return Cmps / MSM.Cmps_Mps;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cmps"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmpsToKph(decimal Cmps = MSM.Value)
        {
            try
            {
                return Cmps * MSM.Cmps_Kph;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cmps"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CmpsToFts(decimal Cmps = MSM.Value)
        {
            try
            {
                return Cmps / MSM.Mps_Fts;
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToMph(decimal Mps = MSM.Value)
        {
            try
            {
                return Mps * MSM.Mps_Mph;
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToKph(decimal Mps = MSM.Value)
        {
            try
            {
                return Mps * MSM.Mps_Kph;
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToFts(decimal Mps = MSM.Value)
        {
            try
            {
                return Mps * MSM.Mps_Fts;
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToKnot(decimal Mps = MSM.Value)
        {
            try
            {
                return Mps * MSM.Mps_Knot;
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MpsToMach(decimal Mps = MSM.Value)
        {
            try
            {
                return Mps / MSM.Mps_Mach;
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToMps(decimal Mph = MSM.Value)
        {
            try
            {
                return Mph * MSM.Mph_Mps;
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal MphToKph(decimal Mph = MSM.Value)
        {
            try
            {
                return Mph * MSM.Mph_Kph;
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToMps(decimal Kph = MSM.Value)
        {
            try
            {
                return Kph / MSM.Kph_Mps;
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KphToMph(decimal Kph = MSM.Value)
        {
            try
            {
                return Kph / MSM.Kph_Mph;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}