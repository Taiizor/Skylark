using System.Net;
using System.Runtime.InteropServices;

namespace Skylark.Struct
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WebRatioStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public string Total;
        /// <summary>
        /// 
        /// </summary>
        public string Text;
        /// <summary>
        /// 
        /// </summary>
        public string Code;
        /// <summary>
        /// 
        /// </summary>
        public string Rate;
    }

    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WebHeaderStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public HttpStatusCode Status;
        /// <summary>
        /// 
        /// </summary>
        public Version Version;
        /// <summary>
        /// 
        /// </summary>
        public string Modified;
        /// <summary>
        /// 
        /// </summary>
        public string Security;
        /// <summary>
        /// 
        /// </summary>
        public TimeSpan? Age;
        /// <summary>
        /// 
        /// </summary>
        public string Server;
        /// <summary>
        /// 
        /// </summary>
        public string Ranges;
        /// <summary>
        /// 
        /// </summary>
        public string Reason;
        /// <summary>
        /// 
        /// </summary>
        public string Length;
        /// <summary>
        /// 
        /// </summary>
        public string Cookie;
        /// <summary>
        /// 
        /// </summary>
        public bool Success;
        /// <summary>
        /// 
        /// </summary>
        public string Cache;
        /// <summary>
        /// 
        /// </summary>
        public string Vary;
        /// <summary>
        /// 
        /// </summary>
        public string ETag;
        /// <summary>
        /// 
        /// </summary>
        public string Type;
        /// <summary>
        /// 
        /// </summary>
        public string Date;
    }
}