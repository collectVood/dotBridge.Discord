using Newtonsoft.Json;

namespace DotDiscord.Gateway.Event
{
    public class Resumed
    {
        [JsonProperty(PropertyName = "_trace")]
        public string[] Trace;
    }
}