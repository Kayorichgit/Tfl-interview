using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Tfl.Hooks;
using Tfl.PageObject;

namespace Tfl.StepDefinitions
{
    [Binding]
    public class InvalidJounyStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        InvalidJourny invalidJourny = new InvalidJourny();

        [Given(@"I am on Tfl landing page ""([^""]*)""")]
        public void GivenIAmOnTflLandingPage(string url)
        {
           invalidJourny.NavigateToTflWeb(url);
        }

        [Given(@"I click accept all cookies box")]
        public void GivenIClickAcceptAllCookiesBox()
        {
            invalidJourny.CookiesBox();
        }


        [Given(@"I inputed ""([^""]*)"" in To field")]
        public void GivenIInputedInToField(string messg)
        {
           invalidJourny.InpuTo(messg);
        }

        [When(@"I click plan my journey button")]
        public void WhenIClickPlanMyJourneyButton()
        {
            invalidJourny.PlanJourneyButton();
        }

        [Then(@"I should recieve an error ""([^""]*)""")]
        public void ThenIShouldRecieveAnError(string p0)
        {
            invalidJourny.IsMessageDisplay();
        }
    }
}
