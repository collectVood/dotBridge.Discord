using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Invite
    {
        [JsonProperty(PropertyName = "code")]
        public string Code;

        [JsonProperty(PropertyName = "guild")]
        public Optional<Guild> Guild;

        [JsonProperty(PropertyName = "channel")]
        public Channel Channel;

        [JsonProperty(PropertyName = "target_user")]
        public User TargetUser;

        [JsonProperty(PropertyName = "target_user_type")]
        public Optional<int> TargetUserType;

        [JsonProperty(PropertyName = "approximate_presence_count")]
        public Optional<int> ApproximatePresenceCount;

        [JsonProperty(PropertyName = "approximate_member_count")]
        public Optional<int> ApproximateMemberCount;
    }
}
