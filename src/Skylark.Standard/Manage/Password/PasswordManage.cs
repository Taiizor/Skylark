﻿using SEAPT = Skylark.Enum.AlphabeticPasswordType;
using SESLPT = Skylark.Enum.SpecialPasswordType;
using SESRPT = Skylark.Enum.SimilarPasswordType;

namespace Skylark.Standard.Manage.Password
{
    /// <summary>
    /// 
    /// </summary>
    internal static class PasswordManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultType = "Mixed";

        /// <summary>
        /// 
        /// </summary>
        public const string Password = "1q2w3e4r5t";

        /// <summary>
        /// 
        /// </summary>
        public const SESRPT SimilarType = SESRPT.Jaccard;

        /// <summary>
        /// 
        /// </summary>
        public const SESLPT SpecialType = SESLPT.Mixed;
        /// <summary>
        /// 
        /// </summary>
        public const SEAPT AlphabeticType = SEAPT.Mixed;

        /// <summary>
        /// 
        /// </summary>
        public const int NGramLength = 2;

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        public const string Error = "Unable to create password with selected parameters.";

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<string, object> MeterOptions = new()
        {
            { "MinLength", 12 },
            { "RegexDigit", @"^.*[0-9].*$" },
            { "RegexUppercase", @"^.*[A-Z].*$" },
            { "RegexLowercase", @"^.*[a-z].*$" },
            { "RegexSymbol", @"^.*[!`'\""^+%&/=?\-_@€£ß*\-+#\\<|>;:.,~½£$\({\[\]}\)Æé~].*$" }
        };
    }
}