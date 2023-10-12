using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Hooks;

namespace Tfl.PageObject
{
    public class JourneyHist
    {
        public IWebDriver driver;
        public JourneyHist()
        {
            driver = BaseTest.driver;
        }

        IWebElement cookieclik => driver.FindElement(By.CssSelector("#CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll > strong"));
        IWebElement recentbutton => driver.FindElement(By.CssSelector("#jp-recent-tab-home > a"));
        IWebElement journeyhistory => driver.FindElement(By.CssSelector("#jp-recent-content-home- > p:nth-child(1)"));
       



        public void NavigateToWebPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CookieClik()
        {
            cookieclik.Click();
        }
        public void RecentButton()
        {
           recentbutton.Click();    
        }

        public void JourneyHistoryButton()
        {
            journeyhistory.Click();
        }

        public bool RecentHistory() 
        { 
           return driver.Equals(recentbutton);
        }

    }
}
