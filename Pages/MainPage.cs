using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Wikipedia.Automation.Pages
{
    class MainPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "js-link-box-en")]
        private IWebElement _englishPageLink;

        [FindsBy(How = How.Id, Using = "js-link-box-ru")]
        private IWebElement _russianPageLink;

        [FindsBy(How = How.ClassName, Using = "pure-button pure-button-primary-progressive")]
        private IWebElement _searchField;

        [FindsBy(How = How.Id, Using = "searchLanguage")]
        private IWebElement _searchLanguageDropdown;

        [FindsBy(How = How.Id, Using = "js-lang-list-button")]
        private IWebElement _selectLanguageMenuButton;

        public HomeDashboardPage(IWebDriver driver) : base(driver)
        {
        }


        
        public void CheckUserIsOnMainPage()
        {
            Assert.IsTrue(_selectLanguageMenuButton.Displayed, "Error, User is not at Login Page!");
        }

    }
}
