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
            _stream = _client.GetStream();
        }

        public void sendResult( bool res )
        {
            byte[] id = new byte[1];

            if (res)
                id[0] = 1;
            else
                id[0] = 0;
            _stream.Write(id, 0, 1);
        }

        public int receiveMessage( byte[] buf, ref int length )
        {
            if (!_isServerRunning)
                return -1;

            if (!_isConnected)
                return -1;

            byte[] id = new byte[1];
            
            _stream.Read(id, 0, 1);

            if (id[0] != 13 && id[0] != 12 && id[0] != 11 && id[0] != 10) 
                return -1;

            byte[] lengthBuf = new byte[4];

            _stream.Read(lengthBuf, 0, 4);

            int dataLength = lengthBuf[0] + 10 * (int)lengthBuf[1] + 
                100 * (int)lengthBuf[2] + 1000 * (int)lengthBuf[3];

            _stream.Read(buf, 0, dataLength);

            length = dataLength;

            if (id[0] == 13) // captcha key!
                return 3;
            if (id[0] == 12) // login
                return 2;
            if (id[0] == 11) // password
                return 1;
            
            return 0; // advert!
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
        private NetworkStream _stream;
    }
}
