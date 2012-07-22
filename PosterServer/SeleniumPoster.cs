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
        private String firefox_path = "d:\\Programs\\Mozilla Firefox\\firefox.exe";
        private IWebDriver slando_driver;
        private IWebDriver avito_driver;
        private IWebDriver olx_driver;
        private IWebDriver restate_driver;

      

        public SeleniumPoster()
        {
            /*slando_driver = new FirefoxDriver(new FirefoxBinary(firefox_path), null);
            avito_driver = new FirefoxDriver(new FirefoxBinary(firefox_path), null);
            olx_driver = new FirefoxDriver(new FirefoxBinary(firefox_path), null);
            restate_driver = new FirefoxDriver(new FirefoxBinary(firefox_path), null);

            String slando_path =
                    "http://slando.ru/account/?ref[0][action]=user&ref[0][method]=index";
            slando_driver.Navigate().GoToUrl(slando_path);

            

            String avito_path = "http://www.avito.ru/profile";
            avito_driver.Navigate().GoToUrl(avito_path);

            String restate_path = "http://www.restate.ru";
            restate_driver.Navigate().GoToUrl(restate_path);*/

            olx_driver = new FirefoxDriver(new FirefoxBinary(firefox_path), null);

            String olx_path = "http://www.olx.ru/login.php";
            olx_driver.Navigate().GoToUrl(olx_path);
        }

        private void _postSlando( Advert adv )
        {

        }

        private void _postAvito( Advert adv )
        {

        }

        public static void Delay(int Seconds)
            {
                System.Threading.Thread.Sleep(Seconds * 1000);
           }

        private void _postOlx( Advert adv )
        {
            olx_driver.Navigate().GoToUrl("http://www.olx.ru/posting.php");
            olx_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            olx_driver.FindElement(By.Id("upload-wrapper")).Click();
            
            /*
            olx_driver.FindElement(By.Id("regionSelectorChangeMode")).Click();
            Delay(2);
            new SelectElement(olx_driver.FindElement(By.Id("state"))).SelectByText("Санкт-Петербург");
            new SelectElement(olx_driver.FindElement(By.Id("city"))).SelectByText("Санкт-Петербург");
            new SelectElement(olx_driver.FindElement(By.Id("categoryParent"))).SelectByText("Недвижимость");
            new SelectElement(olx_driver.FindElement(By.Id("categoryChild"))).SelectByText("Аренда квартир, домов");
            olx_driver.FindElement(By.Id("title")).Clear();
            olx_driver.FindElement(By.Id("title")).SendKeys(adv.name);
            olx_driver.FindElement(By.Id("C")).Clear();
            olx_driver.FindElement(By.Id("C")).SendKeys(adv.price.ToString());
            olx_driver.FindElement(By.Id("email")).Clear();
            olx_driver.FindElement(By.Id("email")).SendKeys(adv.e_mail);
            olx_driver.FindElement(By.Id("phone")).Clear();
            olx_driver.FindElement(By.Id("phone")).SendKeys(adv.phone);
            olx_driver.FindElement(By.Id("surface")).Clear();
            olx_driver.FindElement(By.Id("surface")).SendKeys(adv.square);
            olx_driver.FindElement(By.Id("streetaddress")).Clear();
            olx_driver.FindElement(By.Id("streetaddress")).SendKeys(adv.street + ", " + adv.house);
            new SelectElement(olx_driver.FindElement(By.Id("bedrooms"))).SelectByText(adv.roomNumber.ToString());
            new SelectElement(olx_driver.FindElement(By.Id("neighborhood"))).SelectByText(adv.subway_station.ToString());
            olx_driver.FindElement(By.Id("description_ifr")).SendKeys(adv.desc);

            ISelenium selenium = new WebDriverBackedSelenium(olx_driver, "http://www.google.com");

            selenium.Click("//a[@id='selectFiles']");
            selenium.Type("xpath=//input[@type='file' and @name='userfile']", @"c:\testdata\image.png");
            //olx_driver.FindElement(By.Id("btnPublish")).Click();*/


        }

        private void _postRestate( Advert adv )
        {


        }

        public void postAdvert( Advert adv )
        {
            _postOlx(adv);
            _postRestate(adv);
            _postAvito(adv);
            _postSlando(adv);

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
