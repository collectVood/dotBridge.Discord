using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class PresenceUpdate
    {
        [JsonProperty(PropertyName = "user")]
        public User User;

        [JsonProperty(PropertyName = "roles")]
        public string[] Roles;

        [JsonProperty(PropertyName = "game")]
        public Activity Game;

        [JsonProperty(PropertyName = "guild_id")]
        public string GuildID;

        [JsonProperty(PropertyName = "status")]
        public string Status;

        [JsonProperty(PropertyName = "activities")]
        public Activity[] Activities;

        [JsonProperty(PropertyName = "client_status")]
        public ClientStatus ClientStatus;
    }
}
