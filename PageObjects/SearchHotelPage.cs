using AdactinHotelAppAutomationFramework.Data;
using AdactinHotelAppAutomationFramework.ObjectRepo;
using AdactinHotelAppAutomationFramework.Utilities;
using OpenQA.Selenium;
using System;

namespace AdactinHotelAppAutomationFramework.PageObjects
{
    class SearchHotelPage
    {

        private readonly SearchHotelPageRepo searchHotelPageRepo;
        private readonly IWebDriver driver;
       
        public SearchHotelPage(IWebDriver driver)
        {

            this.driver = driver;
            searchHotelPageRepo = new SearchHotelPageRepo();

        }

        public void CaptureHotelDetailsAndSearch(string location,string hotels,string roomType,string roomNos,string checkInDate,string checkOutDate,string adultRoom,string childRoom)
        {
            
            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageSelects("location"), location);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageSelects("hotels"), hotels);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageSelects("room_type"), roomType);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageSelects("room_nos"), roomNos);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageSelects("adult_room"), adultRoom);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageSelects("child_room"), childRoom);

            WebActions.CaptureData(driver, searchHotelPageRepo.GetSearchHotelPageInputs("datepick_in"), checkInDate);

            WebActions.CaptureData(driver, searchHotelPageRepo.GetSearchHotelPageInputs("datepick_out"), checkOutDate);

            WebActions.ClickOnObject(driver, searchHotelPageRepo.GetSearchHotelPageInputs("Submit"));

            WebActions.ClickOnObject(driver, searchHotelPageRepo.GetSearchHotelPageInputs("radiobutton_0"));

            WebActions.ClickOnObject(driver, searchHotelPageRepo.GetSearchHotelPageInputs("continue"));

        }

        public void Logout()
        {
            WebActions.ClickOnObject(driver, searchHotelPageRepo.GetSearchHotelPageLinks("Logout"));
        }

    }
}
