using System.Security.Cryptography;
using SEET = Skylark.Enum.EncodeType;

namespace Skylark.Standard.Manage.Cryptology
{
    /// <summary>
    /// 
    /// </summary>
    internal static class CryptologyManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const bool Upper = false;

        /// <summary>
        /// 
        /// </summary>
        public const bool Invariant = true;

        /// <summary>
        /// 
        /// </summary>
        public const SEET Mode = SEET.ASCII;

        /// <summary>
        /// 
        /// </summary>
        public const SEET Encode = SEET.UTF8;

        /// <summary>
        /// 
        /// </summary>
        public const string IV = "QxQsRoZQws61N46H";
        /// <summary>
        /// 
        /// </summary>
        public const string Key = "uS830kWPrPSPyZK0pS7Pgw3wP3SvLOGr";
        /// <summary>
        /// 
        /// </summary>
        public const CipherMode Cipher = CipherMode.CBC;


        /// <summary>
        /// 
        /// </summary>
        public const byte[] Byte = null;
        /// <summary>
        /// 
        /// </summary>
        public const string Text = "Taiizor Skylark";
        /// <summary>
        /// 
        /// </summary>
        public const string Base = "VGFpaXpvciBTa3lsYXJr";
        /// <summary>
        /// 
        /// </summary>
        public const string Aes = "FtaPhkX3zIe21xMsryO3dw==";
    }
}