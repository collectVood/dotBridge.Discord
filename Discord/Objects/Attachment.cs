using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Attachment
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;
        
        [JsonProperty(PropertyName = "filename")]
        public string Filename;
        
        [JsonProperty(PropertyName = "size")]
        public int Size;
        
        [JsonProperty(PropertyName = "url")]
        public string Url;
        
        [JsonProperty(PropertyName = "proxy_url")]
        public string ProxyUrl;
        
        [JsonProperty(PropertyName = "height")]
        public int? Height;
        
        [JsonProperty(PropertyName = "width")]
        public int? Width;
    }
}