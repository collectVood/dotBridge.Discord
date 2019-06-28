using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class GuildIntegrationsUpdate
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
    }
}