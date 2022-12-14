using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AdactinHotelAppAutomationFramework.WebPageObjects
{
    class LandingPageRepo
    {

        private readonly IWebDriver driver;
        public LandingPageRepo(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//input[@id = 'username']")]
        public IWebElement txtUsername;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'password']")]
        public IWebElement txtPassword;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'login']")]
        public IWebElement btnLogin;

    }
}