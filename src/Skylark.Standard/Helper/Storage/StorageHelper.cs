using SEMST = Skylark.Enum.ModeStorageType;
using SEST = Skylark.Enum.StorageType;
using SSMSSM = Skylark.Standard.Manage.Storage.StorageManage;

namespace Skylark.Standard.Helper.Storage
{
    /// <summary>
    /// 
    /// </summary>
    internal static class StorageHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static double GetValue(SEST Input, SEST Output, SEMST Mode)
        {
            return SSMSSM.Converter[Mode][Input][Output];
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