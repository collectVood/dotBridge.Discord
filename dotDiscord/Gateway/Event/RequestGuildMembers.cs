using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class RequestGuildMembers
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;

        [JsonProperty(PropertyName = "query")]
        public string Query;

        [JsonProperty(PropertyName = "limit")]
        public int Limit;
    }
}