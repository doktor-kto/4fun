using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosterServer
{
    class SeleniumPoster
    {
        public SeleniumPoster()
        {

        }

        public void postAdvert( String site, Advert adv )
        {

        }

        public void login( String site )
        {
            if (String.Compare("slando.ru", site) == 0)
            {
                return;
            }

            if (String.Compare("olx.ru", site) == 0)
            {
                return;
            }
            
            if (String.Compare("restate.ru", site) == 0)
            {
                return;
            }

            if (String.Compare("avito.ru", site) == 0)
            {
                return;
            }
        }

        ~SeleniumPoster()
        {

        }
    }
}
