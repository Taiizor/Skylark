using Newtonsoft.Json;

namespace Skylark.Standard.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public class IAssets
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id", Required = Required.Default)]
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("size", Required = Required.Default)]
        public long Size { get; set; }

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
        [JsonProperty("state", Required = Required.Default)]
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("label", Required = Required.Default)]
        public object Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("node_id", Required = Required.Default)]
        public string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("uploader", Required = Required.Default)]
        public IUploader Uploader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("content_type", Required = Required.Default)]
        public string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("download_count", Required = Required.Default)]
        public long DownloadCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_at", Required = Required.Default)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("updated_at", Required = Required.Default)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("browser_download_url", Required = Required.Default)]
        public string BrowserDownloadUrl { get; set; }
    }
}