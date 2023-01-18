using Skylark.Enum;
using Skylark.Extension;
using Skylark.Struct;

namespace ConsoleDemoTime
{
    internal class Program
    {
        private const decimal Value = 999;
        private const decimal Value2 = 123456789;

        static void Main()
        {
            StorageStruct AutoBit = StorageExtension.AutoConvert(Value2, StorageType.Bit);
            Console.WriteLine($"{Value2} Bit -> Auto: {AutoBit.Value} {AutoBit.Text}");

            ///

            Console.WriteLine();

            decimal BitBit = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Bit);
            Console.WriteLine($"{Value} Bit -> Bit: {BitBit}");

            ///

            Console.ReadKey();
        }
    }
}