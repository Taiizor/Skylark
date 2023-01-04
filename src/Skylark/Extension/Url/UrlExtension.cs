using System.Web;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using MUM = Skylark.Manage.UrlManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class UrlExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string Encode(string Url = MUM.Url)
        {
            try
            {
                Url = HL.Parameter(Url, MUM.Url);

                return HttpUtility.UrlEncode(Url);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string Decode(string Url = MUM.Url)
        {
            try
            {
                Url = HL.Parameter(Url, MUM.Url);

                return HttpUtility.UrlDecode(Url);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}