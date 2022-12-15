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
            landingPageRepo = new LandingPageRepo();

        }

        public void LaunchAdactin()
        {

            driver.Url = jsonResults.GetValue("adactinUrl").ToString();
            driver.Manage().Window.Maximize();

        }

        public void LoginToAdactin()
        {

            WebActions.CaptureData(driver, landingPageRepo.GetLandingPageInputs("username"), jsonResults.GetValue("adactinLoginUsername").ToString());
            WebActions.CaptureData(driver, landingPageRepo.GetLandingPageInputs("password"), jsonResults.GetValue("adactinLoginPassword").ToString());
            WebActions.ClickOnObject(driver, landingPageRepo.GetLandingPageInputs("login"));
 
        }

    }
}
