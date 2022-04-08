using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        private static readonly string DriverDirectory = "C:\\WebDriver";
        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory); // fast
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
