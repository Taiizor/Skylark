namespace Skylark
{
    public static class SkyMath
    {
        /// <summary>
        /// Determines if a number is at least min and at most max.
        /// If val is above max, returns max. If val is below min. returns min.
        /// </summary>
        /// <param name="value">The value to clamp</param>
        /// <param name="min">Minimum value to compare</param>
        /// <param name="max">Maximum value to compare</param>
        /// <typeparam name="T">Comparable type to clamp</typeparam>
        /// <returns>Clamped value</returns>
        public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
        {
            if (value.CompareTo(min) < 0)
                return min;
            if (value.CompareTo(max) > 0)
                return max;
            return value;
        }
    }
}