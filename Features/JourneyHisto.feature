Feature: JourneyHisto

As a user on Tfl website, when I clicked recent history button,
history of my recent journey should be displayed.


Scenario: [Journey History]
Given I am on Tfl webpage page "https://tfl.gov.uk/"
And I click to accept all cookies
When I click on recents button
Then history of my recent journey shpuld be displayed

