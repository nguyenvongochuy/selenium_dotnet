﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumNUnit.bases
{
    public class Base
{
    private static IWebDriver driver;
    public const String url = "http://192.168.0.185:8080/greenfield";

    public static IWebDriver getDriver(String browserType)
    {
        if (driver==null)
            {
                if (browserType.Equals("firefox"))
                {
                    driver = new FirefoxDriver(Environment.CurrentDirectory);

                }
                else if (browserType.Equals("chrome"))
                {
                    driver = new ChromeDriver(Environment.CurrentDirectory);
                }
                else
                {
                    driver = null;
                }
            }
           

        driver.Manage().Window.Maximize();
        driver.Url = url;
        return driver;

       
    }




}
}
