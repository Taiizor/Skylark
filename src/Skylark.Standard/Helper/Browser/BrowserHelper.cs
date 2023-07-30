using SE = Skylark.Exception;
using SMBBM = Skylark.Standard.Manage.Browser.BrowserManage;
using SMI = Skylark.Manage.Internal;

namespace Skylark.Standard.Helper.Browser
{
    /// <summary>
    /// 
    /// </summary>
    internal static class BrowserHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static FileStream OpenRead(string Path)
        {
            return File.OpenRead(Path);
        }
    }
}