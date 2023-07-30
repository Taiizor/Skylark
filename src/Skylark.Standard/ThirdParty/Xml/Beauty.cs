using System.Text;
using System.Xml;

namespace Skylark.Standard.ThirdParty.Xml
{
    /// <summary>
    /// 
    /// </summary>
    internal static class Beauty
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Xml"></param>
        /// <param name="Encoding"></param>
        /// <returns></returns>
        public static string Beautifier(string Xml, Encoding Encoding)
        {
            MemoryStream Stream = new();
            XmlDocument Document = new();
            XmlTextWriter Writer = new(Stream, Encoding)
            {
                Formatting = Formatting.Indented
            };

            Document.LoadXml(Xml);
            Document.WriteContentTo(Writer);

            Stream.Flush();
            Writer.Flush();

            Stream.Position = 0;

            StreamReader Reader = new(Stream);

            string Beautified = Reader.ReadToEnd();

            Stream.Close();
            Writer.Close();

            return Beautified;
        }
    }
}