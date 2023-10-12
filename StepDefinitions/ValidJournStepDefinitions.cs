using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Tfl.Hooks;
using Tfl.PageObject;

namespace Tfl.StepDefinitions
{
    [Binding]
    public class ValidJournStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        ValidJourny validJourny = new ValidJourny();



        [Given(@"I am on Tfl website page ""([^""]*)""")]
        public void GivenIAmOnTflWebsitePage(string url)
        {
           driver.Navigate().GoToUrl(url);   
        }
        [Given(@"I click accept cookies box")]
        public void GivenIClickAcceptCookiesBox()
        {
            validJourny.CookiesAccepted();
        }


        [Given(@"I do input ""([^""]*)"" in From field")]
        public void GivenIDoInputInFromField(string Mssg)
        {
            validJourny.PutFromField(Mssg);
        }

        [Given(@"I do input ""([^""]*)"" in To field")]
        public void GivenIDoInputInToField(string mssg)
        {
            validJourny.PutToField(mssg);
        }

        [When(@"I do click on plan my journey button")]
        public void WhenIDoClickOnPlanMyJourneyButton()
        {
            validJourny.PlanMyJourney();
        }



        [Then(@"valid journey result displayed")]
        public void ThenValidJourneyResultDisplayed()
        {
            validJourny.ValidJourneyResultDisplayed().Should().BeTrue();
        }
    }
}
