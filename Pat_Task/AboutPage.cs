using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace EHU.Pages
{
    public class AboutPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public AboutPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private By aboutLink => By.LinkText("About");
        private By aboutHeader => By.CssSelector("h1");


        public void GoToAboutPage()
        {
            _driver.Navigate().GoToUrl("https://en.ehu.lt/");
            _wait.Until(ExpectedConditions.ElementToBeClickable(aboutLink)).Click();
        }

        public bool IsAboutHeaderVisible()
        {
            return _wait.Until(ExpectedConditions.ElementIsVisible(aboutHeader)).Displayed;
        }
    }
}
