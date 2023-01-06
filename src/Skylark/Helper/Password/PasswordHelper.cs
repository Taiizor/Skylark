using System.Text.RegularExpressions;
using EAPT = Skylark.Enum.AlphabeticPasswordType;
using EMPT = Skylark.Enum.MeterPasswordType;
using ESPT = Skylark.Enum.SpecialPasswordType;
using MPM = Skylark.Manage.PasswordManage;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class PasswordHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static EMPT GetMeter(string Password)
        {
            EMPT Point = 0;

            if (Password.Length >= (int)MPM.MeterOptions["MinLength"])
            {
                Point += 20;
            }

            if (Regex.IsMatch(Password, MPM.MeterOptions["RegexDigit"] as string))
            {
                Point += 20;
            }

            if (Regex.IsMatch(Password, MPM.MeterOptions["RegexSymbol"] as string))
            {
                Point += 20;
            }

            if (Regex.IsMatch(Password, MPM.MeterOptions["RegexLowercase"] as string))
            {
                Point += 20;
            }

            if (Regex.IsMatch(Password, MPM.MeterOptions["RegexUppercase"] as string))
            {
                Point += 20;
            }

            return Point;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static string GetSpecial(ESPT Mode)
        {
            return Mode switch
            {
                ESPT.None => string.Empty,
                ESPT.Number => MPM.Number,
                ESPT.Symbol => MPM.Symbol,
                _ => MPM.Number + MPM.Symbol,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static string GetAlphabetic(EAPT Mode)
        {
            return Mode switch
            {
                EAPT.Big => MPM.Big,
                EAPT.None => string.Empty,
                EAPT.Small => MPM.Small,
                _ => MPM.Big + MPM.Small,
            };
        }
    }
}