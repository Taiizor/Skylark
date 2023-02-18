using Skylark.Enum;
using System.Text.RegularExpressions;
using EAPT = Skylark.Enum.AlphabeticPasswordType;
using EMPT = Skylark.Enum.MeterPasswordType;
using ESPT = Skylark.Enum.SpecialPasswordType;
using MPPM = Skylark.Manage.Password.PasswordManage;

namespace Skylark.Helper.Password
{
    /// <summary>
    /// 
    /// </summary>
    internal static class PasswordHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static EMPT GetMeter(string Password)
        {
            EMPT Point = 0;

            if (Password.Length >= (int)MPPM.MeterOptions["MinLength"])
            {
                Point = Point.UpgradeMeterLevel();
            }

            if (Regex.IsMatch(Password, MPPM.MeterOptions["RegexDigit"] as string))
            {
                Point = Point.UpgradeMeterLevel();
            }

            if (Regex.IsMatch(Password, MPPM.MeterOptions["RegexSymbol"] as string))
            {
                Point = Point.UpgradeMeterLevel();
            }

            if (Regex.IsMatch(Password, MPPM.MeterOptions["RegexLowercase"] as string))
            {
                Point = Point.UpgradeMeterLevel();
            }

            if (Regex.IsMatch(Password, MPPM.MeterOptions["RegexUppercase"] as string))
            {
                Point = Point.UpgradeMeterLevel();
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
                ESPT.Number => MPPM.Number,
                ESPT.Symbol => MPPM.Symbol,
                _ => MPPM.Number + MPPM.Symbol,
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
                EAPT.Big => MPPM.Big,
                EAPT.None => string.Empty,
                EAPT.Small => MPPM.Small,
                _ => MPPM.Big + MPPM.Small,
            };
        }
    }
}