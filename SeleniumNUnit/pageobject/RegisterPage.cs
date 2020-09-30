using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumNUnit.pageobject
{
    class RegisterPage
    {

		private readonly IWebDriver driver;
		private String newUsername;

		private IWebElement username
		{
			get
			{
				return this.driver.FindElement(By.Id("username"));
			}
		}


		private IWebElement password
		{
			get
			{
				return this.driver.FindElement(By.Id("password"));
			}
		}


		private IWebElement verifyPassword
		{
			get
			{
				return this.driver.FindElement(By.Id("verifyPassword"));
			}
		}


		private IWebElement submit
		{
			get
			{
				return this.driver.FindElement(By.XPath("//input[@value='Submit']"));
			}
		}


		private IWebElement passwordIsMismatched
		{
			get
			{
				return this.driver.FindElement(By.XPath("//span[contains(text(), 'Password and verify password')]"));
			}
		}

		public RegisterPage(IWebDriver driver)
		{
			this.driver = driver;			

		}

		public void fillUserName(String username)
		{
			this.username.SendKeys(username);
		}

		public void fillPassword(String password)
		{
			this.password.SendKeys(password);
		}

		public void fillVerifyPassword(String password)
		{
			this.verifyPassword.SendKeys(password);
		}

		public void clickRegister()
		{
			submit.Click();
		}

		public String getNewUsername()
		{
			return newUsername;
		}

		public void setNewUsername(String newUsername)
		{
			this.newUsername = newUsername;
		}

		public Boolean PasswordIsMismatched()
		{
			return this.passwordIsMismatched.Displayed;

		}

	}
}
