using SETT = Skylark.Enum.TimeType;
using SSMTTM = Skylark.Standard.Manage.Time.TimeManage;

namespace Skylark.Standard.Helper.Time
{
    /// <summary>
    /// 
    /// </summary>
    internal static class TimeHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <returns></returns>
        public static double GetValue(SETT Input, SETT Output)
        {
            return SSMTTM.Converter[Input][Output];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value1"></param>
        /// <param name="Value2"></param>
        /// <returns></returns>
        public static double GetCalc(double Value1, double Value2)
        {
            return Value1 * Value2;
        }
    }
}