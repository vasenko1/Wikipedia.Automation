using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Wikipedia.Automation.Pages;

namespace Wikipedia.Automation.Tests
{
    class CheckMainPageElementPresented
    {
        private readonly IWebDriver driver;
        protected MainPage mainPage;

        public virtual void RunTest()
        {
            OpenMainPage();

            ClickRussianLink();
            CheckIsRussianHomePageOpened();
        }

        private void OpenMainPage()
        {
            driver.Url;
        }

    }
}
