using Newtonsoft.Json;

namespace Skylark.Standard.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public class ILinks
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("git", Required = Required.Default)]
        public string Git { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("self", Required = Required.Default)]
        public string Self { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("html", Required = Required.Default)]
        public string Html { get; set; }
    }
}