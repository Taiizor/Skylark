using System.Web;
using HL = Skylark.Helper.Length;
using MUM = Skylark.Manage.UrlManage;

namespace Skylark.Extension
{
    public class UrlExtension
    {
        public static string Encode(string Url = MUM.Url)
        {
            try
            {
                Url = HL.Parameter(Url, MUM.Url);

                return HttpUtility.UrlEncode(Url);
            }
            catch
            {
                return MUM.Result;
            }
        }

        public static string Decode(string Url = MUM.Url)
        {
            try
            {
                Url = HL.Parameter(Url, MUM.Url);

                return HttpUtility.UrlDecode(Url);
            }
            catch
            {
                return MUM.Url;
            }
        }
    }
}