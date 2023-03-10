using System.Runtime.InteropServices;

namespace Skylark.Struct.Colorise
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct ColoriseStruct
    {
        /// <summary>
        /// 
        /// </summary>
        public readonly byte R;
        /// <summary>
        /// 
        /// </summary>
        public readonly byte G;
        /// <summary>
        /// 
        /// </summary>
        public readonly byte B;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R"></param>
        /// <param name="G"></param>
        /// <param name="B"></param>
        public ColoriseStruct(byte R, byte G, byte B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int ToInt()
        {
            int N = 0;
            N += R;
            N <<= 8;
            N += G;
            N <<= 8;
            N += B;
            return N;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToHex()
        {
            return $"0x{ToInt():X}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{nameof(R)}: {R}, {nameof(G)}: {G}, {nameof(B)}: {B} ({ToHex()})";
        }
    }
}