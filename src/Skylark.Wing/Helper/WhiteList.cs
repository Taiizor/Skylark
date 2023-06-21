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
            const int maxChars = 256;

            StringBuilder className = new(maxChars);

            return NM.GetClassName((int)hwnd, className, maxChars) > 0 && MI.ClassWhiteList.Any(x => x.Equals(className.ToString(), StringComparison.Ordinal));
        }
    }
}