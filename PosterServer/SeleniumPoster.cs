using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
// Requires reference to WebDriver.Support.dll
using OpenQA.Selenium.Support.UI;
using Selenium;

// Activate an application window.


namespace PosterServer
{
    static class Extension
    {
        public static IJavaScriptExecutor Scripts(this IWebDriver driver)
        {
            return (IJavaScriptExecutor)driver;
        }
    }

    class SeleniumPoster
    {
        private String _captchaKey;
        private String firefox_path = "C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe";
        private IWebDriver slando_driver;
        private IWebDriver avito_driver;
        private IWebDriver olx_driver;
        private IWebDriver restate_driver;

        public SeleniumPoster()
        {
            slando_driver = new FirefoxDriver(new FirefoxBinary(firefox_path), null);
            avito_driver = new FirefoxDriver(new FirefoxBinary(firefox_path), null);
            olx_driver = new FirefoxDriver(new FirefoxBinary(firefox_path), null);
            restate_driver = new FirefoxDriver(new FirefoxBinary(firefox_path), null);

            String slando_path =
                    "http://slando.ru/account/?ref[0][action]=user&ref[0][method]=index";
            slando_driver.Navigate().GoToUrl(slando_path);

            String avito_path = "http://www.avito.ru/profile";
            avito_driver.Navigate().GoToUrl(avito_path);

            String olx_path = "http://www.olx.ru/login.php";
            olx_driver.Navigate().GoToUrl(olx_path);

            String restate_path = "http://www.restate.ru";
            restate_driver.Navigate().GoToUrl(restate_path);
        }

        public static void Delay(int Seconds)
        {
            System.Threading.Thread.Sleep(Seconds * 1000);
        }

        public void setCaptchaKey( String key )
        {
            _captchaKey = key;
        }

        public bool verifyCaptchaKey()
        {
            string pathTestCaptcha = "captcha.jpg";
            string check = String.Empty;

            Console.WriteLine("verifyCaptchaKey");

            do
            {
                AntiCaptcha anticap = new AntiCaptcha();
                Console.WriteLine("new anticaptcha");
                check = anticap.GetText(_captchaKey, pathTestCaptcha, 10000);
                Console.Write("check: " + check);
                if (check == "ERROR_NO_SLOT_AVAILABLE")
                {
                    //add your action here
                }
                Delay(2);
            }
            while ((check == "ERROR_NO_SLOT_AVAILABLE"));

            if (check == "D Y 4 F Y" || check == "DY4FY")
                return true;
            else
                return false;
        }
            
        private void _postSlando( Advert adv )
        {
            slando_driver.Navigate().GoToUrl("http://www.slando.ru/post-new-ad/");
            slando_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            
            slando_driver.FindElement(By.Id("add-title")).Clear();
            slando_driver.FindElement(By.Id("add-title")).SendKeys(adv.name);
            slando_driver.FindElement(By.XPath("//span[@id='choose-category-button']")).Click();
            Delay(1);
            slando_driver.FindElement(By.LinkText("Недвижимость")).Click();            
            Delay(1);
            slando_driver.FindElement(By.LinkText("Аренда квартир")).Click();
            Delay(1);
            slando_driver.FindElement(By.LinkText("Долгосрочная аренда квартир")).Click();
            new SelectElement(slando_driver.FindElement(By.Id("id-offer-seek"))).SelectByText("Предлагаю");
            slando_driver.FindElement(By.Name("data[param_price][1]")).Clear();
            slando_driver.FindElement(By.Name("data[param_price][1]")).SendKeys(adv.price);
            slando_driver.FindElement(By.Name("data[param_number_of_rooms]")).Clear();
            slando_driver.FindElement(By.Name("data[param_number_of_rooms]")).SendKeys(adv.roomNumber);
            slando_driver.FindElement(By.Name("data[param_rent_from]")).Click();
            slando_driver.FindElement(By.Name("data[param_rent_from]")).Clear();
            slando_driver.FindElement(By.Name("data[param_rent_from]")).SendKeys(adv.date);
            slando_driver.FindElement(By.Id("parameter-div-number_of_rooms")).Click();
            new SelectElement(slando_driver.FindElement(By.Id("id_private_business"))).SelectByText("Частное лицо");
            slando_driver.FindElement(By.Id("add-description")).Clear();
            slando_driver.FindElement(By.Id("add-description")).SendKeys(adv.desc);
            slando_driver.FindElement(By.Id("show-gallery-html")).Click();
            new SelectElement(slando_driver.FindElement(By.Id("region-id-select"))).SelectByText(" -> Санкт-Петербург");
            slando_driver.FindElement(By.Id("add-person")).Clear();
            slando_driver.FindElement(By.Id("add-person")).SendKeys(adv.person);
            slando_driver.FindElement(By.Id("add-phone")).Clear();
            slando_driver.FindElement(By.Id("add-phone")).SendKeys(adv.phone);
            slando_driver.FindElement(By.Id("save")).Click();
        }

