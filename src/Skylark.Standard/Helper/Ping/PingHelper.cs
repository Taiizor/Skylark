namespace Skylark.Standard.Helper.Ping
{
    /// <summary>
    /// 
    /// </summary>
    internal static class PingHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Address"></param>
        /// <returns></returns>
        public static string GetAddress(string Address)
        {
            if (Address.Contains("https://"))
            {
                Address = Address.Replace("https://", "");
            }

            if (Address.Contains("http://"))
            {
                Address = Address.Replace("http://", "");
            }

            return Address;
        }
    }
}