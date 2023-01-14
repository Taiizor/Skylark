using System.Text;
using HL = Skylark.Helper.Length;
using EET = Skylark.Enum.EncodeType;
using HA = Skylark.Helper.Adaptation;
using HCH = Skylark.Helper.CryptologyHelper;
using MCM = Skylark.Manage.CryptologyManage;

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
        public static byte[] GetBytes(string Text, EET Encode) => Encode switch
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static StringBuilder GetBuild(byte[] Result)
        {
            StringBuilder Builder = new();

            for (int i = 0; i < Result.Length; i++)
            {
                Builder.Append(Result[i].ToString("x2"));
            }

            return Builder;
        }
    }
}