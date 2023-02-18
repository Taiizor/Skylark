using Newtonsoft.Json;
using System.Xml;
using WebMarkupMin.Core;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using MXXM = Skylark.Manage.Xml.XmlManage;
using TPXB = Skylark.ThirdParty.Xml.Beauty;

namespace Skylark.Extension.Xml
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
        public static string ToJson(string Xml = MXXM.Xml, bool Format = MXXM.Format, bool Root = MXXM.Root)
        {
            try
            {
                Xml = HL.Text(Xml, MXXM.Xml);

                XmlDocument Document = new();

                Document.LoadXml(Xml);
                Newtonsoft.Json.Formatting Formatting = Newtonsoft.Json.Formatting.None;

                if (Format)
                {
                    Formatting = Newtonsoft.Json.Formatting.Indented;
                }

                return JsonConvert.SerializeXmlNode(Document, Formatting, Root);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xml"></param>
        /// <param name="Format"></param>
        /// <param name="Root"></param>
        /// <returns></returns>
        public static Task<string> ToJsonAsync(string Xml = MXXM.Xml, bool Format = MXXM.Format, bool Root = MXXM.Root)
        {
            return Task.Run(() => ToJson(Xml, Format, Root));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xml"></param>
        /// <returns></returns>
        public static string ToBeauty(string Xml = MXXM.Xml)
        {
            try
            {
                Xml = HL.Text(Xml, MXXM.Xml);

                return TPXB.Beautifier(Xml);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xml"></param>
        /// <returns></returns>
        public static Task<string> ToBeautyAsync(string Xml = MXXM.Xml)
        {
            return Task.Run(() => ToBeauty(Xml));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xml"></param>
        /// <returns></returns>
        public static string ToMinify(string Xml = MXXM.Xml)
        {
            try
            {
                Xml = HL.Text(Xml, MXXM.Xml);

                XmlMinifier Minifier = new();

                MarkupMinificationResult Minified = Minifier.Minify(Xml);

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
        /// <param name="Xml"></param>
        /// <returns></returns>
        public static Task<string> ToMinifyAsync(string Xml = MXXM.Xml)
        {
            return Task.Run(() => ToMinify(Xml));
        }
    }
}