using Skylark.Enum;
using Skylark.Extension;
using Skylark.Struct;

namespace ConsoleDemoStorage
{
    internal class Program
    {
        private const decimal Value = 999;
        private const decimal Value2 = 123456789;

        static void Main()
        {
            StorageStruct AutoBit = StorageExtension.AutoConvert(Value2, StorageType.Bit);
            Console.WriteLine($"{Value2} Bit -> Auto: {AutoBit.Value} {AutoBit.Text}");

            StorageStruct AutoByte = StorageExtension.AutoConvert(Value2, StorageType.Byte);
            Console.WriteLine($"{Value2} Byte -> Auto: {AutoByte.Value} {AutoByte.Text}");

            StorageStruct AutoKilobyte = StorageExtension.AutoConvert(Value2, StorageType.Kilobyte);
            Console.WriteLine($"{Value2} Kilobyte -> Auto: {AutoKilobyte.Value} {AutoKilobyte.Text}");

            StorageStruct AutoMegabyte = StorageExtension.AutoConvert(Value2, StorageType.Megabyte);
            Console.WriteLine($"{Value2} Megabyte -> Auto: {AutoMegabyte.Value} {AutoMegabyte.Text}");

            StorageStruct AutoGigabyte = StorageExtension.AutoConvert(Value2, StorageType.Gigabyte);
            Console.WriteLine($"{Value2} Gigabyte -> Auto: {AutoGigabyte.Value} {AutoGigabyte.Text}");

            StorageStruct AutoTerabyte = StorageExtension.AutoConvert(Value2, StorageType.Terabyte);
            Console.WriteLine($"{Value2} Terabyte -> Auto: {AutoTerabyte.Value} {AutoTerabyte.Text}");

            StorageStruct AutoPetabyte = StorageExtension.AutoConvert(Value2, StorageType.Petabyte);
            Console.WriteLine($"{Value2} Petabyte -> Auto: {AutoPetabyte.Value} {AutoPetabyte.Text}");

            StorageStruct AutoExabyte = StorageExtension.AutoConvert(Value2, StorageType.Exabyte);
            Console.WriteLine($"{Value2} Exabyte -> Auto: {AutoExabyte.Value} {AutoExabyte.Text}");

            StorageStruct AutoZetabyte = StorageExtension.AutoConvert(Value2, StorageType.Zetabyte);
            Console.WriteLine($"{Value2} Zetabyte -> Auto: {AutoZetabyte.Value} {AutoZetabyte.Text}");

            StorageStruct AutoYottabyte = StorageExtension.AutoConvert(Value2, StorageType.Yottabyte);
            Console.WriteLine($"{Value2} Yottabyte -> Auto: {AutoYottabyte.Value} {AutoYottabyte.Text}");

            Console.WriteLine();

            decimal BitBit = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Bit);
            Console.WriteLine($"{Value} Bit -> Bit: {BitBit}");

            decimal BitByte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Byte);
            Console.WriteLine($"{Value} Bit -> Byte: {BitByte}");

            decimal BitKilobyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Bit -> Kilobyte: {BitKilobyte}");

