using Skylark.Extension;

namespace ConsoleDemoTemperature
{
    internal class Program
    {
        private const decimal Value = 1;

        static void Main()
        {
            decimal CF = TemperatureExtension.CelsiusToFahrenheit(Value);
            Console.WriteLine($"{Value} Celsius -> Fahrenheit: {CF}");

            decimal CK = TemperatureExtension.CelsiusToKelvin(Value);
            Console.WriteLine($"{Value} Celsius -> Kelvin: {CK}");

            Console.WriteLine();
            
            decimal FC = TemperatureExtension.FahrenheitToCelsius(Value);
            Console.WriteLine($"{Value} Fahrenheit -> Celsius: {FC}");

            decimal FK = TemperatureExtension.FahrenheitToKelvin(Value);
            Console.WriteLine($"{Value} Fahrenheit -> Kelvin: {FK}");

            Console.ReadKey();
        }
    }
}