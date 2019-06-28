using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class UpdateVoiceState
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        [JsonProperty(PropertyName = "channel_id")]
        public string Channel;
        
        [JsonProperty(PropertyName = "self_mute")]
        public bool SelfMute;
        
        [JsonProperty(PropertyName = "self_deaf")]
        public bool SelfDeaf;
    }
}