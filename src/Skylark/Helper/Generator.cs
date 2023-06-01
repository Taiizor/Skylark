namespace Skylark.Helper
{
    public static class Generator
    {
        /// <summary>
        /// Generates a range with any generic type with the callback increment function provided as an argument.
        /// Bypasses Enumerable.Range and eagerly creates the range
        /// </summary>
        /// <param name="Start">The starting element</param>
        /// <param name="One">The 0th element</param>
        /// <param name="Length">Length of range</param>
        /// <param name="IncrementFunc">Like i + 1 but for a generic type</param>
        /// <typeparam name="T">Type for range</typeparam>
        /// <returns></returns>
        public static T[] FastRange<T>(T Start, T One, int Length, Func<T, T, T> IncrementFunc)
        {
            var arr = new T[Length];
            T n = Start;
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = n;
                n = IncrementFunc(n, One);
            }

            return arr;
        }

        /// <summary>
        /// Creates an array and sets all elements with the indexed generator
        /// </summary>
        /// <param name="IndexedGenerator">Function to return elements for the array with an index argument</param>
        /// <param name="Length">Length of enumerable</param>
        /// <typeparam name="T">Generic type of elements</typeparam>
        /// <returns>An eagerly generated IEnumerable</returns>
        public static IEnumerable<T> GenerateEnumerable<T>(Func<int, T> IndexedGenerator, int Length)
        {
            var arr = new T[Length];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = IndexedGenerator(i);
            }

            return arr;
        }

        /// <summary>
        /// Lazily yields returned objects from the indexed generator function
        /// </summary>
        /// <param name="IndexedGenerator">Function to return elements for the array with an index argument</param>
        /// <param name="Length">Amount of elements to yield</param>
        /// <typeparam name="T">Generic type of elements</typeparam>
        /// <returns>A lazily generated IEnumerable</returns>
        public static IEnumerable<T> GenerateEnumerableLazy<T>(Func<int, T> IndexedGenerator, int Length)
        {
            for (var i = 0; i < Length; i++)
            {
                yield return IndexedGenerator(i);
            }
        }

        /// <summary>
        /// What could this method do?
        /// </summary>
        /// <param name="AllowedChars">Chars to generate the string with</param>
        /// <param name="Length">Length of the string</param>
        /// <param name="Random">Object to generate random indices with</param>
        /// <returns></returns>
        public static string GenerateString(IList<char> AllowedChars, int Length, Random Random)
        {
            var chars = new char[Length];
            for (var i = 0; i < chars.Length; i++)
            {
                chars[i] = Random.FromWithin(AllowedChars);
            }

            return new string(chars);
        }
    }
}