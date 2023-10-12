using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Tfl.Hooks;
using Tfl.PageObject;

namespace Tfl.StepDefinitions
{
    [Binding]
    public class AmmendJournStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        AmmendJourn ammendJourn = new AmmendJourn();

        [Given(@"I am on Tfl website")]
        public void GivenIAmOnTflWebsite()
        {
            driver.Navigate().GoToUrl("https://tfl.gov.uk/");
        }


        [Given(@"I input ""([^""]*)"" in From field")]
        public void GivenIInputInFromField(string msg)
        {
           ammendJourn.FromField(msg);
        }

        [Given(@"I input ""([^""]*)"" in To field")]
        public void GivenIInputInToField(string message)
        {
           ammendJourn.ToField(message);
        }

        [Given(@"I click on plan my journey button")]
        public void GivenIClickOnPlanMyJourneyButton()
        {
            ammendJourn.PlanJourneyButton();
        }

        [When(@"my journey result is displayed")]
        public void WhenMyJourneyResultIsDisplayed()
        {
            ammendJourn.Journey();
        }

        [When(@"I click on edit journey")]
        public void WhenIClickOnEditJourney()
        {
            ammendJourn.Edit();
        }

        [When(@"I input ""([^""]*)"" in To field")]
        public void WhenIInputInToField(string p0)
        {
            ammendJourn.Inputed();
        }

        [When(@"I click update journey")]
        public void WhenIClickUpdateJourney()
        {
            ammendJourn.Update();
        }

        [Then(@"my journey should be amended")]
        public void ThenMyJourneyShouldBeAmended()
        {
            ammendJourn.Ammend();
        }
    }
}
