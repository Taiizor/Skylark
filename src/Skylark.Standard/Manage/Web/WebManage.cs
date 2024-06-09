using SECWT = Skylark.Enum.CompressWebType;
using SEHWT = Skylark.Enum.HttpWebType;

namespace Skylark.Standard.Manage.Web
{
    /// <summary>
    /// 
    /// </summary>
    internal static class WebManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Code = "0";

        /// <summary>
        /// 
        /// </summary>
        public const int Timeout = 3000;
        /// <summary>
        /// 
        /// </summary>
        public const int MinTimeout = 100;
        /// <summary>
        /// 
        /// </summary>
        public const int MaxTimeout = 9000;

        /// <summary>
        /// 
        /// </summary>
        public const string Total = "0";

        /// <summary>
        /// 
        /// </summary>
        public const string Text = "0";

        /// <summary>
        /// 
        /// </summary>
        public const string Rate = "0.00";

        /// <summary>
        /// 
        /// </summary>
        public const bool Separator = true;

        /// <summary>
        /// 
        /// </summary>
        public const SEHWT HttpType = SEHWT.POST;

        /// <summary>
        /// 
        /// </summary>
        public const string DefaultType = "POST";

        /// <summary>
        /// 
        /// </summary>
        public const SECWT CompressType = SECWT.None;

        /// <summary>
        /// 
        /// </summary>
        public const string Header = "Accept-Encoding";

        /// <summary>
        /// 
        /// </summary>
        public const string Types = "gzip, deflate, br";

        /// <summary>
        /// 
        /// </summary>
        public const string Error = "Invalid Type value.";

        /// <summary>
        /// 
        /// </summary>
        public const string Url = "https://www.google.com";
    }
}