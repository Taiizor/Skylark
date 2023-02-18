using E = Skylark.Exception;
using EAPT = Skylark.Enum.AlphabeticPasswordType;
using EMPT = Skylark.Enum.MeterPasswordType;
using ESPT = Skylark.Enum.SpecialPasswordType;
using HC = Skylark.Helper.Converter;
using HL = Skylark.Helper.Length;
using HPPH = Skylark.Helper.Password.PasswordHelper;
using ME = Skylark.Manage.External;
using MPPM = Skylark.Manage.Password.PasswordManage;

namespace Skylark.Extension.Password
{
    /// <summary>
    /// 
    /// </summary>
    public static class PasswordExtension
    {
        public static EMPT Meter(string Password = MPPM.Password)
        {
            try
            {
                return HPPH.GetMeter(HL.Parameter(Password, MPPM.Password));
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static Task<EMPT> MeterAsync(string Password = MPPM.Password)
        {
            return Task.Run(() => Meter(Password));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Length"></param>
        /// <param name="Alphabetic"></param>
        /// <param name="Special"></param>
        /// <param name="Prefix"></param>
        /// <param name="Suffix"></param>
        /// <returns></returns>
        public static string Generate(int Length = MPPM.Length, string Alphabetic = MPPM.DefaultType, string Special = MPPM.DefaultType, string Prefix = MPPM.Prefix, string Suffix = MPPM.Suffix)
        {
            return Generate(Length, HC.Convert(Alphabetic, MPPM.AlphabeticType), HC.Convert(Special, MPPM.SpecialType), Prefix, Suffix);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Length"></param>
        /// <param name="Alphabetic"></param>
        /// <param name="Special"></param>
        /// <param name="Prefix"></param>
        /// <param name="Suffix"></param>
        /// <returns></returns>
        public static Task<string> GenerateAsync(int Length = MPPM.Length, string Alphabetic = MPPM.DefaultType, string Special = MPPM.DefaultType, string Prefix = MPPM.Prefix, string Suffix = MPPM.Suffix)
        {
            return Task.Run(() => Generate(Length, Alphabetic, Special, Prefix, Suffix));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Length"></param>
        /// <param name="Alphabetic"></param>
        /// <param name="Special"></param>
        /// <param name="Prefix"></param>
        /// <param name="Suffix"></param>
        /// <returns></returns>
        public static string Generate(int Length = MPPM.Length, EAPT Alphabetic = MPPM.AlphabeticType, ESPT Special = MPPM.SpecialType, string Prefix = MPPM.Prefix, string Suffix = MPPM.Suffix)
        {
            try
            {
                Prefix = HL.Parameter(Prefix, MPPM.Prefix);
                Suffix = HL.Parameter(Suffix, MPPM.Suffix);

                string Chars = HPPH.GetAlphabetic(Alphabetic) + HPPH.GetSpecial(Special);

                if (Chars.Length <= 0)
                {
                    throw new E(MPPM.Error);
                }

                string Secret = new(Enumerable.Repeat(Chars, HL.Clamp(Length, MPPM.MinLength, MPPM.MaxLength))
                    .Select(Char => Char[ME.Randomise.Next(Char.Length)]).ToArray());

                return Prefix + Secret + Suffix;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Length"></param>
        /// <param name="Alphabetic"></param>
        /// <param name="Special"></param>
        /// <param name="Prefix"></param>
        /// <param name="Suffix"></param>
        /// <returns></returns>
        public static Task<string> GenerateAsync(int Length = MPPM.Length, EAPT Alphabetic = MPPM.AlphabeticType, ESPT Special = MPPM.SpecialType, string Prefix = MPPM.Prefix, string Suffix = MPPM.Suffix)
        {
            return Task.Run(() => Generate(Length, Alphabetic, Special, Prefix, Suffix));
        }
    }
}