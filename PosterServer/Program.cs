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
            Advert adv = new Advert(3, 20000, "Квартира в хорошем состоянии",
    "Отличная квартира", "Адмиралтейский", "Сенная площадь",
    "Садовая", "24", "50", 3, 5, "891239000",
    "iamdiligentstudent@narod.ru", "Мария", "15-07-2012");

            String str = adv.ToString();

            SeleniumPoster ps = new SeleniumPoster();

            /*ps.login("avito.ru", "iamdiligentstudent@narod.ru", "86420555");*/
            
            //ps.login("slando.ru", "iamdiligentstudent@narod.ru", "86420555");
            /*ps.login("olx.ru", "iamdiligentstudent@narod.ru", "86420555");
            ps.login("restate.ru", "iamdiligentstudent@narod.ru", "86420555");*/

            /*class Advert
            {
                public int roomNumber;
                public int price;
                public string name;
                public string desc;
                public string district;
                public string subway_station;
                public string street;
                public string house;
                public string square;
                public int floor;
                public int floorNumber;
                public string phone;        */

            /*ps.postAdvert(new Advert(3, 20000, "Квартира в хорошем состоянии", 
                "Отличная квартира", "Адмиралтейский", "Сенная площадь",
                "Садовая", "24", "50", 3, 5, "891239000", 
                "iamdiligentstudent@narod.ru", "Мария", "15-07-2012"));*/

            Server s = new Server();

            if (!s.start("192.168.0.104", 5050))
                return;




            s.acceptConnection();

            s.stop();
        }

    }
}

