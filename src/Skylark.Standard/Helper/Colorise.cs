using SHS = Skylark.Helper.Skymath;
using SSCCS = Skylark.Struct.Colorise.ColoriseStruct;

namespace Skylark.Standard.Helper
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
        public static SSCCS ToBlend(this SSCCS RGB, SSCCS Other)
        {
            byte R = BlendToAvg(RGB.R, Other.R);
            byte G = BlendToAvg(RGB.G, Other.G);
            byte B = BlendToAvg(RGB.B, Other.B);

            return new SSCCS(R, G, B);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="RGB"></param>
        /// <param name="Other"></param>
        /// <returns></returns>
        public static async Task<SSCCS> ToBlendAsync(this SSCCS RGB, SSCCS Other)
        {
            return await Task.Run(() => ToBlend(RGB, Other));
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

            float Result = SHS.Average(Bytes, 0, (X, Y) => X + Y, (X, Y) => (float)X / Y);

            return (byte)Math.Round(Result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="B1"></param>
        /// <param name="B2"></param>
        /// <returns></returns>
        public static async Task<byte> BlendToAvgAsync(byte B1, byte B2)
        {
            return await Task.Run(() => BlendToAvg(B1, B2));
        }
    }
}