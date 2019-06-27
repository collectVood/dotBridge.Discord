using Newtonsoft.Json;

namespace DotDiscord.Objects
{
    public class Activity
    {
        [JsonProperty(PropertyName = "name")]
        public string Name;
        
        [JsonProperty(PropertyName = "type")]
        public int ActivityTypeRaw;
        
        [JsonProperty(PropertyName = "url")]
        public string URL;
        
        // TODO: Timestamps object
        
        [JsonProperty(PropertyName = "application_id")]
        public int? ApplicationID;
        
        [JsonProperty(PropertyName = "Details")]
        public string Details;
        
        [JsonProperty(PropertyName = "state")]
        public string State;
        
        // TODO: Party object
        
        // TODO: Assets object
        
        // TODO: Secrets object
        
        [JsonProperty(PropertyName = "instance")]
        public bool? Instance;
        
        [JsonProperty(PropertyName = "flags")]
        public int? Flags;

        [JsonIgnore]
        public ActivityType? ActivityType => (ActivityType?) ActivityTypeRaw;
    }
}