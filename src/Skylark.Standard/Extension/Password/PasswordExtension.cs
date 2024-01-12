using SE = Skylark.Exception;
using SEAPT = Skylark.Enum.AlphabeticPasswordType;
using SEMPT = Skylark.Enum.MeterPasswordType;
using SESLPT = Skylark.Enum.SpecialPasswordType;
using SESRPT = Skylark.Enum.SimilarPasswordType;
using SHC = Skylark.Helper.Converter;
using SHL = Skylark.Helper.Length;
using SSHPPH = Skylark.Standard.Helper.Password.PasswordHelper;
using SSME = Skylark.Standard.Manage.External;
using SSMPPM = Skylark.Standard.Manage.Password.PasswordManage;

namespace Skylark.Standard.Extension.Password
{
    /// <summary>
    /// 
    /// </summary>
    public static class PasswordExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static SEMPT Meter(string Password = SSMPPM.Password)
        {
            try
            {
                return SSHPPH.GetMeter(SHL.Parameter(Password, SSMPPM.Password));
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static async Task<SEMPT> MeterAsync(string Password = SSMPPM.Password)
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
        public static string Generate(int Length = SSMPPM.Length, string Alphabetic = SSMPPM.DefaultType, string Special = SSMPPM.DefaultType, string Prefix = SSMPPM.Prefix, string Suffix = SSMPPM.Suffix)
        {
            return Generate(Length, SHC.Convert(Alphabetic, SSMPPM.AlphabeticType), SHC.Convert(Special, SSMPPM.SpecialType), Prefix, Suffix);
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
        public static async Task<string> GenerateAsync(int Length = SSMPPM.Length, string Alphabetic = SSMPPM.DefaultType, string Special = SSMPPM.DefaultType, string Prefix = SSMPPM.Prefix, string Suffix = SSMPPM.Suffix)
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
        /// <exception cref="SE"></exception>
        public static string Generate(int Length = SSMPPM.Length, SEAPT Alphabetic = SSMPPM.AlphabeticType, SESLPT Special = SSMPPM.SpecialType, string Prefix = SSMPPM.Prefix, string Suffix = SSMPPM.Suffix)
        {
            try
            {
                Prefix = SHL.Parameter(Prefix, SSMPPM.Prefix);
                Suffix = SHL.Parameter(Suffix, SSMPPM.Suffix);

                string Chars = SSHPPH.GetAlphabetic(Alphabetic) + SSHPPH.GetSpecial(Special);

                if (Chars.Length <= 0)
                {
                    throw new SE(SSMPPM.Error);
                }

                string Secret = new(Enumerable.Repeat(Chars, SHL.Clamp(Length, SSMPPM.MinLength, SSMPPM.MaxLength)).Select(Char => Char[SSME.Randomise.Next(Char.Length)]).ToArray());

                return Prefix + Secret + Suffix;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        public static async Task<string> GenerateAsync(int Length = SSMPPM.Length, SEAPT Alphabetic = SSMPPM.AlphabeticType, SESLPT Special = SSMPPM.SpecialType, string Prefix = SSMPPM.Prefix, string Suffix = SSMPPM.Suffix)
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
        public static string Similarity(string Password1 = SSMPPM.Password, string Password2 = SSMPPM.Password, string Similar = SSMPPM.DefaultType)
        {
            return Similarity(Password1, Password2, SHC.Convert(Similar, SSMPPM.SimilarType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password1"></param>
        /// <param name="Password2"></param>
        /// <param name="Similar"></param>
        /// <returns></returns>
        public static async Task<string> SimilarityAsync(string Password1 = SSMPPM.Password, string Password2 = SSMPPM.Password, string Similar = SSMPPM.DefaultType)
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
        /// <exception cref="SE"></exception>
        public static string Similarity(string Password1 = SSMPPM.Password, string Password2 = SSMPPM.Password, SESRPT Similar = SSMPPM.SimilarType)
        {
            try
            {
                Password1 = SHL.Parameter(Password1, SSMPPM.Password);
                Password2 = SHL.Parameter(Password2, SSMPPM.Password);

                return SSHPPH.GetPlaces(Math.Round(decimal.Parse($"{SSHPPH.GetSimilarity(Password1, Password2, Similar):P}".Replace("%", "")), 2), true);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        public static async Task<string> SimilarityAsync(string Password1 = SSMPPM.Password, string Password2 = SSMPPM.Password, SESRPT Similar = SSMPPM.SimilarType)
        {
            return await Task.Run(() => Similarity(Password1, Password2, Similar));
        }
    }
}