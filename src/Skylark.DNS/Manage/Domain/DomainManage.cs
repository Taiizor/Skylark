using DCQT = DnsClient.QueryType;
using SEQDT = Skylark.Enum.QueryDomainType;

namespace Skylark.DNS.Manage.Domain
{
    /// <summary>
    /// 
    /// </summary>
    internal static class DomainManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const SEQDT QueryType = SEQDT.TXT;

        /// <summary>
        /// 
        /// </summary>
        public const DCQT DefaultType = DCQT.TXT;

        /// <summary>
        /// 
        /// </summary>
        public const string Domain = "google.com";
    }
}