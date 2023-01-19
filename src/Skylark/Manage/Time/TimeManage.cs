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
                    { ETT.Centisecond, 1.0E-16 },
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
                    { ETT.Centisecond, 1.0E-13 },
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
                    { ETT.Centisecond, 1.0E-10 },
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
                    { ETT.Attosecond, 1000000000 },
                    { ETT.Femtosecond, 1000000 },
                    { ETT.Picosecond, 1000 },
                    { ETT.Nanosecond, 1.0 },
                    { ETT.Microsecond, 0.001 },
                    { ETT.Millisecond, 1.0E-6 },
                    { ETT.Centisecond, 1.0E-7 },
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
                    { ETT.Attosecond, 1000000000000 },
                    { ETT.Femtosecond, 1000000000 },
                    { ETT.Picosecond, 1000000 },
                    { ETT.Nanosecond, 1000 },
                    { ETT.Microsecond, 1.0 },
                    { ETT.Millisecond, 0.001 },
                    { ETT.Centisecond, 0.0001 },
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
                    { ETT.Millisecond, 1.0 },
                    { ETT.Centisecond, 0.1d },
                    { ETT.Second, 0.001d },
                    { ETT.Minute, 0.000016666666666667d },
                    { ETT.Hour, 0.00000027777777777778d },
                    { ETT.Day, 0.000000011574074074074d },
                    { ETT.Week, 0.0000000016534391534392d },
                    { ETT.Year, 0.000000000031709791983765d },
                    { ETT.Decade, 0d },
                    { ETT.Century, 0d },
                    { ETT.Millennium, 0d }
                }
            },
            {
                ETT.Centisecond, new()
                {
                    { ETT.Attosecond, 10000000000000000d },
                    { ETT.Femtosecond, 10000000000000d },
                    { ETT.Picosecond, 10000000000d },
                    { ETT.Nanosecond, 10000000d },
                    { ETT.Microsecond, 10000d },
                    { ETT.Millisecond, 10d },
                    { ETT.Centisecond, 1.0 },
                    { ETT.Second, 0.01d },
                    { ETT.Minute, 0.00016666666666667d },
                    { ETT.Hour, 0.0000027777777777778d },
                    { ETT.Day, 0.000000115740740740741d },
                    { ETT.Week, 0.000000016534391534392d },
                    { ETT.Year, 0.00000000031709791983764586d },
                    { ETT.Decade, 0.000000000031709791983764586d },
                    { ETT.Century, 0.0000000000031709791983764586d },
                    { ETT.Millennium, 0.00000000000031709791983764586d }
                }
            },
            {
                ETT.Second, new()
                {
                    { ETT.Attosecond, 1000000000000000000d },
                    { ETT.Femtosecond, 1000000000000000d },
                    { ETT.Picosecond, 1000000000000d },
                    { ETT.Nanosecond, 1000000000d },
                    { ETT.Microsecond, 1000000d },
                    { ETT.Millisecond, 1000d },
                    { ETT.Centisecond, 100d },
                    { ETT.Second, 1.0 },
                    { ETT.Minute, 0.016666666666667d },
                    { ETT.Hour, 0.00027777777777778d },
                    { ETT.Day, 0.000011574074074074d },
                    { ETT.Week, 0.0000016534391534392d },
                    { ETT.Year, 0.000000031709791983765d },
                    { ETT.Decade, 0d },
                    { ETT.Century, 0d },
                    { ETT.Millennium, 0d }
                }
            },
            {
                ETT.Minute, new()
                {
                    { ETT.Attosecond, 60000000000000000000d },
                    { ETT.Femtosecond, 60000000000000000 },
                    { ETT.Picosecond, 60000000000000d },
                    { ETT.Nanosecond, 60000000000d },
                    { ETT.Microsecond, 60000000d },
                    { ETT.Millisecond, 60000d },
                    { ETT.Centisecond, 6000d },
                    { ETT.Second, 60d },
                    { ETT.Minute, 1.0 },
                    { ETT.Hour, 0.016666666666667d },
                    { ETT.Day, 0.00069444444444444d },
                    { ETT.Week, 0.000099206349206349d },
                    { ETT.Year, 0.0000019025875190259d },
                    { ETT.Decade, 0d },
                    { ETT.Century, 0d },
                    { ETT.Millennium, 0d }
                }
            },
            {
                ETT.Hour, new() //Here
                {
                    { ETT.Attosecond, 3600000000000000000000d },
                    { ETT.Femtosecond, 3600000000000000000d },
                    { ETT.Picosecond, 3600000000000000d },
                    { ETT.Nanosecond, 3600000000000d },
                    { ETT.Microsecond, 3600000000d },
                    { ETT.Millisecond, 3600000d },
                    { ETT.Centisecond, 360000d },
                    { ETT.Second, 3600d },
                    { ETT.Minute, 60d },
                    { ETT.Hour, 1.0 },
                    { ETT.Day, 0.041666666666667d },
                    { ETT.Week, 0.005952380952381d },
                    { ETT.Year, 0.00011415525114155d },
                    { ETT.Decade, 0d },
                    { ETT.Century, 0d },
                    { ETT.Millennium, 0d }
                }
            },
            {
                ETT.Day, new()
                {
                    { ETT.Attosecond, 8640000000000000000000000000d },
                    { ETT.Femtosecond, 86400000000000000000000000d },
                    { ETT.Picosecond, 86400000000000000000000d },
                    { ETT.Nanosecond, 86400000000000000000d },
                    { ETT.Microsecond, 86400000000000000d },
                    { ETT.Millisecond, 86400000000000d },
                    { ETT.Centisecond, 8640000000000d },
                    { ETT.Second, 864000000d },
                    { ETT.Minute, 14400000d },
                    { ETT.Hour, 240d },
                    { ETT.Day, 1.0 },
                    { ETT.Week, 0.14285714285714d },
                    { ETT.Year, 0.0027397260273973d },
                    { ETT.Decade, 0d },
                    { ETT.Century, 0d },
                    { ETT.Millennium, 0d }
                }
            },
            {
                ETT.Week, new()
                {
                    { ETT.Attosecond, 0d }, //604800000000000000000000000000M - 6.048E+23M
                    { ETT.Femtosecond, 6048000000000000000000000000d },
                    { ETT.Picosecond, 60480000000000000000000000d },
                    { ETT.Nanosecond, 60480000000000000000000d },
                    { ETT.Microsecond, 60480000000000000000d },
                    { ETT.Millisecond, 60480000000000000d },
                    { ETT.Centisecond, 6048000000000000d },
                    { ETT.Second, 604800000000d },
                    { ETT.Minute, 10080000000d },
                    { ETT.Hour, 168000000d },
                    { ETT.Day, 7d },
                    { ETT.Week, 1.0 },
                    { ETT.Year, 0.019178082191781d },
                    { ETT.Decade, 0d },
                    { ETT.Century, 0d },
                    { ETT.Millennium, 0d }
                }
            },
            {
                ETT.Year, new()
                {
                    { ETT.Attosecond, 0d }, //31536000000000000000000000000000M - 3.155759999E+25M
                    { ETT.Femtosecond, 0d }, //315360000000000000000000000000M - 3.155759999E+22M
                    { ETT.Picosecond, 315360000000000000000000000d },
                    { ETT.Nanosecond, 315360000000000000000000d },
                    { ETT.Microsecond, 315360000000000000000d },
                    { ETT.Millisecond, 315360000000000000d },
                    { ETT.Centisecond, 31536000000000000d },
                    { ETT.Second, 315360000000000d },
                    { ETT.Minute, 5256000000000d },
                    { ETT.Hour, 87600000000d },
                    { ETT.Day, 365000000d },
                    { ETT.Week, 52.177d },
                    { ETT.Year, 1.0 },
                    { ETT.Decade, 0.1d },
                    { ETT.Century, 0.01d },
                    { ETT.Millennium, 0.001d }
                }
            },
            {
                ETT.Decade, new()
                {
                    { ETT.Attosecond, 0d }, //315360000000000000000000000000000M - 3.155759999E+26M
                    { ETT.Femtosecond, 0d }, //3153600000000000000000000000000M - 3.155759999E+23M
                    { ETT.Picosecond, 3153600000000000000000000000d },
                    { ETT.Nanosecond, 3153600000000000000000000d },
                    { ETT.Microsecond, 3153600000000000000000d },
                    { ETT.Millisecond, 3153600000000000000d },
                    { ETT.Centisecond, 315360000000000000d },
                    { ETT.Second, 3153600000000000d },
                    { ETT.Minute, 52560000000000d },
                    { ETT.Hour, 876000000000d },
                    { ETT.Day, 3650000000d },
                    { ETT.Week, 521428571430d },
                    { ETT.Year, 10d },
                    { ETT.Decade, 1.0 },
                    { ETT.Century, 0.1d },
                    { ETT.Millennium, 0.01d }
                }
            },
            {
                ETT.Century, new()
                {
                    { ETT.Attosecond, 0d }, //3153600000000000000000000000000000M - 3.155759999E+27M
                    { ETT.Femtosecond, 0d }, //31536000000000000000000000000000M - 3.155759999E+24M
                    { ETT.Picosecond, 31536000000000000000000000000d },
                    { ETT.Nanosecond, 31536000000000000000000000d },
                    { ETT.Microsecond, 31536000000000000000000d },
                    { ETT.Millisecond, 31536000000000000000d },
                    { ETT.Centisecond, 3153600000000000000d },
                    { ETT.Second, 31536000000000000d },
                    { ETT.Minute, 525600000000000d },
                    { ETT.Hour, 8760000000000d },
                    { ETT.Day, 36500000000d },
                    { ETT.Week, 5214285714300d },
                    { ETT.Year, 100d },
                    { ETT.Decade, 10d },
                    { ETT.Century, 1.0 },
                    { ETT.Millennium, 0.1d }
                }
            },
            {
                ETT.Millennium, new()
                {
                    { ETT.Attosecond, 31557600000000000000000000000d },
                    { ETT.Femtosecond, 31557600000000000000000000d },
                    { ETT.Picosecond, 31557600000000000000000d },
                    { ETT.Nanosecond, 31557600000000000000d },
                    { ETT.Microsecond, 31557600000000000d },
                    { ETT.Millisecond, 31557600000000d },
                    { ETT.Centisecond, 315576000000d },
                    { ETT.Second, 31557600000d },
                    { ETT.Minute, 525960000d },
                    { ETT.Hour, 8766000d },
                    { ETT.Day, 365250d },
                    { ETT.Week, 52142.857143d },
                    { ETT.Year, 1000d },
                    { ETT.Decade, 100d },
                    { ETT.Century, 10d },
                    { ETT.Millennium, 1.0 }
                }
            }
        };
    }
}