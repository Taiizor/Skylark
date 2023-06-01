using NUglify;
using System.Globalization;
using System.Text;
using WebMarkupMin.Core;
using E = Skylark.Exception;
using HF = Skylark.Helper.Format;
using HL = Skylark.Helper.Length;
using MHHM = Skylark.Standard.Manage.Html.HtmlManage;

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
        public static string Encode(string Html = MHHM.Html)
        {
            try
            {
                Html = HL.Text(Html, MHHM.Html);

                StringBuilder Builder = new();

                Builder.AppendLine("<script type=\"text/javascript\">");

                string Encrypted = string.Empty;

                foreach (char Char in Html)
                {
                    Encrypted += "%" + HF.Formatter("{0:X2}", Convert.ToInt32(Char));
                }

                Builder.AppendLine($"\tdocument.write(unescape('{Encrypted}'));");

                Builder.AppendLine("</script>");

                return Builder.ToString();
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        public static async Task<string> EncodeAsync(string Html = MHHM.Html)
        {
            return await Task.Run(() => Encode(Html));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        public static string Decode(string Html = MHHM.Html)
        {
            try
            {
                Html = HL.Text(Html, MHHM.Html);

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
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        public static async Task<string> DecodeAsync(string Html = MHHM.Html)
        {
            return await Task.Run(() => Decode(Html));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        public static string ToMinify(string Html = MHHM.Html)
        {
            try
            {
                Html = HL.Text(Html, MHHM.Html);

                HtmlMinifier Minifier = new();

                MarkupMinificationResult Minified = Minifier.Minify(Html);

                if (Minified.Errors.Count == 0)
                {
                    return Minified.MinifiedContent;
                }
                else
                {
                    // TODO: Handle null ref
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
        /// <param name="Html"></param>
        /// <returns></returns>
        public static async Task<string> ToMinifyAsync(string Html = MHHM.Html)
        {
            return await Task.Run(() => ToMinify(Html));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        public static string ToBeauty(string Html = MHHM.Html)
        {
            try
            {
                Html = HL.Text(Html, MHHM.Html);

                UglifyResult Beautified = Uglify.Html(Html, NUglify.Html.HtmlSettings.Pretty());

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
        /// <param name="Html"></param>
        /// <returns></returns>
        public static async Task<string> ToBeautyAsync(string Html = MHHM.Html)
        {
            return await Task.Run(() => ToBeauty(Html));
        }
    }
}