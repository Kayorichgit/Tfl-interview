using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Tfl.PageObject;

namespace TflStepDefinitions
{
    [Binding]
    public class OmitDataStepDef
    {
        public IWebDriver driver;
        OmitData omitData = new OmitData();


        [Given(@"I am on Tfl homepage  ""([^""]*)""")]
        public void GivenIAmOnTflHomepage(string url)
        {
          omitData.NavigateToTflWebsite(url);
        }
        [Given(@"I click to accept all cookies")]
        public void GivenIClickToAcceptAllCookies()
        {
            omitData.CookieBox();
        }


        [When(@"I click on plan my journey button")]
        public void WhenIClickOnPlanMyJourneyButton()
        {
           omitData.clickPlanJourney();
        }

        [Then(@"I should get a required error under both fields")]
        public void ThenIShouldGetARequiredErrorUnderBothFields()
        {
           omitData.RequiredError().Should().BeTrue();
        }
    }
}
