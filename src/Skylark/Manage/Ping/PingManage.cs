using System.Net.NetworkInformation;
using System.Text;
using SPSS = Skylark.Struct.PingSendStruct;

namespace Skylark.Manage
{
    internal class PingManage
    {
        public const int Ttl = 64;
        public const int MinTtl = 30;
        public const int MaxTtl = 255;

        public const int Timeout = 3000;
        public const int MinTimeout = 300;
        public const int MaxTimeout = 6000;

        public const bool Fragment = true;

        public const string Address = "www.google.com";

        public const string Data = "SoferityPortal_Ping_Package_Data";

        public static readonly byte[] Buffer = Encoding.ASCII.GetBytes(Data);

        public static readonly SPSS Result = new()
        {
            Result = IPStatus.Unknown,
            Fragment = Fragment,
            Address = Address,
            RoundTrip = 0,
            Buffer = 0,
            Ttl = 0
        };
    }
}