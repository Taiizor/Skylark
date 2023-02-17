using System.Xml;
using Newtonsoft.Json;
using WebMarkupMin.Core;
using BTPXB = Skylark.ThirdParty.Xml.Beauty;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using MXM = Skylark.Manage.Xml.XmlManage;

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
        public static string ToJson(string Xml = MXM.Xml, bool Format = MXM.Format, bool Root = MXM.Root)
        {
            try
            {
                Xml = HL.Text(Xml, MXM.Xml);

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
        public static Task<string> ToJsonAsync(string Xml = MXM.Xml, bool Format = MXM.Format, bool Root = MXM.Root)
        {
            return Task.Run(() => ToJson(Xml, Format, Root));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xml"></param>
        /// <returns></returns>
        public static string ToBeauty(string Xml = MXM.Xml)
        {
            try
            {
                Xml = HL.Text(Xml, MXM.Xml);

                return BTPXB.Beautifier(Xml);
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
        public static Task<string> ToBeautyAsync(string Xml = MXM.Xml)
        {
            return Task.Run(() => ToBeauty(Xml));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xml"></param>
        /// <returns></returns>
        public static string ToMinify(string Xml = MXM.Xml)
        {
            try
            {
                Xml = HL.Text(Xml, MXM.Xml);

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
        public static Task<string> ToMinifyAsync(string Xml = MXM.Xml)
        {
            return Task.Run(() => ToMinify(Xml));
        }
    }
}