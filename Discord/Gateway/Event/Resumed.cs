using Newtonsoft.Json;

namespace dotBridge.Discord.Gateway.Event
{
    public class Resumed
    {
        [JsonProperty(PropertyName = "_trace")]
        public string[] Trace;
    }
}