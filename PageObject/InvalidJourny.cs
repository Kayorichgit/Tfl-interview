using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Hooks;

namespace Tfl.PageObject
{
    public class InvalidJourny
    {
        public IWebDriver driver;

        public InvalidJourny() 
        {
            driver = BaseTest.driver;
        }

        IWebElement planmyjourneybutton => driver.FindElement(By.CssSelector("#plan-journey-button"));
        IWebElement cookiesbox => driver.FindElement(By.CssSelector("#CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll > strong"));
        IWebElement frominput => driver.FindElement(By.XPath("//*[@id=\"InputFrom\"]"));
        IWebElement inputto => driver.FindElement(By.XPath("//*[@id=\"InputTo\"]"));
        IWebElement planmyjourneyclick => driver.FindElement(By.CssSelector("#plan-journey-button"));
       


        public void NavigateToTflWeb(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void PlanJourneyButton() 
        {
            planmyjourneybutton.Click();
        }

        public void CookiesBox()
        {
            cookiesbox.Click();
        }

        public void FromInput(string EdmontonPoliceStation)
        {
            frominput.SendKeys(EdmontonPoliceStation);
        }

        public void InpuTo( string tyrdhe243)
        {
            inputto.SendKeys(tyrdhe243);
        }

        public void PlanMyJourneyClick()
        {
            planmyjourneyclick.Click();
        }

        public bool IsMessageDisplay()
        {
            return driver.ToString().Should().Equals(IsMessageDisplay());
        }
    }
}
