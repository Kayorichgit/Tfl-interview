using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tfl.Hooks;
using static System.Collections.Specialized.BitVector32;

namespace Tfl.PageObject
{
    public class AmmendJourn
    {
        public IWebDriver driver;

        IWebElement acceptcookies => driver.FindElement(By.CssSelector("#CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll > strong"));
        IWebElement inputfromfield => driver.FindElement(By.XPath("//*[@id=\"InputFrom\"]"));
        IWebElement inputtofield => driver.FindElement(By.XPath("//*[@id=\"InputTo\"]"));
        IWebElement planjourneybutton => driver.FindElement(By.CssSelector("#plan-journey-button"));
        IWebElement journeyresult => driver.FindElement(By.CssSelector("#full-width-content > div > div:nth-child(2) > div > h1 > span"));
        IWebElement clickeditjourney => driver.FindElement(By.CssSelector("#plan-a-journey > div.journey-result-summary > div:nth-child(3) > a > span"));
        IWebElement inputedit => driver.FindElement(By.XPath("//*[@id=\"InputTo\"]"));
        IWebElement clickupdate => driver.FindElement(By.CssSelector("#plan-journey-button"));
        IWebElement amendjouney => driver.FindElement(By.CssSelector("#plan-a-journey > div.journey-result-summary > div.from-to-wrapper > div:nth-child(2) > span.notranslate > strong"));

        public AmmendJourn()
        {
            driver = BaseTest.driver;
        }


        public void AcceptCookies()
        {
            acceptcookies.Click();
        }
        public void FromField(string EdmontonGreenPoliceStation) 
        {
            inputfromfield.SendKeys(EdmontonGreenPoliceStation);
        }

        public void ToField(string DalstonLane)
        {
            inputtofield.SendKeys(DalstonLane);
        }

        public void PlanJourneyButton()
        {
            planjourneybutton.Click();
        }

        public bool Journey()
        {
          return journeyresult.Equals(journeyresult);
        }

        public void Edit()
        {
            clickeditjourney.Click();
        }

        public void Inputed()
        {
            inputedit.Click();
        }

        public void Update() 
        {
            clickupdate.Click();
        }

        public bool Ammend()
        {
            return amendjouney.Equals(amendjouney);
        }

    }
}
