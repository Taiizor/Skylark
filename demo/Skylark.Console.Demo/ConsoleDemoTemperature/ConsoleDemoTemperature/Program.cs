using Skylark.Extension;

namespace ConsoleDemoTemperature
{
    internal class Program
    {
        private const decimal Value = 1234;

        static void Main()
        {
            Console.WriteLine($"Kelvin Symbol {TemperatureExtension.SymbolKelvin}");
            Console.WriteLine($"Rankine Symbol {TemperatureExtension.SymbolRankine}");
            Console.WriteLine($"Reaumur Symbol {TemperatureExtension.SymbolReaumur}");
            Console.WriteLine($"Celsius Symbol {TemperatureExtension.SymbolCelsius}");
            Console.WriteLine($"Fahrenheit Symbol {TemperatureExtension.SymbolFahrenheit}");

            Console.WriteLine();

            decimal CF = TemperatureExtension.CelsiusToFahrenheit(Value);
            Console.WriteLine($"{Value} Celsius -> Fahrenheit: {CF}");

            decimal CK = TemperatureExtension.CelsiusToKelvin(Value);
            Console.WriteLine($"{Value} Celsius -> Kelvin: {CK}");

            decimal CRE = TemperatureExtension.CelsiusToRankine(Value);
            Console.WriteLine($"{Value} Celsius -> Rankine: {CRE}");

            decimal CRR = TemperatureExtension.CelsiusToReaumur(Value);
            Console.WriteLine($"{Value} Celsius -> Reaumur: {CRR}");

            Console.WriteLine();

            decimal FC = TemperatureExtension.FahrenheitToCelsius(Value);
            Console.WriteLine($"{Value} Fahrenheit -> Celsius: {FC}");

            decimal FK = TemperatureExtension.FahrenheitToKelvin(Value);
            Console.WriteLine($"{Value} Fahrenheit -> Kelvin: {FK}");

            decimal FRE = TemperatureExtension.FahrenheitToRankine(Value);
            Console.WriteLine($"{Value} Fahrenheit -> Rankine: {FRE}");

            decimal FRR = TemperatureExtension.FahrenheitToReaumur(Value);
            Console.WriteLine($"{Value} Fahrenheit -> Reaumur: {FRR}");

            Console.WriteLine();

            decimal KC = TemperatureExtension.KelvinToCelsius(Value);
            Console.WriteLine($"{Value} Kelvin -> Celsius: {KC}");

            decimal KF = TemperatureExtension.KelvinToFahrenheit(Value);
            Console.WriteLine($"{Value} Kelvin -> Fahrenheit: {KF}");

            decimal KRE = TemperatureExtension.KelvinToRankine(Value);
            Console.WriteLine($"{Value} Kelvin -> Rankine: {KRE}");

            decimal KRR = TemperatureExtension.KelvinToReaumur(Value);
            Console.WriteLine($"{Value} Kelvin -> Reaumur: {KRR}");

            Console.WriteLine();

            decimal REC = TemperatureExtension.RankineToCelsius(Value);
            Console.WriteLine($"{Value} Rankine -> Celsius: {REC}");

            decimal REF = TemperatureExtension.RankineToFahrenheit(Value);
            Console.WriteLine($"{Value} Rankine -> Fahrenheit: {REF}");

            decimal REK = TemperatureExtension.RankineToKelvin(Value);
            Console.WriteLine($"{Value} Rankine -> Kelvin: {REK}");

            decimal RERR = TemperatureExtension.RankineToReaumur(Value);
            Console.WriteLine($"{Value} Rankine -> Reaumur: {RERR}");

            Console.WriteLine();

            decimal RRC = TemperatureExtension.ReaumurToCelsius(Value);
            Console.WriteLine($"{Value} Reaumur -> Celsius: {RRC}");

            decimal RRF = TemperatureExtension.ReaumurToFahrenheit(Value);
            Console.WriteLine($"{Value} Reaumur -> Fahrenheit: {RRF}");

            decimal RRK = TemperatureExtension.ReaumurToKelvin(Value);
            Console.WriteLine($"{Value} Reaumur -> Kelvin: {RRK}");

            decimal RRRE = TemperatureExtension.ReaumurToRankine(Value);
            Console.WriteLine($"{Value} Reaumur -> Rankine: {RRRE}");

            Console.ReadKey();
        }
    }
}