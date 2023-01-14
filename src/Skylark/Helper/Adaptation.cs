namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class Adaptation
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
        /// <param name="Char"></param>
        /// <param name="MinLength"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        public static string Adapt(string Value, char Char, int MinLength, int MaxLength)
        {
            return Cut(Add(Value, Char, MinLength), MaxLength);
        }
    }
}