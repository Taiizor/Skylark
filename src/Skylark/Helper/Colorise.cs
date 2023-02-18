using HS = Skylark.Helper.Skymath;
using SCCS = Skylark.Struct.Colorise.ColoriseStruct;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Colorise
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="RGB"></param>
        /// <param name="Other"></param>
        /// <returns></returns>
        public static SCCS ToBlend(this SCCS RGB, SCCS Other)
        {
            byte R = BlendToAvg(RGB.R, Other.R);
            byte G = BlendToAvg(RGB.G, Other.G);
            byte B = BlendToAvg(RGB.B, Other.B);

            return new SCCS(R, G, B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="RGB"></param>
        /// <param name="Other"></param>
        /// <returns></returns>
        public static Task<SCCS> ToBlendAsync(this SCCS RGB, SCCS Other)
        {
            return Task.Run(() => ToBlend(RGB, Other));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="B1"></param>
        /// <param name="B2"></param>
        /// <returns></returns>
        private static byte BlendToAvg(byte B1, byte B2)
        {
            byte[] Bytes = new[]
            {
                B1,
                B2
            };

            float Result = HS.Average(Bytes, 0, (X, Y) => X + Y, (X, Y) => (float)X / Y);

            return (byte)Math.Round(Result);
        }
    }
}