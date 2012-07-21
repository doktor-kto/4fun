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
            SeleniumPoster ps = new SeleniumPoster();

            ps.login("avito.ru", "iamdiligentstudent@narod.ru", "86420555");
            ps.login("restate.ru", "iamdiligentstudent@narod.ru", "86420555");
            ps.login("slando.ru", "iamdiligentstudent@narod.ru", "86420555");
            ps.login("olx.ru", "iamdiligentstudent@narod.ru", "86420555");

            Server s = new Server();
            Parser par = new Parser();

            if (!s.start("192.168.0.104", 5050))
                return;

            s.acceptConnection();
            



            s.stop();
            
        }

    }
}

