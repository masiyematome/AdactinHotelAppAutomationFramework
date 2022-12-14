using System;
using OpenQA.Selenium;

namespace AdactinHotelAppAutomationFramework.Utilities
{
    class WebActions
    {
        public static void ClickOnObject(IWebDriver driver,IWebElement element)
        {

            element.Click();
             
        }

        public static void CaptureData(IWebDriver driver,IWebElement element,string data)
        {

            element.SendKeys(data);

        }
    }
}
