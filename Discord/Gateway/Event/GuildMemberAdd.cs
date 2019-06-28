using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class GuildMemberAdd
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
    }
}