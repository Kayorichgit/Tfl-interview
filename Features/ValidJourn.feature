Feature: ValidJourn

As a user on Tfl, when I input my from and to
data, my journey was planned


Scenario: [Valid journey]
	Given I am on Tfl website page "https://tfl.gov.uk/"
	And I click accept cookies box
	And I do input "Edmonton police station" in From field
	And I do input "Dalston lane" in To field
	When I do click on plan my journey button
	Then valid journey result displayed
