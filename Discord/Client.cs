using System;
using System.Collections.Generic;
using dotBridge.Discord.Gateway.Connection;

namespace dotBridge.Discord
{
    public class Client
    {
        internal static List<Client> Clients = new List<Client>();

        public event Events.OnClientClose OnClientClose;

        public bool Active { get; private set; }

        public ClientConfiguration Configuration;
        public Connection Connection;
        
        #region Constructor & Destructor

        private Client(ClientConfiguration configuration)
        {
            OnClientClose = () => { };

            Active = true;
            
            Configuration = configuration;
            Connection = new Connection(this);
        }

        ~Client()
        {
            Close();
        }
        
        #endregion
        
        #region Search, creation & removal

        /// <summary>
        /// Remove the client from clients list and close it
        /// </summary>
        public void Remove()
        {
            if (!Active)
                return;
            
            var index = FindIndex(Configuration.Key);
            Clients.RemoveAt(index);
            
            Close();
            
            Active = false;
        }

        /// <summary>
        /// Create or find an existing client instance
        /// </summary>
        /// <param name="configuration">Client configuration</param>
        /// <returns>Client instance</returns>
        public static Client Create(ClientConfiguration configuration)
        {
            return Find(configuration.Key) ?? new Client(configuration);
        }

        /// <summary>
        /// Find Client in clients list
        /// </summary>
        /// <param name="key">API key</param>
        /// <returns>Client instance or null</returns>
        public static Client Find(string key)
        {
            var index = FindIndex(key);
            return index == -1 ? null : Clients[index];
        }

        /// <summary>
        /// Find Client index in clients list
        /// </summary>
        /// <param name="key">API key</param>
        /// <returns>Index or -1</returns>
        public static int FindIndex(string key)
        {
            for (var i = 0; i < Clients.Count; i++)
            {
                if (Clients[i].Configuration.Key == key)
                    return i;
            }

            return -1;
        }
        
        #endregion

        #region Connection interaction
        
        /// <summary>
        /// Close the client and connection
        /// </summary>
        /// <exception cref="Exception">Exception thrown in OnClientClose event</exception>
        public void Close()
        {
            Exception exception = null;

            try
            {
                OnClientClose?.Invoke();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            finally
            {
                Connection.Close();
                if (exception != null)
                    throw exception;
            }
        }
        
        #endregion
    }
    
}