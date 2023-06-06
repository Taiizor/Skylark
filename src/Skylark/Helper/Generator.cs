namespace Skylark.Helper
{
    public static class Generator
    {
        /// <summary>
        /// Generates a range with any generic type with the callback increment function provided as an argument.
        /// Bypasses Enumerable.Range and eagerly creates the range
        /// </summary>
        /// <typeparam name="T">Type for range</typeparam>
        /// <param name="Start">The starting element</param>
        /// <param name="One">The 0th element</param>
        /// <param name="Length">Length of range</param>
        /// <param name="IncrementFunc">Like i + 1 but for a generic type</param>
        /// <returns></returns>
        public static T[] FastRange<T>(T Start, T One, int Length, Func<T, T, T> IncrementFunc)
        {
            T[] Array = new T[Length];

            T Element = Start;

            for (int Count = 0; Count < Array.Length; Count++)
            {
                Array[Count] = Element;
                Element = IncrementFunc(Element, One);
            }

            return Array;
        }

        /// <summary>
        /// Generates a range with any generic type with the callback increment function provided as an argument.
        /// Bypasses Enumerable.Range and eagerly creates the range
        /// </summary>
        /// <typeparam name="T">Type for range</typeparam>
        /// <param name="Start">The starting element</param>
        /// <param name="One">The 0th element</param>
        /// <param name="Length">Length of range</param>
        /// <param name="IncrementFunc">Like i + 1 but for a generic type</param>
        /// <returns></returns>
        public static async Task<T[]> FastRangeAsync<T>(T Start, T One, int Length, Func<T, T, T> IncrementFunc)
        {
            return await Task.Run(() => FastRange<T>(Start, One, Length, IncrementFunc));
        }

        /// <summary>
        /// Creates an array and sets all elements with the indexed generator
        /// </summary>
        /// <typeparam name="T">Generic type of elements</typeparam>
        /// <param name="IndexedGenerator">Function to return elements for the array with an index argument</param>
        /// <param name="Length">Length of enumerable</param>
        /// <returns>An eagerly generated IEnumerable</returns>
        public static IEnumerable<T> GenerateEnumerable<T>(Func<int, T> IndexedGenerator, int Length)
        {
            T[] Array = new T[Length];

            for (int Count = 0; Count < Array.Length; Count++)
            {
                Array[Count] = IndexedGenerator(Count);
            }

            return Array;
        }

        /// <summary>
        /// Creates an array and sets all elements with the indexed generator
        /// </summary>
        /// <typeparam name="T">Generic type of elements</typeparam>
        /// <param name="IndexedGenerator">Function to return elements for the array with an index argument</param>
        /// <param name="Length">Length of enumerable</param>
        /// <returns>An eagerly generated IEnumerable</returns>
        public static async Task<IEnumerable<T>> GenerateEnumerableAsync<T>(Func<int, T> IndexedGenerator, int Length)
        {
            return await Task.Run(() => GenerateEnumerable<T>(IndexedGenerator,Length));
        }

        /// <summary>
        /// Lazily yields returned objects from the indexed generator function
        /// </summary>
        /// <typeparam name="T">Generic type of elements</typeparam>
        /// <param name="IndexedGenerator">Function to return elements for the array with an index argument</param>
        /// <param name="Length">Amount of elements to yield</param>
        /// <returns>A lazily generated IEnumerable</returns>
        public static IEnumerable<T> GenerateEnumerableLazy<T>(Func<int, T> IndexedGenerator, int Length)
        {
            for (int Count = 0; Count < Length; Count++)
            {
                yield return IndexedGenerator(Count);
            }
        }

        /// <summary>
        /// Lazily yields returned objects from the indexed generator function
        /// </summary>
        /// <typeparam name="T">Generic type of elements</typeparam>
        /// <param name="IndexedGenerator">Function to return elements for the array with an index argument</param>
        /// <param name="Length">Amount of elements to yield</param>
        /// <returns>A lazily generated IEnumerable</returns>
        public static async Task<IEnumerable<T>> GenerateEnumerableLazyAsync<T>(Func<int, T> IndexedGenerator, int Length)
        {
            return await Task.Run(() => GenerateEnumerableLazy<T>(IndexedGenerator, Length));
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
            char[] Chars = new char[Length];

            for (int Count = 0; Count < Chars.Length; Count++)
            {
                Chars[Count] = Random.FromWithin(AllowedChars);
            }

            return new string(Chars);
        }

        /// <summary>
        /// What could this method do?
        /// </summary>
        /// <param name="AllowedChars">Chars to generate the string with</param>
        /// <param name="Length">Length of the string</param>
        /// <param name="Random">Object to generate random indices with</param>
        /// <returns></returns>
        public static async Task<string> GenerateStringAsync(IList<char> AllowedChars, int Length, Random Random)
        {
            return await Task.Run(() => GenerateString(AllowedChars, Length, Random));
        }
    }
}