using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Hooks;

namespace Tfl.PageObject
{
    public class ValidJourny
    {
        public IWebDriver driver;


        public ValidJourny() 
        {
            driver = BaseTest.driver;
        }

        IWebElement cookiesaccepted => driver.FindElement(By.CssSelector("#CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll > strong"));
        IWebElement putfromfield => driver.FindElement(By.XPath("//*[@id=\"InputFrom\"]"));
        IWebElement puttofield => driver.FindElement(By.XPath("//*[@id=\"InputTo\"]"));
        IWebElement planmyjourney => driver.FindElement(By.CssSelector("#plan-journey-button"));

        //IWebElement validjourneyresult => driver.FindElement(By.CssSelector("#full-width-content > div > div:nth-child(7) > div > h2"));


        public void CookiesAccepted()
        {
            cookiesaccepted.Click();
        }
        public void PutFromField(String EdmontonGreenPoliceStation)
        {
            putfromfield.SendKeys(EdmontonGreenPoliceStation);
        }

        public void PutToField(String DalstonLane)
        {
            puttofield.SendKeys(DalstonLane);
        }

        public void PlanMyJourney()
        {
            planmyjourney.Click();
        }
        //public void JourneyPlanButton()
        //{
        //    journeyplanbutton.Click();
        //}
        public bool ValidJourneyResultDisplayed()
        {
            return driver.Url.Equals("https://tfl.gov.uk/plan-a-journey/results?InputFrom=Edmonton+police+station&FromId=&InputTo=Dalston+lane&ToId=");
        }

        
        
    }
}
