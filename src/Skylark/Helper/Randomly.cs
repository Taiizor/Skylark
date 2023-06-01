namespace Skylark.Helper
{
    public static class Randomly
    {
        /// <summary>
        /// Gets a random element from within an IList
        /// </summary>
        /// <param name="Random">Random to use</param>
        /// <param name="List">List to get from within</param>
        /// <typeparam name="T">Generic type of IList</typeparam>
        /// <returns>a random element from inside of IList</returns>
        public static T FromWithin<T>(this Random Random, IList<T> List)
        {
            return List[Random.Next(List.Count)];
        }
    }
}