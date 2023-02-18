using System.Text;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="EncodeType"></param>
        /// <param name="UseUtf8IfNotValid"></param>
        /// <param name="ErrorMessage"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        private static Encoding GetEncoding(this EET EncodeType, bool UseUtf8IfNotValid = false, string ErrorMessage = ErrorMessage)
        {
            if (!System.Enum.IsDefined(typeof(EET), EncodeType))
            {
                if (UseUtf8IfNotValid)
                {
                    return Encoding.UTF8;
                }

                throw new E(ErrorMessage);
            }

            return EncodeType switch
            {
                EET.UTF8 => Encoding.UTF8,
                EET.UTF32 => Encoding.UTF32,
                EET.ASCII => Encoding.ASCII,
                EET.Unicode => Encoding.Unicode,
                EET.UTF7 => Encoding.UTF7,
                EET.BigEndianUnicode => Encoding.BigEndianUnicode,
                _ => Encoding.Default
            };
        }
    }
}