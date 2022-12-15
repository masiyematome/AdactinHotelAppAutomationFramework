using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AdactinHotelAppAutomationFramework.Utilities
{
    class Utils
    {
        
        public static void WaitForProperty(IWebDriver driver,By elementToWaitFor,int waitingDuration,int pollingDuration,string waitCondition)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitingDuration))
            {
                PollingInterval = TimeSpan.FromSeconds(pollingDuration),
            };

            wait.IgnoreExceptionTypes(typeof(ElementNotVisibleException));

            switch (waitCondition.ToLower())
            {

                case "visibility":

                    wait.Until(ExpectedConditions.ElementIsVisible(elementToWaitFor));

                    break;

                case "clickability":

                    wait.Until(ExpectedConditions.ElementToBeClickable(elementToWaitFor));

                    break;
            }

        }

    }
}
