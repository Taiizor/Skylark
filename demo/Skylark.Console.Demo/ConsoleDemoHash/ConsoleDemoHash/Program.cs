using Skylark.Extension.Hash;

namespace ConsoleDemoHash
{
    internal class Program
    {
        private const string File = "Skylark.dll";

        static void Main()
        {
            string MD5 = HashExtension.FileToMD5(File, "", false);
            Console.WriteLine($"MD5: {MD5}");

            string SHA1 = HashExtension.FileToSHA1(File, "-", true);
            Console.WriteLine($"SHA1: {SHA1}");

            string SHA256 = HashExtension.FileToSHA256(File, "%E:\\MyProject\\Skylark\\Lib\\Skylark\\src", false);
            Console.WriteLine($"SHA256: {SHA256}");

            string SHA384 = HashExtension.FileToSHA384(File, "|", true);
            Console.WriteLine($"SHA384: {SHA384}");

            string SHA512 = HashExtension.FileToSHA512(File, "-", false);
            Console.WriteLine($"SHA512: {SHA512}");

            Console.ReadKey();
        }
    }
}