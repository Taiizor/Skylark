using SE = Skylark.Exception;
using SSMTTM = Skylark.Standard.Manage.Temperature.TemperatureManage;

namespace Skylark.Standard.Extension.Temperature
{
    /// <summary>
    /// 
    /// </summary>
    public static class TemperatureExtension
    {
        /// <summary>
        /// 
        /// </summary>
        public static string SymbolKelvin => SSMTTM.Kelvin;

        /// <summary>
        /// 
        /// </summary>
        public static async Task<string> SymbolKelvinAsync()
        {
            return await Task.FromResult(SymbolKelvin);
        }

        /// <summary>
        /// 
        /// </summary>
        public static string SymbolCelsius => SSMTTM.Celsius;

        /// <summary>
        /// 
        /// </summary>
        public static async Task<string> SymbolCelsiusAsync()
        {
            return await Task.FromResult(SymbolCelsius);
        }

        /// <summary>
        /// 
        /// </summary>
        public static string SymbolRankine => SSMTTM.Rankine;

        /// <summary>
        /// 
        /// </summary>
        public static async Task<string> SymbolRankineAsync()
        {
            return await Task.FromResult(SymbolRankine);
        }

        /// <summary>
        /// 
        /// </summary>
        public static string SymbolReaumur => SSMTTM.Reaumur;

        /// <summary>
        /// 
        /// </summary>
        public static async Task<string> SymbolReaumurAsync()
        {
            return await Task.FromResult(SymbolReaumur);
        }

        /// <summary>
        /// 
        /// </summary>
        public static string SymbolFahrenheit => SSMTTM.Fahrenheit;

