using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class VoiceState
    {
        [JsonProperty(PropertyName = "guild_id")]
        public Optional<string> GuildID;

        [JsonProperty(PropertyName = "channel_id")]
        public string ChannelID;

        [JsonProperty(PropertyName = "user_id")]
        public string UserID;

        [JsonProperty(PropertyName = "member")]
        public Optional<GuildMember> Member;

        [JsonProperty(PropertyName = "session_id")]
        public string SessionID;

        [JsonProperty(PropertyName = "deaf")]
        public bool Deaf;

        [JsonProperty(PropertyName = "mute")]
        public bool Mute;

        [JsonProperty(PropertyName = "self_deaf")]
        public bool SelfDeaf;

        [JsonProperty(PropertyName = "self_mute")]
        public bool SelfMute;

        [JsonProperty(PropertyName = "suppress")]
        public bool Suppress;
    }
}
