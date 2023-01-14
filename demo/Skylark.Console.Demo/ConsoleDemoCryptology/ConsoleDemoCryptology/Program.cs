using Skylark.Extension;

namespace ConsoleDemoCryptology
{
    internal class Program
    {
        private const string Text = "Taiizor Skylark";

        static void Main()
        {
            string Base64 = CryptologyExtension.ToBase64(Text);
            Console.WriteLine($"Base64: {Base64}");

            Console.WriteLine();

            string MD5 = CryptologyExtension.ToMD5(Text, false);
            Console.WriteLine($"MD5: {MD5}");

            string SHA1 = CryptologyExtension.ToSHA1(Text, true);
            Console.WriteLine($"SHA1: {SHA1}");

            string SHA256 = CryptologyExtension.ToSHA256(Text, false);
            Console.WriteLine($"SHA256: {SHA256}");

            string SHA384 = CryptologyExtension.ToSHA384(Text, true);
            Console.WriteLine($"SHA384: {SHA384}");

            string SHA512 = CryptologyExtension.ToSHA512(Text, false);
            Console.WriteLine($"SHA512: {SHA512}");

            Console.WriteLine();

            //

            Console.ReadKey();
        }
    }
}