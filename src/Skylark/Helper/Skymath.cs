namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Skymath
    {
        /// <summary>
        /// Determines if a number is at least min and at most max.
        /// If val is above max, returns max. If val is below min. returns min.
        /// </summary>
        /// <param name="Value">The value to clamp</param>
        /// <param name="Min">Minimum value to compare</param>
        /// <param name="Max">Maximum value to compare</param>
        /// <typeparam name="T">Comparable type to clamp</typeparam>
        /// <returns>Clamped value</returns>
        public static T Clamp<T>(T Value, T Min, T Max) where T : IComparable<T>
        {
            if (Value.CompareTo(Min) < 0)
            {
                return Min;
            }

            if (Value.CompareTo(Max) > 0)
            {
                return Max;
            }

            return Value;
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
        public static TOut Average<TIn, TSum, TOut>(IEnumerable<TIn> Elements, TSum Zero, Func<TSum, TIn, TSum> AddToSum, Func<TSum, int, TOut> DivSum)
        {
            int count = 0;
            TSum sum = Zero;

            foreach (TIn element in Elements)
            {
                sum = AddToSum(sum, element);
                count += 1;
            }

            return DivSum(sum, count);
        }

        /// <summary>
        /// Performs linear interpolation between two one-dimensional points.
        /// For example, using a weight of 0.5 finds the midpoint of the segment between both points.
        /// </summary>
        /// <param name="A">Point 1</param>
        /// <param name="B">Point 2</param>
        /// <param name="Weight">Percentage of distance to B from A</param>
        /// <returns>Point A with a weight towards B</returns>
        public static double Lerp(double A, double B, double Weight)
        {
            return A * (1f - Weight) + B * Weight;
        }
        
        /// <summary>
        /// <inheritdoc cref="Lerp(double,double,double)"/>
        /// </summary>
        /// <param name="A">Point 1</param>
        /// <param name="B">Point 2</param>
        /// <param name="Weight">Percentage of distance to B from A</param>
        /// <returns>Point A with a weight towards B</returns>
        public static double Lerp(float A, float B, float Weight)
        {
            return A * (1f - Weight) + B * Weight;
        }
    }
}