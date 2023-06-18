using System.Runtime.InteropServices;
using HS = Skylark.Helper.Skymath;

namespace Skylark.Struct.Colorise
{
    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct ColoriseStruct(byte R, byte G, byte B)
    {
        /// <summary>
        /// 
        /// </summary>
        public readonly byte R = R;
        /// <summary>
        /// 
        /// </summary>
        public readonly byte G = G;
        /// <summary>
        /// 
        /// </summary>
        public readonly byte B = B;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Other"></param>
        /// <param name="Weight"></param>
        /// <returns></returns>
        public ColoriseStruct Lerp(ColoriseStruct Other, double Weight)
        {
            byte R, G, B;

            checked
            {
                R = (byte)HS.Lerp(this.R, Other.R, Weight);
                G = (byte)HS.Lerp(this.G, Other.G, Weight);
                B = (byte)HS.Lerp(this.B, Other.B, Weight);
            }

            return new ColoriseStruct(R, G, B);
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