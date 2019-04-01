Feature: Login
	As a registered user of Firefly
	I would like to login
	So that I can use the site

@mytag
Scenario: Valid Login
	Given I Navigate to the site
	When I enter  username
	And I enter  password
	And I click on login button
	And I click on set personal task
	Then I able to view set personal task popup box
	And I close dialogue box
	And I click user image
	And I click on log out
	