using Reqnroll;
using NUnit.Framework;
using OpenQA.Selenium;
using EHU.Pages;
using EHU.Drivers;

namespace EHU.StepDefinitions
{
    [Binding]
    public class AboutPageSteps
    {
        private IWebDriver _driver;
        private AboutPage _aboutPage;

        public AboutPageSteps()
        {
            _driver = WebDriverSingleton.GetDriver(); 
            _aboutPage = new AboutPage(_driver);
        }

        [Given(@"the user is on the EHU homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            _driver.Navigate().GoToUrl("https://en.ehu.lt/");
        }

        [When(@"the user clicks on the ""About"" link")]
        public void WhenTheUserClicksOnTheAboutLink()
        {
            _aboutPage.GoToAboutPage();
        }

        [Then(@"the About page header should be visible")]
        public void ThenTheHeaderShouldBeVisible()
        {
            Assert.IsTrue(_aboutPage.IsAboutHeaderVisible(), "Заголовок страницы 'About' не отображается.");
        }
    }
}
