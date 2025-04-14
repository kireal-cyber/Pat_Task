using NUnit.Framework;
using EHU.Pages;

namespace EHU.Tests
{
    [TestFixture]
    public class ContactInfoTests : BaseTest
    {
        [Test]
        public void ContactInfo_ShouldBeVisibleToUser()
        {
            var contactPage = new ContactPage(driver);
            contactPage.GoToContactPage();

            Assert.IsTrue(contactPage.IsEmailVisible(), "Email не отображается");
            Assert.IsTrue(contactPage.IsPhoneLTVisible(), "Телефон LT не отображается");
            Assert.IsTrue(contactPage.IsPhoneBYVisible(), "Телефон BY не отображается");
            Assert.IsTrue(contactPage.IsFacebookLinkVisible(), "Ссылка на Facebook не отображается");
            Assert.IsTrue(contactPage.IsTelegramLinkVisible(), "Ссылка на Telegram не отображается");
            Assert.IsTrue(contactPage.IsVKLinkVisible(), "Ссылка на VK не отображается");
        }
    }
}
