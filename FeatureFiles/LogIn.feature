Feature: Search
	This is to log in to Vega.com

@mytag
Scenario: Vegas Sign In

  #Steps
	Given I launch chrome browser
	And I navigate to vegas.com
	Then I click on the sign in button
	Then I enter my passwored and user name
	And I click on the second sign in button
	And I verify I am signed in.