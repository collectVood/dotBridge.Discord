using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class MessageActivity
    {
        [JsonProperty(PropertyName = "type")]
        public int RawType;

        [JsonProperty(PropertyName = "party_id")]
        public Optional<string> PartyID;
    }
}