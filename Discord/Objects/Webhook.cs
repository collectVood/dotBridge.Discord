using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Webhook
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;

        [JsonProperty(PropertyName = "guild_id")]
        public Optional<string> GuildID;

        [JsonProperty(PropertyName = "channel_id")]
        public string ChannelID;

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