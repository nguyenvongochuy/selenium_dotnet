using System;
using OpenQA.Selenium;



namespace SeleniumNUnit.pageobject
{
    class LoginPage
    {
        private readonly IWebDriver driver;
		
		/*
		[FindsBy(How = How.Id, Using = "username")]
		protected IWebElement username { get; set; }
		*/
		private IWebElement username
		{
			get
			{
				return this.driver.FindElement(By.Id("username"));
			}
		}

		/*
		[FindsBy(How = How.Id, Using = "password")]
		protected IWebElement password { get; set; }
		*/

		private IWebElement password
		{
			get
			{
				return this.driver.FindElement(By.Id("password"));
			}
		}

		/*
		[FindsBy(How = How.Name, Using = "keepMe")]
		protected IWebElement keepMe { get; set; } */
		private IWebElement keepMe
		{
			get
			{
				return this.driver.FindElement(By.Name("keepMe"));
			}
		}

		/*
		[FindsBy(How = How.XPath, Using = "//input[@Value='Log In']")]
		protected IWebElement logIn { get; set; } */
		private IWebElement logIn
		{
			get
			{
				return this.driver.FindElement(By.XPath("//input[@Value='Log In']"));
			}
		}

		private IWebElement register
		{
			get
			{
				return this.driver.FindElement(By.XPath("//a[contains(text(), 'Register')]"));
			}
		}


		private IWebElement flag
		{
			get
			{
				return this.driver.FindElement(By.XPath("//img[@class='mr-3']"));
			}
		}


		private IWebElement wordsInScreen
		{
			get
			{
				return this.driver.FindElement(By.TagName("body"));
			}
		}



		private IWebElement UsernameTxtBox
		{
			get
			{
				return this.driver.FindElement(By.Id("user_login"));
			}
		}


		public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
			//PageFactory.InitElements(this.driver, this);

		}

		public void fillUserName(string username)
		{
			this.username.SendKeys(username);
		}

		public void fillPassword(String password)
		{
			this.password.SendKeys(password);
		}

		public void checkRememberMe()
		{
			if (!keepMe.Selected)
				this.keepMe.Click();
		}

		public void uncheckRememberMe()
		{
			if (keepMe.Selected)
				this.keepMe.Click();
		}

		public void clickLogin()
		{
			this.logIn.Click();
		}


		public Boolean isInLoginPage()
		{
			return logIn.Displayed;
		}


		public void clickRegister()
		{
			this.register.Click();

		}


		public void clickOnFlag()
		{
			this.flag.Click();

		}
	}
}
