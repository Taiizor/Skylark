using Newtonsoft.Json;
using System.Dynamic;
using System.Text;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using MJJM = Skylark.Standard.Manage.Json.JsonManage;

namespace Skylark.Standard.Extension.Json
{
    /// <summary>
    /// 
    /// </summary>
    public static class JsonExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <param name="Root"></param>
        /// <param name="Special"></param>
        /// <param name="Array"></param>
        /// <returns></returns>
        public static string ToXml(string Json = MJJM.Json, string Root = MJJM.Root, bool Special = MJJM.Special, bool Array = MJJM.Array)
        {
            try
            {
                Json = HL.Text(Json, MJJM.Json);
                Root = HL.Parameter(Root, MJJM.Root);

                return JsonConvert.DeserializeXNode(Json, Root, Array, Special).ToString();
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <param name="Root"></param>
        /// <param name="Special"></param>
        /// <param name="Array"></param>
        /// <returns></returns>
        public static Task<string> ToXmlAsync(string Json = MJJM.Json, string Root = MJJM.Root, bool Special = MJJM.Special, bool Array = MJJM.Array)
        {
            return Task.Run(() => ToXml(Json, Root, Special, Array));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <param name="Token"></param>
        /// <param name="Value"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static string ToRead(string Json = MJJM.Json, string Token = MJJM.Token, string Value = MJJM.Value, string Separator = MJJM.Seperator)
        {
            try
            {
                Json = HL.Text(Json, MJJM.Json);
                Token = HL.Parameter(Token, MJJM.Token);
                Value = HL.Parameter(Value, MJJM.Value);
                Separator = HL.Parameter(Separator, MJJM.Seperator);

                StringBuilder Builder = new();

                JsonTextReader Reader = new(new StringReader(Json));

                while (Reader.Read())
                {
                    if (Reader.Value != null)
                    {
                        Builder.AppendLine($"{Token}: {Reader.TokenType}{Separator}{Value}: {Reader.Value}");
                    }
                    else
                    {
                        Builder.AppendLine($"{Token}: {Reader.TokenType}");
                    }
                }

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
        /// <param name="Json"></param>
        /// <param name="Token"></param>
        /// <param name="Value"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static Task<string> ToReadAsync(string Json = MJJM.Json, string Token = MJJM.Token, string Value = MJJM.Value, string Separator = MJJM.Seperator)
        {
            return Task.Run(() => ToRead(Json, Token, Value, Separator));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static string ToBeauty(string Json = MJJM.Json)
        {
            try
            {
                Json = HL.Text(Json, MJJM.Json);

                return JsonConvert.SerializeObject(JsonConvert.DeserializeObject(Json), Formatting.Indented);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static Task<string> ToBeautyAsync(string Json = MJJM.Json)
        {
            return Task.Run(() => ToBeauty(Json));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static string ToMinify(string Json = MJJM.Json)
        {
            try
            {
                Json = HL.Text(Json, MJJM.Json);

                return JsonConvert.SerializeObject(JsonConvert.DeserializeObject(Json), Formatting.None);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static Task<string> ToMinifyAsync(string Json = MJJM.Json)
        {
            return Task.Run(() => ToMinify(Json));
        }

        /// <summary>
        /// Deserializes json into an expando object. Convenient
        /// for quick json parsing and good for unknown/random json
        /// structures thanks to the underlying <![CDATA[Dictionary<string, object?>]]>
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static ExpandoObject ToExpando(string Json = MJJM.Json)
        {
            return JsonConvert.DeserializeObject<ExpandoObject>(Json);
        }

        /// <summary>
        /// Deserializes json into an expando object. Convenient
        /// for quick json parsing and good for unknown/random json
        /// structures thanks to the underlying <![CDATA[Dictionary<string, object?>]]>
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static Task<ExpandoObject> ToExpandaAsync(string Json = MJJM.Json)
        {
            return Task.Run(() => ToExpando(Json));
        }
    }
}