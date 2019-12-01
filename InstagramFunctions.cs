using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Insta_Like_Lite
{
    
    class InstagramFunctions
    {
        private ProgramSetup instagramSession;
        private IJavaScriptExecutor screenScroller;

        //first picture view + click 'like'
        //START
        public InstagramFunctions(ProgramSetup scroller)
        {
            
            this.instagramSession = scroller;
            this.screenScroller = instagramSession.getWebDriver() as IJavaScriptExecutor;
        }

        public void ScrollAndLikePhotos()
        {
            //First Picture like
            for (int i = 0; i < 75; i++)
            {
                screenScroller.ExecuteScript("window.scrollBy(0,4)");
            }
            Thread.Sleep(2500);

            var element = instagramSession.getWebDriver().FindElement(By.XPath("//article[1]/div[2]/section[1]/span[1]/button/span"));
            element.Click();
        }
    }
}
