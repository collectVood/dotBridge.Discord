using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class GuildMember
    {
        // TODO: User

        [JsonProperty(PropertyName = "nick")]
        public Optional<string> Nick;

        [JsonProperty(PropertyName = "roles")]
        public string[] Roles;

        [JsonProperty(PropertyName = "joined_at")]
        public string JoinedAt;

        [JsonProperty(PropertyName = "premium_since")]
        public string PremiumSince;

        [JsonProperty(PropertyName = "deaf")]
        public bool Deaf;

        [JsonProperty(PropertyName = "mute")]
        public bool Mute;
    }
}