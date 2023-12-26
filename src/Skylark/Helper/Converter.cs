using EAFT = Skylark.Enum.AncestorFlagsType;
using EAPT = Skylark.Enum.AlphabeticPasswordType;
using ECAT = Skylark.Enum.CompositionActionsType;
using ECNT = Skylark.Enum.ClearNumericType;
using ECT = Skylark.Enum.CountryType;
using ECWT = Skylark.Enum.CompressWebType;
using EHWT = Skylark.Enum.HttpWebType;
using EMST = Skylark.Enum.ModeStorageType;
using EOST = Skylark.Enum.OperatingSystemType;
using EQDT = Skylark.Enum.QueryDomainType;
using ESCT = Skylark.Enum.SortedCountryType;
using ESLPT = Skylark.Enum.SpecialPasswordType;
using ESRPT = Skylark.Enum.SimilarPasswordType;
using ESST = Skylark.Enum.ShortStorageType;
using EST = Skylark.Enum.StorageType;
using ESTT = Skylark.Enum.ShortTimeType;
using ETET = Skylark.Enum.TimeType;
using ETFT = Skylark.Enum.TimeoutFlagsType;
using ETXT = Skylark.Enum.TaxType;
using EVT = Skylark.Enum.VersionType;
using EWPFT = Skylark.Enum.WindowPosFlagsType;
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
        public static ECT Convert(string Type, ECT Back = ECT.AF)
        {
            foreach (ECT Types in (ECT[])System.Enum.GetValues(typeof(ECT)))
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
        public static EVT Convert(string Type, EVT Back = EVT.Equal)
        {
            foreach (EVT Types in (EVT[])System.Enum.GetValues(typeof(EVT)))
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
        public static EOST Convert(string Type, EOST Back = EOST.Unknown)
        {
            foreach (EOST Types in (EOST[])System.Enum.GetValues(typeof(EOST)))
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
        public static ESCT Convert(string Type, ESCT Back = ESCT.AD)
        {
            foreach (ESCT Types in (ESCT[])System.Enum.GetValues(typeof(ESCT)))
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
        public static EAFT Convert(string Type, EAFT Back = EAFT.GetParent)
        {
            foreach (EAFT Types in (EAFT[])System.Enum.GetValues(typeof(EAFT)))
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
        public static ETFT Convert(string Type, ETFT Back = ETFT.SMTO_NORMAL)
        {
            foreach (ETFT Types in (ETFT[])System.Enum.GetValues(typeof(ETFT)))
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
        public static ECAT Convert(string Type, ECAT Back = ECAT.DWM_EC_DISABLECOMPOSITION)
        {
            foreach (ECAT Types in (ECAT[])System.Enum.GetValues(typeof(ECAT)))
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
        public static ESST Convert(string Type, ESST Back = ESST.b)
        {
            foreach (ESST Types in (ESST[])System.Enum.GetValues(typeof(ESST)))
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
        public static ESTT Convert(string Type, ESTT Back = ESTT.aѕ)
        {
            foreach (ESTT Types in (ESST[])System.Enum.GetValues(typeof(ESTT)))
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
        public static EWPFT Convert(string Type, EWPFT Back = EWPFT.SWP_ASYNCWINDOWPOS)
        {
            foreach (EWPFT Types in (EWPFT[])System.Enum.GetValues(typeof(EWPFT)))
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