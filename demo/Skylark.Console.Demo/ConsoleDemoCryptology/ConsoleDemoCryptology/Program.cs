using Skylark.Standard.Extension.Cryptology;
using System.Text;

namespace ConsoleDemoCryptology
{
    internal class Program
    {
        private const string Text = "Taiizor Skylark";

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string Base64 = CryptologyExtension.TextToBase(Text);
            Console.WriteLine($"Base64: {Base64}");
            Console.WriteLine($"Base64 -> Text: {CryptologyExtension.BaseToText(Base64)}");

            Console.WriteLine();

            string AES = CryptologyExtension.TextToAes(Text);
            Console.WriteLine($"Aes: {AES}");
            Console.WriteLine($"Aes -> Text: {CryptologyExtension.AesToText(AES)}");

            Console.WriteLine();

            string MD5 = CryptologyExtension.TextToMD5(Text, false);
            Console.WriteLine($"MD5: {MD5}");

            string SHA1 = CryptologyExtension.TextToSHA1(Text, true);
            Console.WriteLine($"SHA1: {SHA1}");

            string SHA256 = CryptologyExtension.TextToSHA256(Text, false);
            Console.WriteLine($"SHA256: {SHA256}");

            string SHA384 = CryptologyExtension.TextToSHA384(Text, true);
            Console.WriteLine($"SHA384: {SHA384}");

            string SHA512 = CryptologyExtension.TextToSHA512(Text, false);
            Console.WriteLine($"SHA512: {SHA512}");

            Console.ReadKey();
        }
    }
}