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
                    { ETT.Femtosecond, 1M },
                    { ETT.Picosecond, 1M },
                    { ETT.Nanosecond, 1M },
                    { ETT.Microsecond, 0.125M },
                    { ETT.Millisecond, 0.000125M },
                    { ETT.Centisecond, 0.000125M },
                    { ETT.Second, 0.000000125M },
                    { ETT.Minute, 0.000000000125M },
                    { ETT.Hour, 0.000000000000125M },
                    { ETT.Day, 0.000000000000000125M },
                    { ETT.Week, 0.000000000000000000125M },
                    { ETT.Year, 0.000000000000000000000125M },
                    { ETT.Century, 0.000000000000000000000125M },
                    { ETT.Millennium, 0.000000000000000000000000125M }
                }
            }
        };
    }
}