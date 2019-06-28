using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class Hello
    {
        [JsonProperty(PropertyName = "heartbeat_interval")]
        public int HeartbeatInterval;

        [JsonProperty(PropertyName = "_trace")]
        public string[] Trace;
    }
}