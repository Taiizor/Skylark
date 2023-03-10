using EMST = Skylark.Enum.ModeStorageType;
using EST = Skylark.Enum.StorageType;
using MSSM = Skylark.Standard.Manage.Storage.StorageManage;

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
        public static double GetValue(EST Input, EST Output, EMST Mode)
        {
            return MSSM.Converter[Mode][Input][Output];
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