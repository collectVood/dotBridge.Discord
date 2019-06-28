using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
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