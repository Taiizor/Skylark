using Skylark.Enum;
using Skylark.Extension.Password;

namespace ConsoleDemoPassword
{
    internal class Program
    {
        static void Main()
        {
            string Password1 = PasswordExtension.Generate(8, AlphabeticPasswordType.Mixed, SpecialPasswordType.Mixed);
            Console.WriteLine($"{Password1} Meter: {PasswordExtension.Meter(Password1)}");

            Console.WriteLine("=====^^=====");

            string Password2 = PasswordExtension.Generate(12, AlphabeticPasswordType.Big, SpecialPasswordType.Number);
            Console.WriteLine($"{Password2} Meter: {PasswordExtension.Meter(Password2)}");

            Console.WriteLine("=====^^=====");

            string Password3 = PasswordExtension.Generate(12, AlphabeticPasswordType.Small, SpecialPasswordType.Symbol);
            Console.WriteLine($"{Password3} Meter: {PasswordExtension.Meter(Password3)}");

            Console.WriteLine("=====^^=====");

            string Password4 = PasswordExtension.Generate(6, AlphabeticPasswordType.None, SpecialPasswordType.Number, "Prefix");
            Console.WriteLine($"{Password4} Meter: {PasswordExtension.Meter(Password4)}");

            Console.WriteLine("=====^^=====");

            string Password5 = PasswordExtension.Generate(4, AlphabeticPasswordType.Big, SpecialPasswordType.None, "Prefix", "Suffix");
            Console.WriteLine($"{Password5} Meter: {PasswordExtension.Meter(Password5)}");

            Console.WriteLine("=====^^=====");

            string Password6 = PasswordExtension.Generate(18, AlphabeticPasswordType.Mixed, SpecialPasswordType.Mixed, "Prefix", "Suffix");
            Console.WriteLine($"{Password6} Meter: {PasswordExtension.Meter(Password6)}");

            Console.WriteLine();
            
            string Password7 = "Password7";
            string Password8 = "Password8";
            Console.WriteLine($"{Password7} - {Password8} Similarity: {PasswordExtension.Similarity(Password7, Password8, SimilarPasswordType.Jaccard)}");

            Console.ReadKey();
        }
    }
}