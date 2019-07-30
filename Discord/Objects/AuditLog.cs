using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class AuditLog
    {
        [JsonProperty(PropertyName = "webhooks")]
        public Webhook[] Webhooks;

        [JsonProperty(PropertyName = "users")]
        public User[] Users;

        [JsonProperty(PropertyName = "audit_log_entries")]
        public AuditLogEntry[] AuditLogEntries;
    }
}