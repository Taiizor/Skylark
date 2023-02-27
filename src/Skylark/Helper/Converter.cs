using SEAPT = Skylark.Enum.AlphabeticPasswordType;
using SECNT = Skylark.Enum.ClearNumericType;
using SECWT = Skylark.Enum.CompressWebType;
using SEHWT = Skylark.Enum.HttpWebType;
using SEMST = Skylark.Enum.ModeStorageType;
using SEQDT = Skylark.Enum.QueryDomainType;
using SESLPT = Skylark.Enum.SpecialPasswordType;
using SESRPT = Skylark.Enum.SimilarPasswordType;
using SEST = Skylark.Enum.StorageType;
using SETET = Skylark.Enum.TimeType;
using SETXT = Skylark.Enum.TaxType;
using SHN = Skylark.Helper.Numeric;

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
        public static SEST Convert(string Type, SEST Back = SEST.Bit)
        {
            foreach (SEST Types in (SEST[])System.Enum.GetValues(typeof(SEST)))
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
        public static SEQDT Convert(string Type, SEQDT Back = SEQDT.TXT)
        {
            foreach (SEQDT Types in (SEQDT[])System.Enum.GetValues(typeof(SEQDT)))
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
        public static SECNT Convert(string Type, SECNT Back = SHN.ClearType)
        {
            foreach (SECNT Types in (SECNT[])System.Enum.GetValues(typeof(SECNT)))
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
        public static SEMST Convert(string Type, SEMST Back = SEMST.Toucan)
        {
            foreach (SEMST Types in (SEMST[])System.Enum.GetValues(typeof(SEMST)))
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
        public static SETET Convert(string Type, SETET Back = SETET.Attosecond)
        {
            foreach (SETET Types in (SETET[])System.Enum.GetValues(typeof(SETET)))
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
        public static SETXT Convert(string Type, SETXT Back = SETXT.Amount)
        {
            foreach (SETXT Types in (SETXT[])System.Enum.GetValues(typeof(SETXT)))
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
        public static SESRPT Convert(string Type, SESRPT Back = SESRPT.Jaccard)
        {
            foreach (SESRPT Types in (SESRPT[])System.Enum.GetValues(typeof(SESRPT)))
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
        public static SESLPT Convert(string Type, SESLPT Back = SESLPT.Mixed)
        {
            foreach (SESLPT Types in (SESLPT[])System.Enum.GetValues(typeof(SESLPT)))
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
        public static SECWT Convert(string Type, SECWT Back = SECWT.None)
        {
            foreach (SECWT Types in (SECWT[])System.Enum.GetValues(typeof(SECWT)))
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
        public static SEHWT Convert(string Type, SEHWT Back = SEHWT.POST)
        {
            foreach (SEHWT Types in (SEHWT[])System.Enum.GetValues(typeof(SEHWT)))
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
        public static SEAPT Convert(string Type, SEAPT Back = SEAPT.Mixed)
        {
            foreach (SEAPT Types in (SEAPT[])System.Enum.GetValues(typeof(SEAPT)))
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