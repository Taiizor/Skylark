using Skylark.Extension;

namespace ConsoleDemoStorage
{
    internal class Program
    {
        private const decimal Value = 999;

        static void Main()
        {
            decimal BitByte = StorageExtension.Convert(Value);
            Console.WriteLine($"{Value} Bit -> Byte: {BitByte}");

            Console.WriteLine();

            ///

            Console.ReadKey();
        }
    }
}