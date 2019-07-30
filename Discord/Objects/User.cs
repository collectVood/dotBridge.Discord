using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class User
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;

        [JsonProperty(PropertyName = "username")]
        public string Username;

        [JsonProperty(PropertyName = "discriminator")]
        public string Discriminator;

        [JsonProperty(PropertyName = "avatar")]
        public string Avatar;

        [JsonProperty(PropertyName = "bot")]
        public Optional<bool> Bot;

        [JsonProperty(PropertyName = "mfa_enabled")]
        public Optional<bool> MfaEnabled;

        [JsonProperty(PropertyName = "locale")]
        public Optional<string> Locale;

        [JsonProperty(PropertyName = "verified")]
        public Optional<bool> Verified;

        [JsonProperty(PropertyName = "email")]
        public Optional<string> Email;

        [JsonProperty(PropertyName = "flags")]
        public Optional<int> Flags;

        [JsonProperty(PropertyName = "premium_type")]
        public Optional<int> PremiumType;
    }
}
