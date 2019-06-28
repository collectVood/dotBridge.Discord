using System;
using dotBridge.Discord.Gateway;
using WebSocketSharp;

namespace dotBridge.Discord
{
    public class Events
    {
        public delegate void OnClientClose();
        
        public delegate void OnSocketClose(CloseEventArgs e);
        
        public delegate void OnSocketError(Exception e);
        
        public delegate void OnInvalidOpcode(Payload payload);
        
        public delegate void OnInvalidPayload(string data);
    }
}