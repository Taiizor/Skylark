using E = Skylark.Exception;
using EAPT = Skylark.Enum.AlphabeticPasswordType;
using EMPT = Skylark.Enum.MeterPasswordType;
using ESPT = Skylark.Enum.SpecialPasswordType;
using HC = Skylark.Helper.Converter;
using HL = Skylark.Helper.Length;
using HPH = Skylark.Helper.PasswordHelper;
using ME = Skylark.Manage.External;
using MPM = Skylark.Manage.PasswordManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public static class PasswordExtension
    {
        public static EMPT Meter(string Password = MPM.Password)
        {
            try
            {
                return HPH.GetMeter(HL.Parameter(Password, MPM.Password));
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
        public static Task<EMPT> MeterAsync(string Password = MPM.Password)
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
        public static string Generate(int Length = MPM.Length, string Alphabetic = MPM.DefaultType, string Special = MPM.DefaultType, string Prefix = MPM.Prefix, string Suffix = MPM.Suffix)
        {
            return Generate(Length, HC.Convert(Alphabetic, MPM.AlphabeticType), HC.Convert(Special, MPM.SpecialType), Prefix, Suffix);
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
        public static Task<string> GenerateAsync(int Length = MPM.Length, string Alphabetic = MPM.DefaultType, string Special = MPM.DefaultType, string Prefix = MPM.Prefix, string Suffix = MPM.Suffix)
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
        public static string Generate(int Length = MPM.Length, EAPT Alphabetic = MPM.AlphabeticType, ESPT Special = MPM.SpecialType, string Prefix = MPM.Prefix, string Suffix = MPM.Suffix)
        {
            try
            {
                Prefix = HL.Parameter(Prefix, MPM.Prefix);
                Suffix = HL.Parameter(Suffix, MPM.Suffix);

                string Chars = HPH.GetAlphabetic(Alphabetic) + HPH.GetSpecial(Special);

                if (Chars.Length <= 0)
                {
                    throw new E(MPM.Error);
                }

                string Secret = new(Enumerable.Repeat(Chars, HL.Clamp(Length, MPM.MinLength, MPM.MaxLength))
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
        public static Task<string> GenerateAsync(int Length = MPM.Length, EAPT Alphabetic = MPM.AlphabeticType, ESPT Special = MPM.SpecialType, string Prefix = MPM.Prefix, string Suffix = MPM.Suffix)
        {
            return Task.Run(() => Generate(Length, Alphabetic, Special, Prefix, Suffix));
        }
    }
}