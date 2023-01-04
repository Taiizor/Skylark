using Skylark.Enum;
using System.Text.RegularExpressions;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using HWH = Skylark.Helper.WebHelper;
using MWM = Skylark.Manage.WebManage;
using SWHS = Skylark.Struct.WebHeaderStruct;
using SWRS = Skylark.Struct.WebRatioStruct;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class WebExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string Source(string Url = MWM.Url)
        {
            try
            {
                Url = HL.Parameter(Url, MWM.Url);

                HttpClient Client = new();

                return Client.GetStringAsync(Url).Result;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static SWRS Ratio(string Url = MWM.Url, bool Separator = MWM.Separator)
        {
            try
            {
                Url = HL.Parameter(Url, MWM.Url);

                string Rate;
                string Code;
                string Text;
                string Total;

                string Content = Source(Url);

                int CodeCount = Regex.Matches(Content, @"<[^>]*>").Count;
                int TextCount = Regex.Matches(Content, @"[^\s]").Count;

                Rate = $"{CodeCount * 100d / TextCount}";
                Total = $"{Content.Length}";
                Text = $"{TextCount}";
                Code = $"{CodeCount}";

                return new()
                {
                    Rate = HWH.GetPlaces(Math.Round(decimal.Parse(Rate), 2), Separator),
                    Total = HWH.GetPlaces(Total, Separator),
                    Text = HWH.GetPlaces(Text, Separator),
                    Code = HWH.GetPlaces(Code, Separator)
                };
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static SWHS Header(string Url = MWM.Url)
        {
            try
            {
                Url = HL.Parameter(Url, MWM.Url);

                SWHS Result = new();

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
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static CompressWebType Compress(string Url = MWM.Url)
        {
            try
            {
                Url = HL.Parameter(Url, MWM.Url);

                HttpClient Client = new();

                Client.DefaultRequestHeaders.Add(MWM.Header, MWM.Types);

                HttpResponseMessage Response = Client.GetAsync(Url).Result;

                return $"{Response.Content.Headers.ContentEncoding}" switch
                {
                    "deflate" => CompressWebType.Deflate,
                    "gzip" => CompressWebType.Gzip,
                    "br" => CompressWebType.Brotli,
                    _ => CompressWebType.None,
                };
            }
            catch
            {
                return CompressWebType.None;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url1"></param>
        /// <param name="Url2"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static string Similar(string Url1 = MWM.Url, string Url2 = MWM.Url, bool Separator = MWM.Separator)
        {
            try
            {
                Url1 = HL.Parameter(Url1, MWM.Url);
                Url2 = HL.Parameter(Url2, MWM.Url);

                double Percent = 0;

                string Content1 = Source(Url1).ToLower();
                string Content2 = Source(Url2).ToLower();

                string[] Words1 = HWH.GetTags(Content1);
                string[] Words2 = HWH.GetTags(Content2);

                int Common = Words1.Where(Tag1 => Words2.Any(Tag2 => Tag2 == Tag1)).Count();

                int Total = Words1.Length + Words2.Length - Common;
                Percent = (double)Common / Total * 100;

                return HWH.GetPlaces(Math.Round(decimal.Parse($"{Percent}"), 2), Separator);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}