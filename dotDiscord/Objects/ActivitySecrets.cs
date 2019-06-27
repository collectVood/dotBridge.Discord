using Newtonsoft.Json;

namespace DotDiscord.Objects
{
    public class ActivitySecrets
    {
        [JsonProperty(PropertyName = "join")]
        public string Join;
        
        [JsonProperty(PropertyName = "spectate")]
        public string Spectate;
        
        [JsonProperty(PropertyName = "match")]
        public string Match;
    }
}