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

        public void CaptureHotelDetailsAndSearch(string location,string hotels,string roomType,string roomNos,
            string checkInDate,string checkOutDate,string adultRoom,string childRoom)
        {
            
            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageElements("location"), location);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageElements("hotels"), hotels);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageElements("room_type"), roomType);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageElements("room_nos"), roomNos);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageElements("adult_room"), adultRoom);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageElements("child_room"), childRoom);

            WebActions.CaptureData(driver, searchHotelPageRepo.GetSearchHotelPageElements("datepick_in"), checkInDate);

            WebActions.CaptureData(driver, searchHotelPageRepo.GetSearchHotelPageElements("datepick_out"), checkOutDate);

            WebActions.ClickOnObject(driver, searchHotelPageRepo.GetSearchHotelPageElements("Submit"));

            WebActions.ClickOnObject(driver, searchHotelPageRepo.GetSearchHotelPageElements("radiobutton_0"));

            WebActions.ClickOnObject(driver, searchHotelPageRepo.GetSearchHotelPageElements("continue"));

        }

        public void BookAHotel(string firstName,string lastName,string billingAddress,
            string creditCardNo,string creditCardType,string expiryDateMonth,string expiryDateYear,string cvvNumber)
        {

            WebActions.CaptureData(driver, searchHotelPageRepo.GetSearchHotelPageElements("first_name"), firstName);

            WebActions.CaptureData(driver, searchHotelPageRepo.GetSearchHotelPageElements("last_name"), lastName);

            WebActions.CaptureData(driver, searchHotelPageRepo.GetSearchHotelPageElements("address"), billingAddress);

            WebActions.CaptureData(driver, searchHotelPageRepo.GetSearchHotelPageElements("cc_num"), creditCardNo);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageElements("cc_type"), creditCardType);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageElements("cc_exp_month"), expiryDateMonth);

            WebActions.HandleDropDowns(driver, searchHotelPageRepo.GetSearchHotelPageElements("cc_exp_year"), expiryDateYear);

            WebActions.CaptureData(driver, searchHotelPageRepo.GetSearchHotelPageElements("cc_cvv"), cvvNumber);

            WebActions.ClickOnObject(driver, searchHotelPageRepo.GetSearchHotelPageElements("book_now"));

        }



        public void Logout()
        {
            WebActions.ClickOnObject(driver, searchHotelPageRepo.GetSearchHotelPageElements("Logout"));
        }

    }
}
