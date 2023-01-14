using System.Text;
using E = Skylark.Exception;
using EET = Skylark.Enum.EncodeType;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class Encode
    {
        /// <summary>
        /// 
        /// </summary>
        private const string Error = "Encode variable not selected.";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static byte[] GetBytes(string Text, EET Encode)
        {
            return Encode switch
            {
                EET.UTF7 => Encoding.UTF7.GetBytes(Text),
                EET.UTF8 => Encoding.UTF8.GetBytes(Text),
                EET.UTF32 => Encoding.UTF32.GetBytes(Text),
                EET.ASCII => Encoding.ASCII.GetBytes(Text),
                EET.Unicode => Encoding.Unicode.GetBytes(Text),
                EET.Default => Encoding.Default.GetBytes(Text),
                EET.BigEndianUnicode => Encoding.BigEndianUnicode.GetBytes(Text),
                _ => throw new E(Error),
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bytes"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static string GetString(byte[] Bytes, EET Encode)
        {
            return Encode switch
            {
                EET.UTF7 => Encoding.UTF7.GetString(Bytes),
                EET.UTF8 => Encoding.UTF8.GetString(Bytes),
                EET.UTF32 => Encoding.UTF32.GetString(Bytes),
                EET.ASCII => Encoding.ASCII.GetString(Bytes),
                EET.Unicode => Encoding.Unicode.GetString(Bytes),
                EET.Default => Encoding.Default.GetString(Bytes),
                EET.BigEndianUnicode => Encoding.BigEndianUnicode.GetString(Bytes),
                _ => throw new E(Error),
            };
        }
    }
}