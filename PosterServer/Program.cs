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
        public static bool work( SeleniumPoster ps, Server s )
        {
            int length = -1;
            byte[] buf = new byte[4096];
            bool loginCaught = false, passCaught = false;
            String captchakey, pass = "-1", login = "-1", advert;

            try
            {

                while (true)
                {
                    int res = s.receiveMessage(buf, ref length);

                    if (res == 3) // captchakey
                    {
                        System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                        captchakey = enc.GetString(buf, 0, length);

                        ps.setCaptchaKey(captchakey);
                        if (ps.verifyCaptchaKey())
                            s.sendResult(true);
                        else
                            s.sendResult(false);
                    }

                    if (res == 1) // password
                    {
                        passCaught = true;
                        System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                        pass = enc.GetString(buf, 0, length);

                        Console.WriteLine("pass: " + pass);
                    }

                    if (res == 2) // login
                    {
                        loginCaught = true;
                        System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                        login = enc.GetString(buf, 0, length);

                        Console.WriteLine("login: " + login);
                    }

                    if (res == 0) // advert
                    {
                        System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                        advert = enc.GetString(buf, 0, length);

                        string[] words = advert.Split('\n');

                        /*        public Advert( string roomNumber,
                       string price,
                       string name,
                       string desc,
                       string district,
                       string subway_station,
                       string street,
                       string house,
                       string square,
                       string floor,
                       string floorNumber,
                       string phone,
                       string e_mail,
                       string person, 
                       string date )*/

                        Advert adv = new Advert(words[0], words[1], words[2],
                                                words[3], words[4], words[5],
                                                words[6], words[7], words[8],
                                                words[9], words[10], words[11],
                                                words[12], words[13], words[14]);

                        ps.postAdvert(adv);
                        

                    }

                    if (loginCaught && passCaught)
                    {
                        ps.login(login, pass);
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public static void Main()
        {
            Advert adv = new Advert("3", "20000", "Квартира в хорошем состоянии",
    "Отличная квартира", "Адмиралтейский", "Сенная площадь",
    "Садовая", "24", "50", "3", "5", "891239000",
    "iamdiligentstudent@narod.ru", "Мария", "15-07-2012");

            String str = adv.ToString();

            SeleniumPoster ps = new SeleniumPoster();

            /*ps.login("avito.ru", "iamdiligentstudent@narod.ru", "86420555");*/
            
            //ps.login("slando.ru", "iamdiligentstudent@narod.ru", "86420555");
            ps.login("olx.ru", "iamdiligentstudent@narod.ru", "86420555");
            ps.postAdvert(adv);
            //ps.login("restate.ru", "iamdiligentstudent@narod.ru", "86420555");*/

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

            while (true)
            {
                s.acceptConnection();
                Console.WriteLine("Connection accepted\n");
                work(ps, s);
            }

            s.stop();
        }

    }
}

