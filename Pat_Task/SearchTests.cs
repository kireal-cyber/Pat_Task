
using NUnit.Framework;
using EHU.Pages;

namespace EHU.Tests
{
    [TestFixture]
    public class SearchTests : BaseTest
    {
        [Test]
        public void VerifySearchFunctionality()
        {
            var searchPage = new SearchPage(driver);
            searchPage.GoToHomePage();
            searchPage.Search("study programs");
            Assert.IsTrue(searchPage.IsResultVisible("The Women in Tech Project"), "Результаты поиска не отображаются!");
        }
    }
}
