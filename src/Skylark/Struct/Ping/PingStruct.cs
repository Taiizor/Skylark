using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Skylark.Struct
{
    /// <summary>
    /// 
    /// </summary>
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