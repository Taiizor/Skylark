using Skylark.Enum;
using Skylark.Extension;
using Skylark.Struct;

namespace ConsoleDemoStorage
{
    internal class Program
    {
        private const double Value = 999;
        private const double Value2 = 123456789;

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

            double BitBit = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Bit);
            Console.WriteLine($"{Value} Bit -> Bit: {BitBit}");

            double BitByte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Byte);
            Console.WriteLine($"{Value} Bit -> Byte: {BitByte}");

            double BitKilobyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Bit -> Kilobyte: {BitKilobyte}");

            double BitMegabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Megabyte);
            Console.WriteLine($"{Value} Bit -> Megabyte: {BitMegabyte}");

            double BitGigabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Bit -> Gigabyte: {BitGigabyte}");

            double BitTerabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Terabyte);
            Console.WriteLine($"{Value} Bit -> Terabyte: {BitTerabyte}");

            double BitPetabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Petabyte);
            Console.WriteLine($"{Value} Bit -> Petabyte: {BitPetabyte}");

            double BitExabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Exabyte);
            Console.WriteLine($"{Value} Bit -> Exabyte: {BitExabyte}");

            double BitZetabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Bit -> Zetabyte: {BitZetabyte}");

            double BitYottabyte = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Bit -> Yottabyte: {BitYottabyte}");

            Console.WriteLine();

            double ByteBit = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Bit);
            Console.WriteLine($"{Value} Byte -> Bit: {ByteBit}");

            double ByteByte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Byte);
            Console.WriteLine($"{Value} Byte -> Byte: {ByteByte}");

            double ByteKilobyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Byte -> Kilobyte: {ByteKilobyte}");

            double ByteMegabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Byte -> Megabyte: {ByteMegabyte}");

            double ByteGigabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Byte -> Gigabyte: {ByteGigabyte}");

            double ByteTerabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Byte -> Terabyte: {ByteTerabyte}");

            double BytePetabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Byte -> Petabyte: {BytePetabyte}");

            double ByteExabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Byte -> Exabyte: {ByteExabyte}");

            double ByteZetabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Byte -> Zetabyte: {ByteZetabyte}");

            double ByteYottabyte = StorageExtension.Convert(Value, StorageType.Byte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Byte -> Yottabyte: {ByteYottabyte}");

            Console.WriteLine();

            double KilobyteBit = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Bit);
            Console.WriteLine($"{Value} Kilobyte -> Bit: {KilobyteBit}");

            double KilobyteByte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Byte);
            Console.WriteLine($"{Value} Kilobyte -> Byte: {KilobyteByte}");

            double KilobyteKilobyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Kilobyte -> Kilobyte: {KilobyteKilobyte}");

            double KilobyteMegabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Kilobyte -> Megabyte: {KilobyteMegabyte}");

            double KilobyteGigabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Kilobyte -> Gigabyte: {KilobyteGigabyte}");

            double KilobyteTerabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Kilobyte -> Terabyte: {KilobyteTerabyte}");

            double KilobytePetabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Kilobyte -> Petabyte: {KilobytePetabyte}");

            double KilobyteExabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Kilobyte -> Exabyte: {KilobyteExabyte}");

            double KilobyteZetabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Kilobyte -> Zetabyte: {KilobyteZetabyte}");

            double KilobyteYottabyte = StorageExtension.Convert(Value, StorageType.Kilobyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Kilobyte -> Yottabyte: {KilobyteYottabyte}");

            Console.WriteLine();

            double MegabyteBit = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Megabyte -> Bit: {MegabyteBit}");

            double MegabyteByte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Megabyte -> Byte: {MegabyteByte}");

            double MegabyteKilobyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Megabyte -> Kilobyte: {MegabyteKilobyte}");

            double MegabyteMegabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Megabyte -> Megabyte: {MegabyteMegabyte}");

            double MegabyteGigabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Megabyte -> Gigabyte: {MegabyteGigabyte}");

            double MegabyteTerabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Megabyte -> Terabyte: {MegabyteTerabyte}");

            double MegabytePetabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Megabyte -> Petabyte: {MegabytePetabyte}");

            double MegabyteExabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Megabyte -> Exabyte: {MegabyteExabyte}");

            double MegabyteZetabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Megabyte -> Zetabyte: {MegabyteZetabyte}");

            double MegabyteYottabyte = StorageExtension.Convert(Value, StorageType.Megabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Megabyte -> Yottabyte: {MegabyteYottabyte}");

            Console.WriteLine();

            double GigabyteBit = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Gigabyte -> Bit: {GigabyteBit}");

            double GigabyteByte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Gigabyte -> Byte: {GigabyteByte}");

            double GigabyteKilobyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Gigabyte -> Kilobyte: {GigabyteKilobyte}");

            double GigabyteMegabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Gigabyte -> Megabyte: {GigabyteMegabyte}");

            double GigabyteGigabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Gigabyte -> Gigabyte: {GigabyteGigabyte}");

            double GigabyteTerabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Gigabyte -> Terabyte: {GigabyteTerabyte}");

            double GigabytePetabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Gigabyte -> Petabyte: {GigabytePetabyte}");

            double GigabyteExabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Gigabyte -> Exabyte: {GigabyteExabyte}");

            double GigabyteZetabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Gigabyte -> Zetabyte: {GigabyteZetabyte}");

            double GigabyteYottabyte = StorageExtension.Convert(Value, StorageType.Gigabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Gigabyte -> Yottabyte: {GigabyteYottabyte}");

            Console.WriteLine();

            double TerabyteBit = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Terabyte -> Bit: {TerabyteBit}");

            double TerabyteByte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Terabyte -> Byte: {TerabyteByte}");

            double TerabyteKilobyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Terabyte -> Kilobyte: {TerabyteKilobyte}");

            double TerabyteMegabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Terabyte -> Megabyte: {TerabyteMegabyte}");

            double TerabyteGigabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Terabyte -> Gigabyte: {TerabyteGigabyte}");

            double TerabyteTerabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Terabyte -> Terabyte: {TerabyteTerabyte}");

            double TerabytePetabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Terabyte -> Petabyte: {TerabytePetabyte}");

            double TerabyteExabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Terabyte -> Exabyte: {TerabyteExabyte}");

            double TerabyteZetabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Terabyte -> Zetabyte: {TerabyteZetabyte}");

            double TerabyteYottabyte = StorageExtension.Convert(Value, StorageType.Terabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Terabyte -> Yottabyte: {TerabyteYottabyte}");

            Console.WriteLine();

            double PetabyteBit = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Petabyte -> Bit: {PetabyteBit}");

            double PetabyteByte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Petabyte -> Byte: {PetabyteByte}");

            double PetabyteKilobyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Petabyte -> Kilobyte: {PetabyteKilobyte}");

            double PetabyteMegabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Petabyte -> Megabyte: {PetabyteMegabyte}");

            double PetabyteGigabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Petabyte -> Gigabyte: {PetabyteGigabyte}");

            double PetabyteTerabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Petabyte -> Terabyte: {PetabyteTerabyte}");

            double PetabytePetabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Petabyte -> Petabyte: {PetabytePetabyte}");

            double PetabyteExabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Petabyte -> Exabyte: {PetabyteExabyte}");

            double PetabyteZetabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Petabyte -> Zetabyte: {PetabyteZetabyte}");

            double PetabyteYottabyte = StorageExtension.Convert(Value, StorageType.Petabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Petabyte -> Yottabyte: {PetabyteYottabyte}");

            Console.WriteLine();

            double ExabyteBit = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Exabyte -> Bit: {ExabyteBit}");

            double ExabyteByte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Exabyte -> Byte: {ExabyteByte}");

            double ExabyteKilobyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Exabyte -> Kilobyte: {ExabyteKilobyte}");

            double ExabyteMegabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Exabyte -> Megabyte: {ExabyteMegabyte}");

            double ExabyteGigabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Exabyte -> Gigabyte: {ExabyteGigabyte}");

            double ExabyteTerabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Exabyte -> Terabyte: {ExabyteTerabyte}");

            double ExabytePetabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Exabyte -> Petabyte: {ExabytePetabyte}");

            double ExabyteExabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Exabyte -> Exabyte: {ExabyteExabyte}");

            double ExabyteZetabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Exabyte -> Zetabyte: {ExabyteZetabyte}");

            double ExabyteYottabyte = StorageExtension.Convert(Value, StorageType.Exabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Exabyte -> Yottabyte: {ExabyteYottabyte}");

            Console.WriteLine();

            double ZetabyteBit = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Zetabyte -> Bit: {ZetabyteBit}");

            double ZetabyteByte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Zetabyte -> Byte: {ZetabyteByte}");

            double ZetabyteKilobyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Zetabyte -> Kilobyte: {ZetabyteKilobyte}");

            double ZetabyteMegabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Zetabyte -> Megabyte: {ZetabyteMegabyte}");

            double ZetabyteGigabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Zetabyte -> Gigabyte: {ZetabyteGigabyte}");

            double ZetabyteTerabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Zetabyte -> Terabyte: {ZetabyteTerabyte}");

            double ZetabytePetabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Zetabyte -> Petabyte: {ZetabytePetabyte}");

            double ZetabyteExabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Zetabyte -> Exabyte: {ZetabyteExabyte}");

            double ZetabyteZetabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Zetabyte -> Zetabyte: {ZetabyteZetabyte}");

            double ZetabyteYottabyte = StorageExtension.Convert(Value, StorageType.Zetabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Zetabyte -> Yottabyte: {ZetabyteYottabyte}");

            Console.WriteLine();

            double YottabyteBit = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Bit);
            Console.WriteLine($"{Value} Yottabyte -> Bit: {YottabyteBit}");

            double YottabyteByte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Byte);
            Console.WriteLine($"{Value} Yottabyte -> Byte: {YottabyteByte}");

            double YottabyteKilobyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Kilobyte);
            Console.WriteLine($"{Value} Yottabyte -> Kilobyte: {YottabyteKilobyte}");

            double YottabyteMegabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Megabyte);
            Console.WriteLine($"{Value} Yottabyte -> Megabyte: {YottabyteMegabyte}");

            double YottabyteGigabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Gigabyte);
            Console.WriteLine($"{Value} Yottabyte -> Gigabyte: {YottabyteGigabyte}");

            double YottabyteTerabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Terabyte);
            Console.WriteLine($"{Value} Yottabyte -> Terabyte: {YottabyteTerabyte}");

            double YottabytePetabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Petabyte);
            Console.WriteLine($"{Value} Yottabyte -> Petabyte: {YottabytePetabyte}");

            double YottabyteExabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Exabyte);
            Console.WriteLine($"{Value} Yottabyte -> Exabyte: {YottabyteExabyte}");

            double YottabyteZetabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Zetabyte);
            Console.WriteLine($"{Value} Yottabyte -> Zetabyte: {YottabyteZetabyte}");

            double YottabyteYottabyte = StorageExtension.Convert(Value, StorageType.Yottabyte, StorageType.Yottabyte);
            Console.WriteLine($"{Value} Yottabyte -> Yottabyte: {YottabyteYottabyte}");

            Console.ReadKey();
        }
    }
}