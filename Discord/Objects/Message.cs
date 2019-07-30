using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Message
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;
        
        [JsonProperty(PropertyName = "channel_id")]
        public string ChannelID;
        
        [JsonProperty(PropertyName = "guild_id")]
        public Optional<string> GuildID;
        
        // TODO: User
        
        // TODO: Guild member

        [JsonProperty(PropertyName = "content")]
        public Optional<string> Content;

        [JsonProperty(PropertyName = "timestamp")]
        public string RawTimestamp;

        [JsonProperty(PropertyName = "edited_timestamp")]
        public string RawEditedTimestamp;

        [JsonProperty(PropertyName = "tts")]
        public bool Tts;

        [JsonProperty(PropertyName = "mention_everyone")]
        public bool MentionEveryone;
        
        // TODO: Array of user
        
        // TODO: Array of role ID
        
        // TODO: Array of attachment
        
        // TODO: Arary of embed
        
        // TODO: Array of reaction

        [JsonProperty(PropertyName = "nonce")]
        public Optional<string> Nonce;

        [JsonProperty(PropertyName = "pinned")]
        public bool Pinned;

        [JsonProperty(PropertyName = "webhook_id")]
        public Optional<string> WebhookID;

        [JsonProperty(PropertyName = "type")]
        public int RawType;
        
        // TODO: Message activity
        
        // TODO: Message application
    }
}