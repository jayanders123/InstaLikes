using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Facebook_Automation
{
    class InstagramLikeAutomation
       

    {
        public static void Main(string[] args)
        {
            

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/?source=auth_switcher");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            IWebElement element = driver.FindElement(By.Name("username"));

            element.SendKeys("therealjeshh");
            element = driver.FindElement(By.Name("password"));
            element.SendKeys("mnijaila7ls");
            element.SendKeys(Keys.Return);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            element = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[3]/button[2]"));
            element.Click();

            //wait and view first picture
            Thread.Sleep(4000);


            //first picture view + click 'like'
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            for (int i = 0; i < 75; i++)
            {
                js.ExecuteScript("window.scrollBy(0,4)");
            }
            Thread.Sleep(2500);
            element = driver.FindElement(By.XPath("//article[1]/div[2]/section[1]/span[1]/button/span"));
            element.Click();
            Thread.Sleep(2500);

            ////Scroll to picture 2 + click 'like'
            //for (int i = 0; i < 250; i++)
            //{
            //    js.ExecuteScript("window.scrollBy(0,4)");
            //}
            //Thread.Sleep(2500);
            //element = driver.FindElement(By.XPath(xPath[1]));
            //element.Click();

            ////Scroll to picture 3 + like
            //for (int i = 0; i < 250; i++)
            //{
            //    js.ExecuteScript("window.scrollBy(0,4)");
            //}
            //    Thread.Sleep(2570);
            //element = driver.FindElement(By.XPath(xPath[2]));
            //element.Click();

            ////Scroll to picture 4 + like
            //for (int i = 0; i < 250; i++)
            //{
            //    js.ExecuteScript("window.scrollBy(0,4)");
            //}
            //    Thread.Sleep(2000);
            //element = driver.FindElement(By.XPath(xPath[1]));
            //element.Click();


            int number =2;
      
            for (int i = 0; i < 2; i++)
            {
                string xpath = "//article[" + number++ + "]/div[2]/section[1]/span[1]/button/span";
               
                   
                //speed of the javascript screen scroll (per-pixel)
                for (int j = 0; j < 250; j++)
                {
                    js.ExecuteScript("window.scrollBy(0,4)");
                }
                Thread.Sleep(2000);
                element = driver.FindElement(By.XPath(xpath));
                element.Click();
                
            }
                
            //Wait before 5secs close
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