        private void _postAvito( Advert adv )
        {
            avito_driver.Navigate().GoToUrl("http://www.avito.ru/additem");
            avito_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            avito_driver.FindElement(By.Id("fld_phone")).Clear();
            avito_driver.FindElement(By.Id("fld_phone")).SendKeys(adv.phone);
            new SelectElement(avito_driver.FindElement(By.Id("region"))).SelectByText("-- Выберите город --");
            avito_driver.FindElement(By.Id("select-region")).Click();
            avito_driver.FindElement(By.CssSelector("#location_653240 > strong")).Click();
            new SelectElement(avito_driver.FindElement(By.Id("fld_metro_id"))).SelectByText(adv.subway_station);
            new SelectElement(avito_driver.FindElement(By.Id("fld_category_id"))).SelectByText("Квартиры");
            new SelectElement(avito_driver.FindElement(By.Id("flt_param_201"))).SelectByText("Сдам");
            new SelectElement(avito_driver.FindElement(By.Id("flt_param_550"))).SelectByText(adv.roomNumber);
            new SelectElement(avito_driver.FindElement(By.Id("flt_param_504"))).SelectByText("На длительный срок");
            new SelectElement(avito_driver.FindElement(By.Id("flt_param_501"))).SelectByText(adv.floor);
            new SelectElement(avito_driver.FindElement(By.Id("flt_param_502"))).SelectByText(adv.floorNumber);
            avito_driver.FindElement(By.Id("flt_param_500")).Clear();
            avito_driver.FindElement(By.Id("flt_param_500")).SendKeys(adv.square);
            avito_driver.FindElement(By.Id("flt_param_493")).Clear();
            avito_driver.FindElement(By.Id("flt_param_493")).SendKeys(adv.street + ", " + adv.house);
            avito_driver.FindElement(By.Id("fld_title")).Clear();
            avito_driver.FindElement(By.Id("fld_title")).SendKeys(adv.name);
            avito_driver.FindElement(By.Id("fld_description")).Clear();
            avito_driver.FindElement(By.Id("fld_description")).SendKeys(adv.desc);
            avito_driver.FindElement(By.Id("fld_price")).Clear();
            avito_driver.FindElement(By.Id("fld_price")).SendKeys(adv.price);
            avito_driver.FindElement(By.Id("form_submit")).Click();
        }

        private bool _postOlx( Advert adv )
        {
            olx_driver.Navigate().GoToUrl("http://www.olx.ru/posting.php");
            olx_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            olx_driver.FindElement(By.Id("regionSelectorChangeMode")).Click();
            Delay(2);
            new SelectElement(olx_driver.FindElement(By.Id("state"))).SelectByText("Санкт-Петербург");
            new SelectElement(olx_driver.FindElement(By.Id("city"))).SelectByText("Санкт-Петербург");
            new SelectElement(olx_driver.FindElement(By.Id("categoryParent"))).SelectByText("Недвижимость");
            new SelectElement(olx_driver.FindElement(By.Id("categoryChild"))).SelectByText("Аренда квартир, домов");
            olx_driver.FindElement(By.Id("title")).Clear();
            olx_driver.FindElement(By.Id("title")).SendKeys(adv.name);
            olx_driver.FindElement(By.Id("C")).Clear();
            olx_driver.FindElement(By.Id("C")).SendKeys(adv.price);
            olx_driver.FindElement(By.Id("email")).Clear();
            olx_driver.FindElement(By.Id("email")).SendKeys(adv.e_mail);
            olx_driver.FindElement(By.Id("phone")).Clear();
            olx_driver.FindElement(By.Id("phone")).SendKeys(adv.phone);
            olx_driver.FindElement(By.Id("surface")).Clear();
            olx_driver.FindElement(By.Id("surface")).SendKeys(adv.square);
            olx_driver.FindElement(By.Id("streetaddress")).Clear();
            olx_driver.FindElement(By.Id("streetaddress")).SendKeys(adv.street + ", " + adv.house);
            new SelectElement(olx_driver.FindElement(By.Id("bedrooms"))).SelectByText(adv.roomNumber);
            new SelectElement(olx_driver.FindElement(By.Id("neighborhood"))).SelectByText(adv.subway_station);
            
            olx_driver.FindElement(By.Id("description_ifr")).SendKeys(adv.desc);

            olx_driver.FindElement(By.Id("btnPublish")).Click();

            Delay(3);

            if (olx_driver.Url == "http://www.olx.ru/posting_success.php")
                return true;
            else
                return false;
        }

