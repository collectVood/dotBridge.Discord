using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class InviteMetadata
    {
        [JsonProperty(PropertyName = "inviter")]
        public User Inviter;

        [JsonProperty(PropertyName = "uses")]
        public int Uses;

        [JsonProperty(PropertyName = "max_uses")]
        public int MaxUses;

        [JsonProperty(PropertyName = "max_age")]
        public int MaxAge;

        [JsonProperty(PropertyName = "temporary")]
        public bool Temporary;

        [JsonProperty(PropertyName = "created_at")]
        public string RawCreatedAt;

        [JsonProperty(PropertyName = "revoked")]
        public bool Revoked;
    }
}
