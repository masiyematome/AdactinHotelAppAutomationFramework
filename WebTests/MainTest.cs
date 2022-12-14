using AdactinHotelAppAutomationFramework.Data;
using AdactinHotelAppAutomationFramework.WebPageFunctions;
using AdactinHotelAppAutomationFramework.WebPageObjects;
using AdactinHotelAppAutomationFramework.WebUtilities;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AdactinHotelAppAutomationFramework.WebTests
{
    [TestFixture]
    class MainTest
    {
        private LandingPage landingPage;
        private WebBrowserConfig webBrowserConfig;
        private IWebDriver? driver;

        [OneTimeSetUp]
        public void setUp()
        {

            webBrowserConfig = new WebBrowserConfig();

            webBrowserConfig.SetWebDriver(DataHandler.ReadJsonFiles("properties\\environment.json").GetValue("webBrowser").ToString());

            driver = webBrowserConfig.GetWebDriver();

            landingPage = new LandingPage(driver);

        }

        [Test]
        public void test()
        {

            landingPage.LaunchAdactin(driver);
            landingPage.LoginToAdactin();

        }

    }
}
