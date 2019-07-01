using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class AuditEntryInfo
    {
        /// <summary>
        /// MEMBER_PRUNE
        /// </summary>
        [JsonProperty(PropertyName = "delete_member_days")]
        public Optional<string> DeleteMemberDays;
        
        /// <summary>
        /// MEMBER_PRUNE
        /// </summary>
        [JsonProperty(PropertyName = "members_removed")]
        public Optional<string> MembersRemoved;
        
        /// <summary>
        /// MESSAGE_DELETE
        /// </summary>
        [JsonProperty(PropertyName = "channel_id")]
        public Optional<string> ChannelID;
        
        /// <summary>
        /// MESSAGE_DELETE
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public Optional<string> Count;
        
        /// <summary>
        /// CHANNEL_OVERWRITE_CREATE and CHANNEL_OVERWRITE_UPDATE and CHANNEL_OVERWRITE_DELETE
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Optional<string> ID;
        
        /// <summary>
        /// CHANNEL_OVERWRITE_CREATE and CHANNEL_OVERWRITE_UPDATE and CHANNEL_OVERWRITE_DELETE
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public Optional<string> Type;
        
        /// <summary>
        /// CHANNEL_OVERWRITE_CREATE and CHANNEL_OVERWRITE_UPDATE and CHANNEL_OVERWRITE_DELETE
        /// </summary>
        [JsonProperty(PropertyName = "role_name")]
        public Optional<string> RoleName;
    }
}