using EAPT = Skylark.Enum.AlphabeticPasswordType;
using ECWT = Skylark.Enum.CompressWebType;
using ESPT = Skylark.Enum.SpecialPasswordType;
using EST = Skylark.Enum.StorageType;
using ETT = Skylark.Enum.TaxType;
using MPM = Skylark.Manage.PasswordManage;
using MSM = Skylark.Manage.StorageManage;
using MTM = Skylark.Manage.TaxManage;
using MWM = Skylark.Manage.WebManage;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class Converter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static EST Convert(string Type, EST Back = MSM.InputType)
        {
            foreach (EST Types in (EST[])System.Enum.GetValues(typeof(EST)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static ETT Convert(string Type, ETT Back = MTM.TaxType)
        {
            foreach (ETT Types in (ETT[])System.Enum.GetValues(typeof(ETT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static ESPT Convert(string Type, ESPT Back = MPM.SpecialType)
        {
            foreach (ESPT Types in (ESPT[])System.Enum.GetValues(typeof(ESPT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static ECWT Convert(string Type, ECWT Back = MWM.CompressType)
        {
            foreach (ECWT Types in (ECWT[])System.Enum.GetValues(typeof(ECWT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static EAPT Convert(string Type, EAPT Back = MPM.AlphabeticType)
        {
            foreach (EAPT Types in (EAPT[])System.Enum.GetValues(typeof(EAPT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        private static bool Check(object Text, object Type)
        {
            return Check($"{Text}", $"{Type}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        private static bool Check(string Text, string Type)
        {
            if (Text == Type || Text.ToUpper() == Type || Text.ToUpperInvariant() == Type || Text == Type.ToLower() || Text == Type.ToLowerInvariant())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}