using System.Diagnostics;
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

        /// <summary>
        /// If more password strengths are removed, this will compute it automatically
        /// </summary>
        private static readonly int LowestPasswordStrength = typeof(EMPT)
            .GetEnumValues()
            .Cast<int>()
            .Min();

        /// <summary>
        /// If more password strengths are added, this will compute it automatically
        /// </summary>
        private static readonly int HighestPasswordStrength = typeof(EMPT)
            .GetEnumValues()
            .Cast<int>()
            .Max();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MeterPasswordType"></param>
        /// <returns></returns>
        private static EMPT UpgradeMeterLevel(this EMPT MeterPasswordType)
        {
            int Result = (int)MeterPasswordType + 20;

            Skymath.Clamp(Result, LowestPasswordStrength, HighestPasswordStrength);
            Debug.Assert(Result % 20 == 0);
            return (EMPT)Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MeterPasswordType"></param>
        /// <returns></returns>
        private static EMPT DowngradeMeterLevel(this EMPT MeterPasswordType)
        {
            int Result = (int)MeterPasswordType - 20;

            Skymath.Clamp(Result, LowestPasswordStrength, HighestPasswordStrength);
            Debug.Assert(Result % 20 == 0);
            return (EMPT)Result;
        }
    }
}