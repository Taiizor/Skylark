using EST = Skylark.Enum.StorageType;
using MSM = Skylark.Manage.StorageManage;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class StorageHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <returns></returns>
        public static decimal GetValue(EST Input, EST Output)
        {
            return MSM.Converter[Input][Output];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value1"></param>
        /// <param name="Value2"></param>
        /// <returns></returns>
        public static decimal GetCalc(decimal Value1, decimal Value2)
        {
            return Value1 * Value2;
        }
    }
}