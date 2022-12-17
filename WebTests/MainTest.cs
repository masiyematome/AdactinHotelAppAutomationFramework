using AdactinHotelAppAutomationFramework.Data;
using AdactinHotelAppAutomationFramework.PageObjects;
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
        private SearchHotelPage welcomePage;
        private IWebDriver? driver;

        [SetUp]
        public void setUp()
        {

            webBrowserConfig = new WebBrowserConfig();

            webBrowserConfig.SetWebDriver(DataHandler.ReadJsonFiles("properties\\environment.json").GetValue("webBrowser").ToString());

            driver = webBrowserConfig.GetWebDriver();

            landingPage = new LandingPage(driver);
            welcomePage = new SearchHotelPage(driver);

        }

        [Test]
        public void test()
        {

            landingPage.LaunchAdactin();
            landingPage.LoginToAdactin();
            welcomePage.CaptureHotelDetailsAndSearch("London", "Hotel Hervey", "Deluxe", "4 - Four", "15/12/2022","20/12/2022", "2 - Two", "3 - Three");

        }

        [TearDown]
        public void tearDown()
        {

            driver.Quit();

        }

    }
}
