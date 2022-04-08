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
        //installing driver to c - Mai
        // Mais ChromeDriver
        // private static readonly string _chromeDriver = "C:/WebDriver";
        // Lavas FireFoxDriver
        // private static readonly string _foxDriver = "C:/Drivers";
        // Mathias' EdgeDriver
        private static readonly string _edgeDriver = "C:/webDrivers";

        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            // _driver = new ChromeDriver(_chromeDriver); // fast
            // _driver = new FirefoxDriver(_foxDriver);
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

            //_driver.Navigate().GoToUrl("file:///C:/JS/ParProgrammingML/ParProgrammingML/index.html");
            _driver.Navigate().GoToUrl("file:///C:/PairProgrammingMaiLava/index.html");

            string title = _driver.Title;
            Assert.AreEqual("Par programming", title);

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement duathletesList = wait.Until(d => d.FindElement(By.Id("getDuathlete")));

            //Assert.AreEqual("Bibibib", duathletesList.Text);
            // Console.WriteLine(duathletesList.Text);

            Assert.IsTrue(duathletesList.Text.Contains("Eddy5"));

            IWebElement inputName = _driver.FindElement(By.Id("inputName"));
            inputName.SendKeys("MathiasVintherSøndergaard");
            IWebElement inputAge = _driver.FindElement(By.Id("inputAge"));
            inputAge.SendKeys("4");
            IWebElement inputBike = _driver.FindElement(By.Id("inputBike"));
            inputBike.SendKeys("400");
            IWebElement inputRun = _driver.FindElement(By.Id("inputRun"));
            inputRun.SendKeys("100");

            IWebElement postButton = _driver.FindElement(By.Id("buttonPost"));
            postButton.Click();

            IWebElement duathletePost = wait.Until(d => d.FindElement(By.Id("postDuathlete")));

            IWebElement postDuathleteMessage = _driver.FindElement(By.Id("postDuathlete"));
            string text = postDuathleteMessage.Text;

            Assert.IsTrue(duathletesList.Text.Contains("MathiasVintherSøndergaard"));

            // Assert.AreEqual("Response: 201 Created", text);
        }
    }
}
