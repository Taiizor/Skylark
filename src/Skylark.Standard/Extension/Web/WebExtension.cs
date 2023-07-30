using Newtonsoft.Json;
using System.Text;
using System.Text.RegularExpressions;
using SE = Skylark.Exception;
using SECWT = Skylark.Enum.CompressWebType;
using SEHWT = Skylark.Enum.HttpWebType;
using SHC = Skylark.Helper.Converter;
using SHL = Skylark.Helper.Length;
using SSHWWH = Skylark.Standard.Helper.Web.WebHelper;
using SSMI = Skylark.Standard.Manage.Internal;
using SSMWWM = Skylark.Standard.Manage.Web.WebManage;
using SSWWHS = Skylark.Struct.Web.WebHeaderStruct;
using SSWWRS = Skylark.Struct.Web.WebRatioStruct;

namespace Skylark.Standard.Extension.Web
{
    /// <summary>
    /// 
    /// </summary>
    public static class WebExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string Source(string Url = MWWM.Url)
        {
            try
            {
                Url = HL.Parameter(Url, MWWM.Url);

                HttpClient Client = new();

                return Client.GetStringAsync(Url).Result;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static async Task<string> SourceAsync(string Url = MWWM.Url)
        {
            return await Task.Run(() => Source(Url));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static SWWRS Ratio(string Url = MWWM.Url, bool Separator = MWWM.Separator)
        {
            try
            {
                Url = HL.Parameter(Url, MWWM.Url);

                string Rate, Code, Text, Total;

                string Content = Source(Url);

                int CodeCount = Regex.Matches(Content, @"<[^>]*>").Count;
                int TextCount = Regex.Matches(Content, @"[^\s]").Count;

                Rate = $"{CodeCount * 100d / TextCount}";
                Total = $"{Content.Length}";
                Text = $"{TextCount}";
                Code = $"{CodeCount}";

                return new()
                {
                    Rate = HWWH.GetPlaces(Math.Round(decimal.Parse(Rate), 2), Separator),
                    Total = HWWH.GetPlaces(Total, Separator),
                    Text = HWWH.GetPlaces(Text, Separator),
                    Code = HWWH.GetPlaces(Code, Separator)
                };
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static async Task<SWWRS> RatioAsync(string Url = MWWM.Url, bool Separator = MWWM.Separator)
        {
            return await Task.Run(() => Ratio(Url, Separator));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static SWWHS Header(string Url = MWWM.Url)
        {
            try
            {
                Url = HL.Parameter(Url, MWWM.Url);

                SWWHS Result = new();

                HttpClient Client = new();

                HttpResponseMessage Response = Client.GetAsync(Url).Result;

                foreach (KeyValuePair<string, IEnumerable<string>> Header in Response.Content.Headers)
                {
                    switch (Header.Key)
                    {
                        case "Content-Length":
                            Result.Length = Header.Value.FirstOrDefault();
                            break;
                        case "Last-Modified":
                            Result.Modified = Header.Value.FirstOrDefault();
                            break;
                        case "Content-Type":
                            Result.Type = Header.Value.FirstOrDefault();
                            break;
                        default:
                            break;
                    }
                }

                foreach (KeyValuePair<string, IEnumerable<string>> Header in Response.Headers)
                {
                    switch (Header.Key)
                    {
                        case "Strict-Transport-Security":
                            Result.Security = Header.Value.FirstOrDefault();
                            break;
                        case "Accept-Ranges":
                            Result.Ranges = Header.Value.FirstOrDefault();
                            break;
                        case "Set-Cookie":
                            Result.Cookie = Header.Value.FirstOrDefault();
                            break;
                        case "Cache-Control":
                            Result.Cache = Header.Value.FirstOrDefault();
                            break;
                        case "Date":
                            Result.Date = Header.Value.FirstOrDefault();
                            break;
                        case "ETag":
                            Result.ETag = Header.Value.FirstOrDefault();
                            break;
                        case "Vary":
                            Result.Vary = Header.Value.FirstOrDefault();
                            break;
                        default:
                            break;
                    }
                }

                Result.Success = Response.IsSuccessStatusCode;
                Result.Server = $"{Response.Headers.Server}";
                Result.Reason = Response.ReasonPhrase;
                Result.Status = Response.StatusCode;
                Result.Age = Response.Headers.Age;
                Result.Version = Response.Version;

                return Result;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static async Task<SWWHS> HeaderAsync(string Url = MWWM.Url)
        {
            return await Task.Run(() => Header(Url));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Parameter"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static string Request(string Url = MWWM.Url, Dictionary<string, object> Parameter = null, string Type = MWWM.DefaultType)
        {
            return Request(Url, Parameter, HC.Convert(Type, MWWM.HttpType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Parameter"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static async Task<string> RequestAsync(string Url = MWWM.Url, Dictionary<string, object> Parameter = null, string Type = MWWM.DefaultType)
        {
            return await Task.Run(() => Request(Url, Parameter, Type));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Parameter"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Request(string Url = MWWM.Url, Dictionary<string, object> Parameter = null, EHWT Type = MWWM.HttpType)
        {
            try
            {
                Url = HL.Parameter(Url, MWWM.Url);

                Parameter ??= MI.HttpParameter;

                HttpClient Client = new();

                Task<string> Result = null;
                StringContent Content = null;
                HttpRequestMessage Request = null;
                Task<HttpResponseMessage> Response = null;
                FormUrlEncodedContent Parameters = new(Parameter.Select(Param => new KeyValuePair<string, string>(Param.Key, Param.Value.ToString())));

                switch (Type)
                {
                    case EHWT.GET:
                        Response = Client.GetAsync(Url + "?" + Parameters.ReadAsStringAsync().Result);
                        Result = Response.Result.Content.ReadAsStringAsync();
                        return Result.Result;
                    case EHWT.PUT:
                        Response = Client.PutAsync(Url, Parameters);
                        Result = Response.Result.Content.ReadAsStringAsync();
                        return Result.Result;
                    case EHWT.POST:
                        Response = Client.PostAsync(Url, Parameters);
                        Result = Response.Result.Content.ReadAsStringAsync();
                        return Result.Result;
                    case EHWT.HEAD:
                        Request = new()
                        {
                            Method = HttpMethod.Head,
                            RequestUri = new Uri(Url)
                        };

                        Response = Client.SendAsync(Request);
                        return Response.Result.StatusCode.ToString();
                    case EHWT.DELETE:
                        Request = new()
                        {
                            Method = HttpMethod.Delete,
                            RequestUri = new Uri(Url)
                        };

                        Response = Client.SendAsync(Request);
                        return Response.Result.StatusCode.ToString();
                    case EHWT.PATCH:
                        Content = new(JsonConvert.SerializeObject(Parameter), Encoding.UTF8, "application/json");

                        Request = new()
                        {
                            Method = new HttpMethod("PATCH"),
                            RequestUri = new Uri(Url),
                            Content = Content
                        };

                        Response = Client.SendAsync(Request);
                        return Response.Result.Content.ReadAsStringAsync().Result;
                    case EHWT.OPTIONS:
                        Request = new()
                        {
                            Method = new HttpMethod("OPTIONS"),
                            RequestUri = new Uri(Url)
                        };

                        Response = Client.SendAsync(Request);
                        return Response.Result.Content.ReadAsStringAsync().Result;
                    default:
                        throw new SE(MWWM.Error);
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
        /// <param name="Url"></param>
        /// <param name="Parameter"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static async Task<string> RequestAsync(string Url = MWWM.Url, Dictionary<string, object> Parameter = null, EHWT Type = MWWM.HttpType)
        {
            return await Task.Run(() => Request(Url, Parameter, Type));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static ECWT Compress(string Url = MWWM.Url)
        {
            try
            {
                Url = HL.Parameter(Url, MWWM.Url);

                HttpClient Client = new();

                Client.DefaultRequestHeaders.Add(MWWM.Header, MWWM.Types);

                HttpResponseMessage Response = Client.GetAsync(Url).Result;

                return $"{Response.Content.Headers.ContentEncoding}" switch
                {
                    "deflate" => ECWT.Deflate,
                    "gzip" => ECWT.Gzip,
                    "br" => ECWT.Brotli,
                    _ => ECWT.None,
                };
            }
            catch
            {
                return MWWM.CompressType;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static async Task<ECWT> CompressAsync(string Url = MWWM.Url)
        {
            return await Task.Run(() => Compress(Url));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url1"></param>
        /// <param name="Url2"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static string Similarity(string Url1 = MWWM.Url, string Url2 = MWWM.Url, bool Separator = MWWM.Separator)
        {
            try
            {
                Url1 = HL.Parameter(Url1, MWWM.Url);
                Url2 = HL.Parameter(Url2, MWWM.Url);

                double Percent = 0;

                string Content1 = Source(Url1).ToLower();
                string Content2 = Source(Url2).ToLower();

                string[] Words1 = HWWH.GetTags(Content1);
                string[] Words2 = HWWH.GetTags(Content2);

                int Common = Words1.Count(Tag1 => Words2.Any(Tag2 => Tag2 == Tag1));

                int Total = Words1.Length + Words2.Length - Common;
                Percent = (double)Common / Total * 100;

                return HWWH.GetPlaces(Math.Round(decimal.Parse($"{Percent}"), 2), Separator);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url1"></param>
        /// <param name="Url2"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static async Task<string> SimilarityAsync(string Url1 = MWWM.Url, string Url2 = MWWM.Url, bool Separator = MWWM.Separator)
        {
            return await Task.Run(() => Similarity(Url1, Url2, Separator));
        }
    }
}