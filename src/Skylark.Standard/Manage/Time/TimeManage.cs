using ETT = Skylark.Enum.TimeType;
using STTS = Skylark.Struct.Time.TimeStruct;

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
        public const ETT InputType = ETT.Attosecond;
        /// <summary>
        /// 
        /// </summary>
        public const ETT OutputType = ETT.Femtosecond;

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
        public static readonly STTS Result = new()
        {
            Value = Value,
            Type = InputType,
            Text = DefaultInput
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<ETT, Dictionary<ETT, double>> Converter = new()
        {
            {
                ETT.Attosecond, new()
                {
                    { ETT.Attosecond, 1d },
                    { ETT.Femtosecond, 0.001d },
                    { ETT.Picosecond, 1.0E-6 },
                    { ETT.Nanosecond, 1.0E-9 },
                    { ETT.Microsecond, 1.0E-12 },
                    { ETT.Millisecond, 1.0E-15 },
                    { ETT.Second, 1.0E-18 },
                    { ETT.Minute, 1.6666666666667E-20 },
                    { ETT.Hour, 2.7777777777778E-22 },
                    { ETT.Day, 1.1574074074074E-23 },
                    { ETT.Week, 1.6534391534392E-24 },
                    { ETT.Year, 3.1688087814029E-26 },
                    { ETT.Decade, 3.1688087814029E-27 },
                    { ETT.Century, 3.1688087814029E-28 },
                    { ETT.Millennium, 3.1688087814029E-29 }
                }
            },
            {
                ETT.Femtosecond, new()
                {
                    { ETT.Attosecond, 1000d },
                    { ETT.Femtosecond, 1d },
                    { ETT.Picosecond, 0.001d },
                    { ETT.Nanosecond, 1.0E-6 },
                    { ETT.Microsecond, 1.0E-9 },
                    { ETT.Millisecond, 1.0E-12 },
                    { ETT.Second, 1.0E-15 },
                    { ETT.Minute, 1.6666666666667E-17 },
                    { ETT.Hour, 2.7777777777778E-19 },
                    { ETT.Day, 1.1574074074074E-20 },
                    { ETT.Week, 1.6534391534392E-21 },
                    { ETT.Year, 3.1688087814029E-23 },
                    { ETT.Decade, 3.1688087814029E-24 },
                    { ETT.Century, 3.1688087814029E-25 },
                    { ETT.Millennium, 3.1688087814029E-26 }
                }
            },
            {
                ETT.Picosecond, new()
                {
                    { ETT.Attosecond, 1000000d },
                    { ETT.Femtosecond, 1000d },
                    { ETT.Picosecond, 1d },
                    { ETT.Nanosecond, 0.001d },
                    { ETT.Microsecond, 1.0E-6 },
                    { ETT.Millisecond, 1.0E-9 },
                    { ETT.Second, 1.0E-12 },
                    { ETT.Minute, 1.6666666666667E-14 },
                    { ETT.Hour, 2.7777777777778E-16 },
                    { ETT.Day, 1.1574074074074E-17 },
                    { ETT.Week, 1.6534391534392E-18 },
                    { ETT.Year, 3.1688087814029E-20 },
                    { ETT.Decade, 3.1688087814029E-21 },
                    { ETT.Century, 3.1688087814029E-22 },
                    { ETT.Millennium, 3.1688087814029E-23 }
                }
            },
            {
                ETT.Nanosecond, new()
                {
                    { ETT.Attosecond, 1000000000d },
                    { ETT.Femtosecond, 1000000d },
                    { ETT.Picosecond, 1000d },
                    { ETT.Nanosecond, 1d },
                    { ETT.Microsecond, 0.001d },
                    { ETT.Millisecond, 1.0E-6 },
                    { ETT.Second, 1.0E-9 },
                    { ETT.Minute, 1.6666666666667E-11 },
                    { ETT.Hour, 2.7777777777778E-13 },
                    { ETT.Day, 1.1574074074074E-14 },
                    { ETT.Week, 1.6534391534392E-15 },
                    { ETT.Year, 3.1688087814029E-17 },
                    { ETT.Decade, 3.1688087814029E-18 },
                    { ETT.Century, 3.1688087814029E-19 },
                    { ETT.Millennium, 3.1688087814029E-20 }
                }
            },
            {
                ETT.Microsecond, new()
                {
                    { ETT.Attosecond, 1000000000000d },
                    { ETT.Femtosecond, 1000000000d },
                    { ETT.Picosecond, 1000000d },
                    { ETT.Nanosecond, 1000d },
                    { ETT.Microsecond, 1d },
                    { ETT.Millisecond, 0.001d },
                    { ETT.Second, 1.0E-6 },
                    { ETT.Minute, 1.6666666666667E-8 },
                    { ETT.Hour, 2.7777777777778E-10 },
                    { ETT.Day, 1.1574074074074E-11 },
                    { ETT.Week, 1.6534391534392E-12 },
                    { ETT.Year, 3.1688087814029E-14 },
                    { ETT.Decade, 3.1688087814029E-15 },
                    { ETT.Century, 3.1688087814029E-16 },
                    { ETT.Millennium, 3.1688087814029E-17 }
                }
            },
            {
                ETT.Millisecond, new()
                {
                    { ETT.Attosecond, 1.0E+15 },
                    { ETT.Femtosecond, 1000000000000d },
                    { ETT.Picosecond, 1000000000d },
                    { ETT.Nanosecond, 1000000d },
                    { ETT.Microsecond, 1000d },
                    { ETT.Millisecond, 1d },
                    { ETT.Second, 0.001d },
                    { ETT.Minute, 1.66667E-5 },
                    { ETT.Hour, 2.7777777777778E-7 },
                    { ETT.Day, 1.1574074074074E-8 },
                    { ETT.Week, 1.6534391534392E-9 },
                    { ETT.Year, 3.1688087814029E-11 },
                    { ETT.Decade, 3.1688087814029E-12 },
                    { ETT.Century, 3.1688087814029E-13 },
                    { ETT.Millennium, 3.1688087814029E-14 }
                }
            },
            {
                ETT.Second, new()
                {
                    { ETT.Attosecond, 1.0E+18 },
                    { ETT.Femtosecond, 1.0E+15 },
                    { ETT.Picosecond, 1000000000000d },
                    { ETT.Nanosecond, 1000000000d },
                    { ETT.Microsecond, 1000000d },
                    { ETT.Millisecond, 1000d },
                    { ETT.Second, 1d },
                    { ETT.Minute, 0.0166666667d },
                    { ETT.Hour, 0.0002777778d },
                    { ETT.Day, 1.15741E-5 },
                    { ETT.Week, 1.6534391534392E-6 },
                    { ETT.Year, 3.1688087814029E-8 },
                    { ETT.Decade, 3.1688087814029E-9 },
                    { ETT.Century, 3.1688087814029E-10 },
                    { ETT.Millennium, 3.1688087814029E-11 }
                }
            },
            {
                ETT.Minute, new()
                {
                    { ETT.Attosecond, 6.0E+19 },
                    { ETT.Femtosecond, 6.0E+16 },
                    { ETT.Picosecond, 60000000000000d },
                    { ETT.Nanosecond, 60000000000d },
                    { ETT.Microsecond, 60000000d },
                    { ETT.Millisecond, 60000d },
                    { ETT.Second, 60d },
                    { ETT.Minute, 1d },
                    { ETT.Hour, 0.0166666667d },
                    { ETT.Day, 0.0006944444d },
                    { ETT.Week, 9.92063E-5 },
                    { ETT.Year, 1.9012852688417E-6 },
                    { ETT.Decade, 1.9012852688417E-7 },
                    { ETT.Century, 1.9012852688417E-8 },
                    { ETT.Millennium, 1.9012852688417E-9 }
                }
            },
            {
                ETT.Hour, new()
                {
                    { ETT.Attosecond, 3.6E+21 },
                    { ETT.Femtosecond, 3.6E+18 },
                    { ETT.Picosecond, 3.6E+15 },
                    { ETT.Nanosecond, 3600000000000d },
                    { ETT.Microsecond, 3600000000d },
                    { ETT.Millisecond, 3600000d },
                    { ETT.Second, 3600d },
                    { ETT.Minute, 60d },
                    { ETT.Hour, 1d },
                    { ETT.Day, 0.0416666667d },
                    { ETT.Week, 0.005952381d },
                    { ETT.Year, 0.0001140771d },
                    { ETT.Decade, 1.14077E-5 },
                    { ETT.Century, 1.140771161305E-6 },
                    { ETT.Millennium, 1.140771161305E-7 }
                }
            },
            {
                ETT.Day, new()
                {
                    { ETT.Attosecond, 8.64E+22 },
                    { ETT.Femtosecond, 8.64E+19 },
                    { ETT.Picosecond, 8.64E+16 },
                    { ETT.Nanosecond, 86400000000000d },
                    { ETT.Microsecond, 86400000000d },
                    { ETT.Millisecond, 86400000d },
                    { ETT.Second, 86400d },
                    { ETT.Minute, 1440d },
                    { ETT.Hour, 24d },
                    { ETT.Day, 1d },
                    { ETT.Week, 0.1428571429d },
                    { ETT.Year, 0.0027378508d },
                    { ETT.Decade, 0.0002737851d },
                    { ETT.Century, 2.73785E-5 },
                    { ETT.Millennium, 2.7378507871321E-6 }
                }
            },
            {
                ETT.Week, new()
                {
                    { ETT.Attosecond, 6.048E+23 },
                    { ETT.Femtosecond, 6.048E+20 },
                    { ETT.Picosecond, 6.048E+17 },
                    { ETT.Nanosecond, 6.048E+14 },
                    { ETT.Microsecond, 604800000000d },
                    { ETT.Millisecond, 604800000d },
                    { ETT.Second, 604800d },
                    { ETT.Minute, 10080d },
                    { ETT.Hour, 168d },
                    { ETT.Day, 7d },
                    { ETT.Week, 1d },
                    { ETT.Year, 0.0191649555d },
                    { ETT.Decade, 0.0019164956d },
                    { ETT.Century, 0.0001916496d },
                    { ETT.Millennium, 1.9165E-5 }
                }
            },
            {
                ETT.Year, new()
                {
                    { ETT.Attosecond, 3.15576E+25 },
                    { ETT.Femtosecond, 3.15576E+22 },
                    { ETT.Picosecond, 3.15576E+19 },
                    { ETT.Nanosecond, 3.15576E+16 },
                    { ETT.Microsecond, 31557600000000d },
                    { ETT.Millisecond, 31557600000d },
                    { ETT.Second, 31557600d },
                    { ETT.Minute, 525960d },
                    { ETT.Hour, 8766d },
                    { ETT.Day, 365.25d },
                    { ETT.Week, 52.1785714286d },
                    { ETT.Year, 1d },
                    { ETT.Decade, 0.1d },
                    { ETT.Century, 0.01d },
                    { ETT.Millennium, 0.001d }
                }
            },
            {
                ETT.Decade, new()
                {
                    { ETT.Attosecond, 3.15576E+26 },
                    { ETT.Femtosecond, 3.15576E+23 },
                    { ETT.Picosecond, 3.15576E+20 },
                    { ETT.Nanosecond, 3.15576E+17 },
                    { ETT.Microsecond, 3.15576E+14 },
                    { ETT.Millisecond, 315576000000d },
                    { ETT.Second, 315576000d },
                    { ETT.Minute, 5259600d },
                    { ETT.Hour, 87660d },
                    { ETT.Day, 3652.5d },
                    { ETT.Week, 521.7857142857d },
                    { ETT.Year, 10d },
                    { ETT.Decade, 1d },
                    { ETT.Century, 0.1d },
                    { ETT.Millennium, 0.01d }
                }
            },
            {
                ETT.Century, new()
                {
                    { ETT.Attosecond, 3.15576E+27 },
                    { ETT.Femtosecond, 3.15576E+24 },
                    { ETT.Picosecond, 3.15576E+21 },
                    { ETT.Nanosecond, 3.15576E+18 },
                    { ETT.Microsecond, 3.15576E+15 },
                    { ETT.Millisecond, 3155760000000d },
                    { ETT.Second, 3155760000d },
                    { ETT.Minute, 52596000d },
                    { ETT.Hour, 876600d },
                    { ETT.Day, 36525d },
                    { ETT.Week, 5217.8571428571d },
                    { ETT.Year, 100d },
                    { ETT.Decade, 10d },
                    { ETT.Century, 1d },
                    { ETT.Millennium, 0.1d }
                }
            },
            {
                ETT.Millennium, new()
                {
                    { ETT.Attosecond, 3.15576E+28 },
                    { ETT.Femtosecond, 3.15576E+25 },
                    { ETT.Picosecond, 3.15576E+22 },
                    { ETT.Nanosecond, 3.15576E+19 },
                    { ETT.Microsecond, 3.15576E+16 },
                    { ETT.Millisecond, 31557600000000d },
                    { ETT.Second, 31557600000d },
                    { ETT.Minute, 525960000d },
                    { ETT.Hour, 8766000d },
                    { ETT.Day, 365250d },
                    { ETT.Week, 52178.571428571d },
                    { ETT.Year, 1000d },
                    { ETT.Decade, 100d },
                    { ETT.Century, 10d },
                    { ETT.Millennium, 1d }
                }
            }
        };
    }
}