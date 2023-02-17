using System.Diagnostics;
using System.Text;
using Skylark.Enum;
using E = Skylark.Exception;
using EET = Skylark.Enum.EncodeType;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal static class Encode
    {
        /// <summary>
        /// 
        /// </summary>
        private const string ErrorMessage = "Encode variable not selected.";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static byte[] GetBytes(string Text, EET Encode)
        {
            return Encode
                .GetEncoding(false, ErrorMessage)
                .GetBytes(Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bytes"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string GetString(byte[] Bytes, EET Encode)
        {
            return Encode
                .GetEncoding(false, ErrorMessage)
                .GetString(Bytes);
        }
    }
}