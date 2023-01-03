using NUglify;
using NUglify.JavaScript;
using WebMarkupMin.Core;
using HL = Skylark.Helper.Length;
using MJM = Skylark.Manage.JsManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class JsExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Js"></param>
        /// <returns></returns>
        public static string ToMinify(string Js = MJM.Js)
        {
            try
            {
                Js = HL.Text(Js, MJM.Js);

                CrockfordJsMinifier Minifier = new();

                CodeMinificationResult Minified = Minifier.Minify(Js, true);

                if (Minified.Errors.Count == 0)
                {
                    return Minified.MinifiedContent;
                }
                else
                {
                    return MJM.Result;
                }
            }
            catch
            {
                return MJM.Result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Js"></param>
        /// <returns></returns>
        public static string ToBeauty(string Js = MJM.Js)
        {
            try
            {
                Js = HL.Text(Js, MJM.Js);

                UglifyResult Beautified = Uglify.Js(Js, CodeSettings.Pretty());

                if (Beautified.Errors.Count == 0)
                {
                    return Beautified.Code;
                }
                else
                {
                    return MJM.Result;
                }
            }
            catch
            {
                return MJM.Result;
            }
        }
    }
}