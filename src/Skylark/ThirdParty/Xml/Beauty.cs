using System.Text;
using System.Xml;

namespace Skylark.ThirdParty.Xml
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
        /// <returns></returns>
        public static string Beautifier(string Xml)
        {
            MemoryStream Stream = new();
            XmlDocument Document = new();
            XmlTextWriter Writer = new(Stream, Encoding.Unicode)
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