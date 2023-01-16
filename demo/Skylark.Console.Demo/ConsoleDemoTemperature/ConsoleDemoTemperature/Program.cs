﻿using Skylark.Extension;

namespace ConsoleDemoTemperature
{
    internal class Program
    {
        private const decimal Value = 999;

        static void Main()
        {
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

            Console.ReadKey();
        }
    }
}