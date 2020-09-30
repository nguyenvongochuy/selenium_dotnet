using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumNUnit.utilities
{
    class Utilities
    {

       /* public static By getByFromWebElement(IWebElement element)
        {
            By by = null;
            //ignore case string replace using Regex
            Regex rex = new Regex(@"(?s)(.*)\\]$");

            // this line only replace first occurence of 'white'
            String returnString = rex.Replace(element.ToString().Split("->")[1], "$1" + "", 1);
            String[] pathVariables = returnString.Split(":");

            //String a = element.ToString().Split("->")[1].ReplaceFirst("(?s)(.*)\\]", "$1" + "");
            //String[] pathVariables = (element.ToString().Split("->")[1].ReplaceFirst("(?s)(.*)\\]", "$1" + "")).Split(":");

            String selector = pathVariables[0].Trim();
            String value = pathVariables[1].Trim();

            switch (selector)
            {

                case "id":
                    by = By.Id(value);
                    break;
                case "className":
                    by = By.ClassName(value);
                    break;
                case "tagName":
                case "tag name":
                    by = By.TagName(value);
                    break;
                case "xpath":
                    by = By.XPath(value);
                    break;
                case "cssSelector":
                case "css selector":
                    by = By.CssSelector(value);
                    break;
                case "linkText":
                    by = By.LinkText(value);
                    break;
                case "name":
                    by = By.Name(value);
                    break;
                case "partialLinkText":
                    by = By.PartialLinkText(value);
                    break;
                default:
                    throw new InvalidOperationException("locator : " + selector + " not found!!!");
                    
            }
            return by;
        }
*/
       

        public static void explicitWaitByElementToBeClickable(IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public static void explicitWaitByElementExists(IWebDriver driver, By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));
        }

    }
}
