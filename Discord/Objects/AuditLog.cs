using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class AuditLog
    {
        // TODO: Webhooks array
        
        // TODO: Users array

        [JsonProperty(PropertyName = "audit_log_entries")]
        public AuditLogEntry[] AuditLogEntries;
    }
}