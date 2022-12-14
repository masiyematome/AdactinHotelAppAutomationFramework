using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AdactinHotelAppAutomationFramework.Utilities
{
    class Utils
    {
        
        public static void WaitForProperty(IWebDriver driver,IWebElement element,string waitingCondition,int waitingDuration,int pollingDuration)
        {


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitingDuration))
            {
                PollingInterval = TimeSpan.FromMinutes(pollingDuration),
            };


            switch (waitingCondition.ToLower())
            {
                case "visibility":

                    

                    break;
    

            }
        }

    }
}
