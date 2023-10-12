Feature: InvalidJouny

As a user on Tfl website, when I inupt wrong
to data in journey planner, I should reciev invalid message

Scenario: [Invalid Scenerio]
	Given I am on Tfl landing page "https://tfl.gov.uk/"
	And I click accept all cookies box
	And I input "Edmonton police station" in From field
	And I inputed "tyrdhe243" in To field
	When I click plan my journey button
	Then I should recieve an error "The To field is required"
