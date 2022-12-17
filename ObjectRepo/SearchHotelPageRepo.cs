using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AdactinHotelAppAutomationFramework.ObjectRepo
{
    class SearchHotelPageRepo
    {
        public By GetSearchHotelPageElements(string selectLocatorId)
        {

            return By.XPath(string.Format("//*[@id = '{0}']",selectLocatorId));

        }
        
    }
}
