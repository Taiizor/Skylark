using System.Runtime.InteropServices;

namespace Skylark.Struct.Certificate
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CertificateStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public bool State;
        /// <summary>
        /// 
        /// </summary>
        public int RemainingDays;
        /// <summary>
        /// 
        /// </summary>
        public DateTime ExpirationDateTime;
    }
}