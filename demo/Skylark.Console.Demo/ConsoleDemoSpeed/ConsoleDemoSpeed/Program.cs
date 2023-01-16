using Skylark.Extension;

namespace ConsoleDemoSpeed
{
    internal class Program
    {
        private const decimal Value = 10;

        static void Main()
        {
            decimal Kph = SpeedExtension.MphToKph(Value);
            Console.WriteLine($"{Value} Mph -> Kph: {Kph}");

            Console.WriteLine();

            ///

            Console.ReadKey();
        }
    }
}