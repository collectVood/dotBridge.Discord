using System;
using System.Collections.Generic;
using System.Timers;
using WebSocketSharp;

namespace DotDiscord.Gateway.Connection
{
    public class Connection
    {
        public readonly Client Client;

        private WebSocket _socket;

        private Timer _heartbeatTimer;
        private Timer _reconnectTimer;

        private bool _receivedACK;
        private double _heartbeatInterval;
        
        private int? _lastSequence;
        private string _sessionID;

        public List<string[]> TraceHistory;

        public double HeartbeatInterval
        {
            get => _heartbeatInterval;
            set => _heartbeatInterval = value * Client.Configuration.HeartbeatRate;
        }
        
        #region Constructor & destructor

        internal Connection(Client client)
        {
            Client = client;

            _socket = new WebSocket(ConnectionData.URL);
            _socket.OnOpen += OnSocketOpen;
            _socket.OnClose += OnSocketClose;
            _socket.OnError += OnSocketError;
            _socket.OnMessage += OnSocketMessage;
            
            _heartbeatTimer = new Timer();
            // TODO: Run heartbeat
            _reconnectTimer = new Timer();
            _reconnectTimer.Elapsed += (obj, e) => Connect();

            _receivedACK = false;
            _heartbeatInterval = 0d;

            _lastSequence = null;
            _sessionID = string.Empty;
            
            TraceHistory = new List<string[]>();

            Connect();
        }

        ~Connection()
        {
            _heartbeatTimer.Close();
            _reconnectTimer.Close();
        }

        #endregion
        
        #region Interaction

        /// <summary>
        /// Connect to Discord Gateway
        /// </summary>
        /// <returns>Whether client was not already connected</returns>
        public bool Connect()
        {
            if (!IsClosed)
                return false;
            
            _heartbeatTimer.Stop();
            _reconnectTimer.Stop();
            
            _socket.ConnectAsync();
            return true;
        }

        /// <summary>
        /// Close the connection
        /// </summary>
        /// <param name="code">Closure code</param>
        public void Close(ushort code = 1000)
        {
            _heartbeatTimer.Stop();
            _reconnectTimer.Stop();
            
            _socket.Close(code);
        }

        /// <summary>
        /// Close the connection and reconnect in <see cref="reconnectIn"/>
        /// </summary>
        /// <param name="reconnectIn">Time to reconnect in (ms). NaN to reconnect immediately</param>
        /// <param name="closeCode">Closure code</param>
        public void Reconnect(double reconnectIn, ushort closeCode = 1000)
        {
            _reconnectTimer.Stop();
            
            Close(closeCode);
            if (double.IsNaN(reconnectIn))
            {
                Connect();
                return;
            }

            _reconnectTimer.Interval = reconnectIn;
            _reconnectTimer.AutoReset = false;
            _reconnectTimer.Start();
        }
        
        #endregion
        
        #region Status

        /// <summary>
        /// Whether the connection is ready to perform some actions
        /// </summary>
        public bool IsDiscordReady => IsAlive && IsOpen && !string.IsNullOrEmpty(_sessionID);

        public bool IsAlive => _socket.IsAlive;

        public bool IsClosing => _socket.ReadyState == WebSocketState.Closing;

        public bool IsClosed => _socket.ReadyState == WebSocketState.Closed;

        public bool IsConnecting => _socket.ReadyState == WebSocketState.Connecting;

        public bool IsOpen => _socket.ReadyState == WebSocketState.Open;
        
        #endregion
        
        #region WebSocket Event Handlers
        
        private void OnSocketOpen(object sender, EventArgs e)
        {
            
        }

        private void OnSocketClose(object sender, CloseEventArgs e)
        {
            
        }

        private void OnSocketError(object sender, ErrorEventArgs e)
        {
            
        }

        private void OnSocketMessage(object sender, MessageEventArgs e)
        {
            
        }
        
        #endregion
    }
}