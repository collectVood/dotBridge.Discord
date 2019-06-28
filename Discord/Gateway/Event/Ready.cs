using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class Ready
    {
        [JsonProperty(PropertyName = "v")]
        public int Version;
        
        // TODO: User
        
        // TODO: Unavailable Guilds
        
        [JsonProperty(PropertyName = "session_id")]
        public string Session;

        [JsonProperty(PropertyName = "_trace")]
        public string[] Trace;
    }
}