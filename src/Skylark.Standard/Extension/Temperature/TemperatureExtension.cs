using E = Skylark.Exception;
using MTTM = Skylark.Standard.Manage.Temperature.TemperatureManage;

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
        public static string SymbolKelvin => MTTM.Kelvin;
        /// <summary>
        /// 
        /// </summary>
        public static Task<string> SymbolKelvinAsync => Task.FromResult(SymbolKelvin);

        /// <summary>
        /// 
        /// </summary>
        public static string SymbolCelsius => MTTM.Celsius;
        /// <summary>
        /// 
        /// </summary>
        public static Task<string> SymbolCelsiusAsync => Task.FromResult(SymbolCelsius);

        /// <summary>
        /// 
        /// </summary>
        public static string SymbolRankine => MTTM.Rankine;
        /// <summary>
        /// 
        /// </summary>
        public static Task<string> SymbolRankineAsync => Task.FromResult(SymbolRankine);

        /// <summary>
        /// 
        /// </summary>
        public static string SymbolReaumur => MTTM.Reaumur;
        /// <summary>
        /// 
        /// </summary>
        public static Task<string> SymbolReaumurAsync => Task.FromResult(SymbolReaumur);

        /// <summary>
        /// 
        /// </summary>
        public static string SymbolFahrenheit => MTTM.Fahrenheit;
        /// <summary>
        /// 
        /// </summary>
        public static Task<string> SymbolFahrenheitAsync => Task.FromResult(SymbolFahrenheit);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CelsiusToFahrenheit(decimal Celsius = MTTM.Value, decimal Coefficient = MTTM.Celsius_Fahrenheit_Coefficient, decimal Constant = MTTM.Celsius_Fahrenheit_Constant)
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
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> CelsiusToFahrenheitAsync(decimal Celsius = MTTM.Value, decimal Coefficient = MTTM.Celsius_Fahrenheit_Coefficient, decimal Constant = MTTM.Celsius_Fahrenheit_Constant)
        {
            return Task.Run(() => CelsiusToFahrenheit(Celsius, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CelsiusToKelvin(decimal Celsius = MTTM.Value, decimal Constant = MTTM.Celsius_Kelvin_Constant)
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
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> CelsiusToKelvinAsync(decimal Celsius = MTTM.Value, decimal Constant = MTTM.Celsius_Kelvin_Constant)
        {
            return Task.Run(() => CelsiusToKelvin(Celsius, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CelsiusToRankine(decimal Celsius = MTTM.Value, decimal Coefficient = MTTM.Celsius_Rankine_Coefficient, decimal Constant = MTTM.Celsius_Rankine_Constant)
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
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> CelsiusToRankineAsync(decimal Celsius = MTTM.Value, decimal Coefficient = MTTM.Celsius_Rankine_Coefficient, decimal Constant = MTTM.Celsius_Rankine_Constant)
        {
            return Task.Run(() => CelsiusToRankine(Celsius, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal CelsiusToReaumur(decimal Celsius = MTTM.Value, decimal Coefficient = MTTM.Celsius_Reaumur_Coefficient)
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
        /// <param name="Celsius"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        public static Task<decimal> CelsiusToReaumurAsync(decimal Celsius = MTTM.Value, decimal Coefficient = MTTM.Celsius_Reaumur_Coefficient)
        {
            return Task.Run(() => CelsiusToReaumur(Celsius, Coefficient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FahrenheitToCelsius(decimal Fahrenheit = MTTM.Value, decimal Coefficient = MTTM.Fahrenheit_Celsius_Coefficient, decimal Constant = MTTM.Fahrenheit_Celsius_Constant)
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
        public static Task<decimal> FahrenheitToCelsiusAsync(decimal Fahrenheit = MTTM.Value, decimal Coefficient = MTTM.Fahrenheit_Celsius_Coefficient, decimal Constant = MTTM.Fahrenheit_Celsius_Constant)
        {
            return Task.Run(() => FahrenheitToCelsius(Fahrenheit, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FahrenheitToKelvin(decimal Fahrenheit = MTTM.Value, decimal Coefficient = MTTM.Fahrenheit_Kelvin_Coefficient, decimal Constant = MTTM.Fahrenheit_Kelvin_Constant)
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
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> FahrenheitToKelvinAsync(decimal Fahrenheit = MTTM.Value, decimal Coefficient = MTTM.Fahrenheit_Kelvin_Coefficient, decimal Constant = MTTM.Fahrenheit_Kelvin_Constant)
        {
            return Task.Run(() => FahrenheitToKelvin(Fahrenheit, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FahrenheitToRankine(decimal Fahrenheit = MTTM.Value, decimal Constant = MTTM.Fahrenheit_Rankine_Constant)
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
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> FahrenheitToRankineAsync(decimal Fahrenheit = MTTM.Value, decimal Constant = MTTM.Fahrenheit_Rankine_Constant)
        {
            return Task.Run(() => FahrenheitToRankine(Fahrenheit, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Fahrenheit"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal FahrenheitToReaumur(decimal Fahrenheit = MTTM.Value, decimal Coefficient = MTTM.Fahrenheit_Reaumur_Coefficient, decimal Constant = MTTM.Fahrenheit_Reaumur_Constant)
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
        public static Task<decimal> FahrenheitToReaumurAsync(decimal Fahrenheit = MTTM.Value, decimal Coefficient = MTTM.Fahrenheit_Reaumur_Coefficient, decimal Constant = MTTM.Fahrenheit_Reaumur_Constant)
        {
            return Task.Run(() => FahrenheitToReaumur(Fahrenheit, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KelvinToCelsius(decimal Kelvin = MTTM.Value, decimal Constant = MTTM.Kelvin_Celsius_Constant)
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
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KelvinToCelsiusAsync(decimal Kelvin = MTTM.Value, decimal Constant = MTTM.Kelvin_Celsius_Constant)
        {
            return Task.Run(() => KelvinToCelsius(Kelvin, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KelvinToFahrenheit(decimal Kelvin = MTTM.Value, decimal Coefficient = MTTM.Kelvin_Fahrenheit_Coefficient, decimal Constant = MTTM.Kelvin_Fahrenheit_Constant)
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
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> KelvinToFahrenheitAsync(decimal Kelvin = MTTM.Value, decimal Coefficient = MTTM.Kelvin_Fahrenheit_Coefficient, decimal Constant = MTTM.Kelvin_Fahrenheit_Constant)
        {
            return Task.Run(() => KelvinToFahrenheit(Kelvin, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KelvinToRankine(decimal Kelvin = MTTM.Value, decimal Coefficient = MTTM.Kelvin_Rankine_Coefficient)
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
        /// <returns></returns>
        public static Task<decimal> KelvinToRankineAsync(decimal Kelvin = MTTM.Value, decimal Coefficient = MTTM.Kelvin_Rankine_Coefficient)
        {
            return Task.Run(() => KelvinToRankine(Kelvin, Coefficient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Kelvin"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal KelvinToReaumur(decimal Kelvin = MTTM.Value, decimal Coefficient = MTTM.Kelvin_Reaumur_Coefficient, decimal Constant = MTTM.Kelvin_Reaumur_Constant)
        {
            try
            {
                return (Kelvin - Constant) * Coefficient;
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
        public static Task<decimal> KelvinToReaumurAsync(decimal Kelvin = MTTM.Value, decimal Coefficient = MTTM.Kelvin_Reaumur_Coefficient, decimal Constant = MTTM.Kelvin_Reaumur_Constant)
        {
            return Task.Run(() => KelvinToReaumur(Kelvin, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal RankineToCelsius(decimal Rankine = MTTM.Value, decimal Coefficient = MTTM.Rankine_Celsius_Coefficient, decimal Constant = MTTM.Rankine_Celsius_Constant)
        {
            try
            {
                return (Rankine - Constant) * Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> RankineToCelsiusAsync(decimal Rankine = MTTM.Value, decimal Coefficient = MTTM.Rankine_Celsius_Coefficient, decimal Constant = MTTM.Rankine_Celsius_Constant)
        {
            return Task.Run(() => RankineToCelsius(Rankine, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal RankineToFahrenheit(decimal Rankine = MTTM.Value, decimal Constant = MTTM.Rankine_Fahrenheit_Constant)
        {
            try
            {
                return Rankine - Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> RankineToFahrenheitAsync(decimal Rankine = MTTM.Value, decimal Constant = MTTM.Rankine_Fahrenheit_Constant)
        {
            return Task.Run(() => RankineToFahrenheit(Rankine, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal RankineToKelvin(decimal Rankine = MTTM.Value, decimal Coefficient = MTTM.Rankine_Kelvin_Coefficient)
        {
            try
            {
                return Rankine * Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        public static Task<decimal> RankineToKelvinAsync(decimal Rankine = MTTM.Value, decimal Coefficient = MTTM.Rankine_Kelvin_Coefficient)
        {
            return Task.Run(() => RankineToKelvin(Rankine, Coefficient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal RankineToReaumur(decimal Rankine = MTTM.Value, decimal Coefficient = MTTM.Rankine_Reaumur_Coefficient, decimal Constant = MTTM.Rankine_Reaumur_Constant)
        {
            try
            {
                return (Rankine - Constant) * Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Rankine"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> RankineToReaumurAsync(decimal Rankine = MTTM.Value, decimal Coefficient = MTTM.Rankine_Reaumur_Coefficient, decimal Constant = MTTM.Rankine_Reaumur_Constant)
        {
            return Task.Run(() => RankineToReaumur(Rankine, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal ReaumurToCelsius(decimal Reaumur = MTTM.Value, decimal Coefficient = MTTM.Reaumur_Celsius_Coefficient)
        {
            try
            {
                return Reaumur * Coefficient;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <returns></returns>
        public static Task<decimal> ReaumurToCelsiusAsync(decimal Reaumur = MTTM.Value, decimal Coefficient = MTTM.Reaumur_Celsius_Coefficient)
        {
            return Task.Run(() => ReaumurToCelsius(Reaumur, Coefficient));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal ReaumurToFahrenheit(decimal Reaumur = MTTM.Value, decimal Coefficient = MTTM.Reaumur_Fahrenheit_Coefficient, decimal Constant = MTTM.Reaumur_Fahrenheit_Constant)
        {
            try
            {
                return (Reaumur * Coefficient) + Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> ReaumurToFahrenheitAsync(decimal Reaumur = MTTM.Value, decimal Coefficient = MTTM.Reaumur_Fahrenheit_Coefficient, decimal Constant = MTTM.Reaumur_Fahrenheit_Constant)
        {
            return Task.Run(() => ReaumurToFahrenheit(Reaumur, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal ReaumurToKelvin(decimal Reaumur = MTTM.Value, decimal Coefficient = MTTM.Reaumur_Kelvin_Coefficient, decimal Constant = MTTM.Reaumur_Kelvin_Constant)
        {
            try
            {
                return (Reaumur * Coefficient) + Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> ReaumurToKelvinAsync(decimal Reaumur = MTTM.Value, decimal Coefficient = MTTM.Reaumur_Kelvin_Coefficient, decimal Constant = MTTM.Reaumur_Kelvin_Constant)
        {
            return Task.Run(() => ReaumurToKelvin(Reaumur, Coefficient, Constant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal ReaumurToRankine(decimal Reaumur = MTTM.Value, decimal Coefficient = MTTM.Reaumur_Rankine_Coefficient, decimal Constant = MTTM.Reaumur_Rankine_Constant)
        {
            try
            {
                return (Reaumur * Coefficient) + Constant;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Reaumur"></param>
        /// <param name="Coefficient"></param>
        /// <param name="Constant"></param>
        /// <returns></returns>
        public static Task<decimal> ReaumurToRankineAsync(decimal Reaumur = MTTM.Value, decimal Coefficient = MTTM.Reaumur_Rankine_Coefficient, decimal Constant = MTTM.Reaumur_Rankine_Constant)
        {
            return Task.Run(() => ReaumurToRankine(Reaumur, Coefficient, Constant));
        }
    }
}