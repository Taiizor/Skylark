using EAPT = Skylark.Enum.AlphabeticPasswordType;
using ESPT = Skylark.Enum.SpecialPasswordType;

namespace Skylark.Manage
{
    internal class PasswordManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultType = "Mixed";

        /// <summary>
        /// 
        /// </summary>
        public const ESPT SpecialType = ESPT.Mixed;
        /// <summary>
        /// 
        /// </summary>
        public const EAPT AlphabeticType = EAPT.Mixed;

        public const int Length = 8;
        /// <summary>
        /// 
        /// </summary>
        public const int MinLength = 4;
        /// <summary>
        /// 
        /// </summary>
        public const int MaxLength = 50;

        /// <summary>
        /// 
        /// </summary>
        public const string Prefix = "";
        /// <summary>
        /// 
        /// </summary>
        public const string Suffix = "";

        /// <summary>
        /// 
        /// </summary>
        public const string Error = "Taiizor Skylark";

        /// <summary>
        /// 
        /// </summary>
        public const string Big = "ABCDEFGHIJKLMNOPRSTUVYZQWX";
        /// <summary>
        /// 
        /// </summary>
        public const string Small = "abcdefghijklmnoprstuvyzqwx";

        /// <summary>
        /// 
        /// </summary>
        public const string Number = "1234567890";
        /// <summary>
        /// 
        /// </summary>
        public const string Symbol = "!`'\"^+%&/=?-_@€£ß*-+#\\<|>;:.,~½£$({[]})Æé~";
    }
}