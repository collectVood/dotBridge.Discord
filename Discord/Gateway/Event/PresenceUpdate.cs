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
        
        [JsonProperty(PropertyName = "game")]
        public Activity Game;
        
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        [JsonProperty(PropertyName = "status")]
        public string StatusRaw;
        
        [JsonProperty(PropertyName = "activities")]
        public Activity[] Activities;
        
        [JsonProperty(PropertyName = "client_status")]
        public ClientStatus ClientStatus;

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