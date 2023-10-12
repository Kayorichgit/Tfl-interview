using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Hooks;

namespace Tfl.PageObject
{
    public class OmitData
    {
        public IWebDriver driver;
        public OmitData()
        {
            driver = BaseTest.driver;
        }


        IWebElement cookiebox => driver.FindElement(By.CssSelector("#CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll > strong"));
        
        IWebElement planjourneybutton => driver.FindElement(By.CssSelector("#plan-journey-button"));
        IWebElement requirederror => driver.FindElement(By.CssSelector(""));
       
        


        public void NavigateToTflWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void CookieBox()
        {
            cookiebox.Click();
        }
        

        public void clickPlanJourney()
        {
            planjourneybutton.Click();
        }


        public bool RequiredError() 
        {
            return driver.Url.Equals("https://tfl.gov.uk/");
        }

    }
}
