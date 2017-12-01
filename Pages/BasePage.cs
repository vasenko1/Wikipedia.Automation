using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Wikipedia.Automation.Pages
{
    class BasePage
    {
        protected IWebDriver Driver { get; set; }

        private static int DefaultTimeoutInSeconds = 10;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public string GetCurrentUrl()
        {
            return Driver.Url;
        }

        public void GoToPageUrl(string reportUrl, string title)
        {
            var _domain = new Uri(Driver.Url).GetComponents(UriComponents.SchemeAndServer, UriFormat.Unescaped);
            var url = _domain + "/" + reportUrl;

            Driver.Navigate().GoToUrl(url);

            new WebDriverWait(Driver, TimeSpan.FromSeconds(20))
                .Until(ExpectedConditions.TitleIs(title));
        }

        public void WaitForElementPresent(string cssElement, int sec)
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(sec))
                .Until(ExpectedConditions.ElementIsVisible(By.CssSelector(cssElement)));
        }
    }
}
