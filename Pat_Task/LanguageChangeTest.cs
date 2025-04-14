
using NUnit.Framework;
using EHU.Pages;

namespace EHU.Tests
{
    [TestFixture]
    public class LanguageChangeTests : BaseTest
    {
        [Test]
        public void LanguageSwitch_ShouldDisplayRussianContent()
        {
            var languagePage = new LanguagePage(driver);
            languagePage.GoToHomePage();
            languagePage.SwitchToRussian();

            Assert.IsTrue(languagePage.IsRussianHeaderVisible(), "Русскоязычный заголовок не отображается.");
        }
    }
}

