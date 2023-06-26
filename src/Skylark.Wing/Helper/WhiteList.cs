using System;
using System.Linq;
using System.Text;
using SWMI = Skylark.Wing.Manage.Internal;
using SWNM = Skylark.Wing.Native.Methods;

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

            return SWNM.GetClassName((int)hwnd, ClassName, MaxChars) > 0 && SWMI.ClassWhiteList.Any(x => x.Equals(ClassName.ToString(), StringComparison.Ordinal));
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

            return SWNM.GetClassName((int)hwnd, ClassName, MaxChars) > 0 && SWMI.StartsWithClassWhiteList.Any(x => ClassName.ToString().StartsWith(x));
        }
    }
}