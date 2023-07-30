using NUglify;
using NUglify.Html;
using WebMarkupMin.Core;
using SE = Skylark.Exception;
using SHL = Skylark.Helper.Length;
using SSMXXM = Skylark.Standard.Manage.Xhtml.XhtmlManage;

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
        /// <exception cref="SE"></exception>
        public static string ToMinify(string Xhtml = SSMXXM.Xhtml)
        {
            try
            {
                Xhtml = SHL.Text(Xhtml, SSMXXM.Xhtml);

                XhtmlMinifier Minifier = new();

                MarkupMinificationResult Minified = Minifier.Minify(Xhtml);

                if (Minified.Errors.Count == 0)
                {
                    return Minified.MinifiedContent;
                }
                else
                {
                    // TODO: Fix null ref
                    throw new SE(Minified.Errors.FirstOrDefault().Message);
                }
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xhtml"></param>
        /// <returns></returns>
        public static async Task<string> ToMinifyAsync(string Xhtml = SSMXXM.Xhtml)
        {
            return await Task.Run(() => ToMinify(Xhtml));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xhtml"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string ToBeauty(string Xhtml = SSMXXM.Xhtml)
        {
            try
            {
                Xhtml = SHL.Text(Xhtml, SSMXXM.Xhtml);

                UglifyResult Beautified = Uglify.Html(Xhtml, HtmlSettings.Pretty());

                if (Beautified.Errors.Count == 0)
                {
                    return Beautified.Code;
                }
                else
                {
                    // TODO: Fix null ref
                    throw new SE(Beautified.Errors.FirstOrDefault().Message);
                }
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xhtml"></param>
        /// <returns></returns>
        public static async Task<string> ToBeautyAsync(string Xhtml = SSMXXM.Xhtml)
        {
            return await Task.Run(() => ToBeauty(Xhtml));
        }
    }
}