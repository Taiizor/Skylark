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
        /// <exception cref="SE"></exception>
        public static string Source(string Url = SSMWWM.Url)
        {
            try
            {
                Url = SHL.Parameter(Url, SSMWWM.Url);

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
        public static async Task<string> SourceAsync(string Url = SSMWWM.Url)
        {
            return await Task.Run(() => Source(Url));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static SSWWRS Ratio(string Url = SSMWWM.Url, bool Separator = SSMWWM.Separator)
        {
            try
            {
                Url = SHL.Parameter(Url, SSMWWM.Url);

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
                    Rate = SSHWWH.GetPlaces(Math.Round(decimal.Parse(Rate), 2), Separator),
                    Total = SSHWWH.GetPlaces(Total, Separator),
                    Text = SSHWWH.GetPlaces(Text, Separator),
                    Code = SSHWWH.GetPlaces(Code, Separator)
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
        public static async Task<SSWWRS> RatioAsync(string Url = SSMWWM.Url, bool Separator = SSMWWM.Separator)
        {
            return await Task.Run(() => Ratio(Url, Separator));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static SSWWHS Header(string Url = SSMWWM.Url)
        {
            try
            {
                Url = SHL.Parameter(Url, SSMWWM.Url);

                SSWWHS Result = new();

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
        public static async Task<SSWWHS> HeaderAsync(string Url = SSMWWM.Url)
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
        public static string Request(string Url = SSMWWM.Url, Dictionary<string, object> Parameter = null, string Type = SSMWWM.DefaultType)
        {
            return Request(Url, Parameter, SHC.Convert(Type, SSMWWM.HttpType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Parameter"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static async Task<string> RequestAsync(string Url = SSMWWM.Url, Dictionary<string, object> Parameter = null, string Type = SSMWWM.DefaultType)
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
        public static string Request(string Url = SSMWWM.Url, Dictionary<string, object> Parameter = null, SEHWT Type = SSMWWM.HttpType)
        {
            try
            {
                Url = SHL.Parameter(Url, SSMWWM.Url);

                Parameter ??= SSMI.HttpParameter;

                HttpClient Client = new();

                Task<string> Result = null;
                StringContent Content = null;
                HttpRequestMessage Request = null;
                Task<HttpResponseMessage> Response = null;
                FormUrlEncodedContent Parameters = new(Parameter.Select(Param => new KeyValuePair<string, string>(Param.Key, Param.Value.ToString())));

                switch (Type)
                {
                    case SEHWT.GET:
                        Response = Client.GetAsync(Url + "?" + Parameters.ReadAsStringAsync().Result);
                        Result = Response.Result.Content.ReadAsStringAsync();
                        return Result.Result;
                    case SEHWT.PUT:
                        Response = Client.PutAsync(Url, Parameters);
                        Result = Response.Result.Content.ReadAsStringAsync();
                        return Result.Result;
                    case SEHWT.POST:
                        Response = Client.PostAsync(Url, Parameters);
                        Result = Response.Result.Content.ReadAsStringAsync();
                        return Result.Result;
                    case SEHWT.HEAD:
                        Request = new()
                        {
                            Method = HttpMethod.Head,
                            RequestUri = new Uri(Url)
                        };

                        Response = Client.SendAsync(Request);
                        return Response.Result.StatusCode.ToString();
                    case SEHWT.DELETE:
                        Request = new()
                        {
                            Method = HttpMethod.Delete,
                            RequestUri = new Uri(Url)
                        };

                        Response = Client.SendAsync(Request);
                        return Response.Result.StatusCode.ToString();
                    case SEHWT.PATCH:
                        Content = new(JsonConvert.SerializeObject(Parameter), Encoding.UTF8, "application/json");

                        Request = new()
                        {
                            Method = new HttpMethod("PATCH"),
                            RequestUri = new Uri(Url),
                            Content = Content
                        };

                        Response = Client.SendAsync(Request);
                        return Response.Result.Content.ReadAsStringAsync().Result;
                    case SEHWT.OPTIONS:
                        Request = new()
                        {
                            Method = new HttpMethod("OPTIONS"),
                            RequestUri = new Uri(Url)
                        };

                        Response = Client.SendAsync(Request);
                        return Response.Result.Content.ReadAsStringAsync().Result;
                    default:
                        throw new SE(SSMWWM.Error);
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
        public static async Task<string> RequestAsync(string Url = SSMWWM.Url, Dictionary<string, object> Parameter = null, SEHWT Type = SSMWWM.HttpType)
        {
            return await Task.Run(() => Request(Url, Parameter, Type));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static SECWT Compress(string Url = SSMWWM.Url)
        {
            try
            {
                Url = SHL.Parameter(Url, SSMWWM.Url);

                HttpClient Client = new();

                Client.DefaultRequestHeaders.Add(SSMWWM.Header, SSMWWM.Types);

                HttpResponseMessage Response = Client.GetAsync(Url).Result;

                return $"{Response.Content.Headers.ContentEncoding}" switch
                {
                    "deflate" => SECWT.Deflate,
                    "gzip" => SECWT.Gzip,
                    "br" => SECWT.Brotli,
                    _ => SECWT.None,
                };
            }
            catch
            {
                return SSMWWM.CompressType;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static async Task<SECWT> CompressAsync(string Url = SSMWWM.Url)
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
        /// <exception cref="SE"></exception>
        public static string Similarity(string Url1 = SSMWWM.Url, string Url2 = SSMWWM.Url, bool Separator = SSMWWM.Separator)
        {
            try
            {
                Url1 = SHL.Parameter(Url1, SSMWWM.Url);
                Url2 = SHL.Parameter(Url2, SSMWWM.Url);

                double Percent = 0;

                string Content1 = Source(Url1).ToLower();
                string Content2 = Source(Url2).ToLower();

                string[] Words1 = SSHWWH.GetTags(Content1);
                string[] Words2 = SSHWWH.GetTags(Content2);

                int Common = Words1.Count(Tag1 => Words2.Any(Tag2 => Tag2 == Tag1));

                int Total = Words1.Length + Words2.Length - Common;
                Percent = (double)Common / Total * 100;

                return SSHWWH.GetPlaces(Math.Round(decimal.Parse($"{Percent}"), 2), Separator);
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
        public static async Task<string> SimilarityAsync(string Url1 = SSMWWM.Url, string Url2 = SSMWWM.Url, bool Separator = SSMWWM.Separator)
        {
            return await Task.Run(() => Similarity(Url1, Url2, Separator));
        }
    }
}