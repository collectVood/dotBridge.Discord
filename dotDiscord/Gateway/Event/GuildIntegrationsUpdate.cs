using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class GuildIntegrationsUpdate
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
    }
}