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

        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {
            this.driver = Base.getDriver("chrome");
            this.homePage = new HomePage(driver);
            this.loginPage = new LoginPage(driver);

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
            this.loginPage.fillUserName(username);
            this.loginPage.fillPassword(password);
            this.loginPage.clickLogin();

            Session.LogginUsername = username;
        }




    }
}
