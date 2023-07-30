using SE = Skylark.Exception;
using SMI = Skylark.Manage.Internal;
using SSMBBM = Skylark.Standard.Manage.Browser.BrowserManage;

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