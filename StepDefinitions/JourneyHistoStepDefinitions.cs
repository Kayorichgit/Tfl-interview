using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Tfl.PageObject;

namespace Tfl.StepDefinitions
{
    [Binding]
    public class JourneyHistoStepDefinitions
    {
        public IWebDriver driver;
        JourneyHist journeyHist = new JourneyHist();

        [Given(@"I am on Tfl webpage page ""([^""]*)""")]
        public void GivenIAmOnTflWebpagePage(string url)
        {
           journeyHist.NavigateToWebPage(url);
        }


        [When(@"I click on recents button")]
        public void WhenIClickOnRecentsButton()
        {
            journeyHist.RecentButton();

        }

        [Then(@"history of my recent journey shpuld be displayed")]
        public void ThenHistoryOfMyRecentJourneyShpuldBeDisplayed()
        {
          
        }
    }
}
