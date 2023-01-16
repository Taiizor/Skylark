using E = Skylark.Exception;
using MTM = Skylark.Manage.TemperatureManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class TemperatureExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CelsiusToFahrenheit(decimal Celsius = MTM.Value, decimal Coefficient = MTM.Celsius_Fahrenheit_Coefficient, decimal Constant = MTM.Celsius_Fahrenheit_Constant)
        {
            try
            {
                return (Celsius * Coefficient) + Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CelsiusToKelvin(decimal Celsius = MTM.Value, decimal Constant = MTM.Celsius_Kelvin_Constant)
        {
            try
            {
                return Celsius + Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CelsiusToRankine(decimal Celsius = MTM.Value, decimal Coefficient = MTM.Celsius_Rankine_Coefficient, decimal Constant = MTM.Celsius_Rankine_Constant)
        {
            try
            {
                return (Celsius + Constant) * Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CelsiusToReaumur(decimal Celsius = MTM.Value, decimal Coefficient = MTM.Celsius_Reaumur_Coefficient)
        {
            try
            {
                return Celsius * Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FahrenheitToCelsius(decimal Fahrenheit = MTM.Value, decimal Coefficient = MTM.Fahrenheit_Celsius_Coefficient, decimal Constant = MTM.Fahrenheit_Celsius_Constant)
        {
            try
            {
                return (Fahrenheit - Constant) * Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FahrenheitToKelvin(decimal Fahrenheit = MTM.Value, decimal Coefficient = MTM.Fahrenheit_Kelvin_Coefficient, decimal Constant = MTM.Fahrenheit_Kelvin_Constant)
        {
            try
            {
                return (Fahrenheit + Constant) * Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FahrenheitToRankine(decimal Fahrenheit = MTM.Value, decimal Constant = MTM.Fahrenheit_Rankine_Constant)
        {
            try
            {
                return Fahrenheit + Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FahrenheitToReaumur(decimal Fahrenheit = MTM.Value, decimal Coefficient = MTM.Fahrenheit_Reaumur_Coefficient, decimal Constant = MTM.Fahrenheit_Reaumur_Constant)
        {
            try
            {
                return (Fahrenheit - Constant) * Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KelvinToCelsius(decimal Kelvin = MTM.Value, decimal Constant = MTM.Kelvin_Celsius_Constant)
        {
            try
            {
                return Kelvin - Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KelvinToFahrenheit(decimal Kelvin = MTM.Value, decimal Coefficient = MTM.Kelvin_Fahrenheit_Coefficient, decimal Constant = MTM.Kelvin_Fahrenheit_Constant)
        {
            try
            {
                return (Kelvin * Coefficient) - Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KelvinToRankine(decimal Kelvin = MTM.Value, decimal Coefficient = MTM.Kelvin_Rankine_Coefficient)
        {
            try
            {
                return Kelvin * Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KelvinToReaumur(decimal Kelvin = MTM.Value, decimal Coefficient = MTM.Kelvin_Reaumur_Coefficient, decimal Constant = MTM.Kelvin_Reaumur_Constant)
        {
            try
            {
                return (Kelvin - Constant) * 0.8M;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}