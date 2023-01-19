using ETT = Skylark.Enum.TimeType;
using MTM = Skylark.Manage.TimeManage;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class TimeHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <returns></returns>
        public static double GetValue(ETT Input, ETT Output)
        {
            return MTM.Converter[Input][Output];
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