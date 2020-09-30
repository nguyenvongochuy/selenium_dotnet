Feature: For login feature


  @WebTest
Scenario: Login successfully
	Given User is on login page
    When User sign up with below pair info username "admin" and password "admin"
    Then Homepage is displayed
    #And Logout system



  @WebTest
  Scenario Outline: Login failed with username and password
    Given User is on login page
    When User sign up with below pair info username "<username>" and password "<password>"
    Then Still in login page
    

	Examples:
      | username  | password |
      | admin |     admin1 |  
      | admin1 |     admin | 

  @WebTest 
  Scenario Outline: Register user successfully
    Given User is on login page
    When User clicks on Register link
    And Fill random username "<username>" and password "<password>" and confirmPassword "<verifyPassword>" and submit
    Then Register is successfully
    And User sign up with below pair info newUsername and password "<password>"
    And Homepage is displayed


	Examples:
      | username  | password | verifyPassword |
      | user |     Password@123 | Password@123 |
 
  @WebTest 
  Scenario Outline: Register user failed with mismatched passwords
    Given User is on login page
    When User clicks on Register link
    And Fill username "<username>" and password "<password>" and confirmPassword "<verifyPassword>" and submit
    Then Register failed

	Examples:
      | username  | password | verifyPassword |
      | user |     Password@123 | Password@1234 |
      
  @WebTest 
  Scenario: Verify localization functions
    Given User is on login page
    When User clicks on flag
    And System display language "Vietnamese"
    And User clicks on flag
    And System display language "English"
    

