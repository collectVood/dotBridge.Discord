using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class AuditLogEntry
    {
        [JsonProperty(PropertyName = "target_id")]
        public string TargetID;
        
        [JsonProperty(PropertyName = "changes")]
        public Optional<AuditLogChange[]> Changes;
        
        [JsonProperty(PropertyName = "user_id")]
        public string UserID;
        
        [JsonProperty(PropertyName = "id")]
        public string ID;
        
        [JsonProperty(PropertyName = "action_type")]
        public AuditLogEvent Type;
        
        // TODO: Audit Entry Info
        
        [JsonProperty(PropertyName = "reason")]
        public Optional<string> Reason;
    }
}