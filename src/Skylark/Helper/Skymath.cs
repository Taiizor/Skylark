using System.Xml.Linq;

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
        /// <typeparam name="T">Comparable type to clamp</typeparam>
        /// <param name="Value">The value to clamp</param>
        /// <param name="Min">Minimum value to compare</param>
        /// <param name="Max">Maximum value to compare</param>
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
        /// Determines if a number is at least min and at most max.
        /// If val is above max, returns max. If val is below min. returns min.
        /// </summary>
        /// <typeparam name="T">Comparable type to clamp</typeparam>
        /// <param name="Value">The value to clamp</param>
        /// <param name="Min">Minimum value to compare</param>
        /// <param name="Max">Maximum value to compare</param>
        /// <returns>Clamped value</returns>
        public static async Task<T> ClampAsync<T>(T Value, T Min, T Max) where T : IComparable<T>
        {
            return await Task.Run(() => Clamp<T>(Value, Min, Max));
        }

        /// <summary>
        /// Finds the average of all elements given, implemented
        /// entirely by the user to be compatible between any
        /// types.
        /// </summary>
        /// <typeparam name="TIn">Type of elements to sum</typeparam>
        /// <typeparam name="TSum">Type to sum into in case of imminent overflow i.e. bytes, shorts</typeparam>
        /// <typeparam name="TOut">Type to return in DivSum</typeparam>
        /// <param name="Elements">The elements to average</param>
        /// <param name="Zero">Zero as TSum for sum start</param>
        /// <param name="AddToSum">Function to add the TSum with the next TIn element</param>
        /// <param name="DivSum">Function to divide the TSum with 2. The output is returned</param>
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

        /// <summary>
        /// Finds the average of all elements given, implemented
        /// entirely by the user to be compatible between any
        /// types.
        /// </summary>
        /// <typeparam name="TIn">Type of elements to sum</typeparam>
        /// <typeparam name="TSum">Type to sum into in case of imminent overflow i.e. bytes, shorts</typeparam>
        /// <typeparam name="TOut">Type to return in DivSum</typeparam>
        /// <param name="Elements">The elements to average</param>
        /// <param name="Zero">Zero as TSum for sum start</param>
        /// <param name="AddToSum">Function to add the TSum with the next TIn element</param>
        /// <param name="DivSum">Function to divide the TSum with 2. The output is returned</param>
        /// <returns></returns>
        public static async Task<TOut> AverageAsync<TIn, TSum, TOut>(IEnumerable<TIn> Elements, TSum Zero, Func<TSum, TIn, TSum> AddToSum, Func<TSum, int, TOut> DivSum)
        {
            return await Task.Run(() => Average<TIn, TSum, TOut>(Elements, Zero, AddToSum, DivSum));
        }

        /// <summary>
        /// Performs linear interpolation between two one-dimensional points.
        /// For example, using a weight of 0.5 finds the midpoint of the segment between both points
        /// and using a weight of 0.75 finds the point 75% of the way from A to B
        /// </summary>
        /// <param name="A">Point 1</param>
        /// <param name="B">Point 2</param>
        /// <param name="Weight">Percentage of distance from A to B</param>
        /// <returns>Point A with a weight towards B</returns>
        public static double Lerp(double A, double B, double Weight)
        {
            return (A * (1d - Weight)) + (B * Weight);
        }

        /// <summary>
        /// Performs linear interpolation between two one-dimensional points.
        /// For example, using a weight of 0.5 finds the midpoint of the segment between both points
        /// and using a weight of 0.75 finds the point 75% of the way from A to B
        /// </summary>
        /// <param name="A">Point 1</param>
        /// <param name="B">Point 2</param>
        /// <param name="Weight">Percentage of distance from A to B</param>
        /// <returns>Point A with a weight towards B</returns>
        public static async Task<double> LerpAsync(double A, double B, double Weight)
        {
            return await Task.Run(() => Lerp(A, B, Weight));
        }

        /// <summary>
        /// <inheritdoc cref="Lerp(double,double,double)"/>
        /// </summary>
        /// <param name="A">Point 1</param>
        /// <param name="B">Point 2</param>
        /// <param name="Weight">Percentage of distance from A to B</param>
        /// <returns>Point A with a weight towards B</returns>
        public static float Lerp(float A, float B, float Weight)
        {
            return (A * (1f - Weight)) + (B * Weight);
        }

        /// <summary>
        /// <inheritdoc cref="LerpAsync(double,double,double)"/>
        /// </summary>
        /// <param name="A">Point 1</param>
        /// <param name="B">Point 2</param>
        /// <param name="Weight">Percentage of distance from A to B</param>
        /// <returns>Point A with a weight towards B</returns>
        public static async Task<float> LerpAsync(float A, float B, float Weight)
        {
            return await Task.Run(() => Lerp(A, B, Weight));
        }
    }
}