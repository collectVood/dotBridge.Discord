using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class GuildEmojisUpdate
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        // TODO: Emojis array
    }
}