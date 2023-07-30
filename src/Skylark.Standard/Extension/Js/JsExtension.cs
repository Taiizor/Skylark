using NUglify;
using NUglify.JavaScript;
using WebMarkupMin.Core;
using SE = Skylark.Exception;
using SHL = Skylark.Helper.Length;
using SMJJM = Skylark.Standard.Manage.Js.JsManage;

namespace Skylark.Standard.Extension.Js
{
    /// <summary>
    /// 
    /// </summary>
    public static class JsExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Js"></param>
        /// <returns></returns>
        public static string ToMinify(string Js = MJJM.Js)
        {
            try
            {
                Js = SHL.Text(Js, MJJM.Js);

                CrockfordJsMinifier Minifier = new();

                CodeMinificationResult Minified = Minifier.Minify(Js, true);

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
        /// <param name="Js"></param>
        /// <returns></returns>
        public static async Task<string> ToMinifyAsync(string Js = MJJM.Js)
        {
            return await Task.Run(() => ToMinify(Js));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Js"></param>
        /// <returns></returns>
        public static string ToBeauty(string Js = MJJM.Js)
        {
            try
            {
                Js = SHL.Text(Js, MJJM.Js);

                UglifyResult Beautified = Uglify.Js(Js, CodeSettings.Pretty());

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
        /// <param name="Js"></param>
        /// <returns></returns>
        public static async Task<string> ToBeautyAsync(string Js = MJJM.Js)
        {
            return await Task.Run(() => ToBeauty(Js));
        }
    }
}