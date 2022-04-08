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
            _driver.Navigate().GoToUrl("file:///C:/JS/ParProgrammingML/ParProgrammingML/index.html");

            string title = _driver.Title;
            Assert.AreEqual("Par programming", title);

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement duathletesList = wait.Until(d => d.FindElement(By.Id("getDuathlete")));

            //Assert.AreEqual("Bibibib", duathletesList.Text);
            //Console.WriteLine(duathletesList.Text);

            Assert.IsTrue(duathletesList.Text.Contains("Eddy5"));



        }
    }
}
