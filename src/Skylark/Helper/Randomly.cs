namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Randomly
    {
        /// <summary>
        /// Gets a random element from within an IList
        /// </summary>
        /// <typeparam name="T">Generic type of IList</typeparam>
        /// <param name="Random">Random to use</param>
        /// <param name="List">List to get from within</param>
        /// <returns>a random element from inside of IList</returns>
        public static T FromWithin<T>(this Random Random, IList<T> List)
        {
            return List[Random.Next(List.Count)];
        }

        /// <summary>
        /// Gets a random element from within an IList
        /// </summary>
        /// <typeparam name="T">Generic type of IList</typeparam>
        /// <param name="Random">Random to use</param>
        /// <param name="List">List to get from within</param>
        /// <returns>a random element from inside of IList</returns>
        public static async Task<T> FromWithinAsync<T>(this Random Random, IList<T> List)
        {
            return await Task.Run(() => FromWithin<T>(Random, List));
        }
    }
}