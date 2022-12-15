using System;
using OpenQA.Selenium;

namespace AdactinHotelAppAutomationFramework.Utilities
{
    class WebActions
    {
        public static void ClickOnObject(IWebDriver driver,By element)
        {

            Utils.WaitForProperty(driver, element, 10, 2, "clickability");

            driver.FindElement(element).Click();
             
        }

        public static void CaptureData(IWebDriver driver,By element,string data)
        {

            Utils.WaitForProperty(driver, element, 10, 2, "clickability");

            driver.FindElement(element).SendKeys(data);

        }
    }
}
