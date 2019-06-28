namespace dotBridge.Discord.Gateway
{
    public class OpCode
    {
        public enum Gateway
        {
            Dispatch = 0, // Receive
            Heartbeat = 1, // SendReceive
            Identify = 2, // Send
            StatusUpdate = 3, // Send
            VoiceStateUpdate = 4, // Send
            Resume = 6, // Send
            Reconnect = 7, // Receive
            RequestGuildMembers = 8, // Send
            InvalidSession = 9, // Receive
            Hello = 10, // Receive
            HeartbeatACK = 11 // Receive
        }

        public enum GatewayClose
        {
            UnknownError = 4000,
            UnknownOpcode = 4001,
            DecodeError = 4002,
            NotAuthenticated = 4003,
            AuthenticationFailed = 4004,
            AlreadyAuthenticated = 4005,
            InvalidSeq = 4007,
            RateLimited = 4008,
            SessionTimeout = 4009,
            InvalidShard = 4010,
            ShardingRequested = 4011
        }
    }
}