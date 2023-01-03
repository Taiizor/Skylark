using System.Net;
using System.Runtime.InteropServices;

namespace Skylark.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WebRatioStruct
    {
        public string Total;
        public string Text;
        public string Code;
        public string Rate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WebHeaderStruct
    {
        public HttpStatusCode Status;
        public Version Version;
        public string Modified;
        public string Security;
        public TimeSpan? Age;
        public string Server;
        public string Ranges;
        public string Reason;
        public string Length;
        public string Cookie;
        public bool Success;
        public string Cache;
        public string Vary;
        public string ETag;
        public string Type;
        public string Date;
    }
}