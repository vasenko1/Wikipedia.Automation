using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Wikipedia.Automation.Base
{
    [TestFixture]
    class BaseWebdriverSuite
    {
        static IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [Test]
        public void SmokeTest()
        {
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }        
}