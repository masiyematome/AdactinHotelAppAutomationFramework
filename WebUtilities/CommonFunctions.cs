using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace AdactinHotelAppAutomationFramework.WebUtilities
{
    class CommonFunctions
    {

        private WebBrowserConfig webBrowserConfig = new WebBrowserConfig();
        private IWebDriver? driver;
        public void LaunchAdactin()
        {

            JObject jsonObj = JObject.Parse(File.ReadAllText(@"C:\Users\Matome.Masiye\Documents\C#\AdactinHotelAppAutomationFramework\properties\environment.json"));
            string webBrowser = jsonObj.GetValue("webBrowser").ToString();
            string appUrl = jsonObj.GetValue("adactinUrl").ToString();

            webBrowserConfig.SetWebDriver(webBrowser);
            driver = webBrowserConfig.GetWebDriver();

            driver.Url = appUrl;

            driver.Manage().Window.Maximize();

        }
        public void LoginToAdactin()
        {

        }

        public void LogoutOfAdactin()
        {

        }

    }
}
