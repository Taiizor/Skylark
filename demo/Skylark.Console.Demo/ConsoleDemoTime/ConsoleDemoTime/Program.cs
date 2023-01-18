using Skylark.Enum;
using Skylark.Extension;
using Skylark.Struct;

namespace ConsoleDemoTime
{
    internal class Program
    {
        private const decimal Value = 1;
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

            decimal AttosecondAttosecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Attosecond -> Attosecond: {AttosecondAttosecond}");

            decimal AttosecondFemtosecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Attosecond -> Femtosecond: {AttosecondFemtosecond}");

            decimal AttosecondPicosecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Attosecond -> Picosecond: {AttosecondPicosecond}");

            decimal AttosecondNanosecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Attosecond -> Nanosecond: {AttosecondNanosecond}");

            decimal AttosecondMicrosecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Attosecond -> Microsecond: {AttosecondMicrosecond}");

            decimal AttosecondMillisecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Attosecond -> Millisecond: {AttosecondMillisecond}");

            decimal AttosecondCentisecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Centisecond);
            Console.WriteLine($"{Value} Attosecond -> Centisecond: {AttosecondCentisecond}");

            decimal AttosecondSecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Second);
            Console.WriteLine($"{Value} Attosecond -> Second: {AttosecondSecond}");

            decimal AttosecondMinute = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Minute);
            Console.WriteLine($"{Value} Attosecond -> Minute: {AttosecondMinute}");

            decimal AttosecondHour = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Hour);
            Console.WriteLine($"{Value} Attosecond -> Hour: {AttosecondHour}");

            decimal AttosecondDay = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Day);
            Console.WriteLine($"{Value} Attosecond -> Day: {AttosecondDay}");

            decimal AttosecondWeek = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Week);
            Console.WriteLine($"{Value} Attosecond -> Week: {AttosecondWeek}");

            decimal AttosecondYear = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Year);
            Console.WriteLine($"{Value} Attosecond -> Year: {AttosecondYear}");

            decimal AttosecondDecade = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Decade);
            Console.WriteLine($"{Value} Attosecond -> Decade: {AttosecondDecade}");

            decimal AttosecondCentury = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Century);
            Console.WriteLine($"{Value} Attosecond -> Century: {AttosecondCentury}");

            decimal AttosecondMillennium = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Attosecond -> Millennium: {AttosecondMillennium}");

            Console.WriteLine();

            decimal FemtosecondAttosecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Femtosecond -> Attosecond: {FemtosecondAttosecond}");

            decimal FemtosecondFemtosecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Femtosecond -> Femtosecond: {FemtosecondFemtosecond}");

            decimal FemtosecondPicosecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Femtosecond -> Picosecond: {FemtosecondPicosecond}");

            decimal FemtosecondNanosecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Femtosecond -> Nanosecond: {FemtosecondNanosecond}");

            decimal FemtosecondMicrosecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Femtosecond -> Microsecond: {FemtosecondMicrosecond}");

            decimal FemtosecondMillisecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Femtosecond -> Millisecond: {FemtosecondMillisecond}");

            decimal FemtosecondCentisecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Centisecond);
            Console.WriteLine($"{Value} Femtosecond -> Centisecond: {FemtosecondCentisecond}");

            decimal FemtosecondSecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Second);
            Console.WriteLine($"{Value} Femtosecond -> Second: {FemtosecondSecond}");

            decimal FemtosecondMinute = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Minute);
            Console.WriteLine($"{Value} Femtosecond -> Minute: {FemtosecondMinute}");

            decimal FemtosecondHour = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Hour);
            Console.WriteLine($"{Value} Femtosecond -> Hour: {FemtosecondHour}");

            decimal FemtosecondDay = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Day);
            Console.WriteLine($"{Value} Femtosecond -> Day: {FemtosecondDay}");

            decimal FemtosecondWeek = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Week);
            Console.WriteLine($"{Value} Femtosecond -> Week: {FemtosecondWeek}");

            decimal FemtosecondYear = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Year);
            Console.WriteLine($"{Value} Femtosecond -> Year: {FemtosecondYear}");

            decimal FemtosecondDecade = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Decade);
            Console.WriteLine($"{Value} Femtosecond -> Decade: {FemtosecondDecade}");

            decimal FemtosecondCentury = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Century);
            Console.WriteLine($"{Value} Femtosecond -> Century: {FemtosecondCentury}");

            decimal FemtosecondMillennium = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Femtosecond -> Millennium: {FemtosecondMillennium}");

            Console.WriteLine();

            decimal PicosecondAttosecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Picosecond -> Attosecond: {PicosecondAttosecond}");

            decimal PicosecondFemtosecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Picosecond -> Femtosecond: {PicosecondFemtosecond}");

            decimal PicosecondPicosecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Picosecond -> Picosecond: {PicosecondPicosecond}");

            decimal PicosecondNanosecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Picosecond -> Nanosecond: {PicosecondNanosecond}");

            decimal PicosecondMicrosecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Picosecond -> Microsecond: {PicosecondMicrosecond}");

            decimal PicosecondMillisecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Picosecond -> Millisecond: {PicosecondMillisecond}");

            decimal PicosecondCentisecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Centisecond);
            Console.WriteLine($"{Value} Picosecond -> Centisecond: {PicosecondCentisecond}");

            decimal PicosecondSecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Second);
            Console.WriteLine($"{Value} Picosecond -> Second: {PicosecondSecond}");

            decimal PicosecondMinute = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Minute);
            Console.WriteLine($"{Value} Picosecond -> Minute: {PicosecondMinute}");

            decimal PicosecondHour = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Hour);
            Console.WriteLine($"{Value} Picosecond -> Hour: {PicosecondHour}");

            decimal PicosecondDay = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Day);
            Console.WriteLine($"{Value} Picosecond -> Day: {PicosecondDay}");

            decimal PicosecondWeek = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Week);
            Console.WriteLine($"{Value} Picosecond -> Week: {PicosecondWeek}");

            decimal PicosecondYear = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Year);
            Console.WriteLine($"{Value} Picosecond -> Year: {PicosecondYear}");

            decimal PicosecondDecade = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Decade);
            Console.WriteLine($"{Value} Picosecond -> Decade: {PicosecondDecade}");

            decimal PicosecondCentury = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Century);
            Console.WriteLine($"{Value} Picosecond -> Century: {PicosecondCentury}");

            decimal PicosecondMillennium = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Picosecond -> Millennium: {PicosecondMillennium}");

            Console.WriteLine();

            decimal NanosecondAttosecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Nanosecond -> Attosecond: {NanosecondAttosecond}");

            decimal NanosecondFemtosecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Nanosecond -> Femtosecond: {NanosecondFemtosecond}");

            decimal NanosecondPicosecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Nanosecond -> Picosecond: {NanosecondPicosecond}");

            decimal NanosecondNanosecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Nanosecond -> Nanosecond: {NanosecondNanosecond}");

            decimal NanosecondMicrosecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Nanosecond -> Microsecond: {NanosecondMicrosecond}");

            decimal NanosecondMillisecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Nanosecond -> Millisecond: {NanosecondMillisecond}");

            decimal NanosecondCentisecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Centisecond);
            Console.WriteLine($"{Value} Nanosecond -> Centisecond: {NanosecondCentisecond}");

            decimal NanosecondSecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Second);
            Console.WriteLine($"{Value} Nanosecond -> Second: {NanosecondSecond}");

            decimal NanosecondMinute = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Minute);
            Console.WriteLine($"{Value} Nanosecond -> Minute: {NanosecondMinute}");

            decimal NanosecondHour = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Hour);
            Console.WriteLine($"{Value} Nanosecond -> Hour: {NanosecondHour}");

            decimal NanosecondDay = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Day);
            Console.WriteLine($"{Value} Nanosecond -> Day: {NanosecondDay}");

            decimal NanosecondWeek = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Week);
            Console.WriteLine($"{Value} Nanosecond -> Week: {NanosecondWeek}");

            decimal NanosecondYear = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Year);
            Console.WriteLine($"{Value} Nanosecond -> Year: {NanosecondYear}");

            decimal NanosecondDecade = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Decade);
            Console.WriteLine($"{Value} Nanosecond -> Decade: {NanosecondDecade}");

            decimal NanosecondCentury = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Century);
            Console.WriteLine($"{Value} Nanosecond -> Century: {NanosecondCentury}");

            decimal NanosecondMillennium = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Nanosecond -> Millennium: {NanosecondMillennium}");

            Console.WriteLine();

            decimal MicrosecondAttosecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Microsecond -> Attosecond: {MicrosecondAttosecond}");

            decimal MicrosecondFemtosecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Microsecond -> Femtosecond: {MicrosecondFemtosecond}");

            decimal MicrosecondPicosecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Microsecond -> Picosecond: {MicrosecondPicosecond}");

            decimal MicrosecondNanosecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Microsecond -> Nanosecond: {MicrosecondNanosecond}");

            decimal MicrosecondMicrosecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Microsecond -> Microsecond: {MicrosecondMicrosecond}");

            decimal MicrosecondMillisecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Microsecond -> Millisecond: {MicrosecondMillisecond}");

            decimal MicrosecondCentisecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Centisecond);
            Console.WriteLine($"{Value} Microsecond -> Centisecond: {MicrosecondCentisecond}");

            decimal MicrosecondSecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Second);
            Console.WriteLine($"{Value} Microsecond -> Second: {MicrosecondSecond}");

            decimal MicrosecondMinute = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Minute);
            Console.WriteLine($"{Value} Microsecond -> Minute: {MicrosecondMinute}");

            decimal MicrosecondHour = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Hour);
            Console.WriteLine($"{Value} Microsecond -> Hour: {MicrosecondHour}");

            decimal MicrosecondDay = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Day);
            Console.WriteLine($"{Value} Microsecond -> Day: {MicrosecondDay}");

            decimal MicrosecondWeek = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Week);
            Console.WriteLine($"{Value} Microsecond -> Week: {MicrosecondWeek}");

            decimal MicrosecondYear = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Year);
            Console.WriteLine($"{Value} Microsecond -> Year: {MicrosecondYear}");

            decimal MicrosecondDecade = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Decade);
            Console.WriteLine($"{Value} Microsecond -> Decade: {MicrosecondDecade}");

            decimal MicrosecondCentury = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Century);
            Console.WriteLine($"{Value} Microsecond -> Century: {MicrosecondCentury}");

            decimal MicrosecondMillennium = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Microsecond -> Millennium: {MicrosecondMillennium}");

            Console.WriteLine();

            decimal MillisecondAttosecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Millisecond -> Attosecond: {MillisecondAttosecond}");

            decimal MillisecondFemtosecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Millisecond -> Femtosecond: {MillisecondFemtosecond}");

            decimal MillisecondPicosecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Millisecond -> Picosecond: {MillisecondPicosecond}");

            decimal MillisecondNanosecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Millisecond -> Nanosecond: {MillisecondNanosecond}");

            decimal MillisecondMicrosecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Millisecond -> Microsecond: {MillisecondMicrosecond}");

            decimal MillisecondMillisecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Millisecond -> Millisecond: {MillisecondMillisecond}");

            decimal MillisecondCentisecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Centisecond);
            Console.WriteLine($"{Value} Millisecond -> Centisecond: {MillisecondCentisecond}");

            decimal MillisecondSecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Second);
            Console.WriteLine($"{Value} Millisecond -> Second: {MillisecondSecond}");

            decimal MillisecondMinute = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Minute);
            Console.WriteLine($"{Value} Millisecond -> Minute: {MillisecondMinute}");

            decimal MillisecondHour = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Hour);
            Console.WriteLine($"{Value} Millisecond -> Hour: {MillisecondHour}");

            decimal MillisecondDay = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Day);
            Console.WriteLine($"{Value} Millisecond -> Day: {MillisecondDay}");

            decimal MillisecondWeek = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Week);
            Console.WriteLine($"{Value} Millisecond -> Week: {MillisecondWeek}");

            decimal MillisecondYear = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Year);
            Console.WriteLine($"{Value} Millisecond -> Year: {MillisecondYear}");

            decimal MillisecondDecade = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Decade);
            Console.WriteLine($"{Value} Millisecond -> Decade: {MillisecondDecade}");

            decimal MillisecondCentury = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Century);
            Console.WriteLine($"{Value} Millisecond -> Century: {MillisecondCentury}");

            decimal MillisecondMillennium = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Millisecond -> Millennium: {MillisecondMillennium}");

            Console.WriteLine();

            decimal CentisecondAttosecond = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Centisecond -> Attosecond: {CentisecondAttosecond}");

            decimal CentisecondFemtosecond = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Centisecond -> Femtosecond: {CentisecondFemtosecond}");

            decimal CentisecondPicosecond = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Centisecond -> Picosecond: {CentisecondPicosecond}");

            decimal CentisecondNanosecond = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Centisecond -> Nanosecond: {CentisecondNanosecond}");

            decimal CentisecondMicrosecond = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Centisecond -> Microsecond: {CentisecondMicrosecond}");

            decimal CentisecondMillisecond = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Centisecond -> Millisecond: {CentisecondMillisecond}");

            decimal CentisecondCentisecond = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Centisecond);
            Console.WriteLine($"{Value} Centisecond -> Centisecond: {CentisecondCentisecond}");

            decimal CentisecondSecond = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Second);
            Console.WriteLine($"{Value} Centisecond -> Second: {CentisecondSecond}");

            decimal CentisecondMinute = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Minute);
            Console.WriteLine($"{Value} Centisecond -> Minute: {CentisecondMinute}");

            decimal CentisecondHour = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Hour);
            Console.WriteLine($"{Value} Centisecond -> Hour: {CentisecondHour}");

            decimal CentisecondDay = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Day);
            Console.WriteLine($"{Value} Centisecond -> Day: {CentisecondDay}");

            decimal CentisecondWeek = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Week);
            Console.WriteLine($"{Value} Centisecond -> Week: {CentisecondWeek}");

            decimal CentisecondYear = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Year);
            Console.WriteLine($"{Value} Centisecond -> Year: {CentisecondYear}");

            decimal CentisecondDecade = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Decade);
            Console.WriteLine($"{Value} Centisecond -> Decade: {CentisecondDecade}");

            decimal CentisecondCentury = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Century);
            Console.WriteLine($"{Value} Centisecond -> Century: {CentisecondCentury}");

            decimal CentisecondMillennium = TimeExtension.Convert(Value, TimeType.Centisecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Centisecond -> Millennium: {CentisecondMillennium}");

            Console.WriteLine();

            decimal SecondAttosecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Attosecond);
            Console.WriteLine($"{Value} Second -> Attosecond: {SecondAttosecond}");

            decimal SecondFemtosecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Second -> Femtosecond: {SecondFemtosecond}");

            decimal SecondPicosecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Picosecond);
            Console.WriteLine($"{Value} Second -> Picosecond: {SecondPicosecond}");

            decimal SecondNanosecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Second -> Nanosecond: {SecondNanosecond}");

            decimal SecondMicrosecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Microsecond);
            Console.WriteLine($"{Value} Second -> Microsecond: {SecondMicrosecond}");

            decimal SecondMillisecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Millisecond);
            Console.WriteLine($"{Value} Second -> Millisecond: {SecondMillisecond}");

            decimal SecondCentisecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Centisecond);
            Console.WriteLine($"{Value} Second -> Centisecond: {SecondCentisecond}");

            decimal SecondSecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Second);
            Console.WriteLine($"{Value} Second -> Second: {SecondSecond}");

            decimal SecondMinute = TimeExtension.Convert(Value, TimeType.Second, TimeType.Minute);
            Console.WriteLine($"{Value} Second -> Minute: {SecondMinute}");

            decimal SecondHour = TimeExtension.Convert(Value, TimeType.Second, TimeType.Hour);
            Console.WriteLine($"{Value} Second -> Hour: {SecondHour}");

            decimal SecondDay = TimeExtension.Convert(Value, TimeType.Second, TimeType.Day);
            Console.WriteLine($"{Value} Second -> Day: {SecondDay}");

            decimal SecondWeek = TimeExtension.Convert(Value, TimeType.Second, TimeType.Week);
            Console.WriteLine($"{Value} Second -> Week: {SecondWeek}");

            decimal SecondYear = TimeExtension.Convert(Value, TimeType.Second, TimeType.Year);
            Console.WriteLine($"{Value} Second -> Year: {SecondYear}");

            decimal SecondDecade = TimeExtension.Convert(Value, TimeType.Second, TimeType.Decade);
            Console.WriteLine($"{Value} Second -> Decade: {SecondDecade}");

            decimal SecondCentury = TimeExtension.Convert(Value, TimeType.Second, TimeType.Century);
            Console.WriteLine($"{Value} Second -> Century: {SecondCentury}");

            decimal SecondMillennium = TimeExtension.Convert(Value, TimeType.Second, TimeType.Millennium);
            Console.WriteLine($"{Value} Second -> Millennium: {SecondMillennium}");

            Console.WriteLine();

            decimal MinuteAttosecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Attosecond);
            Console.WriteLine($"{Value} Minute -> Attosecond: {MinuteAttosecond}");

            decimal MinuteFemtosecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Minute -> Femtosecond: {MinuteFemtosecond}");

            decimal MinutePicosecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Picosecond);
            Console.WriteLine($"{Value} Minute -> Picosecond: {MinutePicosecond}");

            decimal MinuteNanosecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Minute -> Nanosecond: {MinuteNanosecond}");

            decimal MinuteMicrosecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Microsecond);
            Console.WriteLine($"{Value} Minute -> Microsecond: {MinuteMicrosecond}");

            decimal MinuteMillisecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Millisecond);
            Console.WriteLine($"{Value} Minute -> Millisecond: {MinuteMillisecond}");

            decimal MinuteCentisecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Centisecond);
            Console.WriteLine($"{Value} Minute -> Centisecond: {MinuteCentisecond}");

            decimal MinuteSecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Second);
            Console.WriteLine($"{Value} Minute -> Second: {MinuteSecond}");

            decimal MinuteMinute = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Minute);
            Console.WriteLine($"{Value} Minute -> Minute: {MinuteMinute}");

            decimal MinuteHour = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Hour);
            Console.WriteLine($"{Value} Minute -> Hour: {MinuteHour}");

            decimal MinuteDay = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Day);
            Console.WriteLine($"{Value} Minute -> Day: {MinuteDay}");

            decimal MinuteWeek = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Week);
            Console.WriteLine($"{Value} Minute -> Week: {MinuteWeek}");

            decimal MinuteYear = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Year);
            Console.WriteLine($"{Value} Minute -> Year: {MinuteYear}");

            decimal MinuteDecade = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Decade);
            Console.WriteLine($"{Value} Minute -> Decade: {MinuteDecade}");

            decimal MinuteCentury = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Century);
            Console.WriteLine($"{Value} Minute -> Century: {MinuteCentury}");

            decimal MinuteMillennium = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Millennium);
            Console.WriteLine($"{Value} Minute -> Millennium: {MinuteMillennium}");

            Console.WriteLine();

            decimal HourAttosecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Attosecond);
            Console.WriteLine($"{Value} Hour -> Attosecond: {HourAttosecond}");

            decimal HourFemtosecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Hour -> Femtosecond: {HourFemtosecond}");

            decimal HourPicosecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Picosecond);
            Console.WriteLine($"{Value} Hour -> Picosecond: {HourPicosecond}");

            decimal HourNanosecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Hour -> Nanosecond: {HourNanosecond}");

            decimal HourMicrosecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Microsecond);
            Console.WriteLine($"{Value} Hour -> Microsecond: {HourMicrosecond}");

            decimal HourMillisecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Millisecond);
            Console.WriteLine($"{Value} Hour -> Millisecond: {HourMillisecond}");

            decimal HourCentisecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Centisecond);
            Console.WriteLine($"{Value} Hour -> Centisecond: {HourCentisecond}");

            decimal HourSecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Second);
            Console.WriteLine($"{Value} Hour -> Second: {HourSecond}");

            decimal HourMinute = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Minute);
            Console.WriteLine($"{Value} Hour -> Minute: {HourMinute}");

            decimal HourHour = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Hour);
            Console.WriteLine($"{Value} Hour -> Hour: {HourHour}");

            decimal HourDay = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Day);
            Console.WriteLine($"{Value} Hour -> Day: {HourDay}");

            decimal HourWeek = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Week);
            Console.WriteLine($"{Value} Hour -> Week: {HourWeek}");

            decimal HourYear = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Year);
            Console.WriteLine($"{Value} Hour -> Year: {HourYear}");

            decimal HourDecade = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Decade);
            Console.WriteLine($"{Value} Hour -> Decade: {HourDecade}");

            decimal HourCentury = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Century);
            Console.WriteLine($"{Value} Hour -> Century: {HourCentury}");

            decimal HourMillennium = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Millennium);
            Console.WriteLine($"{Value} Hour -> Millennium: {HourMillennium}");

            Console.WriteLine();

            decimal DayAttosecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Attosecond);
            Console.WriteLine($"{Value} Day -> Attosecond: {DayAttosecond}");

            decimal DayFemtosecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Day -> Femtosecond: {DayFemtosecond}");

            decimal DayPicosecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Picosecond);
            Console.WriteLine($"{Value} Day -> Picosecond: {DayPicosecond}");

            decimal DayNanosecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Day -> Nanosecond: {DayNanosecond}");

            decimal DayMicrosecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Microsecond);
            Console.WriteLine($"{Value} Day -> Microsecond: {DayMicrosecond}");

            decimal DayMillisecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Millisecond);
            Console.WriteLine($"{Value} Day -> Millisecond: {DayMillisecond}");

            decimal DayCentisecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Centisecond);
            Console.WriteLine($"{Value} Day -> Centisecond: {DayCentisecond}");

            decimal DaySecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Second);
            Console.WriteLine($"{Value} Day -> Second: {DaySecond}");

            decimal DayMinute = TimeExtension.Convert(Value, TimeType.Day, TimeType.Minute);
            Console.WriteLine($"{Value} Day -> Minute: {DayMinute}");

            decimal DayHour = TimeExtension.Convert(Value, TimeType.Day, TimeType.Hour);
            Console.WriteLine($"{Value} Day -> Hour: {DayHour}");

            decimal DayDay = TimeExtension.Convert(Value, TimeType.Day, TimeType.Day);
            Console.WriteLine($"{Value} Day -> Day: {DayDay}");

            decimal DayWeek = TimeExtension.Convert(Value, TimeType.Day, TimeType.Week);
            Console.WriteLine($"{Value} Day -> Week: {DayWeek}");

            decimal DayYear = TimeExtension.Convert(Value, TimeType.Day, TimeType.Year);
            Console.WriteLine($"{Value} Day -> Year: {DayYear}");

            decimal DayDecade = TimeExtension.Convert(Value, TimeType.Day, TimeType.Decade);
            Console.WriteLine($"{Value} Day -> Decade: {DayDecade}");

            decimal DayCentury = TimeExtension.Convert(Value, TimeType.Day, TimeType.Century);
            Console.WriteLine($"{Value} Day -> Century: {DayCentury}");

            decimal DayMillennium = TimeExtension.Convert(Value, TimeType.Day, TimeType.Millennium);
            Console.WriteLine($"{Value} Day -> Millennium: {DayMillennium}");

            Console.WriteLine();

            decimal WeekAttosecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Attosecond);
            Console.WriteLine($"{Value} Week -> Attosecond: {WeekAttosecond}");

            decimal WeekFemtosecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Week -> Femtosecond: {WeekFemtosecond}");

            decimal WeekPicosecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Picosecond);
            Console.WriteLine($"{Value} Week -> Picosecond: {WeekPicosecond}");

            decimal WeekNanosecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Week -> Nanosecond: {WeekNanosecond}");

            decimal WeekMicrosecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Microsecond);
            Console.WriteLine($"{Value} Week -> Microsecond: {WeekMicrosecond}");

            decimal WeekMillisecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Millisecond);
            Console.WriteLine($"{Value} Week -> Millisecond: {WeekMillisecond}");

            decimal WeekCentisecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Centisecond);
            Console.WriteLine($"{Value} Week -> Centisecond: {WeekCentisecond}");

            decimal WeekSecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Second);
            Console.WriteLine($"{Value} Week -> Second: {WeekSecond}");

            decimal WeekMinute = TimeExtension.Convert(Value, TimeType.Week, TimeType.Minute);
            Console.WriteLine($"{Value} Week -> Minute: {WeekMinute}");

            decimal WeekHour = TimeExtension.Convert(Value, TimeType.Week, TimeType.Hour);
            Console.WriteLine($"{Value} Week -> Hour: {WeekHour}");

            decimal WeekDay = TimeExtension.Convert(Value, TimeType.Week, TimeType.Day);
            Console.WriteLine($"{Value} Week -> Day: {WeekDay}");

            decimal WeekWeek = TimeExtension.Convert(Value, TimeType.Week, TimeType.Week);
            Console.WriteLine($"{Value} Week -> Week: {WeekWeek}");

            decimal WeekYear = TimeExtension.Convert(Value, TimeType.Week, TimeType.Year);
            Console.WriteLine($"{Value} Week -> Year: {WeekYear}");

            decimal WeekDecade = TimeExtension.Convert(Value, TimeType.Week, TimeType.Decade);
            Console.WriteLine($"{Value} Week -> Decade: {WeekDecade}");

            decimal WeekCentury = TimeExtension.Convert(Value, TimeType.Week, TimeType.Century);
            Console.WriteLine($"{Value} Week -> Century: {WeekCentury}");

            decimal WeekMillennium = TimeExtension.Convert(Value, TimeType.Week, TimeType.Millennium);
            Console.WriteLine($"{Value} Week -> Millennium: {WeekMillennium}");

            Console.WriteLine();

            decimal YearAttosecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Attosecond);
            Console.WriteLine($"{Value} Year -> Attosecond: {YearAttosecond}");

            decimal YearFemtosecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Year -> Femtosecond: {YearFemtosecond}");

            decimal YearPicosecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Picosecond);
            Console.WriteLine($"{Value} Year -> Picosecond: {YearPicosecond}");

            decimal YearNanosecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Year -> Nanosecond: {YearNanosecond}");

            decimal YearMicrosecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Microsecond);
            Console.WriteLine($"{Value} Year -> Microsecond: {YearMicrosecond}");

            decimal YearMillisecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Millisecond);
            Console.WriteLine($"{Value} Year -> Millisecond: {YearMillisecond}");

            decimal YearCentisecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Centisecond);
            Console.WriteLine($"{Value} Year -> Centisecond: {YearCentisecond}");

            decimal YearSecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Second);
            Console.WriteLine($"{Value} Year -> Second: {YearSecond}");

            decimal YearMinute = TimeExtension.Convert(Value, TimeType.Year, TimeType.Minute);
            Console.WriteLine($"{Value} Year -> Minute: {YearMinute}");

            decimal YearHour = TimeExtension.Convert(Value, TimeType.Year, TimeType.Hour);
            Console.WriteLine($"{Value} Year -> Hour: {YearHour}");

            decimal YearDay = TimeExtension.Convert(Value, TimeType.Year, TimeType.Day);
            Console.WriteLine($"{Value} Year -> Day: {YearDay}");

            decimal YearWeek = TimeExtension.Convert(Value, TimeType.Year, TimeType.Week);
            Console.WriteLine($"{Value} Year -> Week: {YearWeek}");

            decimal YearYear = TimeExtension.Convert(Value, TimeType.Year, TimeType.Year);
            Console.WriteLine($"{Value} Year -> Year: {YearYear}");

            decimal YearDecade = TimeExtension.Convert(Value, TimeType.Year, TimeType.Decade);
            Console.WriteLine($"{Value} Year -> Decade: {YearDecade}");

            decimal YearCentury = TimeExtension.Convert(Value, TimeType.Year, TimeType.Century);
            Console.WriteLine($"{Value} Year -> Century: {YearCentury}");

            decimal YearMillennium = TimeExtension.Convert(Value, TimeType.Year, TimeType.Millennium);
            Console.WriteLine($"{Value} Year -> Millennium: {YearMillennium}");

            Console.WriteLine();

            decimal DecadeAttosecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Attosecond);
            Console.WriteLine($"{Value} Decade -> Attosecond: {DecadeAttosecond}");

            decimal DecadeFemtosecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Decade -> Femtosecond: {DecadeFemtosecond}");

            decimal DecadePicosecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Picosecond);
            Console.WriteLine($"{Value} Decade -> Picosecond: {DecadePicosecond}");

            decimal DecadeNanosecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Decade -> Nanosecond: {DecadeNanosecond}");

            decimal DecadeMicrosecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Microsecond);
            Console.WriteLine($"{Value} Decade -> Microsecond: {DecadeMicrosecond}");

            decimal DecadeMillisecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Millisecond);
            Console.WriteLine($"{Value} Decade -> Millisecond: {DecadeMillisecond}");

            decimal DecadeCentisecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Centisecond);
            Console.WriteLine($"{Value} Decade -> Centisecond: {DecadeCentisecond}");

            decimal DecadeSecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Second);
            Console.WriteLine($"{Value} Decade -> Second: {DecadeSecond}");

            decimal DecadeMinute = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Minute);
            Console.WriteLine($"{Value} Decade -> Minute: {DecadeMinute}");

            decimal DecadeHour = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Hour);
            Console.WriteLine($"{Value} Decade -> Hour: {DecadeHour}");

            decimal DecadeDay = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Day);
            Console.WriteLine($"{Value} Decade -> Day: {DecadeDay}");

            decimal DecadeWeek = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Week);
            Console.WriteLine($"{Value} Decade -> Week: {DecadeWeek}");

            decimal DecadeYear = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Year);
            Console.WriteLine($"{Value} Decade -> Year: {DecadeYear}");

            decimal DecadeDecade = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Decade);
            Console.WriteLine($"{Value} Decade -> Decade: {DecadeDecade}");

            decimal DecadeCentury = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Century);
            Console.WriteLine($"{Value} Decade -> Century: {DecadeCentury}");

            decimal DecadeMillennium = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Millennium);
            Console.WriteLine($"{Value} Decade -> Millennium: {DecadeMillennium}");

            Console.WriteLine();

            decimal CenturyAttosecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Attosecond);
            Console.WriteLine($"{Value} Century -> Attosecond: {CenturyAttosecond}");

            decimal CenturyFemtosecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Century -> Femtosecond: {CenturyFemtosecond}");

            decimal CenturyPicosecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Picosecond);
            Console.WriteLine($"{Value} Century -> Picosecond: {CenturyPicosecond}");

            decimal CenturyNanosecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Century -> Nanosecond: {CenturyNanosecond}");

            decimal CenturyMicrosecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Microsecond);
            Console.WriteLine($"{Value} Century -> Microsecond: {CenturyMicrosecond}");

            decimal CenturyMillisecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Millisecond);
            Console.WriteLine($"{Value} Century -> Millisecond: {CenturyMillisecond}");

            decimal CenturyCentisecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Centisecond);
            Console.WriteLine($"{Value} Century -> Centisecond: {CenturyCentisecond}");

            decimal CenturySecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Second);
            Console.WriteLine($"{Value} Century -> Second: {CenturySecond}");

            decimal CenturyMinute = TimeExtension.Convert(Value, TimeType.Century, TimeType.Minute);
            Console.WriteLine($"{Value} Century -> Minute: {CenturyMinute}");

            decimal CenturyHour = TimeExtension.Convert(Value, TimeType.Century, TimeType.Hour);
            Console.WriteLine($"{Value} Century -> Hour: {CenturyHour}");

            decimal CenturyDay = TimeExtension.Convert(Value, TimeType.Century, TimeType.Day);
            Console.WriteLine($"{Value} Century -> Day: {CenturyDay}");

            decimal CenturyWeek = TimeExtension.Convert(Value, TimeType.Century, TimeType.Week);
            Console.WriteLine($"{Value} Century -> Week: {CenturyWeek}");

            decimal CenturyYear = TimeExtension.Convert(Value, TimeType.Century, TimeType.Year);
            Console.WriteLine($"{Value} Century -> Year: {CenturyYear}");

            decimal CenturyDecade = TimeExtension.Convert(Value, TimeType.Century, TimeType.Decade);
            Console.WriteLine($"{Value} Century -> Decade: {CenturyDecade}");

            decimal CenturyCentury = TimeExtension.Convert(Value, TimeType.Century, TimeType.Century);
            Console.WriteLine($"{Value} Century -> Century: {CenturyCentury}");

            decimal CenturyMillennium = TimeExtension.Convert(Value, TimeType.Century, TimeType.Millennium);
            Console.WriteLine($"{Value} Century -> Millennium: {CenturyMillennium}");

            Console.WriteLine();

            decimal MillenniumAttosecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Attosecond);
            Console.WriteLine($"{Value} Millennium -> Attosecond: {MillenniumAttosecond}");

            decimal MillenniumFemtosecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Millennium -> Femtosecond: {MillenniumFemtosecond}");

            decimal MillenniumPicosecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Picosecond);
            Console.WriteLine($"{Value} Millennium -> Picosecond: {MillenniumPicosecond}");

            decimal MillenniumNanosecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Millennium -> Nanosecond: {MillenniumNanosecond}");

            decimal MillenniumMicrosecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Microsecond);
            Console.WriteLine($"{Value} Millennium -> Microsecond: {MillenniumMicrosecond}");

            decimal MillenniumMillisecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Millisecond);
            Console.WriteLine($"{Value} Millennium -> Millisecond: {MillenniumMillisecond}");

            decimal MillenniumCentisecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Centisecond);
            Console.WriteLine($"{Value} Millennium -> Centisecond: {MillenniumCentisecond}");

            decimal MillenniumSecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Second);
            Console.WriteLine($"{Value} Millennium -> Second: {MillenniumSecond}");

            decimal MillenniumMinute = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Minute);
            Console.WriteLine($"{Value} Millennium -> Minute: {MillenniumMinute}");

            decimal MillenniumHour = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Hour);
            Console.WriteLine($"{Value} Millennium -> Hour: {MillenniumHour}");

            decimal MillenniumDay = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Day);
            Console.WriteLine($"{Value} Millennium -> Day: {MillenniumDay}");

            decimal MillenniumWeek = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Week);
            Console.WriteLine($"{Value} Millennium -> Week: {MillenniumWeek}");

            decimal MillenniumYear = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Year);
            Console.WriteLine($"{Value} Millennium -> Year: {MillenniumYear}");

            decimal MillenniumDecade = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Decade);
            Console.WriteLine($"{Value} Millennium -> Decade: {MillenniumDecade}");

            decimal MillenniumCentury = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Century);
            Console.WriteLine($"{Value} Millennium -> Century: {MillenniumCentury}");

            decimal MillenniumMillennium = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Millennium);
            Console.WriteLine($"{Value} Millennium -> Millennium: {MillenniumMillennium}");

            Console.ReadKey();
        }
    }
}