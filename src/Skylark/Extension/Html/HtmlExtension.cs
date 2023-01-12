using NUglify;
using System.Globalization;
using System.Text;
using WebMarkupMin.Core;
using E = Skylark.Exception;
using HF = Skylark.Helper.Format;
using HL = Skylark.Helper.Length;
using MHM = Skylark.Manage.HtmlManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class HtmlExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Html"></param>
        /// <returns></returns>
        public static string Encode(string Html = MHM.Html)
        {
            try
            {
                Html = HL.Text(Html, MHM.Html);

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
        public static string Decode(string Html = MHM.Html)
        {
            try
            {
                Html = HL.Text(Html, MHM.Html);

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
        public static string ToMinify(string Html = MHM.Html)
        {
            try
            {
                Html = HL.Text(Html, MHM.Html);

                HtmlMinifier Minifier = new();

                MarkupMinificationResult Minified = Minifier.Minify(Html);

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
        /// <param name="Html"></param>
        /// <returns></returns>
        public static string ToBeauty(string Html = MHM.Html)
        {
            try
            {
                Html = HL.Text(Html, MHM.Html);

                UglifyResult Beautified = Uglify.Html(Html, NUglify.Html.HtmlSettings.Pretty());

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
    }
}