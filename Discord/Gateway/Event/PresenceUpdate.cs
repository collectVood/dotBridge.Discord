using System;
using dotBridge.Discord.Objects;
using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class PresenceUpdate
    {
        // TODO: User object
        
        [JsonProperty(PropertyName = "roles")]
        public string[] Roles;
        
        // TODO: Activity object
        
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        [JsonProperty(PropertyName = "status")]
        public string StatusRaw;
        
        // TODO: Activities array
        
        // TODO: Client status object

        [JsonIgnore]
        public StatusType? Status
        {
            get
            {
                var parsed = Enum.TryParse<StatusType>(StatusRaw, out var result);
                if (!parsed)
                    return null;

                return result;
            }
        }
    }
}