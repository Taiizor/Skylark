using Microsoft.Win32;
using SEWTT = Skylark.Enum.WindowsThemeType;

namespace Skylark.Wing.Helper
{
    public static class WindowsTheme
    {
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

        private static RegistryKey GetRegistryKey(bool Writable = false)
        {
            return Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", Writable);
        }
    }
}