        private bool _postRestate( Advert adv )
        {
            restate_driver.Navigate().GoToUrl("http://www.restate.ru/add.html");
            restate_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            new SelectElement(restate_driver.FindElement(By.Id("object_deal_id"))).SelectByText("Сдать в аренду");
            new SelectElement(restate_driver.FindElement(By.Id("object_area_id"))).SelectByText(adv.district + " р-н");
            new SelectElement(restate_driver.FindElement(By.Id("object_metro_id"))).SelectByText(adv.subway_station);
            restate_driver.FindElement(By.Id("object_address_street1")).Clear();
            restate_driver.FindElement(By.Id("object_address_street1")).SendKeys(adv.street);
            restate_driver.FindElement(By.Id("house")).Clear();
            restate_driver.FindElement(By.Id("house")).SendKeys(adv.house);
            restate_driver.FindElement(By.Id("sall")).Clear();
            restate_driver.FindElement(By.Id("sall")).SendKeys(adv.square);
            restate_driver.FindElement(By.Id("description")).Clear();
            restate_driver.FindElement(By.Id("description")).SendKeys(adv.desc);
            restate_driver.FindElement(By.Id("price")).Clear();
            restate_driver.FindElement(By.Id("price")).SendKeys(adv.price);
            restate_driver.FindElement(By.Id("contacts")).Clear();
            restate_driver.FindElement(By.Id("contacts")).SendKeys(adv.phone + "\n" + adv.e_mail);
            restate_driver.FindElement(By.Name("commit")).Click();

            restate_driver.FindElement(By.Id("rooms")).Clear();
            restate_driver.FindElement(By.Id("rooms")).SendKeys(adv.roomNumber);
            restate_driver.FindElement(By.Id("et")).Clear();
            restate_driver.FindElement(By.Id("et")).SendKeys(adv.floor);
            restate_driver.FindElement(By.Id("etall")).Clear();
            restate_driver.FindElement(By.Id("etall")).SendKeys(adv.floorNumber);
            restate_driver.FindElement(By.Id("s1")).Clear();
            restate_driver.FindElement(By.Id("s1")).SendKeys(adv.square);
            restate_driver.FindElement(By.Name("commit")).Click();

            return true;
        }

        public void postAdvert( Advert adv )
        {
            if (_postOlx(adv))
                ;
            if (_postRestate(adv))
                ;
            _postAvito(adv);
            _postSlando(adv);
        }

        public void login( String mail, String password )
        {
            login("slando.ru", mail, password);
            login("olx.ru", mail, password);
            login("restate.ru", mail, password);
            login("avito.ru", mail, password);
        }

        public void login( String site, String mail, String password )
        {
            if (String.Compare("slando.ru", site) == 0)
            {                
                IWebElement mail_elem = slando_driver.FindElement(By.Id("userEmail"));

                mail_elem.Clear();
                mail_elem.Click();
                mail_elem.SendKeys(mail);

                IWebElement pass_elem = slando_driver.FindElement(By.Id("userPass"));

                pass_elem.Clear();
                pass_elem.Click();
                pass_elem.SendKeys(password);

                IWebElement login_form = slando_driver.FindElement(By.Id("se_userLogin"));

                login_form.Click();
                
                return;
            }

            if (String.Compare("olx.ru", site) == 0)
            {
                IWebElement mail_elem = olx_driver.FindElement(By.Id("username"));

                mail_elem.Clear();
                mail_elem.Click();
                mail_elem.SendKeys(mail);

                IWebElement pass_elem = olx_driver.FindElement(By.Id("password"));

                pass_elem.Clear();
                pass_elem.Click();
                pass_elem.SendKeys(password);

                IWebElement login_form = olx_driver.FindElement(By.Id("submit"));

                login_form.Click();
                         
                return;
            }
            
            if (String.Compare("avito.ru", site) == 0)
            {
                IWebElement mail_elem = avito_driver.FindElement(By.Id("user_name"));

                mail_elem.Clear();
                mail_elem.Click();
                mail_elem.SendKeys(mail);

                IWebElement pass_elem = avito_driver.FindElement(By.Id("pass"));

                pass_elem.Clear();
                pass_elem.Click();
                pass_elem.SendKeys(password);

                IWebElement login_form = avito_driver.FindElement(By.Name("submit"));

                login_form.Click();

                return;
            }

            if (String.Compare("restate.ru", site) == 0)
            {                
                IWebElement mail_elem = restate_driver.FindElement(By.Name("login"));

                mail_elem.Clear();
                mail_elem.Click();
                mail_elem.SendKeys(mail);

                IWebElement pass_elem = restate_driver.FindElement(By.Name("password"));

                pass_elem.Clear();
                pass_elem.Click();
                pass_elem.SendKeys(password);

                IWebElement login_form = restate_driver.FindElement(By.Id("submitButton"));

                login_form.Click();

                return;
            }
        }

        ~SeleniumPoster()
        {
            restate_driver.Quit();
            olx_driver.Quit();
            avito_driver.Quit();
            slando_driver.Quit();
        }
    }
}
