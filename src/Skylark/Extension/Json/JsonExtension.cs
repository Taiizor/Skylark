using Newtonsoft.Json;
using System.Text;
using HL = Skylark.Helper.Length;
using MJM = Skylark.Manage.JsonManage;

namespace Skylark.Extension
{
    public class JsonExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <param name="Root"></param>
        /// <param name="Special"></param>
        /// <param name="Array"></param>
        /// <returns></returns>
        public static string ToXml(string Json = MJM.Json, string Root = MJM.Root, bool Special = MJM.Special, bool Array = MJM.Array)
        {
            try
            {
                Json = HL.Text(Json, MJM.Json);
                Root = HL.Parameter(Root, MJM.Root);

                return JsonConvert.DeserializeXNode(Json, Root, Array, Special).ToString();
            }
            catch
            {
                return MJM.Result;
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
        public static string ToRead(string Json = MJM.Json, string Token = MJM.Token, string Value = MJM.Value, string Separator = MJM.Seperator)
        {
            try
            {
                Json = HL.Text(Json, MJM.Json);
                Token = HL.Parameter(Token, MJM.Token);
                Value = HL.Parameter(Value, MJM.Value);
                Separator = HL.Parameter(Separator, MJM.Seperator);

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
            catch
            {
                return new StringBuilder().ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static string ToBeauty(string Json = MJM.Json)
        {
            try
            {
                Json = HL.Text(Json, MJM.Json);

                return JsonConvert.SerializeObject(JsonConvert.DeserializeObject(Json), Formatting.Indented);
            }
            catch
            {
                return MJM.Result;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static string ToMinify(string Json = MJM.Json)
        {
            try
            {
                Json = HL.Text(Json, MJM.Json);

                return JsonConvert.SerializeObject(JsonConvert.DeserializeObject(Json), Formatting.None);
            }
            catch
            {
                return MJM.Result;
            }
        }
    }
}