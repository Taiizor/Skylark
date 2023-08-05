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
        private static readonly TimeSpan Time = TimeSpan.FromMinutes(5);

        /// <summary>
        /// 
        /// </summary>
        private static readonly Dictionary<string, CachedData> Cache = new();

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
            string[] Keys = { Owner, Repository, UserAgent, Authorization };
            string Key = string.Join(",", Keys);

            if (Cache.TryGetValue(Key, out CachedData Data))
            {
                if (DateTime.Now - Data.Timestamp < Time)
                {
                    if (Data.Status)
                    {
                        return Data.Content;
                    }
                    else
                    {
                        throw new SE(Data.Content);
                    }
                }
            }

            InitializeClient(UserAgent, Authorization);

            HttpResponseMessage Response = Client.GetAsync($"{Uri}/repos/{Owner}/{Repository}/releases").Result;

            string Result = Response.Content.ReadAsStringAsync().Result;

            Cache[Key] = new CachedData(Response.IsSuccessStatusCode, Result, DateTime.Now);

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
            string[] Keys = { Owner, Repository, Path, Branch, UserAgent, Authorization };
            string Key = string.Join(",", Keys);

            if (Cache.TryGetValue(Key, out CachedData Data))
            {
                if (DateTime.Now - Data.Timestamp < Time)
                {
                    if (Data.Status)
                    {
                        return Data.Content;
                    }
                    else
                    {
                        throw new SE(Data.Content);
                    }
                }
            }

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

            Cache[Key] = new CachedData(Response.IsSuccessStatusCode, Result, DateTime.Now);

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
            Client.DefaultRequestHeaders.Clear();

            if (string.IsNullOrEmpty(UserAgent))
            {
                UserAgent = Agent;
            }

            Client.DefaultRequestHeaders.Add("User-Agent", UserAgent);

            if (!string.IsNullOrEmpty(Authorization))
            {
                Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Authorization}");
            }
        }

        public class CachedData(bool status, string content, DateTime timestamp)
        {
            public bool Status { get; } = status;

            public string Content { get; } = content;

            public DateTime Timestamp { get; } = timestamp;
        }
    }
}