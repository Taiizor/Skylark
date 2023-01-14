using System.Text;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class CryptologyHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static StringBuilder GetBuild(byte[] Result)
        {
            StringBuilder Builder = new();

            foreach (byte Char in Result)
            {
                Builder.Append(Char.ToString("x2"));
            }

            return Builder;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bytes"></param>
        /// <returns></returns>
        public static string ToBase64String(byte[] Bytes)
        {
            return Convert.ToBase64String(Bytes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <returns></returns>
        public static byte[] FromBase64String(string Base)
        {
            return Convert.FromBase64String(Base);
        }
    }
}