using WebMarkupMin.Core;
using SE = Skylark.Exception;
using SHL = Skylark.Helper.Length;
using SMBBM = Skylark.Standard.Manage.Browser.BrowserManage;

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
        public static string ToMinify(string Css = MBBM.Css)
        {
            try
            {
                Css = HL.Text(Css, MBBM.Css);

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
        public static async Task<string> ToMinifyAsync(string Css = MBBM.Css)
        {
            return await Task.Run(() => ToMinify(Css));
        }
    }
}