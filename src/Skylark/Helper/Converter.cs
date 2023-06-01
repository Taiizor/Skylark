using EAPT = Skylark.Enum.AlphabeticPasswordType;
using ECNT = Skylark.Enum.ClearNumericType;
using ECWT = Skylark.Enum.CompressWebType;
using EHWT = Skylark.Enum.HttpWebType;
using EMST = Skylark.Enum.ModeStorageType;
using EQDT = Skylark.Enum.QueryDomainType;
using ESLPT = Skylark.Enum.SpecialPasswordType;
using ESRPT = Skylark.Enum.SimilarPasswordType;
using EST = Skylark.Enum.StorageType;
using ETET = Skylark.Enum.TimeType;
using ETXT = Skylark.Enum.TaxType;
using HN = Skylark.Helper.Numeric;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Converter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static EST Convert(string Type, EST Back = EST.Bit)
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
        public static EQDT Convert(string Type, EQDT Back = EQDT.TXT)
        {
            foreach (EQDT Types in (EQDT[])System.Enum.GetValues(typeof(EQDT)))
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
        public static ECNT Convert(string Type, ECNT Back = HN.ClearType)
        {
            foreach (ECNT Types in (ECNT[])System.Enum.GetValues(typeof(ECNT)))
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
        public static EMST Convert(string Type, EMST Back = EMST.Toucan)
        {
            foreach (EMST Types in (EMST[])System.Enum.GetValues(typeof(EMST)))
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
        public static ETET Convert(string Type, ETET Back = ETET.Attosecond)
        {
            foreach (ETET Types in (ETET[])System.Enum.GetValues(typeof(ETET)))
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
        public static ETXT Convert(string Type, ETXT Back = ETXT.Amount)
        {
            foreach (ETXT Types in (ETXT[])System.Enum.GetValues(typeof(ETXT)))
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
        public static ESRPT Convert(string Type, ESRPT Back = ESRPT.Jaccard)
        {
            foreach (ESRPT Types in (ESRPT[])System.Enum.GetValues(typeof(ESRPT)))
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
        public static ESLPT Convert(string Type, ESLPT Back = ESLPT.Mixed)
        {
            foreach (ESLPT Types in (ESLPT[])System.Enum.GetValues(typeof(ESLPT)))
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
        public static ECWT Convert(string Type, ECWT Back = ECWT.None)
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
        public static EHWT Convert(string Type, EHWT Back = EHWT.POST)
        {
            foreach (EHWT Types in (EHWT[])System.Enum.GetValues(typeof(EHWT)))
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
        public static EAPT Convert(string Type, EAPT Back = EAPT.Mixed)
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