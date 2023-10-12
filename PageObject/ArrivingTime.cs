using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tfl.Hooks;

namespace Tfl.PageObject
{
    public class ArrivingTime : BaseTest
    {
        public IWebDriver driver;

        public ArrivingTime()
        {
            driver = BaseTest.driver;
        }


        IWebElement arrivetime => driver.FindElement(By.CssSelector("#Time"));
        IWebElement arrive => driver.FindElement(By.XPath("//*[@id=\"plan-a-journey\"]/fieldset/div[2]/div[2]/div[1]/ul/li[2]/label"));
        IWebElement clickchangetime => driver.FindElement(By.CssSelector("#plan-a-journey > fieldset > div.time-options.clearfix > div.time-defaults > a"));
       



        public void NavigateToTfl(string url)
        {
           driver.Navigate().GoToUrl(url);
        }

        public void ArriveTime()
        {
            arrivetime.Click();
        }

        public void Click()
        {
            clickchangetime.Click();
        }


        public void ArriveTimeIsDisplayed()
        {
            string actualText = arrive.Text;
            string expectedText = "Arriving";
            Assert.AreEqual(expectedText, actualText);
        }

        

    }
}
