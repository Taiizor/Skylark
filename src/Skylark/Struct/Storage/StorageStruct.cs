using System.Runtime.InteropServices;
using ESST = Skylark.Enum.ShortStorageType;
using EST = Skylark.Enum.StorageType;

namespace Skylark.Struct.Storage
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct StorageStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public double Value;
        /// <summary>
        /// 
        /// </summary>
        public string Text;
        /// <summary>
        /// 
        /// </summary>
        public ESST Short;
        /// <summary>
        /// 
        /// </summary>
        public EST Type;
    }
}