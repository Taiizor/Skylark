using Newtonsoft.Json;
using System.Dynamic;
using System.Text;
using SE = Skylark.Exception;
using SHL = Skylark.Helper.Length;
using SSMJJM = Skylark.Standard.Manage.Json.JsonManage;

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
        /// <exception cref="SE"></exception>
        public static string ToXml(string Json = SSMJJM.Json, string Root = SSMJJM.Root, bool Special = SSMJJM.Special, bool Array = SSMJJM.Array)
        {
            try
            {
                Json = SHL.Text(Json, SSMJJM.Json);
                Root = SHL.Parameter(Root, SSMJJM.Root);

                return JsonConvert.DeserializeXNode(Json, Root, Array, Special).ToString();
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        public static async Task<string> ToXmlAsync(string Json = SSMJJM.Json, string Root = SSMJJM.Root, bool Special = SSMJJM.Special, bool Array = SSMJJM.Array)
        {
            return await Task.Run(() => ToXml(Json, Root, Special, Array));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <param name="Token"></param>
        /// <param name="Value"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string ToRead(string Json = SSMJJM.Json, string Token = SSMJJM.Token, string Value = SSMJJM.Value, string Separator = SSMJJM.Seperator)
        {
            try
            {
                Json = SHL.Text(Json, SSMJJM.Json);
                Token = SHL.Parameter(Token, SSMJJM.Token);
                Value = SHL.Parameter(Value, SSMJJM.Value);
                Separator = SHL.Parameter(Separator, SSMJJM.Seperator);

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
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
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
        public static async Task<string> ToReadAsync(string Json = SSMJJM.Json, string Token = SSMJJM.Token, string Value = SSMJJM.Value, string Separator = SSMJJM.Seperator)
        {
            return await Task.Run(() => ToRead(Json, Token, Value, Separator));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string ToBeauty(string Json = SSMJJM.Json)
        {
            try
            {
                Json = SHL.Text(Json, SSMJJM.Json);

                return JsonConvert.SerializeObject(JsonConvert.DeserializeObject(Json), Formatting.Indented);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static async Task<string> ToBeautyAsync(string Json = SSMJJM.Json)
        {
            return await Task.Run(() => ToBeauty(Json));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string ToMinify(string Json = SSMJJM.Json)
        {
            try
            {
                Json = SHL.Text(Json, SSMJJM.Json);

                return JsonConvert.SerializeObject(JsonConvert.DeserializeObject(Json), Formatting.None);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static async Task<string> ToMinifyAsync(string Json = SSMJJM.Json)
        {
            return await Task.Run(() => ToMinify(Json));
        }

        /// <summary>
        /// Deserializes json into an expando object. Convenient
        /// for quick json parsing and good for unknown/random json
        /// structures thanks to the underlying <![CDATA[Dictionary<string, object?>]]>
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static ExpandoObject ToExpando(string Json = SSMJJM.Json)
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
        public static async Task<ExpandoObject> ToExpandoAsync(string Json = SSMJJM.Json)
        {
            return await Task.Run(() => ToExpando(Json));
        }
    }
}