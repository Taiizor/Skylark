using Skylark.Standard.Extension.Hash;
using System.Text;

namespace ConsoleDemoHash
{
    internal class Program
    {
        private const string File = "Skylark.dll";

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string MD5 = HashExtension.FileToMD5(File, "", false);
            Console.WriteLine($"MD5: {MD5}");

            string SHA1 = HashExtension.FileToSHA1(File, "-", true);
            Console.WriteLine($"SHA1: {SHA1}");

            string SHA256 = HashExtension.FileToSHA256(File, "%", false);
            Console.WriteLine($"SHA256: {SHA256}");

            string SHA384 = HashExtension.FileToSHA384(File, "|", true);
            Console.WriteLine($"SHA384: {SHA384}");

            string SHA512 = HashExtension.FileToSHA512(File, "-", false);
            Console.WriteLine($"SHA512: {SHA512}");

            Console.ReadKey();
        }
    }
}