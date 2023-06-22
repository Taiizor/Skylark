using System;

namespace Skylark.WallpaperEngine.CS
{
    public class Variable
    {
        public static int GetInt(string Variable, int Default)
        {
            try
            {
                return Convert.ToInt32(Variable);
            }
            catch
            {
                return Default;
            }
        }

        public static int GetInt(string Variable, int Default, int Bigger)
        {
            try
            {
                int Number = Convert.ToInt32(Variable);
                if (Number <= Bigger)
                {
                    return Number;
                }
                else
                {
                    return Default;
                }
            }
            catch
            {
                return Default;
            }
        }

        public static int GetInt(string Variable, int Default, int Smaller, int Bigger)
        {
            try
            {
                int Number = Convert.ToInt32(Variable);
                if (Number <= Bigger && Number >= Smaller)
                {
                    return Number;
                }
                else
                {
                    return Default;
                }
            }
            catch
            {
                return Default;
            }
        }

        public static long GetLong(string Variable, long Default)
        {
            try
            {
                return Convert.ToInt64(Variable);
            }
            catch
            {
                return Default;
            }
        }

        public static string GetString(int Variable, int Default)
        {
            try
            {
                return Variable.ToString();
            }
            catch
            {
                return Default.ToString();
            }
        }

        public static string GetString(long Variable, long Default)
        {
            try
            {
                return Variable.ToString();
            }
            catch
            {
                return Default.ToString();
            }
        }

        public static string GetString(int Variable, string Default)
        {
            try
            {
                return Variable.ToString();
            }
            catch
            {
                return Default;
            }
        }

        public static string GetString(bool Variable, bool Default)
        {
            try
            {
                return Variable.ToString();
            }
            catch
            {
                return Default.ToString();
            }
        }


        public static bool GetBoolean(string Variable, bool Default)
        {
            try
            {
                return Convert.ToBoolean(Variable);
            }
            catch
            {
                return Default;
            }
        }
    }
}