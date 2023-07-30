using WebMarkupMin.Core;
using SE = Skylark.Exception;
using SHL = Skylark.Helper.Length;
using SSMBBM = Skylark.Standard.Manage.Browser.BrowserManage;

namespace Skylark.Standard.Extension.Browser
{
    /// <summary>
    /// 
    /// </summary>
    public static class BrowserExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Css"></param>
        /// <returns></returns>
        public static string ToMinify(string Css = SSMBBM.Css)
        {
            try
            {
                Css = SHL.Text(Css, SSMBBM.Css);

                KristensenCssMinifier Minifier = new();

                CodeMinificationResult Minified = Minifier.Minify(Css, true);

                if (Minified.Errors.Count == 0)
                {
                    return Minified.MinifiedContent;
                }
                else
                {
                    // TODO: Handle null reference
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
        /// <param name="Css"></param>
        /// <returns></returns>
        public static async Task<string> ToMinifyAsync(string Css = SSMBBM.Css)
        {
            return await Task.Run(() => ToMinify(Css));
        }
    }
}