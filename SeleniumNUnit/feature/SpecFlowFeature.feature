Feature: For login feature


@webTest
Scenario: Login successfully
	Given User is on login page
    When User sign up with below pair info username "admin" and password "admin"
    Then Homepage is displayed
    And Logout system



