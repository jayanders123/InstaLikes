using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Insta_Like_Lite
{
    class ProgramSetup
    {
        private string username;
        private string password;
        private string url;

        private IWebDriver driver { get; } = new ChromeDriver();

        public ProgramSetup(string username, string password, string url)
        {
            this.username = username;
            this.password = password;
            this.url = url;
        }

        public IWebDriver getWebDriver()
        {
            return driver;
        }

        public void Login()
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            //username
            IWebElement selectElementOnScreen = driver.FindElement(By.Name("username"));
            selectElementOnScreen.SendKeys(username);
            //password
            selectElementOnScreen = driver.FindElement(By.Name("password"));
            selectElementOnScreen.SendKeys(password);
            selectElementOnScreen.SendKeys(Keys.Return);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //Notification click away
            selectElementOnScreen = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[3]/button[2]"));
            selectElementOnScreen.Click();

            Thread.Sleep(4000);
        }
    }
}
