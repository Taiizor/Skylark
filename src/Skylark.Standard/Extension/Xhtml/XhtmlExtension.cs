using NUglify;
using NUglify.Html;
using WebMarkupMin.Core;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using MXXM = Skylark.Standard.Manage.Xhtml.XhtmlManage;

namespace Skylark.Standard.Extension.Xhtml
{
    /// <summary>
    /// 
    /// </summary>
    public static class XhtmlExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xhtml"></param>
        /// <returns></returns>
        public static string ToMinify(string Xhtml = MXXM.Xhtml)
        {
            try
            {
                Xhtml = HL.Text(Xhtml, MXXM.Xhtml);

                XhtmlMinifier Minifier = new();

                MarkupMinificationResult Minified = Minifier.Minify(Xhtml);

                if (Minified.Errors.Count == 0)
                {
                    return Minified.MinifiedContent;
                }
                else
                {
                    // TODO: Fix null ref
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
        public static async Task<string> ToMinifyAsync(string Xhtml = MXXM.Xhtml)
        {
            return await Task.Run(() => ToMinify(Xhtml));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xhtml"></param>
        /// <returns></returns>
        public static string ToBeauty(string Xhtml = MXXM.Xhtml)
        {
            try
            {
                Xhtml = HL.Text(Xhtml, MXXM.Xhtml);

                UglifyResult Beautified = Uglify.Html(Xhtml, HtmlSettings.Pretty());

                if (Beautified.Errors.Count == 0)
                {
                    return Beautified.Code;
                }
                else
                {
                    // TODO: Fix null ref
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
        public static async Task<string> ToBeautyAsync(string Xhtml = MXXM.Xhtml)
        {
            return await Task.Run(() => ToBeauty(Xhtml));
        }
    }
}