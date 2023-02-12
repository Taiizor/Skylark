using NUglify;
using NUglify.JavaScript;
using WebMarkupMin.Core;
using E = Skylark.Exception;
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
        public static Task<string> ToMinifyAsync(string Js = MJM.Js)
        {
            return Task.Run(() => ToMinify(Js));
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
        public static Task<string> ToBeautyAsync(string Js = MJM.Js)
        {
            return Task.Run(() => ToBeauty(Js));
        }
    }
}