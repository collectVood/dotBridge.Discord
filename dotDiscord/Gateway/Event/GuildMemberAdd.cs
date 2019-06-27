using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class GuildMemberAdd
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
    }
}