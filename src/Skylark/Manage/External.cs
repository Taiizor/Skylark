using System.Net.NetworkInformation;
using MPM = Skylark.Manage.Ping.PingManage;

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
        public static readonly Ping Ping = new();

        /// <summary>
        /// 
        /// </summary>
        public static readonly Random Randomise = new();

        /// <summary>
        /// 
        /// </summary>
        public static PingOptions PingOptions = new(MPM.Ttl, MPM.Fragment);

        /// <summary>
        /// 
        /// </summary>
        public const StringSplitOptions SplitOption = StringSplitOptions.None;
    }
}