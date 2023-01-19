using Skylark.Enum;
using Skylark.Extension;
using Skylark.Struct;

namespace ConsoleDemoTime
{
    internal class Program
    {
        private const double Value = 1;
        private const double Value2 = 123456789;

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

            double AttosecondAttosecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Attosecond -> Attosecond: {AttosecondAttosecond}");

            double AttosecondFemtosecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Attosecond -> Femtosecond: {AttosecondFemtosecond}");

            double AttosecondPicosecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Attosecond -> Picosecond: {AttosecondPicosecond}");

            double AttosecondNanosecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Attosecond -> Nanosecond: {AttosecondNanosecond}");

            double AttosecondMicrosecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Attosecond -> Microsecond: {AttosecondMicrosecond}");

            double AttosecondMillisecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Attosecond -> Millisecond: {AttosecondMillisecond}");

            double AttosecondSecond = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Second);
            Console.WriteLine($"{Value} Attosecond -> Second: {AttosecondSecond}");

            double AttosecondMinute = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Minute);
            Console.WriteLine($"{Value} Attosecond -> Minute: {AttosecondMinute}");

            double AttosecondHour = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Hour);
            Console.WriteLine($"{Value} Attosecond -> Hour: {AttosecondHour}");

            double AttosecondDay = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Day);
            Console.WriteLine($"{Value} Attosecond -> Day: {AttosecondDay}");

            double AttosecondWeek = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Week);
            Console.WriteLine($"{Value} Attosecond -> Week: {AttosecondWeek}");

            double AttosecondYear = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Year);
            Console.WriteLine($"{Value} Attosecond -> Year: {AttosecondYear}");

            double AttosecondDecade = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Decade);
            Console.WriteLine($"{Value} Attosecond -> Decade: {AttosecondDecade}");

            double AttosecondCentury = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Century);
            Console.WriteLine($"{Value} Attosecond -> Century: {AttosecondCentury}");

            double AttosecondMillennium = TimeExtension.Convert(Value, TimeType.Attosecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Attosecond -> Millennium: {AttosecondMillennium}");

            Console.WriteLine();

            double FemtosecondAttosecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Femtosecond -> Attosecond: {FemtosecondAttosecond}");

            double FemtosecondFemtosecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Femtosecond -> Femtosecond: {FemtosecondFemtosecond}");

            double FemtosecondPicosecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Femtosecond -> Picosecond: {FemtosecondPicosecond}");

            double FemtosecondNanosecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Femtosecond -> Nanosecond: {FemtosecondNanosecond}");

            double FemtosecondMicrosecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Femtosecond -> Microsecond: {FemtosecondMicrosecond}");

            double FemtosecondMillisecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Femtosecond -> Millisecond: {FemtosecondMillisecond}");

            double FemtosecondSecond = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Second);
            Console.WriteLine($"{Value} Femtosecond -> Second: {FemtosecondSecond}");

            double FemtosecondMinute = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Minute);
            Console.WriteLine($"{Value} Femtosecond -> Minute: {FemtosecondMinute}");

            double FemtosecondHour = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Hour);
            Console.WriteLine($"{Value} Femtosecond -> Hour: {FemtosecondHour}");

            double FemtosecondDay = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Day);
            Console.WriteLine($"{Value} Femtosecond -> Day: {FemtosecondDay}");

            double FemtosecondWeek = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Week);
            Console.WriteLine($"{Value} Femtosecond -> Week: {FemtosecondWeek}");

            double FemtosecondYear = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Year);
            Console.WriteLine($"{Value} Femtosecond -> Year: {FemtosecondYear}");

            double FemtosecondDecade = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Decade);
            Console.WriteLine($"{Value} Femtosecond -> Decade: {FemtosecondDecade}");

            double FemtosecondCentury = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Century);
            Console.WriteLine($"{Value} Femtosecond -> Century: {FemtosecondCentury}");

            double FemtosecondMillennium = TimeExtension.Convert(Value, TimeType.Femtosecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Femtosecond -> Millennium: {FemtosecondMillennium}");

            Console.WriteLine();

            double PicosecondAttosecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Picosecond -> Attosecond: {PicosecondAttosecond}");

            double PicosecondFemtosecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Picosecond -> Femtosecond: {PicosecondFemtosecond}");

            double PicosecondPicosecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Picosecond -> Picosecond: {PicosecondPicosecond}");

            double PicosecondNanosecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Picosecond -> Nanosecond: {PicosecondNanosecond}");

            double PicosecondMicrosecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Picosecond -> Microsecond: {PicosecondMicrosecond}");

            double PicosecondMillisecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Picosecond -> Millisecond: {PicosecondMillisecond}");

            double PicosecondSecond = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Second);
            Console.WriteLine($"{Value} Picosecond -> Second: {PicosecondSecond}");

            double PicosecondMinute = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Minute);
            Console.WriteLine($"{Value} Picosecond -> Minute: {PicosecondMinute}");

            double PicosecondHour = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Hour);
            Console.WriteLine($"{Value} Picosecond -> Hour: {PicosecondHour}");

            double PicosecondDay = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Day);
            Console.WriteLine($"{Value} Picosecond -> Day: {PicosecondDay}");

            double PicosecondWeek = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Week);
            Console.WriteLine($"{Value} Picosecond -> Week: {PicosecondWeek}");

            double PicosecondYear = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Year);
            Console.WriteLine($"{Value} Picosecond -> Year: {PicosecondYear}");

            double PicosecondDecade = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Decade);
            Console.WriteLine($"{Value} Picosecond -> Decade: {PicosecondDecade}");

            double PicosecondCentury = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Century);
            Console.WriteLine($"{Value} Picosecond -> Century: {PicosecondCentury}");

            double PicosecondMillennium = TimeExtension.Convert(Value, TimeType.Picosecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Picosecond -> Millennium: {PicosecondMillennium}");

            Console.WriteLine();

            double NanosecondAttosecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Nanosecond -> Attosecond: {NanosecondAttosecond}");

            double NanosecondFemtosecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Nanosecond -> Femtosecond: {NanosecondFemtosecond}");

            double NanosecondPicosecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Nanosecond -> Picosecond: {NanosecondPicosecond}");

            double NanosecondNanosecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Nanosecond -> Nanosecond: {NanosecondNanosecond}");

            double NanosecondMicrosecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Nanosecond -> Microsecond: {NanosecondMicrosecond}");

            double NanosecondMillisecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Nanosecond -> Millisecond: {NanosecondMillisecond}");

            double NanosecondSecond = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Second);
            Console.WriteLine($"{Value} Nanosecond -> Second: {NanosecondSecond}");

            double NanosecondMinute = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Minute);
            Console.WriteLine($"{Value} Nanosecond -> Minute: {NanosecondMinute}");

            double NanosecondHour = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Hour);
            Console.WriteLine($"{Value} Nanosecond -> Hour: {NanosecondHour}");

            double NanosecondDay = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Day);
            Console.WriteLine($"{Value} Nanosecond -> Day: {NanosecondDay}");

            double NanosecondWeek = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Week);
            Console.WriteLine($"{Value} Nanosecond -> Week: {NanosecondWeek}");

            double NanosecondYear = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Year);
            Console.WriteLine($"{Value} Nanosecond -> Year: {NanosecondYear}");

            double NanosecondDecade = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Decade);
            Console.WriteLine($"{Value} Nanosecond -> Decade: {NanosecondDecade}");

            double NanosecondCentury = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Century);
            Console.WriteLine($"{Value} Nanosecond -> Century: {NanosecondCentury}");

            double NanosecondMillennium = TimeExtension.Convert(Value, TimeType.Nanosecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Nanosecond -> Millennium: {NanosecondMillennium}");

            Console.WriteLine();

            double MicrosecondAttosecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Microsecond -> Attosecond: {MicrosecondAttosecond}");

            double MicrosecondFemtosecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Microsecond -> Femtosecond: {MicrosecondFemtosecond}");

            double MicrosecondPicosecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Microsecond -> Picosecond: {MicrosecondPicosecond}");

            double MicrosecondNanosecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Microsecond -> Nanosecond: {MicrosecondNanosecond}");

            double MicrosecondMicrosecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Microsecond -> Microsecond: {MicrosecondMicrosecond}");

            double MicrosecondMillisecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Microsecond -> Millisecond: {MicrosecondMillisecond}");

            double MicrosecondSecond = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Second);
            Console.WriteLine($"{Value} Microsecond -> Second: {MicrosecondSecond}");

            double MicrosecondMinute = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Minute);
            Console.WriteLine($"{Value} Microsecond -> Minute: {MicrosecondMinute}");

            double MicrosecondHour = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Hour);
            Console.WriteLine($"{Value} Microsecond -> Hour: {MicrosecondHour}");

            double MicrosecondDay = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Day);
            Console.WriteLine($"{Value} Microsecond -> Day: {MicrosecondDay}");

            double MicrosecondWeek = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Week);
            Console.WriteLine($"{Value} Microsecond -> Week: {MicrosecondWeek}");

            double MicrosecondYear = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Year);
            Console.WriteLine($"{Value} Microsecond -> Year: {MicrosecondYear}");

            double MicrosecondDecade = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Decade);
            Console.WriteLine($"{Value} Microsecond -> Decade: {MicrosecondDecade}");

            double MicrosecondCentury = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Century);
            Console.WriteLine($"{Value} Microsecond -> Century: {MicrosecondCentury}");

            double MicrosecondMillennium = TimeExtension.Convert(Value, TimeType.Microsecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Microsecond -> Millennium: {MicrosecondMillennium}");

            Console.WriteLine();

            double MillisecondAttosecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Attosecond);
            Console.WriteLine($"{Value} Millisecond -> Attosecond: {MillisecondAttosecond}");

            double MillisecondFemtosecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Millisecond -> Femtosecond: {MillisecondFemtosecond}");

            double MillisecondPicosecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Picosecond);
            Console.WriteLine($"{Value} Millisecond -> Picosecond: {MillisecondPicosecond}");

            double MillisecondNanosecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Millisecond -> Nanosecond: {MillisecondNanosecond}");

            double MillisecondMicrosecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Microsecond);
            Console.WriteLine($"{Value} Millisecond -> Microsecond: {MillisecondMicrosecond}");

            double MillisecondMillisecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Millisecond);
            Console.WriteLine($"{Value} Millisecond -> Millisecond: {MillisecondMillisecond}");

            double MillisecondSecond = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Second);
            Console.WriteLine($"{Value} Millisecond -> Second: {MillisecondSecond}");

            double MillisecondMinute = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Minute);
            Console.WriteLine($"{Value} Millisecond -> Minute: {MillisecondMinute}");

            double MillisecondHour = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Hour);
            Console.WriteLine($"{Value} Millisecond -> Hour: {MillisecondHour}");

            double MillisecondDay = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Day);
            Console.WriteLine($"{Value} Millisecond -> Day: {MillisecondDay}");

            double MillisecondWeek = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Week);
            Console.WriteLine($"{Value} Millisecond -> Week: {MillisecondWeek}");

            double MillisecondYear = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Year);
            Console.WriteLine($"{Value} Millisecond -> Year: {MillisecondYear}");

            double MillisecondDecade = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Decade);
            Console.WriteLine($"{Value} Millisecond -> Decade: {MillisecondDecade}");

            double MillisecondCentury = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Century);
            Console.WriteLine($"{Value} Millisecond -> Century: {MillisecondCentury}");

            double MillisecondMillennium = TimeExtension.Convert(Value, TimeType.Millisecond, TimeType.Millennium);
            Console.WriteLine($"{Value} Millisecond -> Millennium: {MillisecondMillennium}");

            Console.WriteLine();

            double SecondAttosecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Attosecond);
            Console.WriteLine($"{Value} Second -> Attosecond: {SecondAttosecond}");

            double SecondFemtosecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Second -> Femtosecond: {SecondFemtosecond}");

            double SecondPicosecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Picosecond);
            Console.WriteLine($"{Value} Second -> Picosecond: {SecondPicosecond}");

            double SecondNanosecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Second -> Nanosecond: {SecondNanosecond}");

            double SecondMicrosecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Microsecond);
            Console.WriteLine($"{Value} Second -> Microsecond: {SecondMicrosecond}");

            double SecondMillisecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Millisecond);
            Console.WriteLine($"{Value} Second -> Millisecond: {SecondMillisecond}");

            double SecondSecond = TimeExtension.Convert(Value, TimeType.Second, TimeType.Second);
            Console.WriteLine($"{Value} Second -> Second: {SecondSecond}");

            double SecondMinute = TimeExtension.Convert(Value, TimeType.Second, TimeType.Minute);
            Console.WriteLine($"{Value} Second -> Minute: {SecondMinute}");

            double SecondHour = TimeExtension.Convert(Value, TimeType.Second, TimeType.Hour);
            Console.WriteLine($"{Value} Second -> Hour: {SecondHour}");

            double SecondDay = TimeExtension.Convert(Value, TimeType.Second, TimeType.Day);
            Console.WriteLine($"{Value} Second -> Day: {SecondDay}");

            double SecondWeek = TimeExtension.Convert(Value, TimeType.Second, TimeType.Week);
            Console.WriteLine($"{Value} Second -> Week: {SecondWeek}");

            double SecondYear = TimeExtension.Convert(Value, TimeType.Second, TimeType.Year);
            Console.WriteLine($"{Value} Second -> Year: {SecondYear}");

            double SecondDecade = TimeExtension.Convert(Value, TimeType.Second, TimeType.Decade);
            Console.WriteLine($"{Value} Second -> Decade: {SecondDecade}");

            double SecondCentury = TimeExtension.Convert(Value, TimeType.Second, TimeType.Century);
            Console.WriteLine($"{Value} Second -> Century: {SecondCentury}");

            double SecondMillennium = TimeExtension.Convert(Value, TimeType.Second, TimeType.Millennium);
            Console.WriteLine($"{Value} Second -> Millennium: {SecondMillennium}");

            Console.WriteLine();

            double MinuteAttosecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Attosecond);
            Console.WriteLine($"{Value} Minute -> Attosecond: {MinuteAttosecond}");

            double MinuteFemtosecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Minute -> Femtosecond: {MinuteFemtosecond}");

            double MinutePicosecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Picosecond);
            Console.WriteLine($"{Value} Minute -> Picosecond: {MinutePicosecond}");

            double MinuteNanosecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Minute -> Nanosecond: {MinuteNanosecond}");

            double MinuteMicrosecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Microsecond);
            Console.WriteLine($"{Value} Minute -> Microsecond: {MinuteMicrosecond}");

            double MinuteMillisecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Millisecond);
            Console.WriteLine($"{Value} Minute -> Millisecond: {MinuteMillisecond}");

            double MinuteSecond = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Second);
            Console.WriteLine($"{Value} Minute -> Second: {MinuteSecond}");

            double MinuteMinute = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Minute);
            Console.WriteLine($"{Value} Minute -> Minute: {MinuteMinute}");

            double MinuteHour = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Hour);
            Console.WriteLine($"{Value} Minute -> Hour: {MinuteHour}");

            double MinuteDay = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Day);
            Console.WriteLine($"{Value} Minute -> Day: {MinuteDay}");

            double MinuteWeek = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Week);
            Console.WriteLine($"{Value} Minute -> Week: {MinuteWeek}");

            double MinuteYear = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Year);
            Console.WriteLine($"{Value} Minute -> Year: {MinuteYear}");

            double MinuteDecade = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Decade);
            Console.WriteLine($"{Value} Minute -> Decade: {MinuteDecade}");

            double MinuteCentury = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Century);
            Console.WriteLine($"{Value} Minute -> Century: {MinuteCentury}");

            double MinuteMillennium = TimeExtension.Convert(Value, TimeType.Minute, TimeType.Millennium);
            Console.WriteLine($"{Value} Minute -> Millennium: {MinuteMillennium}");

            Console.WriteLine();

            double HourAttosecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Attosecond);
            Console.WriteLine($"{Value} Hour -> Attosecond: {HourAttosecond}");

            double HourFemtosecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Hour -> Femtosecond: {HourFemtosecond}");

            double HourPicosecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Picosecond);
            Console.WriteLine($"{Value} Hour -> Picosecond: {HourPicosecond}");

            double HourNanosecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Hour -> Nanosecond: {HourNanosecond}");

            double HourMicrosecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Microsecond);
            Console.WriteLine($"{Value} Hour -> Microsecond: {HourMicrosecond}");

            double HourMillisecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Millisecond);
            Console.WriteLine($"{Value} Hour -> Millisecond: {HourMillisecond}");

            double HourSecond = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Second);
            Console.WriteLine($"{Value} Hour -> Second: {HourSecond}");

            double HourMinute = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Minute);
            Console.WriteLine($"{Value} Hour -> Minute: {HourMinute}");

            double HourHour = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Hour);
            Console.WriteLine($"{Value} Hour -> Hour: {HourHour}");

            double HourDay = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Day);
            Console.WriteLine($"{Value} Hour -> Day: {HourDay}");

            double HourWeek = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Week);
            Console.WriteLine($"{Value} Hour -> Week: {HourWeek}");

            double HourYear = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Year);
            Console.WriteLine($"{Value} Hour -> Year: {HourYear}");

            double HourDecade = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Decade);
            Console.WriteLine($"{Value} Hour -> Decade: {HourDecade}");

            double HourCentury = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Century);
            Console.WriteLine($"{Value} Hour -> Century: {HourCentury}");

            double HourMillennium = TimeExtension.Convert(Value, TimeType.Hour, TimeType.Millennium);
            Console.WriteLine($"{Value} Hour -> Millennium: {HourMillennium}");

            Console.WriteLine();

            double DayAttosecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Attosecond);
            Console.WriteLine($"{Value} Day -> Attosecond: {DayAttosecond}");

            double DayFemtosecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Day -> Femtosecond: {DayFemtosecond}");

            double DayPicosecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Picosecond);
            Console.WriteLine($"{Value} Day -> Picosecond: {DayPicosecond}");

            double DayNanosecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Day -> Nanosecond: {DayNanosecond}");

            double DayMicrosecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Microsecond);
            Console.WriteLine($"{Value} Day -> Microsecond: {DayMicrosecond}");

            double DayMillisecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Millisecond);
            Console.WriteLine($"{Value} Day -> Millisecond: {DayMillisecond}");

            double DaySecond = TimeExtension.Convert(Value, TimeType.Day, TimeType.Second);
            Console.WriteLine($"{Value} Day -> Second: {DaySecond}");

            double DayMinute = TimeExtension.Convert(Value, TimeType.Day, TimeType.Minute);
            Console.WriteLine($"{Value} Day -> Minute: {DayMinute}");

            double DayHour = TimeExtension.Convert(Value, TimeType.Day, TimeType.Hour);
            Console.WriteLine($"{Value} Day -> Hour: {DayHour}");

            double DayDay = TimeExtension.Convert(Value, TimeType.Day, TimeType.Day);
            Console.WriteLine($"{Value} Day -> Day: {DayDay}");

            double DayWeek = TimeExtension.Convert(Value, TimeType.Day, TimeType.Week);
            Console.WriteLine($"{Value} Day -> Week: {DayWeek}");

            double DayYear = TimeExtension.Convert(Value, TimeType.Day, TimeType.Year);
            Console.WriteLine($"{Value} Day -> Year: {DayYear}");

            double DayDecade = TimeExtension.Convert(Value, TimeType.Day, TimeType.Decade);
            Console.WriteLine($"{Value} Day -> Decade: {DayDecade}");

            double DayCentury = TimeExtension.Convert(Value, TimeType.Day, TimeType.Century);
            Console.WriteLine($"{Value} Day -> Century: {DayCentury}");

            double DayMillennium = TimeExtension.Convert(Value, TimeType.Day, TimeType.Millennium);
            Console.WriteLine($"{Value} Day -> Millennium: {DayMillennium}");

            Console.WriteLine();

            double WeekAttosecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Attosecond);
            Console.WriteLine($"{Value} Week -> Attosecond: {WeekAttosecond}");

            double WeekFemtosecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Week -> Femtosecond: {WeekFemtosecond}");

            double WeekPicosecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Picosecond);
            Console.WriteLine($"{Value} Week -> Picosecond: {WeekPicosecond}");

            double WeekNanosecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Week -> Nanosecond: {WeekNanosecond}");

            double WeekMicrosecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Microsecond);
            Console.WriteLine($"{Value} Week -> Microsecond: {WeekMicrosecond}");

            double WeekMillisecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Millisecond);
            Console.WriteLine($"{Value} Week -> Millisecond: {WeekMillisecond}");

            double WeekSecond = TimeExtension.Convert(Value, TimeType.Week, TimeType.Second);
            Console.WriteLine($"{Value} Week -> Second: {WeekSecond}");

            double WeekMinute = TimeExtension.Convert(Value, TimeType.Week, TimeType.Minute);
            Console.WriteLine($"{Value} Week -> Minute: {WeekMinute}");

            double WeekHour = TimeExtension.Convert(Value, TimeType.Week, TimeType.Hour);
            Console.WriteLine($"{Value} Week -> Hour: {WeekHour}");

            double WeekDay = TimeExtension.Convert(Value, TimeType.Week, TimeType.Day);
            Console.WriteLine($"{Value} Week -> Day: {WeekDay}");

            double WeekWeek = TimeExtension.Convert(Value, TimeType.Week, TimeType.Week);
            Console.WriteLine($"{Value} Week -> Week: {WeekWeek}");

            double WeekYear = TimeExtension.Convert(Value, TimeType.Week, TimeType.Year);
            Console.WriteLine($"{Value} Week -> Year: {WeekYear}");

            double WeekDecade = TimeExtension.Convert(Value, TimeType.Week, TimeType.Decade);
            Console.WriteLine($"{Value} Week -> Decade: {WeekDecade}");

            double WeekCentury = TimeExtension.Convert(Value, TimeType.Week, TimeType.Century);
            Console.WriteLine($"{Value} Week -> Century: {WeekCentury}");

            double WeekMillennium = TimeExtension.Convert(Value, TimeType.Week, TimeType.Millennium);
            Console.WriteLine($"{Value} Week -> Millennium: {WeekMillennium}");

            Console.WriteLine();

            double YearAttosecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Attosecond);
            Console.WriteLine($"{Value} Year -> Attosecond: {YearAttosecond}");

            double YearFemtosecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Year -> Femtosecond: {YearFemtosecond}");

            double YearPicosecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Picosecond);
            Console.WriteLine($"{Value} Year -> Picosecond: {YearPicosecond}");

            double YearNanosecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Year -> Nanosecond: {YearNanosecond}");

            double YearMicrosecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Microsecond);
            Console.WriteLine($"{Value} Year -> Microsecond: {YearMicrosecond}");

            double YearMillisecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Millisecond);
            Console.WriteLine($"{Value} Year -> Millisecond: {YearMillisecond}");

            double YearSecond = TimeExtension.Convert(Value, TimeType.Year, TimeType.Second);
            Console.WriteLine($"{Value} Year -> Second: {YearSecond}");

            double YearMinute = TimeExtension.Convert(Value, TimeType.Year, TimeType.Minute);
            Console.WriteLine($"{Value} Year -> Minute: {YearMinute}");

            double YearHour = TimeExtension.Convert(Value, TimeType.Year, TimeType.Hour);
            Console.WriteLine($"{Value} Year -> Hour: {YearHour}");

            double YearDay = TimeExtension.Convert(Value, TimeType.Year, TimeType.Day);
            Console.WriteLine($"{Value} Year -> Day: {YearDay}");

            double YearWeek = TimeExtension.Convert(Value, TimeType.Year, TimeType.Week);
            Console.WriteLine($"{Value} Year -> Week: {YearWeek}");

            double YearYear = TimeExtension.Convert(Value, TimeType.Year, TimeType.Year);
            Console.WriteLine($"{Value} Year -> Year: {YearYear}");

            double YearDecade = TimeExtension.Convert(Value, TimeType.Year, TimeType.Decade);
            Console.WriteLine($"{Value} Year -> Decade: {YearDecade}");

            double YearCentury = TimeExtension.Convert(Value, TimeType.Year, TimeType.Century);
            Console.WriteLine($"{Value} Year -> Century: {YearCentury}");

            double YearMillennium = TimeExtension.Convert(Value, TimeType.Year, TimeType.Millennium);
            Console.WriteLine($"{Value} Year -> Millennium: {YearMillennium}");

            Console.WriteLine();

            double DecadeAttosecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Attosecond);
            Console.WriteLine($"{Value} Decade -> Attosecond: {DecadeAttosecond}");

            double DecadeFemtosecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Decade -> Femtosecond: {DecadeFemtosecond}");

            double DecadePicosecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Picosecond);
            Console.WriteLine($"{Value} Decade -> Picosecond: {DecadePicosecond}");

            double DecadeNanosecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Decade -> Nanosecond: {DecadeNanosecond}");

            double DecadeMicrosecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Microsecond);
            Console.WriteLine($"{Value} Decade -> Microsecond: {DecadeMicrosecond}");

            double DecadeMillisecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Millisecond);
            Console.WriteLine($"{Value} Decade -> Millisecond: {DecadeMillisecond}");

            double DecadeSecond = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Second);
            Console.WriteLine($"{Value} Decade -> Second: {DecadeSecond}");

            double DecadeMinute = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Minute);
            Console.WriteLine($"{Value} Decade -> Minute: {DecadeMinute}");

            double DecadeHour = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Hour);
            Console.WriteLine($"{Value} Decade -> Hour: {DecadeHour}");

            double DecadeDay = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Day);
            Console.WriteLine($"{Value} Decade -> Day: {DecadeDay}");

            double DecadeWeek = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Week);
            Console.WriteLine($"{Value} Decade -> Week: {DecadeWeek}");

            double DecadeYear = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Year);
            Console.WriteLine($"{Value} Decade -> Year: {DecadeYear}");

            double DecadeDecade = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Decade);
            Console.WriteLine($"{Value} Decade -> Decade: {DecadeDecade}");

            double DecadeCentury = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Century);
            Console.WriteLine($"{Value} Decade -> Century: {DecadeCentury}");

            double DecadeMillennium = TimeExtension.Convert(Value, TimeType.Decade, TimeType.Millennium);
            Console.WriteLine($"{Value} Decade -> Millennium: {DecadeMillennium}");

            Console.WriteLine();

            double CenturyAttosecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Attosecond);
            Console.WriteLine($"{Value} Century -> Attosecond: {CenturyAttosecond}");

            double CenturyFemtosecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Century -> Femtosecond: {CenturyFemtosecond}");

            double CenturyPicosecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Picosecond);
            Console.WriteLine($"{Value} Century -> Picosecond: {CenturyPicosecond}");

            double CenturyNanosecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Century -> Nanosecond: {CenturyNanosecond}");

            double CenturyMicrosecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Microsecond);
            Console.WriteLine($"{Value} Century -> Microsecond: {CenturyMicrosecond}");

            double CenturyMillisecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Millisecond);
            Console.WriteLine($"{Value} Century -> Millisecond: {CenturyMillisecond}");

            double CenturySecond = TimeExtension.Convert(Value, TimeType.Century, TimeType.Second);
            Console.WriteLine($"{Value} Century -> Second: {CenturySecond}");

            double CenturyMinute = TimeExtension.Convert(Value, TimeType.Century, TimeType.Minute);
            Console.WriteLine($"{Value} Century -> Minute: {CenturyMinute}");

            double CenturyHour = TimeExtension.Convert(Value, TimeType.Century, TimeType.Hour);
            Console.WriteLine($"{Value} Century -> Hour: {CenturyHour}");

            double CenturyDay = TimeExtension.Convert(Value, TimeType.Century, TimeType.Day);
            Console.WriteLine($"{Value} Century -> Day: {CenturyDay}");

            double CenturyWeek = TimeExtension.Convert(Value, TimeType.Century, TimeType.Week);
            Console.WriteLine($"{Value} Century -> Week: {CenturyWeek}");

            double CenturyYear = TimeExtension.Convert(Value, TimeType.Century, TimeType.Year);
            Console.WriteLine($"{Value} Century -> Year: {CenturyYear}");

            double CenturyDecade = TimeExtension.Convert(Value, TimeType.Century, TimeType.Decade);
            Console.WriteLine($"{Value} Century -> Decade: {CenturyDecade}");

            double CenturyCentury = TimeExtension.Convert(Value, TimeType.Century, TimeType.Century);
            Console.WriteLine($"{Value} Century -> Century: {CenturyCentury}");

            double CenturyMillennium = TimeExtension.Convert(Value, TimeType.Century, TimeType.Millennium);
            Console.WriteLine($"{Value} Century -> Millennium: {CenturyMillennium}");

            Console.WriteLine();

            double MillenniumAttosecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Attosecond);
            Console.WriteLine($"{Value} Millennium -> Attosecond: {MillenniumAttosecond}");

            double MillenniumFemtosecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Femtosecond);
            Console.WriteLine($"{Value} Millennium -> Femtosecond: {MillenniumFemtosecond}");

            double MillenniumPicosecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Picosecond);
            Console.WriteLine($"{Value} Millennium -> Picosecond: {MillenniumPicosecond}");

            double MillenniumNanosecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Nanosecond);
            Console.WriteLine($"{Value} Millennium -> Nanosecond: {MillenniumNanosecond}");

            double MillenniumMicrosecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Microsecond);
            Console.WriteLine($"{Value} Millennium -> Microsecond: {MillenniumMicrosecond}");

            double MillenniumMillisecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Millisecond);
            Console.WriteLine($"{Value} Millennium -> Millisecond: {MillenniumMillisecond}");

            double MillenniumSecond = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Second);
            Console.WriteLine($"{Value} Millennium -> Second: {MillenniumSecond}");

            double MillenniumMinute = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Minute);
            Console.WriteLine($"{Value} Millennium -> Minute: {MillenniumMinute}");

            double MillenniumHour = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Hour);
            Console.WriteLine($"{Value} Millennium -> Hour: {MillenniumHour}");

            double MillenniumDay = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Day);
            Console.WriteLine($"{Value} Millennium -> Day: {MillenniumDay}");

            double MillenniumWeek = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Week);
            Console.WriteLine($"{Value} Millennium -> Week: {MillenniumWeek}");

            double MillenniumYear = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Year);
            Console.WriteLine($"{Value} Millennium -> Year: {MillenniumYear}");

            double MillenniumDecade = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Decade);
            Console.WriteLine($"{Value} Millennium -> Decade: {MillenniumDecade}");

            double MillenniumCentury = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Century);
            Console.WriteLine($"{Value} Millennium -> Century: {MillenniumCentury}");

            double MillenniumMillennium = TimeExtension.Convert(Value, TimeType.Millennium, TimeType.Millennium);
            Console.WriteLine($"{Value} Millennium -> Millennium: {MillenniumMillennium}");

            Console.ReadKey();
        }
    }
}