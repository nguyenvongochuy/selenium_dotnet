using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumNUnit.utilities;

namespace SeleniumNUnit.pageobject
{
    class CommonPage
    {
		private IWebDriver driver;


		/*		private IWebElement wordsInScreen
				{
					get
					{
						return this.driver.FindElement(By.TagName("body"));
					}
				}*/

		private By wordsInScreen = By.TagName("body");

		public CommonPage(IWebDriver driver)
		{
			this.driver = driver;
			
		}

		public Boolean isExistedTexts(List<String> texts)
		{
			foreach (String text in texts)
			{
				if (!isExistedText(text))
				{
					return false;
				}
			}
			return true;

		}

		public Boolean isExistedText(String value)
		{
			String bodyText = driver.FindElement(wordsInScreen).Text;
			return bodyText.Contains(value);
		}

	}
}
