using Newtonsoft.Json;

namespace Skylark.Standard.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public class IContents
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("size", Required = Required.Default)]
        public long Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sha", Required = Required.Default)]
        public string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("url", Required = Required.Default)]
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name", Required = Required.Default)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("path", Required = Required.Default)]
        public string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type", Required = Required.Default)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("_links", Required = Required.Default)]
        public ILinks Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("git_url", Required = Required.Default)]
        public string GitUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("html_url", Required = Required.Default)]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("download_url", Required = Required.Default)]
        public string DownloadUrl { get; set; }
    }
}