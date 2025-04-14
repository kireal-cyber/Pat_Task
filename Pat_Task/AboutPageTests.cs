
using NUnit.Framework;
using EHU.Pages;

namespace EHU.Tests
{
    [TestFixture]
    public class AboutPageTests : BaseTest
    {
        [Test]
        public void AboutPage_Header_ShouldBeVisible()
        {
            var aboutPage = new AboutPage(driver);
            aboutPage.GoToAboutPage();

            Assert.IsTrue(aboutPage.IsAboutHeaderVisible(), "Заголовок 'About EHU' не отображается.");
        }
    }
}
