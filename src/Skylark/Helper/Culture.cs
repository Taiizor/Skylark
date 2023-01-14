using System.Globalization;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public class Culture
    {
        /// <summary>
        /// 
        /// </summary>
        public static CultureInfo Current
        {
            get => CultureInfo.CurrentCulture;
            set => CultureInfo.CurrentCulture = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CultureInfo CurrentUI
        {
            get => CultureInfo.CurrentUICulture;
            set => CultureInfo.CurrentUICulture = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CultureInfo ThreadCurrent
        {
            get => CultureInfo.DefaultThreadCurrentCulture;
            set => CultureInfo.DefaultThreadCurrentCulture = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CultureInfo ThreadCurrentUI
        {
            get => CultureInfo.DefaultThreadCurrentCulture;
            set => CultureInfo.DefaultThreadCurrentUICulture = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CultureInfo Invariant => CultureInfo.InvariantCulture;

        /// <summary>
        /// 
        /// </summary>
        public static CultureInfo InstalledUI => CultureInfo.InstalledUICulture;
    }
}