using MI = Skylark.Manage.Internal;

namespace Skylark.Helper
{
    internal class Length
    {
        public static string Text(string Value, string Back)
        {
            if (Value.Length > MI.TextLength)
            {
                Value = Back;
            }

            return Value;
        }

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