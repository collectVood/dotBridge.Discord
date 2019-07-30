using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Integration
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;
        
        [JsonProperty(PropertyName = "name")]
        public string Name;
        
        [JsonProperty(PropertyName = "type")]
        public string Type;
        
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled;
        
        [JsonProperty(PropertyName = "syncing")]
        public bool Syncing;
        
        [JsonProperty(PropertyName = "role_id")]
        public string RoleID;
        
        [JsonProperty(PropertyName = "expire_behavior")]
        public string ExpireBehavior;
        
        [JsonProperty(PropertyName = "expire_grace_period")]
        public string ExpireGracePeriod;
        
        // TODO: User
        
        // TODO: Integration account
        
        [JsonProperty(PropertyName = "synced_at")]
        public string SyncedAt;
    }
}