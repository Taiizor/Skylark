using System.Runtime.InteropServices;
using EST = Skylark.Enum.StorageType;

namespace Skylark.Struct
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct StorageStruct
    {
        public decimal Value;
        public string Text;
        public EST Type;
    }
}