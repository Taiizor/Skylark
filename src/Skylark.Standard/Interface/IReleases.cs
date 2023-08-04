using Newtonsoft.Json;

namespace Skylark.Standard.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public class IReleases
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id", Required = Required.Default)]
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("url", Required = Required.Default)]
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("draft", Required = Required.Default)]
        public bool Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("body", Required = Required.Default)]
        public string Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name", Required = Required.Default)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("zipball_url", Required = Required.Default)]
        public string Zipball { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tarball_url", Required = Required.Default)]
        public string Tarball { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tag_name", Required = Required.Default)]
        public string TagName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prerelease", Required = Required.Default)]
        public bool PreRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_at", Required = Required.Default)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mentions_count", Required = Required.Default)]
        public long MentionsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("published_at", Required = Required.Default)]
        public DateTime PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assets", Required = Required.Default)]
        public List<IAssets> Assets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("reactions", Required = Required.Default)]
        public IReactions Reactions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_commitish", Required = Required.Default)]
        public string TargetCommitish { get; set; }
    }
}