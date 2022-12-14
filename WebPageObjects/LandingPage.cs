using System;
using OpenQA.Selenium;

namespace AdactinHotelAppAutomationFramework.WebPageObjects
{
    class LandingPage
    {
        public By getLandingPageInputs(string pathString)
        {
            return By.XPath(String.Format("//input[@id = '{0}']",pathString));
        }

    }
}