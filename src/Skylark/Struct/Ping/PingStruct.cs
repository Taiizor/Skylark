using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Skylark.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PingSendStruct
    {
        public IPStatus Result;
        public string Address;
        public long RoundTrip;
        public bool Fragment;
        public int Buffer;
        public int Ttl;
    }
}