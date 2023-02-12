using NUglify;
using NUglify.Html;
using WebMarkupMin.Core;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using MXM = Skylark.Manage.XhtmlManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
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
                    throw new E(Minified.Errors.FirstOrDefault().Message);
                }
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xhtml"></param>
        /// <returns></returns>
        public static Task<string> ToMinifyAsync(string Xhtml = MXM.Xhtml)
        {
            return Task.Run(() => ToMinify(Xhtml));
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
                    throw new E(Beautified.Errors.FirstOrDefault().Message);
                }
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xhtml"></param>
        /// <returns></returns>
        public static Task<string> ToBeautyAsync(string Xhtml = MXM.Xhtml)
        {
            return Task.Run(() => ToBeauty(Xhtml));
        }
    }
}