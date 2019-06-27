using System;
using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class ChannelPinsUpdate
    {
        [JsonProperty(PropertyName = "guild_id")]
        public string Guild;
        
        [JsonProperty(PropertyName = "channel_id")]
        public string Channel;
        
        [JsonProperty(PropertyName = "last_pin_timestamp")]
        public string LastPinRaw;

        [JsonIgnore]
        public DateTime? LastPin
        {
            get
            {
                if (string.IsNullOrEmpty(LastPinRaw) || !DateTime.TryParse(LastPinRaw, out var result))
                    return null;

                return result;
            }
        }
    }
}