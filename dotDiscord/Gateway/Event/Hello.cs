using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class Hello
    {
        [JsonProperty(PropertyName = "heartbeat_interval")]
        public int HeartbeatInterval;

        [JsonProperty(PropertyName = "_trace")]
        public string[] Trace;
    }
}