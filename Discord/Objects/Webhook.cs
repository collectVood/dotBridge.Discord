using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Webhook
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;

        [JsonProperty(PropertyName = "guild_id")]
        public Optional<string> GuildId;

        [JsonProperty(PropertyName = "channel_id")]
        public string Channel;

        [JsonProperty(PropertyName = "user")]
        public Optional<User> User;

        [JsonProperty(PropertyName = "name")]
        public string Name;

        [JsonProperty(PropertyName = "avatar")]
        public string Avatar;

        [JsonProperty(PropertyName = "token")]
        public string Token;
    }
}