﻿using AdactinHotelAppAutomationFramework.Data;
using AdactinHotelAppAutomationFramework.Utilities;
using AdactinHotelAppAutomationFramework.WebPageObjects;
using AdactinHotelAppAutomationFramework.WebUtilities;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace AdactinHotelAppAutomationFramework.WebPageFunctions
{
    class WebFunctions
    {

        private readonly WebBrowserConfig webBrowserConfig = new WebBrowserConfig();
        private readonly LandingPage landingPage = new LandingPage();
        private readonly DataHandler dataHandler = new DataHandler();
        private IWebDriver? driver;

        public void LaunchAdactin()
        {

            JObject jsonResults = dataHandler.ReadJsonFiles("properties\\environment.json");

            webBrowserConfig.SetWebDriver(jsonResults.GetValue("webBrowser").ToString());
            driver = webBrowserConfig.GetWebDriver();


            if (driver is not null)
            {
                
                driver.Url = jsonResults.GetValue("adactinUrl").ToString();

                driver.Manage().Window.Maximize();

            }

        }
        public void LoginToAdactin()
        {

            

        }

        public void LogoutOfAdactin()
        {

        }

    }
}
