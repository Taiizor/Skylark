using Microsoft.Win32;
using EWTT = Skylark.Enum.WindowsThemeType;

namespace Skylark.Wing.Helper
{
    public static class WindowsTheme
    {
        public static EWTT GetTheme()
        {
            try
            {
                using RegistryKey Key = GetRegistryKey();

                object Values = Key?.GetValue("AppsUseLightTheme");

                if (Values == null)
                {
                    return EWTT.Light;
                }

                int Value = (int)Values;

                return Value > 0 ? EWTT.Light : EWTT.Dark;
            }
            catch
            {
                return EWTT.Dark;
            }
        }

        private static RegistryKey GetRegistryKey(bool Writable = false)
        {
            return Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", false);
        }
    }
}
