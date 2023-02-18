using ETT = Skylark.Enum.TimeType;
using MTTM = Skylark.Manage.Time.TimeManage;

namespace Skylark.Helper.Time
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
        public static double GetValue(ETT Input, ETT Output)
        {
            return MTTM.Converter[Input][Output];
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