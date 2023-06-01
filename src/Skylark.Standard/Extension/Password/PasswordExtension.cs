using E = Skylark.Exception;
using EAPT = Skylark.Enum.AlphabeticPasswordType;
using EMPT = Skylark.Enum.MeterPasswordType;
using ESLPT = Skylark.Enum.SpecialPasswordType;
using ESRPT = Skylark.Enum.SimilarPasswordType;
using HC = Skylark.Helper.Converter;
using HL = Skylark.Helper.Length;
using HPPH = Skylark.Standard.Helper.Password.PasswordHelper;
using ME = Skylark.Standard.Manage.External;
using MPPM = Skylark.Standard.Manage.Password.PasswordManage;

namespace Skylark.Standard.Extension.Password
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
        public static async Task<EMPT> MeterAsync(string Password = MPPM.Password)
        {
            return await Task.Run(() => Meter(Password));
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
        public static async Task<string> GenerateAsync(int Length = MPPM.Length, string Alphabetic = MPPM.DefaultType, string Special = MPPM.DefaultType, string Prefix = MPPM.Prefix, string Suffix = MPPM.Suffix)
        {
            return await Task.Run(() => Generate(Length, Alphabetic, Special, Prefix, Suffix));
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
        public static string Generate(int Length = MPPM.Length, EAPT Alphabetic = MPPM.AlphabeticType, ESLPT Special = MPPM.SpecialType, string Prefix = MPPM.Prefix, string Suffix = MPPM.Suffix)
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
        public static async Task<string> GenerateAsync(int Length = MPPM.Length, EAPT Alphabetic = MPPM.AlphabeticType, ESLPT Special = MPPM.SpecialType, string Prefix = MPPM.Prefix, string Suffix = MPPM.Suffix)
        {
            return await Task.Run(() => Generate(Length, Alphabetic, Special, Prefix, Suffix));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password1"></param>
        /// <param name="Password2"></param>
        /// <param name="Similar"></param>
        /// <returns></returns>
        public static string Similarity(string Password1 = MPPM.Password, string Password2 = MPPM.Password, string Similar = MPPM.DefaultType)
        {
            return Similarity(Password1, Password2, HC.Convert(Similar, MPPM.SimilarType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password1"></param>
        /// <param name="Password2"></param>
        /// <param name="Similar"></param>
        /// <returns></returns>
        public static async Task<string> SimilarityAsync(string Password1 = MPPM.Password, string Password2 = MPPM.Password, string Similar = MPPM.DefaultType)
        {
            return await Task.Run(() => Similarity(Password1, Password2, Similar));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password1"></param>
        /// <param name="Password2"></param>
        /// <param name="Similar"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string Similarity(string Password1 = MPPM.Password, string Password2 = MPPM.Password, ESRPT Similar = MPPM.SimilarType)
        {
            try
            {
                Password1 = HL.Parameter(Password1, MPPM.Password);
                Password2 = HL.Parameter(Password2, MPPM.Password);

                return HPPH.GetPlaces(Math.Round(decimal.Parse($"{HPPH.GetSimilarity(Password1, Password2, Similar):P}".Replace("%", "")), 2), true);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        public static async Task<string> SimilarityAsync(string Password1 = MPPM.Password, string Password2 = MPPM.Password, ESRPT Similar = MPPM.SimilarType)
        {
            return await Task.Run(() => Similarity(Password1, Password2, Similar));
        }
    }
}