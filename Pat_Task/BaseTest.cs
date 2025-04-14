
using NUnit.Framework;
using OpenQA.Selenium;
using EHU.Drivers;

namespace EHU.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = WebDriverSingleton.GetDriver();
        }

        [TearDown]
        public void TearDown()
        {
            WebDriverSingleton.QuitDriver();
        }
    }
}
