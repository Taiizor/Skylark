using SSCCS = Skylark.Struct.Certificate.CertificateStruct;

namespace Skylark.Standard.Manage.Certificate
{
    /// <summary>
    /// 
    /// </summary>
    internal static class CertificateManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const int Timeout = 3000;
        /// <summary>
        /// 
        /// </summary>
        public const int MinTimeout = 100;
        /// <summary>
        /// 
        /// </summary>
        public const int MaxTimeout = 9000;

        /// <summary>
        /// 
        /// </summary>
        public const string Address = "www.google.com";

        /// <summary>
        /// 
        /// </summary>
        public static readonly SSCCS Result = new()
        {
            ExpirationDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            RemainingDays = -1,
            State = false
        };
    }
}