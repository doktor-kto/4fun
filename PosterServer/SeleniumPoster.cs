using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

// Requires reference to WebDriver.Support.dll
using OpenQA.Selenium.Support.UI;

namespace PosterServer
{
    class SeleniumPoster
    {
        private String firefox_path = "d:\\Programs\\Mozilla Firefox\\firefox.exe";
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

            String olx_path = "http://www.olx.ru/login.php";
            olx_driver.Navigate().GoToUrl(olx_path);

            String avito_path = "http://www.avito.ru/profile";
            avito_driver.Navigate().GoToUrl(avito_path);

            String restate_path = "http://www.restate.ru";
            restate_driver.Navigate().GoToUrl(restate_path);
        }

        public void postAdvert( String site, Advert adv )
        {

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
