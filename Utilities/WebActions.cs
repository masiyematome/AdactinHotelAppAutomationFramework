using System;
using OpenQA.Selenium;

namespace AdactinHotelAppAutomationFramework.Utilities
{
    class WebActions
    {
        public static void ClickOnObject(IWebDriver driver,By element)
        {

            driver.FindElement(element).Click();
             
        }

    }
}