        /// <summary>
        /// 
        /// </summary>
        public static async Task<string> SymbolFahrenheitAsync()
        {
            return await Task.FromResult(SymbolFahrenheit);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CelsiusToFahrenheit(decimal Celsius = SSMTTM.Value, decimal Coefficient = SSMTTM.Celsius_Fahrenheit_Coefficient, decimal Constant = SSMTTM.Celsius_Fahrenheit_Constant)
        {
            try
            {
                return (Celsius * Coefficient) + Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CelsiusToFahrenheitAsync(decimal Celsius = SSMTTM.Value, decimal Coefficient = SSMTTM.Celsius_Fahrenheit_Coefficient, decimal Constant = SSMTTM.Celsius_Fahrenheit_Constant)
        {
            return await Task.Run(() => CelsiusToFahrenheit(Celsius, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CelsiusToKelvin(decimal Celsius = SSMTTM.Value, decimal Constant = SSMTTM.Celsius_Kelvin_Constant)
        {
            try
            {
                return Celsius + Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CelsiusToKelvinAsync(decimal Celsius = SSMTTM.Value, decimal Constant = SSMTTM.Celsius_Kelvin_Constant)
        {
            return await Task.Run(() => CelsiusToKelvin(Celsius, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CelsiusToRankine(decimal Celsius = SSMTTM.Value, decimal Coefficient = SSMTTM.Celsius_Rankine_Coefficient, decimal Constant = SSMTTM.Celsius_Rankine_Constant)
        {
            try
            {
                return (Celsius + Constant) * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> CelsiusToRankineAsync(decimal Celsius = SSMTTM.Value, decimal Coefficient = SSMTTM.Celsius_Rankine_Coefficient, decimal Constant = SSMTTM.Celsius_Rankine_Constant)
        {
            return await Task.Run(() => CelsiusToRankine(Celsius, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal CelsiusToReaumur(decimal Celsius = SSMTTM.Value, decimal Coefficient = SSMTTM.Celsius_Reaumur_Coefficient)
        {
            try
            {
                return Celsius * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        public static async Task<decimal> CelsiusToReaumurAsync(decimal Celsius = SSMTTM.Value, decimal Coefficient = SSMTTM.Celsius_Reaumur_Coefficient)
        {
            return await Task.Run(() => CelsiusToReaumur(Celsius, Coefficient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FahrenheitToCelsius(decimal Fahrenheit = SSMTTM.Value, decimal Coefficient = SSMTTM.Fahrenheit_Celsius_Coefficient, decimal Constant = SSMTTM.Fahrenheit_Celsius_Constant)
        {
            try
            {
                return (Fahrenheit - Constant) * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FahrenheitToCelsiusAsync(decimal Fahrenheit = SSMTTM.Value, decimal Coefficient = SSMTTM.Fahrenheit_Celsius_Coefficient, decimal Constant = SSMTTM.Fahrenheit_Celsius_Constant)
        {
            return await Task.Run(() => FahrenheitToCelsius(Fahrenheit, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FahrenheitToKelvin(decimal Fahrenheit = SSMTTM.Value, decimal Coefficient = SSMTTM.Fahrenheit_Kelvin_Coefficient, decimal Constant = SSMTTM.Fahrenheit_Kelvin_Constant)
        {
            try
            {
                return (Fahrenheit + Constant) * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FahrenheitToKelvinAsync(decimal Fahrenheit = SSMTTM.Value, decimal Coefficient = SSMTTM.Fahrenheit_Kelvin_Coefficient, decimal Constant = SSMTTM.Fahrenheit_Kelvin_Constant)
        {
            return await Task.Run(() => FahrenheitToKelvin(Fahrenheit, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FahrenheitToRankine(decimal Fahrenheit = SSMTTM.Value, decimal Constant = SSMTTM.Fahrenheit_Rankine_Constant)
        {
            try
            {
                return Fahrenheit + Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FahrenheitToRankineAsync(decimal Fahrenheit = SSMTTM.Value, decimal Constant = SSMTTM.Fahrenheit_Rankine_Constant)
        {
            return await Task.Run(() => FahrenheitToRankine(Fahrenheit, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal FahrenheitToReaumur(decimal Fahrenheit = SSMTTM.Value, decimal Coefficient = SSMTTM.Fahrenheit_Reaumur_Coefficient, decimal Constant = SSMTTM.Fahrenheit_Reaumur_Constant)
        {
            try
            {
                return (Fahrenheit - Constant) * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> FahrenheitToReaumurAsync(decimal Fahrenheit = SSMTTM.Value, decimal Coefficient = SSMTTM.Fahrenheit_Reaumur_Coefficient, decimal Constant = SSMTTM.Fahrenheit_Reaumur_Constant)
        {
            return await Task.Run(() => FahrenheitToReaumur(Fahrenheit, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KelvinToCelsius(decimal Kelvin = SSMTTM.Value, decimal Constant = SSMTTM.Kelvin_Celsius_Constant)
        {
            try
            {
                return Kelvin - Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KelvinToCelsiusAsync(decimal Kelvin = SSMTTM.Value, decimal Constant = SSMTTM.Kelvin_Celsius_Constant)
        {
            return await Task.Run(() => KelvinToCelsius(Kelvin, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KelvinToFahrenheit(decimal Kelvin = SSMTTM.Value, decimal Coefficient = SSMTTM.Kelvin_Fahrenheit_Coefficient, decimal Constant = SSMTTM.Kelvin_Fahrenheit_Constant)
        {
            try
            {
                return (Kelvin * Coefficient) - Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KelvinToFahrenheitAsync(decimal Kelvin = SSMTTM.Value, decimal Coefficient = SSMTTM.Kelvin_Fahrenheit_Coefficient, decimal Constant = SSMTTM.Kelvin_Fahrenheit_Constant)
        {
            return await Task.Run(() => KelvinToFahrenheit(Kelvin, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KelvinToRankine(decimal Kelvin = SSMTTM.Value, decimal Coefficient = SSMTTM.Kelvin_Rankine_Coefficient)
        {
            try
            {
                return Kelvin * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        public static async Task<decimal> KelvinToRankineAsync(decimal Kelvin = SSMTTM.Value, decimal Coefficient = SSMTTM.Kelvin_Rankine_Coefficient)
        {
            return await Task.Run(() => KelvinToRankine(Kelvin, Coefficient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal KelvinToReaumur(decimal Kelvin = SSMTTM.Value, decimal Coefficient = SSMTTM.Kelvin_Reaumur_Coefficient, decimal Constant = SSMTTM.Kelvin_Reaumur_Constant)
        {
            try
            {
                return (Kelvin - Constant) * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> KelvinToReaumurAsync(decimal Kelvin = SSMTTM.Value, decimal Coefficient = SSMTTM.Kelvin_Reaumur_Coefficient, decimal Constant = SSMTTM.Kelvin_Reaumur_Constant)
        {
            return await Task.Run(() => KelvinToReaumur(Kelvin, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal RankineToCelsius(decimal Rankine = SSMTTM.Value, decimal Coefficient = SSMTTM.Rankine_Celsius_Coefficient, decimal Constant = SSMTTM.Rankine_Celsius_Constant)
        {
            try
            {
                return (Rankine - Constant) * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> RankineToCelsiusAsync(decimal Rankine = SSMTTM.Value, decimal Coefficient = SSMTTM.Rankine_Celsius_Coefficient, decimal Constant = SSMTTM.Rankine_Celsius_Constant)
        {
            return await Task.Run(() => RankineToCelsius(Rankine, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal RankineToFahrenheit(decimal Rankine = SSMTTM.Value, decimal Constant = SSMTTM.Rankine_Fahrenheit_Constant)
        {
            try
            {
                return Rankine - Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> RankineToFahrenheitAsync(decimal Rankine = SSMTTM.Value, decimal Constant = SSMTTM.Rankine_Fahrenheit_Constant)
        {
            return await Task.Run(() => RankineToFahrenheit(Rankine, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal RankineToKelvin(decimal Rankine = SSMTTM.Value, decimal Coefficient = SSMTTM.Rankine_Kelvin_Coefficient)
        {
            try
            {
                return Rankine * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        public static async Task<decimal> RankineToKelvinAsync(decimal Rankine = SSMTTM.Value, decimal Coefficient = SSMTTM.Rankine_Kelvin_Coefficient)
        {
            return await Task.Run(() => RankineToKelvin(Rankine, Coefficient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal RankineToReaumur(decimal Rankine = SSMTTM.Value, decimal Coefficient = SSMTTM.Rankine_Reaumur_Coefficient, decimal Constant = SSMTTM.Rankine_Reaumur_Constant)
        {
            try
            {
                return (Rankine - Constant) * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> RankineToReaumurAsync(decimal Rankine = SSMTTM.Value, decimal Coefficient = SSMTTM.Rankine_Reaumur_Coefficient, decimal Constant = SSMTTM.Rankine_Reaumur_Constant)
        {
            return await Task.Run(() => RankineToReaumur(Rankine, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal ReaumurToCelsius(decimal Reaumur = SSMTTM.Value, decimal Coefficient = SSMTTM.Reaumur_Celsius_Coefficient)
        {
            try
            {
                return Reaumur * Coefficient;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        public static async Task<decimal> ReaumurToCelsiusAsync(decimal Reaumur = SSMTTM.Value, decimal Coefficient = SSMTTM.Reaumur_Celsius_Coefficient)
        {
            return await Task.Run(() => ReaumurToCelsius(Reaumur, Coefficient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal ReaumurToFahrenheit(decimal Reaumur = SSMTTM.Value, decimal Coefficient = SSMTTM.Reaumur_Fahrenheit_Coefficient, decimal Constant = SSMTTM.Reaumur_Fahrenheit_Constant)
        {
            try
            {
                return (Reaumur * Coefficient) + Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> ReaumurToFahrenheitAsync(decimal Reaumur = SSMTTM.Value, decimal Coefficient = SSMTTM.Reaumur_Fahrenheit_Coefficient, decimal Constant = SSMTTM.Reaumur_Fahrenheit_Constant)
        {
            return await Task.Run(() => ReaumurToFahrenheit(Reaumur, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal ReaumurToKelvin(decimal Reaumur = SSMTTM.Value, decimal Coefficient = SSMTTM.Reaumur_Kelvin_Coefficient, decimal Constant = SSMTTM.Reaumur_Kelvin_Constant)
        {
            try
            {
                return (Reaumur * Coefficient) + Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> ReaumurToKelvinAsync(decimal Reaumur = SSMTTM.Value, decimal Coefficient = SSMTTM.Reaumur_Kelvin_Coefficient, decimal Constant = SSMTTM.Reaumur_Kelvin_Constant)
        {
            return await Task.Run(() => ReaumurToKelvin(Reaumur, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static decimal ReaumurToRankine(decimal Reaumur = SSMTTM.Value, decimal Coefficient = SSMTTM.Reaumur_Rankine_Coefficient, decimal Constant = SSMTTM.Reaumur_Rankine_Constant)
        {
            try
            {
                return (Reaumur * Coefficient) + Constant;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static async Task<decimal> ReaumurToRankineAsync(decimal Reaumur = SSMTTM.Value, decimal Coefficient = SSMTTM.Reaumur_Rankine_Coefficient, decimal Constant = SSMTTM.Reaumur_Rankine_Constant)
        {
            return await Task.Run(() => ReaumurToRankine(Reaumur, Coefficient, Constant));
        }
    }
}