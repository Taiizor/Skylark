using Newtonsoft.Json;
using System.Text;
using System.Xml;
using WebMarkupMin.Core;
using SE = Skylark.Exception;
using SHL = Skylark.Helper.Length;
using SSMXXM = Skylark.Standard.Manage.Xml.XmlManage;
using SSTPXB = Skylark.Standard.ThirdParty.Xml.Beauty;

namespace Skylark.Standard.Extension.Xml
{
    /// <summary>
    /// 
    /// </summary>
    public static class XmlExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xml"></param>
        /// <param name="Format"></param>
        /// <param name="Root"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string ToJson(string Xml = SSMXXM.Xml, bool Format = SSMXXM.Format, bool Root = SSMXXM.Root)
        {
            try
            {
                Xml = SHL.Text(Xml, SSMXXM.Xml);

                XmlDocument Document = new();

                Document.LoadXml(Xml);
                Newtonsoft.Json.Formatting Formatting = Newtonsoft.Json.Formatting.None;

                if (Format)
                {
                    Formatting = Newtonsoft.Json.Formatting.Indented;
                }

                return JsonConvert.SerializeXmlNode(Document, Formatting, Root);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xml"></param>
        /// <param name="Format"></param>
        /// <param name="Root"></param>
        /// <returns></returns>
        public static async Task<string> ToJsonAsync(string Xml = SSMXXM.Xml, bool Format = SSMXXM.Format, bool Root = SSMXXM.Root)
        {
            return await Task.Run(() => ToJson(Xml, Format, Root));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xml"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string ToBeauty(string Xml = SSMXXM.Xml)
        {
            try
            {
                Xml = SHL.Text(Xml, SSMXXM.Xml);

                return SSTPXB.Beautifier(Xml, Encoding.Unicode);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xml"></param>
        /// <returns></returns>
        public static async Task<string> ToBeautyAsync(string Xml = SSMXXM.Xml)
        {
            return await Task.Run(() => ToBeauty(Xml));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xml"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string ToMinify(string Xml = SSMXXM.Xml)
        {
            try
            {
                Xml = SHL.Text(Xml, SSMXXM.Xml);

                XmlMinifier Minifier = new();

                MarkupMinificationResult Minified = Minifier.Minify(Xml);

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
        /// <param name="Xml"></param>
        /// <returns></returns>
        public static async Task<string> ToMinifyAsync(string Xml = SSMXXM.Xml)
        {
            return await Task.Run(() => ToMinify(Xml));
        }
    }
}