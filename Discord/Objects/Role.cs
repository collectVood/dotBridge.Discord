using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Role
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;

        [JsonProperty(PropertyName = "name")]
        public string Name;

        [JsonProperty(PropertyName = "color")]
        public int Color;

        [JsonProperty(PropertyName = "hoist")]
        public bool Hoist;

        [JsonProperty(PropertyName = "position")]
        public int Position;

        [JsonProperty(PropertyName = "permissions")]
        public int Permissions;

        [JsonProperty(PropertyName = "managed")]
        public bool Managed;

        [JsonProperty(PropertyName = "mentionable")]
        public bool Mentionable;
    }
}
