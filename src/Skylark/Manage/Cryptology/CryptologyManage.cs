using System.Security.Cryptography;
using EET = Skylark.Enum.EncodeType;

namespace Skylark.Manage
{
    /// <summary>
    /// 
    /// </summary>
    internal class CryptologyManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const bool Upper = false;

        /// <summary>
        /// 
        /// </summary>
        public const EET Mode = EET.ASCII;

        /// <summary>
        /// 
        /// </summary>
        public const EET Encode = EET.UTF8;

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
        public const string Text = "Taiizor Skylark";
        /// <summary>
        /// 
        /// </summary>
        public const string Base = "VGFpaXpvciBTa3lsYXJr";
    }
}