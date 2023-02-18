using System.Globalization;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Culture
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

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentNativeName => CultureInfo.CurrentCulture.NativeName;

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentUINativeName => CultureInfo.CurrentUICulture.NativeName;

        /// <summary>
        /// 
        /// </summary>
        public static string InvariantNativeName => CultureInfo.InvariantCulture.NativeName;

        /// <summary>
        /// 
        /// </summary>
        public static string InstalledUINativeName => CultureInfo.InstalledUICulture.NativeName;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentNativeName => CultureInfo.DefaultThreadCurrentCulture.NativeName;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentUINativeName => CultureInfo.DefaultThreadCurrentUICulture.NativeName;

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentDisplayName => CultureInfo.CurrentCulture.DisplayName;

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentUIDisplayName => CultureInfo.CurrentUICulture.DisplayName;

        /// <summary>
        /// 
        /// </summary>
        public static string InvariantDisplayName => CultureInfo.InvariantCulture.DisplayName;

        /// <summary>
        /// 
        /// </summary>
        public static string InstalledUIDisplayName => CultureInfo.InstalledUICulture.DisplayName;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentDisplayName => CultureInfo.DefaultThreadCurrentCulture.DisplayName;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentUIDisplayName => CultureInfo.DefaultThreadCurrentUICulture.DisplayName;

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentEnglishName => CultureInfo.CurrentCulture.EnglishName;

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentUIEnglishName => CultureInfo.CurrentUICulture.EnglishName;

        /// <summary>
        /// 
        /// </summary>
        public static string InvariantEnglishName => CultureInfo.InvariantCulture.EnglishName;

        /// <summary>
        /// 
        /// </summary>
        public static string InstalledUIEnglishName => CultureInfo.InstalledUICulture.EnglishName;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentEnglishName => CultureInfo.DefaultThreadCurrentCulture.EnglishName;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentUIEnglishName => CultureInfo.DefaultThreadCurrentUICulture.EnglishName;

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentTwoLetterISOLanguageName => CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentUITwoLetterISOLanguageName => CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string InvariantTwoLetterISOLanguageName => CultureInfo.InvariantCulture.TwoLetterISOLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string InstalledUITwoLetterISOLanguageName => CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentTwoLetterISOLanguageName => CultureInfo.DefaultThreadCurrentCulture.TwoLetterISOLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentUITwoLetterISOLanguageName => CultureInfo.DefaultThreadCurrentUICulture.TwoLetterISOLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentThreeLetterISOLanguageName => CultureInfo.CurrentCulture.ThreeLetterISOLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentUIThreeLetterISOLanguageName => CultureInfo.CurrentUICulture.ThreeLetterISOLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string InvariantThreeLetterISOLanguageName => CultureInfo.InvariantCulture.ThreeLetterISOLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string InstalledUIThreeLetterISOLanguageName => CultureInfo.InstalledUICulture.ThreeLetterISOLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentThreeLetterISOLanguageName => CultureInfo.DefaultThreadCurrentCulture.ThreeLetterISOLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentUIThreeLetterISOLanguageName => CultureInfo.DefaultThreadCurrentUICulture.ThreeLetterISOLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentThreeLetterWindowsLanguageName => CultureInfo.CurrentCulture.ThreeLetterWindowsLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string CurrentUIThreeLetterWindowsLanguageName => CultureInfo.CurrentUICulture.ThreeLetterWindowsLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string InvariantThreeLetterWindowsLanguageName => CultureInfo.InvariantCulture.ThreeLetterWindowsLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string InstalledUIThreeLetterWindowsLanguageName => CultureInfo.InstalledUICulture.ThreeLetterWindowsLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentThreeLetterWindowsLanguageName => CultureInfo.DefaultThreadCurrentCulture.ThreeLetterWindowsLanguageName;

        /// <summary>
        /// 
        /// </summary>
        public static string ThreadCurrentUIThreeLetterWindowsLanguageName => CultureInfo.DefaultThreadCurrentUICulture.ThreeLetterWindowsLanguageName;
    }
}