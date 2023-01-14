using System.Text;
using EET = Skylark.Enum.EncodeType;

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
                _ => Encoding.UTF8.GetBytes(Text),
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
                _ => Encoding.UTF8.GetString(Bytes),
            };
        }

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