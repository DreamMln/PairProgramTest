using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

/*
  nuget Selenium.WebDriver v3.141
  NuGet OpenQA.Selenium.Support.UI v3.141
*/

namespace PairProgrammingMLTest
{
    [TestClass]
    public class UnitTest1
    {
        //installing driver to c
        private static readonly string _chromeDriver = "C:\\WebDriver";

        private static readonly string _foxDriver = "C:\\Drivers";
        private static readonly string _edgeDriver = "C:\\webDrivers";
       
        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(_chromeDriver); // fast
            _driver = new FirefoxDriver(_foxDriver);
            _driver = new EdgeDriver(_edgeDriver);
        }

        [ClassCleanup]
        //static behover ikke har return typen hvor void er empty
        public static void TearDown()
        {
            _driver.Dispose();
        }

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
