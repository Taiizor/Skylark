using Newtonsoft.Json;

namespace Skylark.Standard.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public class IReactions
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eyes", Required = Required.Default)]
        public long Eyes { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("url", Required = Required.Default)]
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("heart", Required = Required.Default)]
        public long Heart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("laugh", Required = Required.Default)]
        public long Laugh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rocket", Required = Required.Default)]
        public long Rocket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hooray", Required = Required.Default)]
        public long Hooray { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("+1", Required = Required.Default)]
        public long PlusOne { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("-1", Required = Required.Default)]
        public long MinusOne { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("confused", Required = Required.Default)]
        public long Confused { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_count", Required = Required.Default)]
        public long TotalCount { get; set; }
    }
}