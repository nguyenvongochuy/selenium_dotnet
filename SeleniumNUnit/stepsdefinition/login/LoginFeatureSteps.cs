using System;
using OpenQA.Selenium;
using SeleniumNUnit.pageobject;
using SeleniumNUnit.bases;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumNUnit.stepsdefinition
{
    [Binding]
    public class LoginFeatureSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;

        [BeforeScenario]
        public void SetUp()
        {
            driver = Base.getDriver();
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
        }

        [AfterScenario]
        public void TearDown()
        {
            // Cleanup code
        }

        
        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {
            Assert.IsTrue(loginPage.isInLoginPage());

        }

        [Then(@"Homepage is displayed")]
        public void ThenHomepageIsDisplayed()
        {
            String loginUserName = Session.LogginUsername;
            Assert.IsTrue(homePage.verifyHomePage(loginUserName));
        }

        [Then(@"Logout system")]
        public void ThenLogoutSystem()
        {
            homePage.clickLogout();
        }



        [When(@"User sign up with below pair info username ""(.*)"" and password ""(.*)""")]
        public void WhenUserSignUpWithBelowPairInfoUserNameAndPassWord(string username, string password)
        {
            loginPage.fillUserName(username);
            loginPage.fillPassword(password);
            loginPage.clickLogin();

            Session.LogginUsername = username;
        }

        [Then(@"Still in login page")]
        public void ThenStillInLoginPage()
        {
            Assert.IsTrue(loginPage.isInLoginPage());
        }


       





    }
}
