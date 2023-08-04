using Microsoft.Win32;
using SEWTT = Skylark.Enum.WindowsThemeType;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class WindowsTheme
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SEWTT GetTheme()
        {
            try
            {
                using RegistryKey Key = GetRegistryKey();

                object Values = Key?.GetValue("AppsUseLightTheme");

                if (Values == null)
                {
                    return SEWTT.Light;
                }

                int Value = (int)Values;

                return Value > 0 ? SEWTT.Light : SEWTT.Dark;
            }
            catch
            {
                return SEWTT.Dark;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Writable"></param>
        /// <returns></returns>
        private static RegistryKey GetRegistryKey(bool Writable = false)
        {
            return Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", Writable);
        }
    }
}