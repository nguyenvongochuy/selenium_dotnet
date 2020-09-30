using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumNUnit.bases;
using SeleniumNUnit.pageobject;
using TechTalk.SpecFlow;

namespace SeleniumNUnit.stepsdefinition.login
{
    [Binding]
    public class LocalizationFeatureSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private CommonPage commonPage;

        [BeforeScenario]
        public void SetUp()
        {
            driver = Base.getDriver();
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            commonPage = new CommonPage(driver);
        }

        [When(@"User clicks on flag")]
        public void WhenUserClicksOnFlag()
        {
            loginPage.clickOnFlag();
        }
        
        [When(@"System display language ""(.*)""")]
        public void WhenSystemDisplayLanguage(string language)
        {
            String expectedText;
            if (language.Equals("Vietnamese"))
            {
                expectedText = "Xin chào,";
            }
            else
            {
                expectedText = "Hello,";
            }

            Assert.IsTrue(commonPage.isExistedText(expectedText));
        }
    
    }
}
