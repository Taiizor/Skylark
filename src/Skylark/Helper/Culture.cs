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
        public static CultureInfo All
        {
            set
            {
                Current = value;
                CurrentUI = value;
                ThreadCurrent = value;
                ThreadCurrentUI = value;
            }
        }

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
            get => CultureInfo.DefaultThreadCurrentUICulture;
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

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentName => CultureInfo.CurrentCulture.Name;

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentUIName => CultureInfo.CurrentUICulture.Name;

        /// <summary>
        /// 
        /// </summary>
        public static string InvariantName => CultureInfo.InvariantCulture.Name;

        /// <summary>
        /// 
        /// </summary>
        public static string InstalledUIName => CultureInfo.InstalledUICulture.Name;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentName => CultureInfo.DefaultThreadCurrentCulture.Name;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentUIName => CultureInfo.DefaultThreadCurrentUICulture.Name;
    }
}