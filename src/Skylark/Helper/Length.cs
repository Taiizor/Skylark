using MI = Skylark.Manage.Internal;

namespace Skylark.Helper
{
    internal class Length
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static string Text(string Value, string Back)
        {
            if (Value.Length > MI.TextLength)
            {
                Value = Back;
            }

            return Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="MinValue"></param>
        /// <param name="MaxValue"></param>
        /// <returns></returns>
        public static int Number(int Value, int MinValue, int MaxValue)
        {
            if (Value < MinValue)
            {
                return MinValue;
            }

            if (Value > MaxValue)
            {
                return MaxValue;
            }

            return Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static string Parameter(string Value, string Back)
        {
            if (Value.Length > MI.ParameterLength)
            {
                Value = Back;
            }

            return Value;
        }
    }
}