using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactinHotelAppAutomationFramework.WebPageObjects
{
    class LandingPage
    {
        private readonly IWebDriver driver;

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement txtUsername => driver.FindElement(By.XPath("//input[@id='username']"));
        public IWebElement txtPassword => driver.FindElement(By.XPath("//input[@id='password']"));
        public IWebElement btnLogin => driver.FindElement(By.XPath("//input[@id='login']"));
        public IWebElement imgLogo => driver.FindElement(By.XPath("//img[@class='logo']"));

    }
}
