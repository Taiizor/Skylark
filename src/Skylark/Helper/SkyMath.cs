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

        /// <summary>
        /// Finds the average of all elements given, implemented
        /// entirely by the user to be compatible between any
        /// types.
        /// </summary>
        /// <param name="Elements">The elements to average</param>
        /// <param name="Zero">Zero as TSum for sum start</param>
        /// <param name="AddToSum">Function to add the TSum with the next TIn element</param>
        /// <param name="DivSum">Function to divide the TSum with 2. The output is returned</param>
        /// <typeparam name="TIn">Type of elements to sum</typeparam>
        /// <typeparam name="TSum">Type to sum into in case of imminent overflow i.e. bytes, shorts</typeparam>
        /// <typeparam name="TOut">Type to return in DivSum</typeparam>
        /// <returns></returns>
        public static TOut Average<TIn, TSum, TOut>
            (IEnumerable<TIn> Elements, TSum Zero, Func<TSum, TIn, TSum> AddToSum, Func<TSum, int, TOut> DivSum)
        {
            var count = 0;
            TSum sum = Zero;
            foreach (var el in Elements)
            {
                sum = AddToSum(sum, el);
                count += 1;
            }

            return DivSum(sum, count);
        }
    }
}