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
        private IWebDriver driver;

        public SeleniumPoster()
        {
            String path = "d:\\Programs\\Mozilla Firefox\\firefox.exe";
            driver = new FirefoxDriver(new FirefoxBinary(path), null);
        }

        public void postAdvert( String site, Advert adv )
        {

        }

        public void login( String site, String mail, String password )
        {
            if (String.Compare("slando.ru", site) == 0)
            {
                String slando_path = 
                    "http://slando.ru/account/?ref[0][action]=user&ref[0][method]=index";
                driver.Navigate().GoToUrl(slando_path);

                IWebElement mail_elem = driver.FindElement(By.Id("userEmail"));

                mail_elem.Click();
                mail_elem.SendKeys(mail);

                IWebElement pass_elem = driver.FindElement(By.Id("userPass"));

                pass_elem.Click();
                pass_elem.SendKeys(password);

                IWebElement login_form = driver.FindElement(By.Id("se_userLogin"));

                login_form.Click();
                
                return;
            }

            if (String.Compare("olx.ru", site) == 0)
            {
                String slando_path = "http://www.olx.ru/login.php";
                driver.Navigate().GoToUrl(slando_path);

                IWebElement mail_elem = driver.FindElement(By.Id("username"));

                mail_elem.Click();
                mail_elem.SendKeys(mail);

                IWebElement pass_elem = driver.FindElement(By.Id("password"));

                pass_elem.Click();
                pass_elem.SendKeys(password);

                IWebElement login_form = driver.FindElement(By.Id("submit"));

                login_form.Click();
                         
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
            driver.Quit();
        }
    }
}
