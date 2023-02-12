namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public class Adaptation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        public static string Cut(string Value, int MaxLength)
        {
            return Value.Length > MaxLength ? Value.Substring(0, MaxLength) : Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        public static Task<string> CutAsync(string Value, int MaxLength)
        {
            return Task.Run(() => Cut(Value, MaxLength));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Char"></param>
        /// <param name="MinLength"></param>
        /// <returns></returns>
        public static string Add(string Value, char Char, int MinLength)
        {
            return Value.Length < MinLength ? Value.PadRight(MinLength, Char) : Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Char"></param>
        /// <param name="MinLength"></param>
        /// <returns></returns>
        public static Task<string> AddAsync(string Value, char Char, int MinLength)
        {
            return Task.Run(() => Add(Value, Char, MinLength));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <param name="Length"></param>
        /// <returns></returns>
        public static string Pin(string Value, string Back, int Length)
        {
            return Value.Length == Length ? Value : Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <param name="Length"></param>
        /// <returns></returns>
        public static Task<string> PinAsync(string Value, string Back, int Length)
        {
            return Task.Run(() => Pin(Value, Back, Length));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <param name="MinLength"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        public static string Feed(string Value, string Back, int MinLength, int MaxLength)
        {
            return Value.Length < MinLength ? Back : Value.Length > MaxLength ? Back : Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <param name="MinLength"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        public static Task<string> FeedAsync(string Value, string Back, int MinLength, int MaxLength)
        {
            return Task.Run(() => Feed(Value, Back, MinLength, MaxLength));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Char"></param>
        /// <param name="MinLength"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        public static string Adapt(string Value, char Char, int MinLength, int MaxLength)
        {
            return Cut(Add(Value, Char, MinLength), MaxLength);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Char"></param>
        /// <param name="MinLength"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        public static Task<string> AdaptAsync(string Value, char Char, int MinLength, int MaxLength)
        {
            return Task.Run(() => Adapt(Value, Char, MinLength, MaxLength));
        }
    }
}