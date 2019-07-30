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

        /// <summary>
        /// MESSAGE_CREATE and MESSAGE_UPDATE
        /// </summary>
        [JsonProperty(PropertyName = "author")]
        public User Author;

        [JsonProperty(PropertyName = "member")]
        public Optional<GuildMember> Member;

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

        /// <summary>
        /// MESSAGE_CREATE and MESSAGE_UPDATE
        /// </summary>
        [JsonProperty(PropertyName = "mentions")]
        public Optional<User[]> Mentions;

        [JsonProperty(PropertyName = "mention_roles")]
        public string[] MentionRoles;

        [JsonProperty(PropertyName = "attachments")]
        public Attachment[] Attachements;

        [JsonProperty(PropertyName = "embeds")]
        public Embed[] Embeds;

        [JsonProperty(PropertyName = "reactions")]
        public Optional<Reaction[]> Reactions;

        [JsonProperty(PropertyName = "nonce")]
        public Optional<string> Nonce;

        [JsonProperty(PropertyName = "pinned")]
        public bool Pinned;

        [JsonProperty(PropertyName = "webhook_id")]
        public Optional<string> WebhookID;

        [JsonProperty(PropertyName = "type")]
        public int RawType;

        [JsonProperty(PropertyName = "activity")]
        public Optional<MessageActivity> Activity;

        [JsonProperty(PropertyName = "application")]
        public Optional<MessageApplication> Application;
    }
}