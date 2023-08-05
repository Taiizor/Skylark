using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SE = Skylark.Exception;
using SSIIC = Skylark.Standard.Interface.IContents;
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
        private const string Path = null;

        /// <summary>
        /// 
        /// </summary>
        private const string Token = null;

        /// <summary>
        /// 
        /// </summary>
        private const string Branch = null;

        /// <summary>
        /// 
        /// </summary>
        private const string Owner = "Taiizor";

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
        private const string Agent = "Awesome-Skylark-Library";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Releases(string Owner = Owner, string Repository = Repository, string UserAgent = Agent, string Authorization = Token)
        {
            InitializeClient(UserAgent, Authorization);

            HttpResponseMessage Response = Client.GetAsync($"{Uri}/repos/{Owner}/{Repository}/releases").Result;

            string Result = Response.Content.ReadAsStringAsync().Result;

            if (Response.IsSuccessStatusCode)
            {
                return Result;
            }
            else
            {
                throw new SE(Result);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static async Task<string> ReleasesAsync(string Owner = Owner, string Repository = Repository, string UserAgent = Agent, string Authorization = Token)
        {
            return await Task.Run(() => Releases(Owner, Repository, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static object ReleasesObject(string Owner = Owner, string Repository = Repository, string UserAgent = Agent, string Authorization = Token)
        {
            return JsonConvert.DeserializeObject(Releases(Owner, Repository, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static async Task<object> ReleasesObjectAsync(string Owner = Owner, string Repository = Repository, string UserAgent = Agent, string Authorization = Token)
        {
            return await Task.Run(() => ReleasesObject(Owner, Repository, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static JArray ReleasesJArray(string Owner = Owner, string Repository = Repository, string UserAgent = Agent, string Authorization = Token)
        {
            return JArray.Parse(Releases(Owner, Repository, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static async Task<JArray> ReleasesJArrayAsync(string Owner = Owner, string Repository = Repository, string UserAgent = Agent, string Authorization = Token)
        {
            return await Task.Run(() => ReleasesJArray(Owner, Repository, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static List<SSIIR> ReleasesList(string Owner = Owner, string Repository = Repository, string UserAgent = Agent, string Authorization = Token)
        {
            return JsonConvert.DeserializeObject<List<SSIIR>>(Releases(Owner, Repository, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static async Task<List<SSIIR>> ReleasesListAsync(string Owner = Owner, string Repository = Repository, string UserAgent = Agent, string Authorization = Token)
        {
            return await Task.Run(() => ReleasesList(Owner, Repository, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="Path"></param>
        /// <param name="Branch"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string Contents(string Owner = Owner, string Repository = Repository, string Path = Path, string Branch = Branch, string UserAgent = Agent, string Authorization = Token)
        {
            InitializeClient(UserAgent, Authorization);

            string BaseUri = $"{Uri}/repos/{Owner}/{Repository}/contents";

            if (!string.IsNullOrEmpty(Path))
            {
                BaseUri += $"/{Path}";
            }

            if (!string.IsNullOrEmpty(Branch))
            {
                BaseUri += $"?ref={Branch}";
            }

            HttpResponseMessage Response = Client.GetAsync(BaseUri).Result;

            string Result = Response.Content.ReadAsStringAsync().Result;

            if (Response.IsSuccessStatusCode)
            {
                return Result;
            }
            else
            {
                throw new SE(Result);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="Path"></param>
        /// <param name="Branch"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static async Task<string> ContentsAsync(string Owner = Owner, string Repository = Repository, string Path = Path, string Branch = Branch, string UserAgent = Agent, string Authorization = Token)
        {
            return await Task.Run(() => Contents(Owner, Repository, Path, Branch, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="Path"></param>
        /// <param name="Branch"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static object ContentsObject(string Owner = Owner, string Repository = Repository, string Path = Path, string Branch = Branch, string UserAgent = Agent, string Authorization = Token)
        {
            return JsonConvert.DeserializeObject(Contents(Owner, Repository, Path, Branch, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="Path"></param>
        /// <param name="Branch"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static async Task<object> ContentsObjectAsync(string Owner = Owner, string Repository = Repository, string Path = Path, string Branch = Branch, string UserAgent = Agent, string Authorization = Token)
        {
            return await Task.Run(() => ContentsObject(Owner, Repository, Path, Branch, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="Path"></param>
        /// <param name="Branch"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static JArray ContentsJArray(string Owner = Owner, string Repository = Repository, string Path = Path, string Branch = Branch, string UserAgent = Agent, string Authorization = Token)
        {
            return JArray.Parse(Contents(Owner, Repository, Path, Branch, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="Path"></param>
        /// <param name="Branch"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static async Task<JArray> ContentsJArrayAsync(string Owner = Owner, string Repository = Repository, string Path = Path, string Branch = Branch, string UserAgent = Agent, string Authorization = Token)
        {
            return await Task.Run(() => ContentsJArray(Owner, Repository, Path, Branch, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="Path"></param>
        /// <param name="Branch"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static List<SSIIC> ContentsList(string Owner = Owner, string Repository = Repository, string Path = Path, string Branch = Branch, string UserAgent = Agent, string Authorization = Token)
        {
            return JsonConvert.DeserializeObject<List<SSIIC>>(Contents(Owner, Repository, Path, Branch, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Owner"></param>
        /// <param name="Repository"></param>
        /// <param name="Path"></param>
        /// <param name="Branch"></param>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        /// <returns></returns>
        public static async Task<List<SSIIC>> ContentsListAsync(string Owner = Owner, string Repository = Repository, string Path = Path, string Branch = Branch, string UserAgent = Agent, string Authorization = Token)
        {
            return await Task.Run(() => ContentsList(Owner, Repository, Path, Branch, UserAgent, Authorization));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <param name="Authorization"></param>
        private static void InitializeClient(string UserAgent = Agent, string Authorization = Token)
        {
            if (!Client.DefaultRequestHeaders.Contains("User-Agent"))
            {
                if (string.IsNullOrEmpty(UserAgent))
                {
                    UserAgent = Agent;
                }

                Client.DefaultRequestHeaders.Add("User-Agent", UserAgent);
            }

            if (!Client.DefaultRequestHeaders.Contains("Authorization") && !string.IsNullOrEmpty(Authorization))
            {
                Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Authorization}");
            }
        }
    }
}