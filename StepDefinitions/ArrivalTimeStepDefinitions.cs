using OpenQA.Selenium;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;
using Tfl.Hooks;
using Tfl.PageObject;

namespace Tfl.StepDefinitions
{
    [Binding]
    public class ArrivalTimeStepDefinitions : BaseTest
    {

        public IWebDriver driver = BaseTest.driver;
        ArrivingTime arrivingTime = new ArrivingTime();


        [Given(@"that I am on Tfl landing page ""([^""]*)""")]
        public void GivenThatIAmOnTflLandingPage(string url)
        {
            arrivingTime.NavigateToTfl(url);
        }


        [When(@"I click on change time")]
        public void WhenIClickOnChangeTime()
        {
            arrivingTime.Click();
        }

        [Then(@"arriving time should be displayed")]
        public void ThenArrivingTimeShouldBeDisplayed()
        {
           
        }



    }
}
