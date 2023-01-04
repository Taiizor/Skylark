using Skylark.Enum;
using Skylark.Extension;

namespace ConsoleDemoPassword
{
    internal class Program
    {
        static void Main()
        {
            string Password1 = PasswordExtension.Generate(8, AlphabeticPasswordType.Mixed, SpecialPasswordType.Mixed);
            Console.WriteLine(Password1);

            Console.WriteLine("=====^^=====");

            string Password2 = PasswordExtension.Generate(12, AlphabeticPasswordType.Big, SpecialPasswordType.Number);
            Console.WriteLine(Password2);

            Console.WriteLine("=====^^=====");

            string Password3 = PasswordExtension.Generate(12, AlphabeticPasswordType.Small, SpecialPasswordType.Symbol);
            Console.WriteLine(Password3);

            Console.WriteLine("=====^^=====");

            string Password4 = PasswordExtension.Generate(6, AlphabeticPasswordType.None, SpecialPasswordType.Number, "Prefix");
            Console.WriteLine(Password4);

            Console.WriteLine("=====^^=====");

            string Password5 = PasswordExtension.Generate(4, AlphabeticPasswordType.Big, SpecialPasswordType.None, "Prefix", "Suffix");
            Console.WriteLine(Password5);
        }
    }
}