using System.Web;
using SE = Skylark.Exception;
using SHL = Skylark.Helper.Length;
using SSMUUM = Skylark.Standard.Manage.Url.UrlManage;

namespace Skylark.Standard.Extension.Url
{
    /// <summary>
    /// 
    /// </summary>
    public static class UrlExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Encode(string Url = SSMUUM.Url)
        {
            try
            {
                Url = SHL.Parameter(Url, SSMUUM.Url);

                return HttpUtility.UrlEncode(Url);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static async Task<string> EncodeAsync(string Url = SSMUUM.Url)
        {
            return await Task.Run(() => Encode(Url));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Decode(string Url = SSMUUM.Url)
        {
            try
            {
                Url = SHL.Parameter(Url, SSMUUM.Url);

                return HttpUtility.UrlDecode(Url);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static async Task<string> DecodeAsync(string Url = SSMUUM.Url)
        {
            return await Task.Run(() => Decode(Url));
        }
    }
}