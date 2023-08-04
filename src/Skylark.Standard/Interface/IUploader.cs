using Newtonsoft.Json;

namespace Skylark.Standard.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public class IUploader
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
        [JsonProperty("type", Required = Required.Default)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("login", Required = Required.Default)]
        public string Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("node_id", Required = Required.Default)]
        public string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("html_url", Required = Required.Default)]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("site_admin", Required = Required.Default)]
        public bool SiteAdmin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gists_url", Required = Required.Default)]
        public string GistsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("repos_url", Required = Required.Default)]
        public string ReposUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("events_url", Required = Required.Default)]
        public string EventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("avatar_url", Required = Required.Default)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("starred_url", Required = Required.Default)]
        public string StarredUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gravatar_id", Required = Required.Default)]
        public string GravatarId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("followers_url", Required = Required.Default)]
        public string FollowersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("following_url", Required = Required.Default)]
        public string FollowingUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subscriptions_url", Required = Required.Default)]
        public string SubscriptionsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("organizations_url", Required = Required.Default)]
        public string OrganizationsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("received_events_url", Required = Required.Default)]
        public string ReceivedEventsUrl { get; set; }
    }
}