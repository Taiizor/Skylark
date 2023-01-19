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
                    { ETT.Attosecond, 1d },
                    { ETT.Femtosecond, 0.001d },
                    { ETT.Picosecond, 0.0000010d },
                    { ETT.Nanosecond, 0.0000000010d },
                    { ETT.Microsecond, 0.0000000000010d },
                    { ETT.Millisecond, 0.0000000000000010d },
                    { ETT.Centisecond, 0.00000000000000010d },
                    { ETT.Second, 0.0000000000000000010d },
                    { ETT.Minute, 0.000000000000000000016666666666667d },
                    { ETT.Hour, 0.00000000000000000000027777777777778d },
                    { ETT.Day, 0.000000000000000000000011574074074074d },
                    { ETT.Week, 0.0000000000000000000000016534391534392d },
                    { ETT.Year, 0.000000000000000000000000031709791983765d },
                    { ETT.Decade, 0.0000000000000000000000000031709791983765d },
                    { ETT.Century, 0.00000000000000000000000000031709791983765d },
                    { ETT.Millennium, 0.000000000000000000000000000031709791983765d }
                }
            },
            {
                ETT.Femtosecond, new()
                {
                    { ETT.Attosecond, 1000d },
                    { ETT.Femtosecond, 1d },
                    { ETT.Picosecond, 0.001d },
                    { ETT.Nanosecond, 0.0000010d },
                    { ETT.Microsecond, 0.0000000010d },
                    { ETT.Millisecond, 0.0000000000010d },
                    { ETT.Centisecond, 0.00000000000010d },
                    { ETT.Second, 0.0000000000000010d },
                    { ETT.Minute, 0.000000000000000016666666666667d },
                    { ETT.Hour, 0.00000000000000000027777777777778d },
                    { ETT.Day, 0.000000000000000000011574074074074d },
                    { ETT.Week, 0.0000000000000000000016534391534392d },
                    { ETT.Year, 0.000000000000000000000031709791983765d },
                    { ETT.Decade, 0d },
                    { ETT.Century, 0d },
                    { ETT.Millennium, 0d }
                }
            },
            {
                ETT.Picosecond, new()
                {
                    { ETT.Attosecond, 1000000d },
                    { ETT.Femtosecond, 1000d },
                    { ETT.Picosecond, 1d },
                    { ETT.Nanosecond, 0.001d },
                    { ETT.Microsecond, 0.0000010d },
                    { ETT.Millisecond, 0.0000000010d },
                    { ETT.Centisecond, 0.00000000010d },
                    { ETT.Second, 0.0000000000010d },
                    { ETT.Minute, 0.000000000000016666666666667d },
                    { ETT.Hour, 0.00000000000000027777777777778d },
                    { ETT.Day, 0.000000000000000011574074074074d },
                    { ETT.Week, 0.0000000000000000016534391534392d },
                    { ETT.Year, 0.000000000000000000031709791983765d },
                    { ETT.Decade, 0d },
                    { ETT.Century, 0d },
                    { ETT.Millennium, 0d }
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
                    { ETT.Millisecond, 0.0000010d },
                    { ETT.Centisecond, 0.00000010d },
                    { ETT.Second, 0.0000000010d },
                    { ETT.Minute, 0.000000000016666666666667d },
                    { ETT.Hour, 0.00000000000027777777777778d },
                    { ETT.Day, 0.000000000000011574074074074d },
                    { ETT.Week, 0.0000000000000016534391534392d },
                    { ETT.Year, 0.000000000000000031709791983765d },
                    { ETT.Decade, 0d },
                    { ETT.Century, 0d },
                    { ETT.Millennium, 0d }
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
                    { ETT.Centisecond, 0.0001d },
                    { ETT.Second, 0.0000010d },
                    { ETT.Minute, 0.000000016666666666667d },
                    { ETT.Hour, 0.00000000027777777777778d },
                    { ETT.Day, 0.000000000011574074074074d },
                    { ETT.Week, 0.0000000000016534391534392d },
                    { ETT.Year, 0.000000000000031709791983765d },
                    { ETT.Decade, 0d },
                    { ETT.Century, 0d },
                    { ETT.Millennium, 0d }
                }
            },
            {
                ETT.Millisecond, new()
                {
                    { ETT.Attosecond, 1000000000000000d },
                    { ETT.Femtosecond, 1000000000000d },
                    { ETT.Picosecond, 1000000000d },
                    { ETT.Nanosecond, 1000000d },
                    { ETT.Microsecond, 1000d },
                    { ETT.Millisecond, 1d },
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
                    { ETT.Centisecond, 1d },
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
                    { ETT.Second, 1d },
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
                    { ETT.Minute, 1d },
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
                    { ETT.Hour, 1d },
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
                    { ETT.Day, 1d },
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
                    { ETT.Week, 1d },
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
                    { ETT.Year, 1d },
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
                    { ETT.Decade, 1d },
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
                    { ETT.Century, 1d },
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
                    { ETT.Millennium, 1d }
                }
            }
        };
    }
}