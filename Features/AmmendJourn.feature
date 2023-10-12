Feature: AmmendJourn

As a user on Tfl website, when I planned my journey, and later 
ammend my to location, my journey should be planned

Scenario: [Ammended journey]
Given I am on Tfl website
And I click to accept all cookies
And I input "Edmonton police station" in From field
And I input "Dalston lane" in To field
And I click on plan my journey button
When my journey result is displayed
And I click on edit journey
And I input "Liverpool street" in To field
When I click update journey
Then my journey should be amended
