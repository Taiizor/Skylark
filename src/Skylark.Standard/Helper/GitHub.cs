using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using SE = Skylark.Exception;
using SSIIR = Skylark.Standard.Interface.IReleases;

namespace Skylark.Standard.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class GitHub
    {
        /// <summary>
        /// 
        /// </summary>
        private const string Value = "0";

        /// <summary>
        /// 
        /// </summary>
        private const string Owner = "Taiizor";

        /// <summary>
        /// 
        /// </summary>
        private const string Branch = "develop";

        /// <summary>
        /// 
        /// </summary>
        private const string Repository = "Skylark";

        /// <summary>
        /// 
        /// </summary>
        private static readonly HttpClient Client = new();

        /// <summary>
        /// 
        /// </summary>
        private const string Uri = "https://api.github.com";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Releases(string Owner = Owner, string Repository = Repository)
        {
            Client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

            HttpResponseMessage Response = Client.GetAsync($"{Uri}/repos/{Owner}/{Repository}/releases").Result;

            if (Response.IsSuccessStatusCode)
            {
                return Response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                throw new SE("API Error: " + Response.ReasonPhrase);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <returns></returns>
        public static async Task<string> ReleasesAsync(string Owner = Owner, string Repository = Repository)
        {
            return await Task.Run(() => Releases(Owner, Repository));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <returns></returns>
        public static JArray ReleasesJArray(string Owner = Owner, string Repository = Repository)
        {
            return JArray.Parse(Releases(Owner, Repository));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <returns></returns>
        public static async Task<JArray> ReleasesJArrayAsync(string Owner = Owner, string Repository = Repository)
        {
            return await Task.Run(() => ReleasesJArray(Owner, Repository));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <returns></returns>
        public static List<SSIIR> ReleasesList(string Owner = Owner, string Repository = Repository)
        {
            return JsonConvert.DeserializeObject<List<SSIIR>>(Releases(Owner, Repository));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <returns></returns>
        public static async Task<List<SSIIR>> ReleasesListAsync(string Owner = Owner, string Repository = Repository)
        {
            return await Task.Run(() => ReleasesList(Owner, Repository));
        }
    }
}