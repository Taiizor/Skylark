using NUglify;
using NUglify.JavaScript;
using WebMarkupMin.Core;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using MJJM = Skylark.Manage.Js.JsManage;

namespace Skylark.Extension.Js
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
                Js = HL.Text(Js, MJJM.Js);

                CrockfordJsMinifier Minifier = new();

                CodeMinificationResult Minified = Minifier.Minify(Js, true);

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
        /// <param name="Js"></param>
        /// <returns></returns>
        public static Task<string> ToMinifyAsync(string Js = MJJM.Js)
        {
            return Task.Run(() => ToMinify(Js));
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
                Js = HL.Text(Js, MJJM.Js);

                UglifyResult Beautified = Uglify.Js(Js, CodeSettings.Pretty());

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
        /// <param name="Js"></param>
        /// <returns></returns>
        public static Task<string> ToBeautyAsync(string Js = MJJM.Js)
        {
            return Task.Run(() => ToBeauty(Js));
        }
    }
}