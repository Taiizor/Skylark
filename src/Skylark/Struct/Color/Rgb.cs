using Skylark.Helper;

namespace Skylark.Struct.Color
{
    public readonly struct Rgb
    {
        public readonly byte R;
        public readonly byte G;
        public readonly byte B;

        public Rgb(byte R, byte G, byte B)
        {
            this.R = R;
            this.G = G;
            this.B = B;
        }

        public int ToInt()
        {
            int n = 0;
            n += R;
            n <<= 8;
            n += G;
            n <<= 8;
            n += B;
            return n;
        }

        public string ToHex()
        {
            return $"0x{ToInt():X}";
        }

        public override string ToString()
        {
            return $"{nameof(R)}: {R}, {nameof(G)}: {G}, {nameof(B)}: {B} ({ToHex()})";
        }
    }

    public static class RgbHelper // Move this class?
    {
        public static Rgb Blend(this Rgb rgb, Rgb other)
        {
            var r = Avg(rgb.R, other.R);
            var g = Avg(rgb.G, other.G);
            var b = Avg(rgb.B, other.B);
            return new Rgb(r, g, b);
        }

        private static byte Avg(byte b1, byte b2)
        {
            var bytes = new[] { b1, b2 };
            var avgResult = SkyMath.Average<byte, int, float>
                (bytes, 0, (x, y) => x + y, (x, y) => (float)x / y);
            return (byte)Math.Round(avgResult);
        }
    }
}