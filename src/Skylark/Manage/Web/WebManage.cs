using ECWT = Skylark.Enum.CompressWebType;
using EHWT = Skylark.Enum.HttpWebType;

namespace Skylark.Manage.Web
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
        public const EHWT HttpType = EHWT.POST;

        /// <summary>
        /// 
        /// </summary>
        public const string DefaultType = "POST";

        /// <summary>
        /// 
        /// </summary>
        public const ECWT CompressType = ECWT.None;

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