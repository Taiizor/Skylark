using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Skylark.Struct.Ping
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PingSendStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public IPStatus Result;
        /// <summary>
        /// 
        /// </summary>
        public string Address;
        /// <summary>
        /// 
        /// </summary>
        public long RoundTrip;
        /// <summary>
        /// 
        /// </summary>
        public bool Fragment;
        /// <summary>
        /// 
        /// </summary>
        public int Buffer;
        /// <summary>
        /// 
        /// </summary>
        public int Ttl;
    }
}