using System;
using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class ChannelPinsUpdate
    {
        [JsonProperty(PropertyName = "guild_id")]
        public Optional<string> Guild;
        
        [JsonProperty(PropertyName = "channel_id")]
        public string Channel;
        
        [JsonProperty(PropertyName = "last_pin_timestamp")]
        public Optional<string> LastPinRaw;

        [JsonIgnore]
        public DateTime? LastPin
        {
            get
            {
                if (string.IsNullOrEmpty(LastPinRaw.GetValue()) || !DateTime.TryParse(LastPinRaw.Value, out var result))
                    return null;

                return result;
            }
        }
    }
}