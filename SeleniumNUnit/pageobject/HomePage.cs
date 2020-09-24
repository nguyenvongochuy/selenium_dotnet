using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumNUnit.pageobject
{
    class HomePage
    {
		private readonly  IWebDriver driver;


		private IWebElement cartLink
		{
			get
			{
				return this.driver.FindElement(By.XPath("//a[@href='/greenfield/cart/']"));
			}
		}


		private IWebElement hello
		{
			get
			{
				return this.driver.FindElement(By.TagName("body"));
			}
		}


		private IWebElement logout
		{
			get
			{
				return this.driver.FindElement(By.XPath("//a[@href='/greenfield/logout']"));
			}
		}

		//@FindBy(xpath = "//a[contains(text(), 'Flowers')]")
		private IWebElement treeType;


		private IWebElement detailButton
		{
			get
			{
				return this.driver.FindElement(By.XPath("//a[starts-with(@href,'/greenfield/product?id=') and starts-with(@class,'btn')]"));
			}
		}

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

		public Boolean verifyHomePage(String username)
		{
			Boolean existedHelloText;

			//String bodyText = driver.FindElement(Utilities.getByFromWebElement(hello)).getText();
			String bodyText = hello.Text;
			existedHelloText = bodyText.Contains("Hello, " + username);

			Boolean hasCart;
			hasCart = cartLink.Displayed;

			return existedHelloText && hasCart;
		}

		public IWebElement getCartLink()
		{
			return cartLink;
		}

		public void clickLogout()
		{
			logout.Click();
		}

		public void clickOnTreeType(String treeType)
		{
			By by = By.XPath("//a[contains(text(), '" + treeType + "')]");

			//Utilities.explicitWaitByElementToBeClickable(driver, by);

			this.treeType = driver.FindElement(by);
			this.treeType.Click();

		}

		public void clickOnDetail()
		{
			detailButton.Click();

		}


	}
}
