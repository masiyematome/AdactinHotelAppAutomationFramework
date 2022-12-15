using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AdactinHotelAppAutomationFramework.WebPageObjects
{
    class LandingPageRepo
    {

        public By getLandingPageInputs(string pathId)
        {
            return By.XPath(string.Format("//input[@id = '{0}']",pathId));
        }

    }
}