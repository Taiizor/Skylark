using MSM = Skylark.Manage.StorageManage;
using EST = Skylark.Enum.StorageType;

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
    }
}