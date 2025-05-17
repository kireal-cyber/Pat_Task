using Reqnroll;
using NUnit.Framework;
using OpenQA.Selenium;
using EHU.Drivers;
using EHU.Pages;

namespace EHU.StepDefinitions
{
    [Binding]
    public class SearchSteps
    {
        private readonly IWebDriver _driver;
        private readonly SearchPage _searchPage;

        public SearchSteps()
        {
            _driver = WebDriverSingleton.GetDriver();
            _searchPage = new SearchPage(_driver);
        }

        [Given(@"the user opens the homepage for search")]
        public void GivenTheUserIsOnTheHomepage()
        {
            _searchPage.GoToHomePage();
        }

        [When(@"the user searches for ""(.*)""")]
        public void WhenTheUserSearchesFor(string query)
        {
            _searchPage.Search(query);
        }

        [Then(@"the result ""(.*)"" should be visible")]
        public void ThenTheResultShouldBeVisible(string expectedText)
        {
            Assert.IsTrue(_searchPage.IsResultVisible(expectedText), $"Результат поиска по фразе '{expectedText}' не найден!");
        }
    }
}
