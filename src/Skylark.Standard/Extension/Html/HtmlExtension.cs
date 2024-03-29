﻿using NUglify;
using System.Globalization;
using System.Text;
using WebMarkupMin.Core;
using SE = Skylark.Exception;
using SHF = Skylark.Helper.Format;
using SHL = Skylark.Helper.Length;
using SSMHHM = Skylark.Standard.Manage.Html.HtmlManage;

namespace Skylark.Standard.Extension.Html
{
    /// <summary>
    /// 
    /// </summary>
    public static class HtmlExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Encode(string Html = SSMHHM.Html)
        {
            try
            {
                Html = SHL.Text(Html, SSMHHM.Html);

                StringBuilder Builder = new();

                Builder.AppendLine("<script type=\"text/javascript\">");

                string Encrypted = string.Empty;

                foreach (char Char in Html)
                {
                    Encrypted += "%" + SHF.Formatter("{0:X2}", Convert.ToInt32(Char));
                }

                Builder.AppendLine($"\tdocument.write(unescape('{Encrypted}'));");

                Builder.AppendLine("</script>");

                return Builder.ToString();
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        public static async Task<string> EncodeAsync(string Html = SSMHHM.Html)
        {
            return await Task.Run(() => Encode(Html));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Decode(string Html = SSMHHM.Html)
        {
            try
            {
                Html = SHL.Text(Html, SSMHHM.Html);

                Html = Html.Replace("<script type=\"text/javascript\">", string.Empty);
                Html = Html.Replace("</script>", string.Empty);
                Html = Html.Replace("\tdocument.write(unescape('", string.Empty);
                Html = Html.Replace("document.write(unescape('", string.Empty);
                Html = Html.Replace("'));", string.Empty);
                Html = Html.Trim();

                string Decrypted = string.Empty;
                string[] Encrypted = Html.Split('%');

                foreach (string Char in Encrypted)
                {
                    if (Char.Length > 0)
                    {
                        Decrypted += (char)int.Parse(Char, NumberStyles.HexNumber);
                    }
                }

                return Decrypted;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        public static async Task<string> DecodeAsync(string Html = SSMHHM.Html)
        {
            return await Task.Run(() => Decode(Html));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string ToMinify(string Html = SSMHHM.Html)
        {
            try
            {
                Html = SHL.Text(Html, SSMHHM.Html);

                HtmlMinifier Minifier = new();

                MarkupMinificationResult Minified = Minifier.Minify(Html);

                if (Minified.Errors.Count == 0)
                {
                    return Minified.MinifiedContent;
                }
                else
                {
                    // TODO: Handle null ref
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
        /// <param name="Html"></param>
        /// <returns></returns>
        public static async Task<string> ToMinifyAsync(string Html = SSMHHM.Html)
        {
            return await Task.Run(() => ToMinify(Html));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string ToBeauty(string Html = SSMHHM.Html)
        {
            try
            {
                Html = SHL.Text(Html, SSMHHM.Html);

                UglifyResult Beautified = Uglify.Html(Html, NUglify.Html.HtmlSettings.Pretty());

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
        /// <param name="Html"></param>
        /// <returns></returns>
        public static async Task<string> ToBeautyAsync(string Html = SSMHHM.Html)
        {
            return await Task.Run(() => ToBeauty(Html));
        }
    }
}