            decimal BitMegabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Megabyte);
            Console.WriteLine($"{Value} Bit -> Megabyte: {BitMegabyte}");

            decimal BitGigabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Bit -> Gigabyte: {BitGigabyte}");

            decimal BitTerabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Terabyte);
            Console.WriteLine($"{Value} Bit -> Terabyte: {BitTerabyte}");

            decimal BitPetabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Petabyte);
            Console.WriteLine($"{Value} Bit -> Petabyte: {BitPetabyte}");

            decimal BitExabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Exabyte);
            Console.WriteLine($"{Value} Bit -> Exabyte: {BitExabyte}");

            decimal BitZetabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Bit -> Zetabyte: {BitZetabyte}");

            decimal BitYottabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Bit -> Yottabyte: {BitYottabyte}");

            Console.WriteLine();

            decimal ByteBit = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Bit);
            Console.WriteLine($"{Value} Byte -> Bit: {ByteBit}");

            decimal ByteByte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Byte);
            Console.WriteLine($"{Value} Byte -> Byte: {ByteByte}");

            decimal ByteKilobyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Byte -> Kilobyte: {ByteKilobyte}");

            decimal ByteMegabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Byte -> Megabyte: {ByteMegabyte}");

            decimal ByteGigabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Byte -> Gigabyte: {ByteGigabyte}");

            decimal ByteTerabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Byte -> Terabyte: {ByteTerabyte}");

            decimal BytePetabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Byte -> Petabyte: {BytePetabyte}");

            decimal ByteExabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Byte -> Exabyte: {ByteExabyte}");

            decimal ByteZetabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Byte -> Zetabyte: {ByteZetabyte}");

            decimal ByteYottabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Byte -> Yottabyte: {ByteYottabyte}");

            Console.WriteLine();

            decimal KilobyteBit = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Bit);
            Console.WriteLine($"{Value} Kilobyte -> Bit: {KilobyteBit}");

            decimal KilobyteByte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Byte);
            Console.WriteLine($"{Value} Kilobyte -> Byte: {KilobyteByte}");

            decimal KilobyteKilobyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Kilobyte -> Kilobyte: {KilobyteKilobyte}");

            decimal KilobyteMegabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Kilobyte -> Megabyte: {KilobyteMegabyte}");

            decimal KilobyteGigabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Kilobyte -> Gigabyte: {KilobyteGigabyte}");

            decimal KilobyteTerabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Kilobyte -> Terabyte: {KilobyteTerabyte}");

            decimal KilobytePetabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Kilobyte -> Petabyte: {KilobytePetabyte}");

            decimal KilobyteExabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Kilobyte -> Exabyte: {KilobyteExabyte}");

            decimal KilobyteZetabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Kilobyte -> Zetabyte: {KilobyteZetabyte}");

            decimal KilobyteYottabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Kilobyte -> Yottabyte: {KilobyteYottabyte}");

            Console.WriteLine();

            decimal MegabyteBit = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Megabyte -> Bit: {MegabyteBit}");

            decimal MegabyteByte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Megabyte -> Byte: {MegabyteByte}");

            decimal MegabyteKilobyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Megabyte -> Kilobyte: {MegabyteKilobyte}");

            decimal MegabyteMegabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Megabyte -> Megabyte: {MegabyteMegabyte}");

            decimal MegabyteGigabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Megabyte -> Gigabyte: {MegabyteGigabyte}");

            decimal MegabyteTerabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Megabyte -> Terabyte: {MegabyteTerabyte}");

            decimal MegabytePetabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Megabyte -> Petabyte: {MegabytePetabyte}");

            decimal MegabyteExabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Megabyte -> Exabyte: {MegabyteExabyte}");

            decimal MegabyteZetabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Megabyte -> Zetabyte: {MegabyteZetabyte}");

            decimal MegabyteYottabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Megabyte -> Yottabyte: {MegabyteYottabyte}");

            Console.WriteLine();

            decimal GigabyteBit = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Gigabyte -> Bit: {GigabyteBit}");

            decimal GigabyteByte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Gigabyte -> Byte: {GigabyteByte}");

            decimal GigabyteKilobyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Gigabyte -> Kilobyte: {GigabyteKilobyte}");

            decimal GigabyteMegabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Gigabyte -> Megabyte: {GigabyteMegabyte}");

            decimal GigabyteGigabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Gigabyte -> Gigabyte: {GigabyteGigabyte}");

            decimal GigabyteTerabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Gigabyte -> Terabyte: {GigabyteTerabyte}");

            decimal GigabytePetabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Gigabyte -> Petabyte: {GigabytePetabyte}");

            decimal GigabyteExabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Gigabyte -> Exabyte: {GigabyteExabyte}");

            decimal GigabyteZetabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Gigabyte -> Zetabyte: {GigabyteZetabyte}");

            decimal GigabyteYottabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Gigabyte -> Yottabyte: {GigabyteYottabyte}");

            Console.WriteLine();

            decimal TerabyteBit = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Terabyte -> Bit: {TerabyteBit}");

            decimal TerabyteByte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Terabyte -> Byte: {TerabyteByte}");

            decimal TerabyteKilobyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Terabyte -> Kilobyte: {TerabyteKilobyte}");

            decimal TerabyteMegabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Terabyte -> Megabyte: {TerabyteMegabyte}");

            decimal TerabyteGigabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Terabyte -> Gigabyte: {TerabyteGigabyte}");

            decimal TerabyteTerabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Terabyte -> Terabyte: {TerabyteTerabyte}");

            decimal TerabytePetabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Terabyte -> Petabyte: {TerabytePetabyte}");

            decimal TerabyteExabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Terabyte -> Exabyte: {TerabyteExabyte}");

            decimal TerabyteZetabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Terabyte -> Zetabyte: {TerabyteZetabyte}");

            decimal TerabyteYottabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Terabyte -> Yottabyte: {TerabyteYottabyte}");

            Console.WriteLine();

            decimal PetabyteBit = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Petabyte -> Bit: {PetabyteBit}");

            decimal PetabyteByte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Petabyte -> Byte: {PetabyteByte}");

            decimal PetabyteKilobyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Petabyte -> Kilobyte: {PetabyteKilobyte}");

            decimal PetabyteMegabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Petabyte -> Megabyte: {PetabyteMegabyte}");

            decimal PetabyteGigabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Petabyte -> Gigabyte: {PetabyteGigabyte}");

            decimal PetabyteTerabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Petabyte -> Terabyte: {PetabyteTerabyte}");

            decimal PetabytePetabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Petabyte -> Petabyte: {PetabytePetabyte}");

            decimal PetabyteExabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Petabyte -> Exabyte: {PetabyteExabyte}");

            decimal PetabyteZetabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Petabyte -> Zetabyte: {PetabyteZetabyte}");

            decimal PetabyteYottabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Petabyte -> Yottabyte: {PetabyteYottabyte}");

            Console.WriteLine();

            decimal ExabyteBit = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Exabyte -> Bit: {ExabyteBit}");

            decimal ExabyteByte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Exabyte -> Byte: {ExabyteByte}");

            decimal ExabyteKilobyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Exabyte -> Kilobyte: {ExabyteKilobyte}");

            decimal ExabyteMegabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Exabyte -> Megabyte: {ExabyteMegabyte}");

            decimal ExabyteGigabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Exabyte -> Gigabyte: {ExabyteGigabyte}");

            decimal ExabyteTerabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Exabyte -> Terabyte: {ExabyteTerabyte}");

            decimal ExabytePetabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Exabyte -> Petabyte: {ExabytePetabyte}");

            decimal ExabyteExabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Exabyte -> Exabyte: {ExabyteExabyte}");

            decimal ExabyteZetabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Exabyte -> Zetabyte: {ExabyteZetabyte}");

            decimal ExabyteYottabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Exabyte -> Yottabyte: {ExabyteYottabyte}");

            Console.WriteLine();

            decimal ZetabyteBit = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Zetabyte -> Bit: {ZetabyteBit}");

            decimal ZetabyteByte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Zetabyte -> Byte: {ZetabyteByte}");

            decimal ZetabyteKilobyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Zetabyte -> Kilobyte: {ZetabyteKilobyte}");

            decimal ZetabyteMegabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Zetabyte -> Megabyte: {ZetabyteMegabyte}");

            decimal ZetabyteGigabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Zetabyte -> Gigabyte: {ZetabyteGigabyte}");

            decimal ZetabyteTerabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Zetabyte -> Terabyte: {ZetabyteTerabyte}");

            decimal ZetabytePetabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Zetabyte -> Petabyte: {ZetabytePetabyte}");

            decimal ZetabyteExabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Zetabyte -> Exabyte: {ZetabyteExabyte}");

            decimal ZetabyteZetabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Zetabyte -> Zetabyte: {ZetabyteZetabyte}");

            decimal ZetabyteYottabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Zetabyte -> Yottabyte: {ZetabyteYottabyte}");

            Console.WriteLine();

            decimal YottabyteBit = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Yottabyte -> Bit: {YottabyteBit}");

            decimal YottabyteByte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Yottabyte -> Byte: {YottabyteByte}");

            decimal YottabyteKilobyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Yottabyte -> Kilobyte: {YottabyteKilobyte}");

            decimal YottabyteMegabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Yottabyte -> Megabyte: {YottabyteMegabyte}");

            decimal YottabyteGigabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Yottabyte -> Gigabyte: {YottabyteGigabyte}");

            decimal YottabyteTerabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Yottabyte -> Terabyte: {YottabyteTerabyte}");

            decimal YottabytePetabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Yottabyte -> Petabyte: {YottabytePetabyte}");

            decimal YottabyteExabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Yottabyte -> Exabyte: {YottabyteExabyte}");

            decimal YottabyteZetabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Yottabyte -> Zetabyte: {YottabyteZetabyte}");

            decimal YottabyteYottabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Yottabyte -> Yottabyte: {YottabyteYottabyte}");

            Console.ReadKey();
        }
    }
}