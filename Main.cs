using Insta_Like_Lite;
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
         void setUsernameAndPass(string username, string password)
        {

        }

        public static void Main(string[] args)
        {
            ProgramSetup session = new ProgramSetup("therealjeshh", "mnijaila7ls", "https://www.instagram.com/accounts/login/?source=auth_switcher");

            session.Login();

            InstagramFunctions webpage = new InstagramFunctions(session);

            webpage.ScrollAndLikePhotos();
            Thread.Sleep(2500);

            var element = session.getWebDriver().FindElement(By.XPath("//article[1]/div[2]/section[1]/span[1]/button/span"));
            element.Click();
            //END

            Thread.Sleep(2500);
            //PROGRESS FROM HERE ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 


            int number =2;
      
            for (int i = 0; i < 2; i++)
            {
                string xpath = "//article[" + number++ + "]/div[2]/section[1]/span[1]/button/span";
               
                   
                //speed of the javascript screen scroll (per-pixel)
                for (int j = 0; j < 250; j++)
                {
                    //js.ExecuteScript("window.scrollBy(0,4)");
                }
                Thread.Sleep(2000);
                element = session.getWebDriver().FindElement(By.XPath(xpath));
                element.Click();
            }
                
            //Wait before 5secs close
            Thread.Sleep(5000);
            session.getWebDriver().Quit();
        }
    }
}
