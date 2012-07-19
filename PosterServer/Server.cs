using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace PosterServer
{
    class Server
    {
    
        public Server()
        {
            _isServerRunning = false;
            _isConnected = false;
        }

        public bool start( String IP, int Port )
        {
            if (!_isServerRunning)
            {
                try
                {
                    IPAddress ipAd = IPAddress.Parse(IP);

                    _listener = new TcpListener(ipAd, Port);

                    _listener.Start();                    

                    _isServerRunning = true;
    
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error..... " + e.StackTrace);
                    Console.WriteLine("Error..... " + e.Message);

                    return false;
                }
            }

            return true;
        }

        public void acceptConnection()
        {
            _client = _listener.AcceptTcpClient();
            _isConnected = true;
        }

        public bool receiveMessage( byte[] buf )
        {
            if (!_isServerRunning)
                return false;

            if (!_isConnected)
                return false;

            return true;
        }
        
        public void stop()
        {
            if (_isServerRunning)
            {
                _isServerRunning = false;
                _listener.Stop();                
            }
        }

        ~Server()
        {
            if (_isServerRunning)
            {
                _isServerRunning = false;
            }

        }

        private bool _isServerRunning, _isConnected;
        private TcpListener _listener;
        private TcpClient _client;
    }
}
