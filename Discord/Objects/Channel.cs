using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Channel
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;

        [JsonProperty(PropertyName = "type")]
        public int RawType;

        [JsonProperty(PropertyName = "guild_id")]
        public Optional<string> GuildID;

        [JsonProperty(PropertyName = "position")]
        public Optional<int> Position;
        
        // TODO: Array of overwrite

        [JsonProperty(PropertyName = "name")]
        public Optional<string> Name;

        [JsonProperty(PropertyName = "topic")]
        public Optional<string> Topic;

        [JsonProperty(PropertyName = "nsfw")]
        public Optional<bool> Nsfw;

        [JsonProperty(PropertyName = "last_message_id")]
        public Optional<string> LastMessageID;

        [JsonProperty(PropertyName = "bitrate")]
        public Optional<int> BitRate;

        [JsonProperty(PropertyName = "user_limit")]
        public Optional<int> UserLimit;

        [JsonProperty(PropertyName = "rate_limit_per_user")]
        public Optional<int> RateLimitPerUser;
        
        // TODO: Array of user

        [JsonProperty(PropertyName = "icon")]
        public Optional<string> Icon;

        [JsonProperty(PropertyName = "owner_id")]
        public Optional<string> OwnerID;

        [JsonProperty(PropertyName = "application_id")]
        public Optional<string> ApplicationID;

        [JsonProperty(PropertyName = "parent_id")]
        public Optional<string> ParentID;

        [JsonProperty(PropertyName = "last_pin_timestamp")]
        public Optional<string> RawLastPinTimestamp;
    }
}