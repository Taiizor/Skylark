using SE = Skylark.Exception;
using SMI = Skylark.Manage.Internal;
using SSMDDM = Skylark.Standard.Manage.Decompression.DecompressionManage;

namespace Skylark.Standard.Helper.Decompression
{
    /// <summary>
    /// 
    /// </summary>
    internal static class DecompressionHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        /// <exception cref="SE"></exception>
        public static void DataControl(byte[] Data)
        {
            long Byte = Data.Length;

            if (Byte > SMI.ByteLength)
            {
                throw new SE(SSMDDM.Length);
            }
        }
    }
}