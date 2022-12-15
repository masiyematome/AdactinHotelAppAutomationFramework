using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AdactinHotelAppAutomationFramework.WebPageObjects
{
    class LandingPageRepo
    {

        public By GetLandingPageInputs(string pathId)
        {
            return By.XPath(string.Format("//input[@id = '{0}']",pathId));
        }

    }
}