namespace dotBridge.Discord
{
    public class ClientConfiguration
    {
        /// <summary>
        /// Time to reconnect to the server in (ms)
        /// </summary>
        public double ReconnectIn = 10000d;
        
        /// <summary>
        /// Heartbeat frequency rate
        /// </summary>
        public double HeartbeatRate = 1d;

        /// <summary>
        /// Discord API Key
        /// </summary>
        public string Key = string.Empty;
    }
}