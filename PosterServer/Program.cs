using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace PosterServer
{
    class Program
    {
        public static void Main()
        {
            Server s = new Server();
            Parser par = new Parser();

            s.start("192.168.0.101", 5050);
            s.acceptConnection();



            s.stop();
            
        }

    }
}

