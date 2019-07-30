using dotBridge.Discord.Utils;
using Newtonsoft.Json;

namespace dotBridge.Discord.Objects
{
    public class Guild
    {
        [JsonProperty(PropertyName = "id")]
        public string ID;

        [JsonProperty(PropertyName = "name")]
        public string Name;

        [JsonProperty(PropertyName = "icon")]
        public string Icon;

        [JsonProperty(PropertyName = "splash")]
        public string Splash;

        [JsonProperty(PropertyName = "owner")]
        public Optional<bool> Owner;

        [JsonProperty(PropertyName = "owner_id")]
        public string OwnerID;

        [JsonProperty(PropertyName = "permissions")]
        public Optional<int> Permissions;

        [JsonProperty(PropertyName = "region")]
        public string Region;

        [JsonProperty(PropertyName = "afk_channel_id")]
        public string AfkChannelID;

        [JsonProperty(PropertyName = "afk_timeout")]
        public int AfkTimeout;

        [JsonProperty(PropertyName = "embed_enabled")]
        public Optional<bool> EmbedEnabled;

        [JsonProperty(PropertyName = "embed_channel_id")]
        public Optional<string> EmbedChannelID;

        [JsonProperty(PropertyName = "verification_level")]
        public int VerificationLevel;

        [JsonProperty(PropertyName = "default_message_notifications")]
        public int DefaultMessageNotifications;

        [JsonProperty(PropertyName = "explicit_content_filter")]
        public int ExplicitContentFilter;
        
        // TODO: Array of role

        [JsonProperty(PropertyName = "emojis")]
        public Emoji[] Emojis;

        [JsonProperty(PropertyName = "features")]
        public string[] Features;

        [JsonProperty(PropertyName = "mfa_level")]
        public int MfaLevel;

        [JsonProperty(PropertyName = "application_id")]
        public string ApplicationID;

        [JsonProperty(PropertyName = "widget_enabled")]
        public Optional<bool> WidgetEnabledID;

        [JsonProperty(PropertyName = "widget_channel_id")]
        public Optional<string> WidgetChannelID;

        [JsonProperty(PropertyName = "system_channel_id")]
        public Optional<string> SystemChannelID;

        [JsonProperty(PropertyName = "joined_at")]
        public Optional<string> RawJoinedAt;

        [JsonProperty(PropertyName = "large")]
        public Optional<bool> Large;

        [JsonProperty(PropertyName = "unavailable")]
        public Optional<bool> Unavailable;

        [JsonProperty(PropertyName = "member_count")]
        public Optional<int> MemberCount;

        // TODO: Array of voice state
        
        // TODO: Array of guild member

        [JsonProperty(PropertyName = "channels")]
        public Channel[] Channels;
        
        // TODO: Array of precense

        [JsonProperty(PropertyName = "max_precenses")]
        public int? MaxPrecenses;

        [JsonProperty(PropertyName = "max_members")]
        public int MaxMembers;

        [JsonProperty(PropertyName = "vanity_url_code")]
        public string VanityUrlCode;

        [JsonProperty(PropertyName = "description")]
        public string Description;

        [JsonProperty(PropertyName = "banner")]
        public string Banner;

        [JsonProperty(PropertyName = "premium_tier")]
        public int PremiumTier;

        [JsonProperty(PropertyName = "premium_subscription_count")]
        public Optional<int> PremiumSubscriptionCount;
    }
}