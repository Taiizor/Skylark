﻿using NUglify;
using NUglify.Css;
using WebMarkupMin.Core;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using MCM = Skylark.Manage.Css.CssManage;

namespace Skylark.Extension.Css
{
    /// <summary>
    /// 
    /// </summary>
    public static class CssExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Css"></param>
        /// <returns></returns>
        public static string ToMinify(string Css = MCM.Css)
        {
            try
            {
                Css = HL.Text(Css, MCM.Css);

                KristensenCssMinifier Minifier = new();

                CodeMinificationResult Minified = Minifier.Minify(Css, true);

                if (Minified.Errors.Count == 0)
                {
                    return Minified.MinifiedContent;
                }
                else
                {
                    // TODO: Handle null reference
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
        /// <param name="Css"></param>
        /// <returns></returns>
        public static Task<string> ToMinifyAsync(string Css = MCM.Css)
        {
            return Task.Run(() => ToMinify(Css));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Css"></param>
        /// <returns></returns>
        public static string ToBeauty(string Css = MCM.Css)
        {
            try
            {
                Css = HL.Text(Css, MCM.Css);

                UglifyResult Beautified = Uglify.Css(Css, CssSettings.Pretty());

                if (Beautified.Errors.Count == 0)
                {
                    return Beautified.Code;
                }
                else
                {
                    // TODO: Handle null ref
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
        /// <param name="Css"></param>
        /// <returns></returns>
        public static Task<string> ToBeautyAsync(string Css = MCM.Css)
        {
            return Task.Run(() => ToBeauty(Css));
        }
    }
}