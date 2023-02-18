using Skylark.Extension.Unicode;

namespace ConsoleDemoUnicode
{
    internal class Program
    {
        private const string Text = "Taiizor Skylark";

        static void Main()
        {
            string ASCII = UnicodeExtension.TextToASCII(Text);
            Console.WriteLine($"ASCII: {ASCII}");
            Console.WriteLine($"ASCII -> Text: {UnicodeExtension.ASCIIToText(ASCII)}");

            Console.ReadKey();
        }
    }
}