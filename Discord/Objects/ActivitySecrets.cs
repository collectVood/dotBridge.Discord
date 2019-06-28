using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class ActivitySecrets
    {
        [JsonProperty(PropertyName = "join")]
        public Optional<string> Join;
        
        [JsonProperty(PropertyName = "spectate")]
        public Optional<string> Spectate;
        
        [JsonProperty(PropertyName = "match")]
        public Optional<string> Match;
    }
}