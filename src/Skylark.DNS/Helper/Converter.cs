using DCQT = DnsClient.QueryType;
using EQDT = Skylark.DNS.Enum.QueryDomainType;
using MDDM = Skylark.DNS.Manage.Domain.DomainManage;

namespace Skylark.DNS.Helper
{
    internal static class Converter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static EQDT Convert(DCQT Type, EQDT Back = MDDM.QueryType)
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
        public static DCQT Convert(EQDT Type, DCQT Back = MDDM.DefaultType)
        {
            foreach (DCQT Types in (DCQT[])System.Enum.GetValues(typeof(DCQT)))
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
