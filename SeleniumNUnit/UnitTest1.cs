using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumNUnit
{
    
    public class Browser_ops
    {
        IWebDriver webDriver;
        public void Init_Browser()
        {
            //webDriver = new FirefoxDriver(Environment.CurrentDirectory);
            webDriver = new ChromeDriver(Environment.CurrentDirectory);

            webDriver.Manage().Window.Maximize();
        }
        public string Title
        {
            get { return webDriver.Title; }
        }
        public void Goto(string url)
        {
            webDriver.Url = url;
        }
        public void Close()
        {
            webDriver.Quit();
        }
        public IWebDriver getDriver
        {
            get { return webDriver; }
        }
    }


    class NUnit_Demo_1
    {
        Browser_ops brow = new Browser_ops();
        //String test_url = "https://www.duckduckgo.com";
        String test_url = "http://localhost:8080/greenfield/";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            brow.Init_Browser();
        }

        [Test]
        public void test_Browserops()
        {
            brow.Goto(test_url);
            //System.Threading.Thread.Sleep(4000);

            driver = brow.getDriver;

            //IWebElement element = driver.FindElement(By.XPath("//*[@id='search_form_input_homepage']"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //IWebElement element = driver.FindElement(By.Id("search_form_input_homepage"));

            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("search_form_input_homepage")));
            element.SendKeys("Manual fill text");

            /* Submit the Search */

            //element.Submit();
            driver.FindElement(By.Id("search_button_homepage")).Click();
           

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);

            

        }

        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }
}
