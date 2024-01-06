using SE = Skylark.Exception;
using SHTZ = Skylark.Helper.TimeZone;
using SETZT = Skylark.Enum.TimeZoneType;
using SSMTZTZM = Skylark.Standard.Manage.TimeZone.TimeZoneManage;

namespace Skylark.Standard.Extension.TimeZone
{
    /// <summary>
    /// 
    /// </summary>
    public static class TimeZoneExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="TimeOffset"></param>
        /// <param name="TimeZone"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static DateTimeOffset Convert(DateTimeOffset TimeOffset, SETZT TimeZone = SSMTZTZM.TimeZone)
        {
            try
            {
                TimeSpan ConvertTimeZone;

                string ShortTimeZone = SHTZ.CleanShortName(TimeZone);

                string[] SplitTimeZone = ShortTimeZone.Substring(3).Split(SSMTZTZM.Separators, StringSplitOptions.RemoveEmptyEntries);

                if (SplitTimeZone.Length >= 2 && int.TryParse(SplitTimeZone[0], out int Hour) && int.TryParse(SplitTimeZone[1], out int Minute))
                {
                    if (ShortTimeZone.Contains('-'))
                    {
                        ConvertTimeZone = -(TimeSpan.FromHours(Hour) + TimeSpan.FromMinutes(Minute));
                    }
                    else
                    {
                        ConvertTimeZone = TimeSpan.FromHours(Hour) + TimeSpan.FromMinutes(Minute);
                    }
                }
                else
                {
                    return SSMTZTZM.DateOffsetUtc;
                }

                return TimeOffset.ToOffset(ConvertTimeZone);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TimeOffset"></param>
        /// <param name="TimeZone"></param>
        /// <returns></returns>
        public static async Task<DateTimeOffset> ConvertAsync(DateTimeOffset TimeOffset, SETZT TimeZone = SSMTZTZM.TimeZone)
        {
            return await Task.Run(() => Convert(TimeOffset, TimeZone));
        }
    }
}