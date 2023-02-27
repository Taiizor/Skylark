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
            int Count = 0;
            TSum Sum = Zero;

            foreach (TIn Element in Elements)
            {
                Sum = AddToSum(Sum, Element);
                Count += 1;
            }

            return DivSum(Sum, Count);
        }
    }
}