using AdactinHotelAppAutomationFramework.WebUtilities;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;


namespace AdactinHotelAppAutomationFramework.WebTests
{
    [TestFixture]
    class LaunchBrowser
    {

        private CommonFunctions commonFunctions;

        [OneTimeSetUp]
        public void SetUp()
        {
            commonFunctions = new CommonFunctions();
        }

        [Test]
        public void BrowserLaunch()
        {

            commonFunctions.LaunchAdactin();

        }

    }
}
