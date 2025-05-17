using Reqnroll;
using NUnit.Framework;
using OpenQA.Selenium;
using EHU.Pages;
using EHU.Drivers;

namespace EHU.StepDefinitions
{
    [Binding]
    public class ContactPageSteps
    {
        private IWebDriver _driver;
        private ContactPage _contactPage;

        public ContactPageSteps()
        {
            _driver = WebDriverSingleton.GetDriver();
            _contactPage = new ContactPage(_driver);
        }

        [Given(@"the user is on the Contact page")]
        public void GivenTheUserIsOnTheContactPage()
        {
            _contactPage.GoToContactPage();
        }

        [Then(@"the email address should be visible")]
        public void ThenTheEmailAddressShouldBeVisible()
        {
            Assert.IsTrue(_contactPage.IsEmailVisible(), "Email не отображается");
        }

        [Then(@"the Lithuanian phone number should be visible")]
        public void ThenTheLithuanianPhoneNumberShouldBeVisible()
        {
            Assert.IsTrue(_contactPage.IsPhoneLTVisible(), "Литовский номер телефона не отображается");
        }

        [Then(@"the Belarusian phone number should be visible")]
        public void ThenTheBelarusianPhoneNumberShouldBeVisible()
        {
            Assert.IsTrue(_contactPage.IsPhoneBYVisible(), "Белорусский номер телефона не отображается");
        }

        [Then(@"the Facebook link should be visible")]
        public void ThenTheFacebookLinkShouldBeVisible()
        {
            Assert.IsTrue(_contactPage.IsFacebookLinkVisible(), "Ссылка на Facebook не отображается");
        }

        [Then(@"the Telegram link should be visible")]
        public void ThenTheTelegramLinkShouldBeVisible()
        {
            Assert.IsTrue(_contactPage.IsTelegramLinkVisible(), "Ссылка на Telegram не отображается");
        }

        [Then(@"the VK link should be visible")]
        public void ThenTheVKLinkShouldBeVisible()
        {
            Assert.IsTrue(_contactPage.IsVKLinkVisible(), "Ссылка на VK не отображается");
        }
    }
}
