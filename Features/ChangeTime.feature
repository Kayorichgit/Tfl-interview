Feature: ArrivalTime

As a user on Tfl website, when I clicked plan my jouney,
I should see arrival time


Scenario: [Arrival time]
	Given that I am on Tfl landing page "https://tfl.gov.uk/"
	And I click to accept all cookies
	When I click on change time 
	Then arriving time should be displayed
	
