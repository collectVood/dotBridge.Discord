using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Activity
    {
        [JsonProperty(PropertyName = "name")]
        public string Name;
        
        [JsonProperty(PropertyName = "type")]
        public int ActivityTypeRaw;
        
        [JsonProperty(PropertyName = "url")]
        public Optional<string> URL;
        
        [JsonProperty(PropertyName = "timestamps")]
        public Optional<ActivityTimestamps> Timestamps;
        
        [JsonProperty(PropertyName = "application_id")]
        public Optional<int> ApplicationID;
        
        [JsonProperty(PropertyName = "Details")]
        public Optional<string> Details;
        
        [JsonProperty(PropertyName = "state")]
        public Optional<string> State;

        [JsonProperty(PropertyName = "party")]
        public Optional<ActivityParty> Party;

        [JsonProperty(PropertyName = "assets")]
        public Optional<ActivityAssets> Assets;

        [JsonProperty(PropertyName = "secrets")]
        public Optional<ActivitySecrets> Secrets;
        
        [JsonProperty(PropertyName = "instance")]
        public Optional<bool> Instance;
        
        [JsonProperty(PropertyName = "flags")]
        public Optional<int> Flags;

        [JsonIgnore]
        public ActivityType? ActivityType => (ActivityType?) ActivityTypeRaw;
    }
}