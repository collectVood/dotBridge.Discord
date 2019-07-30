using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Connection
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;

        [JsonProperty(PropertyName = "name")]
        public string Name;

        [JsonProperty(PropertyName = "type")]
        public string Type;

        [JsonProperty(PropertyName = "revoked")]
        public bool revoked;

        [JsonProperty(PropertyName = "integrations")]
        public Integration[] Integrations;

        [JsonProperty(PropertyName = "verified")]
        public bool Verified;

        [JsonProperty(PropertyName = "friend_sync")]
        public bool FriendSync;

        [JsonProperty(PropertyName = "show_activity")]
        public bool ShowActivity;

        [JsonProperty(PropertyName = "visibility")]
        public int Visibility;
    }
}
