﻿using NUglify;
using NUglify.Css;
using WebMarkupMin.Core;
using SE = Skylark.Exception;
using SHL = Skylark.Helper.Length;
using SSMCCM = Skylark.Standard.Manage.Css.CssManage;

namespace Skylark.Standard.Extension.Css
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
        /// <exception cref="SE"></exception>
        public static string ToMinify(string Css = SSMCCM.Css)
        {
            try
            {
                Css = SHL.Text(Css, SSMCCM.Css);

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
        public static async Task<string> ToMinifyAsync(string Css = SSMCCM.Css)
        {
            return await Task.Run(() => ToMinify(Css));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Css"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string ToBeauty(string Css = SSMCCM.Css)
        {
            try
            {
                Css = SHL.Text(Css, SSMCCM.Css);

                UglifyResult Beautified = Uglify.Css(Css, CssSettings.Pretty());

                if (Beautified.Errors.Count == 0)
                {
                    return Beautified.Code;
                }
                else
                {
                    // TODO: Handle null ref
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
        /// <param name="Css"></param>
        /// <returns></returns>
        public static async Task<string> ToBeautyAsync(string Css = SSMCCM.Css)
        {
            return await Task.Run(() => ToBeauty(Css));
        }
    }
}