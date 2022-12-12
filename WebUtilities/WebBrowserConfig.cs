using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using WebDriverManager.DriverConfigs.Impl;

namespace AdactinHotelAppAutomationFramework.WebUtilities
{
    class WebBrowserConfig
    {
        private IWebDriver? driver;

        public IWebDriver? GetWebDriver()
        {
            return driver;
        }

        public void SetWebDriver(string webBrowser)
        {

            switch (webBrowser.ToLower())
            {

                case "chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "ie":
                    new WebDriverManager.DriverManager().SetUpDriver(new InternetExplorerConfig());
                    driver = new InternetExplorerDriver();
                    break;

            }

        }

    }
}
