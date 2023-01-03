using System.Net.NetworkInformation;
using MPM = Skylark.Manage.PingManage;

namespace Skylark.Manage
{
    public class External
    {
        public static readonly Ping Ping = new();

        public static readonly Random Randomise = new();

        public static PingOptions PingOptions = new(MPM.Ttl, MPM.Fragment);

        public const StringSplitOptions SplitOption = StringSplitOptions.None;
    }
}