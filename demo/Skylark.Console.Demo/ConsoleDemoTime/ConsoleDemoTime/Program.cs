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
            TimeStruct AutoAttosecond = TimeExtension.AutoConvert(Value2, TimeType.Attosecond);
            Console.WriteLine($"{Value2} Attosecond -> Auto: {AutoAttosecond.Value} {AutoAttosecond.Text}");

            TimeStruct AutoFemtosecond = TimeExtension.AutoConvert(Value2, TimeType.Femtosecond);
            Console.WriteLine($"{Value2} Femtosecond -> Auto: {AutoFemtosecond.Value} {AutoFemtosecond.Text}");

            TimeStruct AutoPicosecond = TimeExtension.AutoConvert(Value2, TimeType.Picosecond);
            Console.WriteLine($"{Value2} Picosecond -> Auto: {AutoPicosecond.Value} {AutoPicosecond.Text}");

            TimeStruct AutoNanosecond = TimeExtension.AutoConvert(Value2, TimeType.Nanosecond);
            Console.WriteLine($"{Value2} Nanosecond -> Auto: {AutoNanosecond.Value} {AutoNanosecond.Text}");

            TimeStruct AutoMicrosecond = TimeExtension.AutoConvert(Value2, TimeType.Microsecond);
            Console.WriteLine($"{Value2} Microsecond -> Auto: {AutoMicrosecond.Value} {AutoMicrosecond.Text}");

            TimeStruct AutoMillisecond = TimeExtension.AutoConvert(Value2, TimeType.Millisecond);
            Console.WriteLine($"{Value2} Millisecond -> Auto: {AutoMillisecond.Value} {AutoMillisecond.Text}");

            TimeStruct AutoCentisecond = TimeExtension.AutoConvert(Value2, TimeType.Centisecond);
            Console.WriteLine($"{Value2} Centisecond -> Auto: {AutoCentisecond.Value} {AutoCentisecond.Text}");

            TimeStruct AutoSecond = TimeExtension.AutoConvert(Value2, TimeType.Second);
            Console.WriteLine($"{Value2} Second -> Auto: {AutoSecond.Value} {AutoSecond.Text}");

            TimeStruct AutoMinute = TimeExtension.AutoConvert(Value2, TimeType.Minute);
            Console.WriteLine($"{Value2} Minute -> Auto: {AutoMinute.Value} {AutoMinute.Text}");

            TimeStruct AutoHour = TimeExtension.AutoConvert(Value2, TimeType.Hour);
            Console.WriteLine($"{Value2} Hour -> Auto: {AutoHour.Value} {AutoHour.Text}");

            TimeStruct AutoDay = TimeExtension.AutoConvert(Value2, TimeType.Day);
            Console.WriteLine($"{Value2} Day -> Auto: {AutoDay.Value} {AutoDay.Text}");

            TimeStruct AutoWeek = TimeExtension.AutoConvert(Value2, TimeType.Week);
            Console.WriteLine($"{Value2} Week -> Auto: {AutoWeek.Value} {AutoWeek.Text}");

            TimeStruct AutoYear = TimeExtension.AutoConvert(Value2, TimeType.Year);
            Console.WriteLine($"{Value2} Year -> Auto: {AutoYear.Value} {AutoYear.Text}");

            TimeStruct AutoDecade = TimeExtension.AutoConvert(Value2, TimeType.Decade);
            Console.WriteLine($"{Value2} Decade -> Auto: {AutoDecade.Value} {AutoDecade.Text}");

            TimeStruct AutoCentury = TimeExtension.AutoConvert(Value2, TimeType.Century);
            Console.WriteLine($"{Value2} Century -> Auto: {AutoCentury.Value} {AutoCentury.Text}");

            TimeStruct AutoMillennium = TimeExtension.AutoConvert(Value2, TimeType.Millennium);
            Console.WriteLine($"{Value2} Millennium -> Auto: {AutoMillennium.Value} {AutoMillennium.Text}");
            
            Console.WriteLine();

            decimal BitBit = StorageExtension.Convert(Value, StorageType.Bit, StorageType.Bit);
            Console.WriteLine($"{Value} Bit -> Bit: {BitBit}");

            ///

            Console.ReadKey();
        }
    }
}