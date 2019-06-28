namespace dotBridge.Discord.Gateway.Connection
{
    public class ConnectionData
    {
        private const int Version = 6;

        private const string Encoding = "json";

        public static readonly string URL = $"wss://gateway.discord.gg/?v={Version}&encoding={Encoding}";
    }
}