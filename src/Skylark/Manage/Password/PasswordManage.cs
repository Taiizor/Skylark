using EAPT = Skylark.Enum.AlphabeticPasswordType;
using ESPT = Skylark.Enum.SpecialPasswordType;

namespace Skylark.Manage
{
    internal class PasswordManage
    {
        public const string DefaultType = "Mixed";

        public const ESPT SpecialType = ESPT.Mixed;
        public const EAPT AlphabeticType = EAPT.Mixed;

        public const int Length = 8;
        public const int MinLength = 4;
        public const int MaxLength = 50;

        public const string Prefix = "";
        public const string Suffix = "";

        public const string Error = "Taiizor Skylark";

        public const string Big = "ABCDEFGHIJKLMNOPRSTUVYZQWX";
        public const string Small = "abcdefghijklmnoprstuvyzqwx";

        public const string Number = "1234567890";
        public const string Symbol = "!`'\"^+%&/=?-_@€£ß*-+#\\<|>;:.,~½£$({[]})Æé~";
    }
}