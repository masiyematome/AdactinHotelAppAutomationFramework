using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AdactinHotelAppAutomationFramework.Utilities
{
    class WebActions
    {
        public static void ClickOnObject(IWebDriver driver,By element)
        {

            Utils.WaitForProperty(driver, element, 10, 2, "clickability");

            driver.FindElement(element).Click();
             
        }

        public static void CaptureData(IWebDriver driver,By elementLocator,string data)
        {

            IWebElement elementToCaptureInto = driver.FindElement(elementLocator);

            Utils.WaitForProperty(driver, elementLocator, 10, 2, "clickability");

            elementToCaptureInto.Clear();
            elementToCaptureInto.SendKeys(data);

        }

        public static void HandleDropDowns(IWebDriver driver,By elementLocator,string elementToSelect)
        {

            IWebElement targetDropdownElement = driver.FindElement(elementLocator);

            SelectElement selectElement = new SelectElement(targetDropdownElement);

            Utils.WaitForProperty(driver, elementLocator, 10, 2, "clickability");

            selectElement.SelectByText(elementToSelect);
           
        }

    }
}
