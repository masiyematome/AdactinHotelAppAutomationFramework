using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AdactinHotelAppAutomationFramework.ObjectRepo
{
    class SearchHotelPageRepo
    {
        public By GetSearchHotelPageSelects(string selectLocatorId)
        {

            return By.XPath(string.Format("//select[@id = '{0}']",selectLocatorId));

        }

        public By GetSearchHotelPageInputs(string inputLocatorId)
        {

            return By.XPath(string.Format("//input[@id = '{0}']",inputLocatorId));

        }

        public By GetSearchHotelPageLinks(string locatorText)
        {

            return By.XPath(string.Format("//a[text()[contains(.,'{0}')]]",locatorText));

        }
        
    }
}
