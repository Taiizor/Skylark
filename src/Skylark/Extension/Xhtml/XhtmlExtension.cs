using NUglify;
using NUglify.Html;
using WebMarkupMin.Core;
using HL = Skylark.Helper.Length;
using MXM = Skylark.Manage.XhtmlManage;

namespace Skylark.Extension
{
    public class XhtmlExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xhtml"></param>
        /// <returns></returns>
        public static string ToMinify(string Xhtml = MXM.Xhtml)
        {
            try
            {
                Xhtml = HL.Text(Xhtml, MXM.Xhtml);

                XhtmlMinifier Minifier = new();

                MarkupMinificationResult Minified = Minifier.Minify(Xhtml);

                if (Minified.Errors.Count == 0)
                {
                    return Minified.MinifiedContent;
                }
                else
                {
                    return MXM.Result;
                }
            }
            catch
            {
                return MXM.Result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xhtml"></param>
        /// <returns></returns>
        public static string ToBeauty(string Xhtml = MXM.Xhtml)
        {
            try
            {
                Xhtml = HL.Text(Xhtml, MXM.Xhtml);

                UglifyResult Beautified = Uglify.Html(Xhtml, HtmlSettings.Pretty());

                if (Beautified.Errors.Count == 0)
                {
                    return Beautified.Code;
                }
                else
                {
                    return MXM.Result;
                }
            }
            catch
            {
                return MXM.Result;
            }
        }
    }
}