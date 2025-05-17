using Reqnroll;
using NUnit.Framework;
using OpenQA.Selenium;
using EHU.Drivers;
using EHU.Pages;

namespace EHU.StepDefinitions
{
    [Binding]
    public class LanguageSteps
    {
        private readonly IWebDriver _driver;
        private readonly LanguagePage _languagePage;

        public LanguageSteps()
        {
            _driver = WebDriverSingleton.GetDriver();
            _languagePage = new LanguagePage(_driver);
        }

        [Given(@"the user is on the homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            _languagePage.GoToHomePage();
        }

        [When(@"the user switches language to Russian")]
        public void WhenTheUserSwitchesLanguageToRussian()
        {
            _languagePage.SwitchToRussian();
        }

        [Then(@"the Russian version of the site should be displayed")]
        public void ThenTheRussianVersionOfTheSiteShouldBeDisplayed()
        {
            Assert.IsTrue(_languagePage.IsRussianHeaderVisible(), "Русскоязычный заголовок не отображается.");
        }
    }
}
