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
        /// <param name="Core"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CelsiusToKelvin(decimal Celsius = MTM.Value, decimal Core = MTM.Celsius_Kelvin)
        {
            try
            {
                return Celsius + Core;
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
    }
}