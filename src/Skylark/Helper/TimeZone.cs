using ETZT = Skylark.Enum.TimeZoneType;
using MI = Skylark.Manage.Internal;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class TimeZone
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Zone"></param>
        /// <returns></returns>
        public static string Name(ETZT Zone)
        {
            if (MI.TimeZoneNames.TryGetValue(Zone, out string Name))
            {
                return Name;
            }

            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Zone"></param>
        /// <returns></returns>
        public static async Task<string> NameAsync(ETZT Zone)
        {
            return await Task.Run(() => Name(Zone));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Zone"></param>
        /// <returns></returns>
        public static string ShortName(ETZT Zone)
        {
            if (MI.TimeZoneShortNames.TryGetValue(Zone, out string Name))
            {
                return Name;
            }

            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Zone"></param>
        /// <returns></returns>
        public static async Task<string> ShortNameAsync(ETZT Zone)
        {
            return await Task.Run(() => ShortName(Zone));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Zone"></param>
        /// <returns></returns>
        public static string CleanShortName(ETZT Zone)
        {
            if (MI.TimeZoneShortNames.TryGetValue(Zone, out string Name))
            {
                return Name.Replace("(", "").Replace(")", "");
            }

            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Zone"></param>
        /// <returns></returns>
        public static async Task<string> CleanShortNameAsync(ETZT Zone)
        {
            return await Task.Run(() => CleanShortName(Zone));
        }
    }
}