using SETZT = Skylark.Enum.TimeZoneType;

namespace Skylark.Standard.Manage.TimeZone
{
    /// <summary>
    /// 
    /// </summary>
    internal static class TimeZoneManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const SETZT TimeZone = SETZT.GMT_Plus_00_00_UTC;

        /// <summary>
        /// 
        /// </summary>
        public static readonly char[] Separators = new[] { ':', '-' };

        /// <summary>
        /// 
        /// </summary>
        public static DateTimeOffset DateOffsetNow => DateTimeOffset.Now;
        /// <summary>
        /// 
        /// </summary>
        public static DateTimeOffset DateOffsetUtc => DateTimeOffset.UtcNow;
    }
}