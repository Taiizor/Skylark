using Newtonsoft.Json;
using System.Xml;
using WebMarkupMin.Core;
using BTPXB = Skylark.ThirdParty.Xml.Beauty;
using HL = Skylark.Helper.Length;
using MXM = Skylark.Manage.XmlManage;

namespace Skylark.Extension
{
    public class XmlExtension
    {
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
            catch
            {
                return MXM.Result;
            }
        }

        public static string ToBeauty(string Xml = MXM.Xml)
        {
            try
            {
                Xml = HL.Text(Xml, MXM.Xml);

                return BTPXB.Beautifier(Xml);
            }
            catch
            {
                return MXM.Result;
            }
        }

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
                    return MXM.Result;
                }
            }
            catch
            {
                return MXM.Result;
            }
        }
    }
}