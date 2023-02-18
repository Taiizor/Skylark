using MPPM = Skylark.Manage.Ping.PingManage;
using SNNIP = System.Net.NetworkInformation.Ping;
using SNNIPO = System.Net.NetworkInformation.PingOptions;

namespace Skylark.Manage
{
    /// <summary>
    /// 
    /// </summary>
    public static class External
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly SNNIP Ping = new();

        /// <summary>
        /// 
        /// </summary>
        public static readonly Random Randomise = new();

        /// <summary>
        /// 
        /// </summary>
        public static SNNIPO PingOptions = new(MPPM.Ttl, MPPM.Fragment);

        /// <summary>
        /// 
        /// </summary>
        public const StringSplitOptions SplitOption = StringSplitOptions.None;
    }
}