using SETT = Skylark.Enum.TimeType;
using SSTTS = Skylark.Struct.Time.TimeStruct;

namespace Skylark.Standard.Manage.Time
{
    /// <summary>
    /// 
    /// </summary>
    internal static class TimeManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const bool Type = true;

        /// <summary>
        /// 
        /// </summary>
        public const double Value = 10;

        /// <summary>
        /// 
        /// </summary>
        public const SETT InputType = SETT.Attosecond;
        /// <summary>
        /// 
        /// </summary>
        public const SETT OutputType = SETT.Femtosecond;

        /// <summary>
        /// 
        /// </summary>
        public const string DefaultInput = "Attosecond";
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultOutput = "Femtosecond";

        /// <summary>
        /// 
        /// </summary>
        public const string Error = "The input type is incorrect.";

        /// <summary>
        /// 
        /// </summary>
        public static readonly SSTTS Result = new()
        {
            Value = Value,
            Type = InputType,
            Text = DefaultInput
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<SETT, Dictionary<SETT, double>> Converter = new()
        {
            {
                SETT.Attosecond, new()
                {
                    { SETT.Attosecond, 1d },
                    { SETT.Femtosecond, 0.001d },
                    { SETT.Picosecond, 1.0E-6 },
                    { SETT.Nanosecond, 1.0E-9 },
                    { SETT.Microsecond, 1.0E-12 },
                    { SETT.Millisecond, 1.0E-15 },
                    { SETT.Second, 1.0E-18 },
                    { SETT.Minute, 1.6666666666667E-20 },
                    { SETT.Hour, 2.7777777777778E-22 },
                    { SETT.Day, 1.1574074074074E-23 },
                    { SETT.Week, 1.6534391534392E-24 },
                    { SETT.Year, 3.1688087814029E-26 },
                    { SETT.Decade, 3.1688087814029E-27 },
                    { SETT.Century, 3.1688087814029E-28 },
                    { SETT.Millennium, 3.1688087814029E-29 }
                }
            },
            {
                SETT.Femtosecond, new()
                {
                    { SETT.Attosecond, 1000d },
                    { SETT.Femtosecond, 1d },
                    { SETT.Picosecond, 0.001d },
                    { SETT.Nanosecond, 1.0E-6 },
                    { SETT.Microsecond, 1.0E-9 },
                    { SETT.Millisecond, 1.0E-12 },
                    { SETT.Second, 1.0E-15 },
                    { SETT.Minute, 1.6666666666667E-17 },
                    { SETT.Hour, 2.7777777777778E-19 },
                    { SETT.Day, 1.1574074074074E-20 },
                    { SETT.Week, 1.6534391534392E-21 },
                    { SETT.Year, 3.1688087814029E-23 },
                    { SETT.Decade, 3.1688087814029E-24 },
                    { SETT.Century, 3.1688087814029E-25 },
                    { SETT.Millennium, 3.1688087814029E-26 }
                }
            },
            {
                SETT.Picosecond, new()
                {
                    { SETT.Attosecond, 1000000d },
                    { SETT.Femtosecond, 1000d },
                    { SETT.Picosecond, 1d },
                    { SETT.Nanosecond, 0.001d },
                    { SETT.Microsecond, 1.0E-6 },
                    { SETT.Millisecond, 1.0E-9 },
                    { SETT.Second, 1.0E-12 },
                    { SETT.Minute, 1.6666666666667E-14 },
                    { SETT.Hour, 2.7777777777778E-16 },
                    { SETT.Day, 1.1574074074074E-17 },
                    { SETT.Week, 1.6534391534392E-18 },
                    { SETT.Year, 3.1688087814029E-20 },
                    { SETT.Decade, 3.1688087814029E-21 },
                    { SETT.Century, 3.1688087814029E-22 },
                    { SETT.Millennium, 3.1688087814029E-23 }
                }
            },
            {
                SETT.Nanosecond, new()
                {
                    { SETT.Attosecond, 1000000000d },
                    { SETT.Femtosecond, 1000000d },
                    { SETT.Picosecond, 1000d },
                    { SETT.Nanosecond, 1d },
                    { SETT.Microsecond, 0.001d },
                    { SETT.Millisecond, 1.0E-6 },
                    { SETT.Second, 1.0E-9 },
                    { SETT.Minute, 1.6666666666667E-11 },
                    { SETT.Hour, 2.7777777777778E-13 },
                    { SETT.Day, 1.1574074074074E-14 },
                    { SETT.Week, 1.6534391534392E-15 },
                    { SETT.Year, 3.1688087814029E-17 },
                    { SETT.Decade, 3.1688087814029E-18 },
                    { SETT.Century, 3.1688087814029E-19 },
                    { SETT.Millennium, 3.1688087814029E-20 }
                }
            },
            {
                SETT.Microsecond, new()
                {
                    { SETT.Attosecond, 1000000000000d },
                    { SETT.Femtosecond, 1000000000d },
                    { SETT.Picosecond, 1000000d },
                    { SETT.Nanosecond, 1000d },
                    { SETT.Microsecond, 1d },
                    { SETT.Millisecond, 0.001d },
                    { SETT.Second, 1.0E-6 },
                    { SETT.Minute, 1.6666666666667E-8 },
                    { SETT.Hour, 2.7777777777778E-10 },
                    { SETT.Day, 1.1574074074074E-11 },
                    { SETT.Week, 1.6534391534392E-12 },
                    { SETT.Year, 3.1688087814029E-14 },
                    { SETT.Decade, 3.1688087814029E-15 },
                    { SETT.Century, 3.1688087814029E-16 },
                    { SETT.Millennium, 3.1688087814029E-17 }
                }
            },
            {
                SETT.Millisecond, new()
                {
                    { SETT.Attosecond, 1.0E+15 },
                    { SETT.Femtosecond, 1000000000000d },
                    { SETT.Picosecond, 1000000000d },
                    { SETT.Nanosecond, 1000000d },
                    { SETT.Microsecond, 1000d },
                    { SETT.Millisecond, 1d },
                    { SETT.Second, 0.001d },
                    { SETT.Minute, 1.66667E-5 },
                    { SETT.Hour, 2.7777777777778E-7 },
                    { SETT.Day, 1.1574074074074E-8 },
                    { SETT.Week, 1.6534391534392E-9 },
                    { SETT.Year, 3.1688087814029E-11 },
                    { SETT.Decade, 3.1688087814029E-12 },
                    { SETT.Century, 3.1688087814029E-13 },
                    { SETT.Millennium, 3.1688087814029E-14 }
                }
            },
            {
                SETT.Second, new()
                {
                    { SETT.Attosecond, 1.0E+18 },
                    { SETT.Femtosecond, 1.0E+15 },
                    { SETT.Picosecond, 1000000000000d },
                    { SETT.Nanosecond, 1000000000d },
                    { SETT.Microsecond, 1000000d },
                    { SETT.Millisecond, 1000d },
                    { SETT.Second, 1d },
                    { SETT.Minute, 0.0166666667d },
                    { SETT.Hour, 0.0002777778d },
                    { SETT.Day, 1.15741E-5 },
                    { SETT.Week, 1.6534391534392E-6 },
                    { SETT.Year, 3.1688087814029E-8 },
                    { SETT.Decade, 3.1688087814029E-9 },
                    { SETT.Century, 3.1688087814029E-10 },
                    { SETT.Millennium, 3.1688087814029E-11 }
                }
            },
            {
                SETT.Minute, new()
                {
                    { SETT.Attosecond, 6.0E+19 },
                    { SETT.Femtosecond, 6.0E+16 },
                    { SETT.Picosecond, 60000000000000d },
                    { SETT.Nanosecond, 60000000000d },
                    { SETT.Microsecond, 60000000d },
                    { SETT.Millisecond, 60000d },
                    { SETT.Second, 60d },
                    { SETT.Minute, 1d },
                    { SETT.Hour, 0.0166666667d },
                    { SETT.Day, 0.0006944444d },
                    { SETT.Week, 9.92063E-5 },
                    { SETT.Year, 1.9012852688417E-6 },
                    { SETT.Decade, 1.9012852688417E-7 },
                    { SETT.Century, 1.9012852688417E-8 },
                    { SETT.Millennium, 1.9012852688417E-9 }
                }
            },
            {
                SETT.Hour, new()
                {
                    { SETT.Attosecond, 3.6E+21 },
                    { SETT.Femtosecond, 3.6E+18 },
                    { SETT.Picosecond, 3.6E+15 },
                    { SETT.Nanosecond, 3600000000000d },
                    { SETT.Microsecond, 3600000000d },
                    { SETT.Millisecond, 3600000d },
                    { SETT.Second, 3600d },
                    { SETT.Minute, 60d },
                    { SETT.Hour, 1d },
                    { SETT.Day, 0.0416666667d },
                    { SETT.Week, 0.005952381d },
                    { SETT.Year, 0.0001140771d },
                    { SETT.Decade, 1.14077E-5 },
                    { SETT.Century, 1.140771161305E-6 },
                    { SETT.Millennium, 1.140771161305E-7 }
                }
            },
            {
                SETT.Day, new()
                {
                    { SETT.Attosecond, 8.64E+22 },
                    { SETT.Femtosecond, 8.64E+19 },
                    { SETT.Picosecond, 8.64E+16 },
                    { SETT.Nanosecond, 86400000000000d },
                    { SETT.Microsecond, 86400000000d },
                    { SETT.Millisecond, 86400000d },
                    { SETT.Second, 86400d },
                    { SETT.Minute, 1440d },
                    { SETT.Hour, 24d },
                    { SETT.Day, 1d },
                    { SETT.Week, 0.1428571429d },
                    { SETT.Year, 0.0027378508d },
                    { SETT.Decade, 0.0002737851d },
                    { SETT.Century, 2.73785E-5 },
                    { SETT.Millennium, 2.7378507871321E-6 }
                }
            },
            {
                SETT.Week, new()
                {
                    { SETT.Attosecond, 6.048E+23 },
                    { SETT.Femtosecond, 6.048E+20 },
                    { SETT.Picosecond, 6.048E+17 },
                    { SETT.Nanosecond, 6.048E+14 },
                    { SETT.Microsecond, 604800000000d },
                    { SETT.Millisecond, 604800000d },
                    { SETT.Second, 604800d },
                    { SETT.Minute, 10080d },
                    { SETT.Hour, 168d },
                    { SETT.Day, 7d },
                    { SETT.Week, 1d },
                    { SETT.Year, 0.0191649555d },
                    { SETT.Decade, 0.0019164956d },
                    { SETT.Century, 0.0001916496d },
                    { SETT.Millennium, 1.9165E-5 }
                }
            },
            {
                SETT.Year, new()
                {
                    { SETT.Attosecond, 3.15576E+25 },
                    { SETT.Femtosecond, 3.15576E+22 },
                    { SETT.Picosecond, 3.15576E+19 },
                    { SETT.Nanosecond, 3.15576E+16 },
                    { SETT.Microsecond, 31557600000000d },
                    { SETT.Millisecond, 31557600000d },
                    { SETT.Second, 31557600d },
                    { SETT.Minute, 525960d },
                    { SETT.Hour, 8766d },
                    { SETT.Day, 365.25d },
                    { SETT.Week, 52.1785714286d },
                    { SETT.Year, 1d },
                    { SETT.Decade, 0.1d },
                    { SETT.Century, 0.01d },
                    { SETT.Millennium, 0.001d }
                }
            },
            {
                SETT.Decade, new()
                {
                    { SETT.Attosecond, 3.15576E+26 },
                    { SETT.Femtosecond, 3.15576E+23 },
                    { SETT.Picosecond, 3.15576E+20 },
                    { SETT.Nanosecond, 3.15576E+17 },
                    { SETT.Microsecond, 3.15576E+14 },
                    { SETT.Millisecond, 315576000000d },
                    { SETT.Second, 315576000d },
                    { SETT.Minute, 5259600d },
                    { SETT.Hour, 87660d },
                    { SETT.Day, 3652.5d },
                    { SETT.Week, 521.7857142857d },
                    { SETT.Year, 10d },
                    { SETT.Decade, 1d },
                    { SETT.Century, 0.1d },
                    { SETT.Millennium, 0.01d }
                }
            },
            {
                SETT.Century, new()
                {
                    { SETT.Attosecond, 3.15576E+27 },
                    { SETT.Femtosecond, 3.15576E+24 },
                    { SETT.Picosecond, 3.15576E+21 },
                    { SETT.Nanosecond, 3.15576E+18 },
                    { SETT.Microsecond, 3.15576E+15 },
                    { SETT.Millisecond, 3155760000000d },
                    { SETT.Second, 3155760000d },
                    { SETT.Minute, 52596000d },
                    { SETT.Hour, 876600d },
                    { SETT.Day, 36525d },
                    { SETT.Week, 5217.8571428571d },
                    { SETT.Year, 100d },
                    { SETT.Decade, 10d },
                    { SETT.Century, 1d },
                    { SETT.Millennium, 0.1d }
                }
            },
            {
                SETT.Millennium, new()
                {
                    { SETT.Attosecond, 3.15576E+28 },
                    { SETT.Femtosecond, 3.15576E+25 },
                    { SETT.Picosecond, 3.15576E+22 },
                    { SETT.Nanosecond, 3.15576E+19 },
                    { SETT.Microsecond, 3.15576E+16 },
                    { SETT.Millisecond, 31557600000000d },
                    { SETT.Second, 31557600000d },
                    { SETT.Minute, 525960000d },
                    { SETT.Hour, 8766000d },
                    { SETT.Day, 365250d },
                    { SETT.Week, 52178.571428571d },
                    { SETT.Year, 1000d },
                    { SETT.Decade, 100d },
                    { SETT.Century, 10d },
                    { SETT.Millennium, 1d }
                }
            }
        };
    }
}