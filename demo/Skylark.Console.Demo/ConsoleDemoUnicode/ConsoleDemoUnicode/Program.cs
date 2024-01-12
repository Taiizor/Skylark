using Skylark.Standard.Extension.Unicode;
using System.Text;

namespace ConsoleDemoUnicode
{
    internal class Program
    {
        private const string Text = "Taiizor Skylark";

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string ASCII = UnicodeExtension.TextToASCII(Text);
            Console.WriteLine($"ASCII: {ASCII}");
            Console.WriteLine($"ASCII -> Text: {UnicodeExtension.ASCIIToText(ASCII)}");

            Console.ReadKey();
        }
    }
}