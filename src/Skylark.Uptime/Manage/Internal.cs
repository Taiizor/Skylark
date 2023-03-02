using SSCCS = Skylark.Struct.Certificate.CertificateStruct;

namespace Skylark.Uptime.Manage
{
    /// <summary>
    /// 
    /// </summary>
    internal static class Internal
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly SSCCS CertificateStruct = new()
        {
            State = false,
            RemainingDays = -1,
            ExpirationDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
        };
    }
}