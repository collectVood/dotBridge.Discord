using System;
using DotDiscord.Gateway;
using WebSocketSharp;

namespace DotDiscord
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