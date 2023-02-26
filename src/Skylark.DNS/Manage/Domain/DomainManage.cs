using DCQT = DnsClient.QueryType;
using EQDT = Skylark.DNS.Enum.QueryDomainType;

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
        public const EQDT QueryType = EQDT.TXT;

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