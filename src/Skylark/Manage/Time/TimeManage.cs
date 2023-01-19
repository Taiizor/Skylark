using ETT = Skylark.Enum.TimeType;
using STS = Skylark.Struct.TimeStruct;

namespace Skylark.Manage
{
    /// <summary>
    /// 
    /// </summary>
    internal class TimeManage
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
        public static readonly STS Result = new()
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
                    { ETT.Attosecond, 1.0 },
                    { ETT.Femtosecond, 0.001 },
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
                    { ETT.Attosecond, 1000.0 },
                    { ETT.Femtosecond, 1.0 },
                    { ETT.Picosecond, 0.001 },
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
                    { ETT.Attosecond, 1000000.0 },
                    { ETT.Femtosecond, 1000.0 },
                    { ETT.Picosecond, 1.0 },
                    { ETT.Nanosecond, 0.001 },
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
                    { ETT.Attosecond, 1000000000.0 },
                    { ETT.Femtosecond, 1000000.0 },
                    { ETT.Picosecond, 1000.0 },
                    { ETT.Nanosecond, 1.0 },
                    { ETT.Microsecond, 0.001 },
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
                    { ETT.Attosecond, 1000000000000.0 },
                    { ETT.Femtosecond, 1000000000.0 },
                    { ETT.Picosecond, 1000000.0 },
                    { ETT.Nanosecond, 1000.0 },
                    { ETT.Microsecond, 1.0 },
                    { ETT.Millisecond, 0.001 },
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
                    { ETT.Femtosecond, 1000000000000.0 },
                    { ETT.Picosecond, 1000000000.0 },
                    { ETT.Nanosecond, 1000000.0 },
                    { ETT.Microsecond, 1000.0 },
                    { ETT.Millisecond, 1.0 },
                    { ETT.Second, 0.001 },
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
                    { ETT.Picosecond, 1000000000000.0 },
                    { ETT.Nanosecond, 1000000000.0 },
                    { ETT.Microsecond, 1000000.0 },
                    { ETT.Millisecond, 1000.0 },
                    { ETT.Second, 1.0 },
                    { ETT.Minute, 0.0166666667 },
                    { ETT.Hour, 0.0002777778 },
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
                    { ETT.Picosecond, 60000000000000.0 },
                    { ETT.Nanosecond, 60000000000.0 },
                    { ETT.Microsecond, 60000000.0 },
                    { ETT.Millisecond, 60000.0 },
                    { ETT.Second, 60.0 },
                    { ETT.Minute, 1.0 },
                    { ETT.Hour, 0.0166666667 },
                    { ETT.Day, 0.0006944444 },
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
                    { ETT.Nanosecond, 3600000000000.0 },
                    { ETT.Microsecond, 3600000000.0 },
                    { ETT.Millisecond, 3600000.0 },
                    { ETT.Second, 3600.0 },
                    { ETT.Minute, 60.0 },
                    { ETT.Hour, 1.0 },
                    { ETT.Day, 0.0416666667 },
                    { ETT.Week, 0.005952381 },
                    { ETT.Year, 0.0001140771 },
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
                    { ETT.Nanosecond, 86400000000000.0 },
                    { ETT.Microsecond, 86400000000.0 },
                    { ETT.Millisecond, 86400000.0 },
                    { ETT.Second, 86400.0 },
                    { ETT.Minute, 1440.0 },
                    { ETT.Hour, 24.0 },
                    { ETT.Day, 1.0 },
                    { ETT.Week, 0.1428571429 },
                    { ETT.Year, 0.0027378508 },
                    { ETT.Decade, 0.0002737851 },
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
                    { ETT.Microsecond, 604800000000.0 },
                    { ETT.Millisecond, 604800000.0 },
                    { ETT.Second, 604800.0 },
                    { ETT.Minute, 10080.0 },
                    { ETT.Hour, 168.0 },
                    { ETT.Day, 7.0 },
                    { ETT.Week, 1.0 },
                    { ETT.Year, 0.0191649555 },
                    { ETT.Decade, 0.0019164956 },
                    { ETT.Century, 0.0001916496 },
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
                    { ETT.Microsecond, 31557600000000.0 },
                    { ETT.Millisecond, 31557600000.0 },
                    { ETT.Second, 31557600.0 },
                    { ETT.Minute, 525960.0 },
                    { ETT.Hour, 8766.0 },
                    { ETT.Day, 365.25 },
                    { ETT.Week, 52.1785714286 },
                    { ETT.Year, 1.0 },
                    { ETT.Decade, 0.1d },
                    { ETT.Century, 0.01 },
                    { ETT.Millennium, 0.001 }
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
                    { ETT.Millisecond, 315576000000.0 },
                    { ETT.Second, 315576000.0 },
                    { ETT.Minute, 5259600.0 },
                    { ETT.Hour, 87660.0 },
                    { ETT.Day, 3652.5 },
                    { ETT.Week, 521.7857142857 },
                    { ETT.Year, 10.0 },
                    { ETT.Decade, 1.0 },
                    { ETT.Century, 0.1 },
                    { ETT.Millennium, 0.01 }
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
                    { ETT.Millisecond, 3155760000000.0 },
                    { ETT.Second, 3155760000.0 },
                    { ETT.Minute, 52596000.0 },
                    { ETT.Hour, 876600.0 },
                    { ETT.Day, 36525.0 },
                    { ETT.Week, 5217.8571428571 },
                    { ETT.Year, 100.0 },
                    { ETT.Decade, 10.0 },
                    { ETT.Century, 1.0 },
                    { ETT.Millennium, 0.1 }
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
                    { ETT.Millisecond, 31557600000000.0 },
                    { ETT.Second, 31557600000.0 },
                    { ETT.Minute, 525960000.0 },
                    { ETT.Hour, 8766000.0 },
                    { ETT.Day, 365250.0 },
                    { ETT.Week, 52178.571428571 },
                    { ETT.Year, 1000.0 },
                    { ETT.Decade, 100.0 },
                    { ETT.Century, 10.0 },
                    { ETT.Millennium, 1.0 }
                }
            }
        };
    }
}