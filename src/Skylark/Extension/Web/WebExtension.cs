using Skylark.Enum;
using System.Text.RegularExpressions;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using HWWH = Skylark.Helper.Web.WebHelper;
using MWWM = Skylark.Manage.Web.WebManage;
using SWWHS = Skylark.Struct.Web.WebHeaderStruct;
using SWWRS = Skylark.Struct.Web.WebRatioStruct;

namespace Skylark.Extension.Web
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
        public static Task<string> SourceAsync(string Url = MWWM.Url)
        {
            return Task.Run(() => Source(Url));
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
                    Rate = HWWH.GetPlaces(Math.Round(decimal.Parse(Rate), 2), Separator),
                    Total = HWWH.GetPlaces(Total, Separator),
                    Text = HWWH.GetPlaces(Text, Separator),
                    Code = HWWH.GetPlaces(Code, Separator)
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
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static Task<SWWRS> RatioAsync(string Url = MWWM.Url, bool Separator = MWWM.Separator)
        {
            return Task.Run(() => Ratio(Url, Separator));
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
        public static Task<SWWHS> HeaderAsync(string Url = MWWM.Url)
        {
            return Task.Run(() => Header(Url));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static CompressWebType Compress(string Url = MWWM.Url)
        {
            try
            {
                Url = HL.Parameter(Url, MWWM.Url);

                HttpClient Client = new();

                Client.DefaultRequestHeaders.Add(MWWM.Header, MWWM.Types);

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
        /// <param name="Url"></param>
        /// <returns></returns>
        public static Task<CompressWebType> CompressAsync(string Url = MWWM.Url)
        {
            return Task.Run(() => Compress(Url));
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
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url1"></param>
        /// <param name="Url2"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static Task<string> SimilarityAsync(string Url1 = MWWM.Url, string Url2 = MWWM.Url, bool Separator = MWWM.Separator)
        {
            return Task.Run(() => Similarity(Url1, Url2, Separator));
        }
    }
}