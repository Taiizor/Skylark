using DCQT = DnsClient.QueryType;
using SDNSMDDM = Skylark.DNS.Manage.Domain.DomainManage;
using SEQDT = Skylark.Enum.QueryDomainType;

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
        public static SEQDT Convert(DCQT Type, SEQDT Back = SDNSMDDM.QueryType)
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
        public static DCQT Convert(SEQDT Type, DCQT Back = SDNSMDDM.DefaultType)
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
