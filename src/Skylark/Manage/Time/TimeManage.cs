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
        public const decimal Value = 10;

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
        public static readonly Dictionary<ETT, Dictionary<ETT, decimal>> Converter = new()
        {
            {
                ETT.Attosecond, new()
                {
                    { ETT.Attosecond, 1M },
                    { ETT.Femtosecond, 0.001M },
                    { ETT.Picosecond, 0.0000010M },
                    { ETT.Nanosecond, 0.0000000010M },
                    { ETT.Microsecond, 0.0000000000010M },
                    { ETT.Millisecond, 0.0000000000000010M },
                    { ETT.Centisecond, 0.00000000000000010M },
                    { ETT.Second, 0.0000000000000000010M },
                    { ETT.Minute, 0.000000000000000000016666666666667M },
                    { ETT.Hour, 0.00000000000000000000027777777777778M },
                    { ETT.Day, 0.000000000000000000000011574074074074M },
                    { ETT.Week, 0.0000000000000000000000016534391534392M },
                    { ETT.Year, 0.000000000000000000000000031709791983765M },
                    { ETT.Decade, 0M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Femtosecond, new()
                {
                    { ETT.Attosecond, 1000M },
                    { ETT.Femtosecond, 1M },
                    { ETT.Picosecond, 0.001M },
                    { ETT.Nanosecond, 0.0000010M },
                    { ETT.Microsecond, 0.0000000010M },
                    { ETT.Millisecond, 0.0000000000010M },
                    { ETT.Centisecond, 0.00000000000010M },
                    { ETT.Second, 0.0000000000000010M },
                    { ETT.Minute, 0.000000000000000016666666666667M },
                    { ETT.Hour, 0.00000000000000000027777777777778M },
                    { ETT.Day, 0.000000000000000000011574074074074M },
                    { ETT.Week, 0.0000000000000000000016534391534392M },
                    { ETT.Year, 0.000000000000000000000031709791983765M },
                    { ETT.Decade, 0M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Picosecond, new()
                {
                    { ETT.Attosecond, 1000000M },
                    { ETT.Femtosecond, 1000M },
                    { ETT.Picosecond, 1M },
                    { ETT.Nanosecond, 0.001M },
                    { ETT.Microsecond, 0.0000010M },
                    { ETT.Millisecond, 0.0000000010M },
                    { ETT.Centisecond, 0.00000000010M },
                    { ETT.Second, 0.0000000000010M },
                    { ETT.Minute, 0.000000000000016666666666667M },
                    { ETT.Hour, 0.00000000000000027777777777778M },
                    { ETT.Day, 0.000000000000000011574074074074M },
                    { ETT.Week, 0.0000000000000000016534391534392M },
                    { ETT.Year, 0.000000000000000000031709791983765M },
                    { ETT.Decade, 0M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Nanosecond, new()
                {
                    { ETT.Attosecond, 1000000000M },
                    { ETT.Femtosecond, 1000000M },
                    { ETT.Picosecond, 1000M },
                    { ETT.Nanosecond, 1M },
                    { ETT.Microsecond, 0.001M },
                    { ETT.Millisecond, 0.0000010M },
                    { ETT.Centisecond, 0.00000010M },
                    { ETT.Second, 0.0000000010M },
                    { ETT.Minute, 0.000000000016666666666667M },
                    { ETT.Hour, 0.00000000000027777777777778M },
                    { ETT.Day, 0.000000000000011574074074074M },
                    { ETT.Week, 0.0000000000000016534391534392M },
                    { ETT.Year, 0.000000000000000031709791983765M },
                    { ETT.Decade, 0M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Microsecond, new()
                {
                    { ETT.Attosecond, 1000000000000M },
                    { ETT.Femtosecond, 1000000000M },
                    { ETT.Picosecond, 1000000M },
                    { ETT.Nanosecond, 1000M },
                    { ETT.Microsecond, 1M },
                    { ETT.Millisecond, 0.001M },
                    { ETT.Centisecond, 0.0001M },
                    { ETT.Second, 0.0000010M },
                    { ETT.Minute, 0.000000016666666666667M },
                    { ETT.Hour, 0.00000000027777777777778M },
                    { ETT.Day, 0.000000000011574074074074M },
                    { ETT.Week, 0.0000000000016534391534392M },
                    { ETT.Year, 0.000000000000031709791983765M },
                    { ETT.Decade, 0M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Millisecond, new()
                {
                    { ETT.Attosecond, 1000000000000000M },
                    { ETT.Femtosecond, 1000000000000M },
                    { ETT.Picosecond, 1000000000M },
                    { ETT.Nanosecond, 1000000M },
                    { ETT.Microsecond, 1000M },
                    { ETT.Millisecond, 1M },
                    { ETT.Centisecond, 0.1M },
                    { ETT.Second, 0.001M },
                    { ETT.Minute, 0.000016666666666667M },
                    { ETT.Hour, 0.00000027777777777778M },
                    { ETT.Day, 0.000000011574074074074M },
                    { ETT.Week, 0.0000000016534391534392M },
                    { ETT.Year, 0.000000000031709791983765M },
                    { ETT.Decade, 0M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Centisecond, new()
                {
                    { ETT.Attosecond, 10000000000000000M },
                    { ETT.Femtosecond, 10000000000000M },
                    { ETT.Picosecond, 10000000000M },
                    { ETT.Nanosecond, 10000000M },
                    { ETT.Microsecond, 10000M },
                    { ETT.Millisecond, 10M },
                    { ETT.Centisecond, 1M },
                    { ETT.Second, 0.01M },
                    { ETT.Minute, 0.00016666666666667M },
                    { ETT.Hour, 0.0000027777777777778M },
                    { ETT.Day, 0.000000115740740740741M },
                    { ETT.Week, 0.000000016534391534392M },
                    { ETT.Year, 0.00000000031709791983764586M },
                    { ETT.Decade, 0.000000000031709791983764586M },
                    { ETT.Century, 0.0000000000031709791983764586M },
                    { ETT.Millennium, 0.00000000000031709791983764586M }
                }
            },
            {
                ETT.Second, new()
                {
                    { ETT.Attosecond, 1000000000000000000M },
                    { ETT.Femtosecond, 1000000000000000M },
                    { ETT.Picosecond, 1000000000000M },
                    { ETT.Nanosecond, 1000000000M },
                    { ETT.Microsecond, 1000000M },
                    { ETT.Millisecond, 1000M },
                    { ETT.Centisecond, 100M },
                    { ETT.Second, 1M },
                    { ETT.Minute, 0.016666666666667M },
                    { ETT.Hour, 0.00027777777777778M },
                    { ETT.Day, 0.000011574074074074M },
                    { ETT.Week, 0.0000016534391534392M },
                    { ETT.Year, 0.000000031709791983765M },
                    { ETT.Decade, 0M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Minute, new()
                {
                    { ETT.Attosecond, 60000000000000000000M },
                    { ETT.Femtosecond, 60000000000000000 },
                    { ETT.Picosecond, 60000000000000M },
                    { ETT.Nanosecond, 60000000000M },
                    { ETT.Microsecond, 60000000M },
                    { ETT.Millisecond, 60000M },
                    { ETT.Centisecond, 6000M },
                    { ETT.Second, 60M },
                    { ETT.Minute, 1M },
                    { ETT.Hour, 0.016666666666667M },
                    { ETT.Day, 0.00069444444444444M },
                    { ETT.Week, 0.000099206349206349M },
                    { ETT.Year, 0.0000019025875190259M },
                    { ETT.Decade, 0M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Hour, new() //Here
                {
                    { ETT.Attosecond, 3600000000000000000000M },
                    { ETT.Femtosecond, 3600000000000000000M },
                    { ETT.Picosecond, 3600000000000000M },
                    { ETT.Nanosecond, 3600000000000M },
                    { ETT.Microsecond, 3600000000M },
                    { ETT.Millisecond, 3600000M },
                    { ETT.Centisecond, 360000M },
                    { ETT.Second, 3600M },
                    { ETT.Minute, 60M },
                    { ETT.Hour, 1M },
                    { ETT.Day, 0.041666666666667M },
                    { ETT.Week, 0.005952380952381M },
                    { ETT.Year, 0.00011415525114155M },
                    { ETT.Decade, 0M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Day, new()
                {
                    { ETT.Attosecond, 8640000000000000000000000000M },
                    { ETT.Femtosecond, 86400000000000000000000000M },
                    { ETT.Picosecond, 86400000000000000000000M },
                    { ETT.Nanosecond, 86400000000000000000M },
                    { ETT.Microsecond, 86400000000000000M },
                    { ETT.Millisecond, 86400000000000M },
                    { ETT.Centisecond, 8640000000000M },
                    { ETT.Second, 864000000M },
                    { ETT.Minute, 14400000M },
                    { ETT.Hour, 240M },
                    { ETT.Day, 1M },
                    { ETT.Week, 0M },
                    { ETT.Year, 0M },
                    { ETT.Decade, 0M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Week, new()
                {
                    { ETT.Attosecond, 0M }, //604800000000000000000000000000M - 6.048E+23M
                    { ETT.Femtosecond, 6048000000000000000000000000M },
                    { ETT.Picosecond, 60480000000000000000000000M },
                    { ETT.Nanosecond, 60480000000000000000000M },
                    { ETT.Microsecond, 60480000000000000000M },
                    { ETT.Millisecond, 60480000000000000M },
                    { ETT.Centisecond, 6048000000000000M },
                    { ETT.Second, 604800000000M },
                    { ETT.Minute, 10080000000M },
                    { ETT.Hour, 168000000M },
                    { ETT.Day, 7M },
                    { ETT.Week, 1M },
                    { ETT.Year, 0M },
                    { ETT.Decade, 0M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Year, new()
                {
                    { ETT.Attosecond, 0M }, //31536000000000000000000000000000M - 3.155759999E+25M
                    { ETT.Femtosecond, 0M }, //315360000000000000000000000000M - 3.155759999E+22M
                    { ETT.Picosecond, 315360000000000000000000000M },
                    { ETT.Nanosecond, 315360000000000000000000M },
                    { ETT.Microsecond, 315360000000000000000M },
                    { ETT.Millisecond, 315360000000000000M },
                    { ETT.Centisecond, 31536000000000000M },
                    { ETT.Second, 315360000000000M },
                    { ETT.Minute, 5256000000000M },
                    { ETT.Hour, 87600000000M },
                    { ETT.Day, 365000000M },
                    { ETT.Week, 52.177M },
                    { ETT.Year, 1M },
                    { ETT.Decade, 0M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Decade, new()
                {
                    { ETT.Attosecond, 0M }, //315360000000000000000000000000000M - 3.155759999E+26M
                    { ETT.Femtosecond, 0M }, //3153600000000000000000000000000M - 3.155759999E+23M
                    { ETT.Picosecond, 3153600000000000000000000000M },
                    { ETT.Nanosecond, 3153600000000000000000000M },
                    { ETT.Microsecond, 3153600000000000000000M },
                    { ETT.Millisecond, 3153600000000000000M },
                    { ETT.Centisecond, 315360000000000000M },
                    { ETT.Second, 3153600000000000M },
                    { ETT.Minute, 52560000000000M },
                    { ETT.Hour, 876000000000M },
                    { ETT.Day, 3650000000M },
                    { ETT.Week, 521428571430M },
                    { ETT.Year, 10M },
                    { ETT.Decade, 1M },
                    { ETT.Century, 0M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Century, new()
                {
                    { ETT.Attosecond, 0M }, //3153600000000000000000000000000000M - 3.155759999E+27M
                    { ETT.Femtosecond, 0M }, //31536000000000000000000000000000M - 3.155759999E+24M
                    { ETT.Picosecond, 31536000000000000000000000000M },
                    { ETT.Nanosecond, 31536000000000000000000000M },
                    { ETT.Microsecond, 31536000000000000000000M },
                    { ETT.Millisecond, 31536000000000000000M },
                    { ETT.Centisecond, 3153600000000000000M },
                    { ETT.Second, 31536000000000000M },
                    { ETT.Minute, 525600000000000M },
                    { ETT.Hour, 8760000000000M },
                    { ETT.Day, 36500000000M },
                    { ETT.Week, 5214285714300M },
                    { ETT.Year, 100M },
                    { ETT.Decade, 10M },
                    { ETT.Century, 1M },
                    { ETT.Millennium, 0M }
                }
            },
            {
                ETT.Millennium, new()
                {
                    { ETT.Attosecond, 31557600000000000000000000000M },
                    { ETT.Femtosecond, 31557600000000000000000000M },
                    { ETT.Picosecond, 31557600000000000000000M },
                    { ETT.Nanosecond, 31557600000000000000M },
                    { ETT.Microsecond, 31557600000000000M },
                    { ETT.Millisecond, 31557600000000M },
                    { ETT.Centisecond, 315576000000M },
                    { ETT.Second, 31557600000M },
                    { ETT.Minute, 525960000M },
                    { ETT.Hour, 8766000M },
                    { ETT.Day, 365250M },
                    { ETT.Week, 52142.857143M },
                    { ETT.Year, 1000M },
                    { ETT.Decade, 100M },
                    { ETT.Century, 10M },
                    { ETT.Millennium, 1M }
                }
            }
        };
    }
}