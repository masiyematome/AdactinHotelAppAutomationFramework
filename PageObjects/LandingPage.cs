using AdactinHotelAppAutomationFramework.Data;
using AdactinHotelAppAutomationFramework.Utilities;
using AdactinHotelAppAutomationFramework.WebPageObjects;
using AdactinHotelAppAutomationFramework.WebUtilities;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace AdactinHotelAppAutomationFramework.WebPageFunctions
{
    class LandingPage
    {

        private readonly IWebDriver driver;
        private readonly JObject jsonResults;
        private readonly LandingPageRepo landingPageRepo;

        public LandingPage(IWebDriver driver)
        {

            this.driver = driver;
            jsonResults = DataHandler.ReadJsonFiles("\\properties\\environment.json");
            landingPageRepo = new LandingPageRepo(driver);

        }

        public void LaunchAdactin(IWebDriver driver)
        {

            driver.Url = jsonResults.GetValue("adactinUrl").ToString();
            driver.Manage().Window.Maximize();

        }

        public void LoginToAdactin()
        {

            WebActions.CaptureData(driver, landingPageRepo.txtUsername, jsonResults.GetValue("adactinLoginUsername").ToString());
            WebActions.CaptureData(driver, landingPageRepo.txtPassword, jsonResults.GetValue("adactinLoginPassword").ToString());
            WebActions.ClickOnObject(driver, landingPageRepo.btnLogin);
 
        }

    }
}
