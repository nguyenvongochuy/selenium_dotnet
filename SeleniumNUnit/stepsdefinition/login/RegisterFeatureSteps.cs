using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumNUnit.bases;
using SeleniumNUnit.pageobject;
using TechTalk.SpecFlow;

namespace SeleniumNUnit.stepsdefinition.login
{
    [Binding]
    public class RegisterFeatureSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private RegisterPage registerPage;

        [BeforeScenario]
        public void SetUp()
        {
            driver = Base.getDriver();
            loginPage = new LoginPage(driver);
            registerPage = new RegisterPage(driver);
        }

        [AfterScenario]
        public void TearDown()
        {
            // Cleanup code
        }


        [When(@"User clicks on Register link")]
        public void WhenUserClicksOnRegisterLink()
        {
            
            loginPage.clickRegister();
        }
        
        [When(@"Fill random username ""(.*)"" and password ""(.*)"" and confirmPassword ""(.*)"" and submit")]
        public void WhenFillRandomUsernameAndPasswordAndConfirmPasswordAndSubmit(string username, string password, string verifyPassword)
        {
            Guid guid = Guid.NewGuid();
 
            username += guid;
            System.Console.WriteLine("Created username: " + username);
            registerPage.setNewUsername(username);
            Session.LogginUsername = username;

            registerPage.fillUserName(username);
            registerPage.fillPassword(password);
            registerPage.fillVerifyPassword(verifyPassword);
            registerPage.clickRegister();
        }
        
        [When(@"Fill username ""(.*)"" and password ""(.*)"" and confirmPassword ""(.*)"" and submit")]
        public void WhenFillUsernameAndPasswordAndConfirmPasswordAndSubmit(string username, string password, string verifyPassword)
        {
            registerPage.fillUserName(username);
            registerPage.fillPassword(password);
            registerPage.fillVerifyPassword(verifyPassword);
            registerPage.clickRegister();
        }
        
        [Then(@"Register is successfully")]
        public void ThenRegisterIsSuccessfully()
        {
            Assert.IsTrue(loginPage.isInLoginPage());
        }
        


        [Then(@"User sign up with below pair info newUsername and password ""(.*)""")]
        public void ThenUserSignUpWithBelowPairInfoNewUsernameAndPassword(string password)
        {
            loginPage.fillUserName(registerPage.getNewUsername());
            loginPage.fillPassword(password);
            loginPage.clickLogin();
        }


        [Then(@"Register failed")]
        public void ThenRegisterFailed()
        {
            Assert.IsTrue(registerPage.PasswordIsMismatched());
        }
    }
}
