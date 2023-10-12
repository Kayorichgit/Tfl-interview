Feature: Feature1

As a user on Tfl website, when I omit fro and to data plane,
and click plan my journey button, I should recieve error message



Scenario: [Omitting data plane]
	Given I am on Tfl homepage  "https://tfl.gov.uk/"
	And I click to accept all cookies
	When I click on plan my journey button
	Then I should get a required error under both fields
