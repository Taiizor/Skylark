using System;
using System.Linq;
using System.Text;
using MI = Skylark.Wing.Manage.Internal;
using NM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class WhiteList
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwnd"></param>
        /// <returns></returns>
        public static bool IsWhitelistedClass(IntPtr hwnd)
        {
            const int MaxChars = 256;

            StringBuilder ClassName = new(MaxChars);

            return NM.GetClassName((int)hwnd, ClassName, MaxChars) > 0 && MI.ClassWhiteList.Any(x => x.Equals(ClassName.ToString(), StringComparison.Ordinal));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hwnd"></param>
        /// <returns></returns>
        public static bool IsWhitelistedStartsWithClass(IntPtr hwnd)
        {
            const int MaxChars = 256;

            StringBuilder ClassName = new(MaxChars);

            return NM.GetClassName((int)hwnd, ClassName, MaxChars) > 0 && MI.StartsWithClassWhiteList.Any(x => ClassName.ToString().StartsWith(x));
        }
    }
}