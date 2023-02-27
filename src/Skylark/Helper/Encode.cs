using System.Text;
using SE = Skylark.Exception;
using SEET = Skylark.Enum.EncodeType;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Encode
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
        /// <exception cref="SE"></exception>
        public static byte[] GetBytes(string Text, SEET Encode)
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
        /// <exception cref="SE"></exception>
        public static string GetString(byte[] Bytes, SEET Encode)
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
        /// <exception cref="SE"></exception>
        private static Encoding GetEncoding(this SEET EncodeType, bool UseUtf8IfNotValid = false, string ErrorMessage = ErrorMessage)
        {
            if (!System.Enum.IsDefined(typeof(SEET), EncodeType))
            {
                if (UseUtf8IfNotValid)
                {
                    return Encoding.UTF8;
                }

                throw new SE(ErrorMessage);
            }

            return EncodeType switch
            {
                SEET.UTF7 => Encoding.UTF7,
                SEET.UTF8 => Encoding.UTF8,
                SEET.UTF32 => Encoding.UTF32,
                SEET.ASCII => Encoding.ASCII,
                SEET.Unicode => Encoding.Unicode,
                SEET.BigEndianUnicode => Encoding.BigEndianUnicode,
                _ => Encoding.Default
            };
        }
    }
}