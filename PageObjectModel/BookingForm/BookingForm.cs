using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.BookingForm
{
    public class BookingForm
    {
        #region Element Locator

        By LocationField = By.Id("location");
        By HotelField = By.Id("hotels");
        By RoomTypeField = By.Id("room_type");
        By NumOfRoomField = By.Id("room_nos");
        By CheckInField = By.Id("datepick_in");
        By CheckOutField = By.Id("datepick_out");
        By AdultField = By.Id("adult_room");
        By ChildField = By.Id("child_room");
        By SearchBtn = By.Id("Submit");
        By ResetBtn = By.Id("Reset");

        #endregion

        #region Test Steps

        public void BookingSteps(IWebDriver driver, string Location, string Hotel, string RoomType, string NumOfRoom, string Adult, string Child)

        {
            var element = driver.FindElement(LocationField);
            var selectdropdown = new SelectElement(element);
            selectdropdown.SelectByText(Location);

            var element2 = driver.FindElement(HotelField);
            var selectdropdown2 = new SelectElement(element2);
            selectdropdown.SelectByText(Hotel);

            var element3 = driver.FindElement(RoomTypeField);
            var selectdropdown3 = new SelectElement(element3);
            selectdropdown.SelectByText(RoomType);

            var element4 = driver.FindElement(NumOfRoomField);
            var selectdropdown4 = new SelectElement(element4);
            selectdropdown.SelectByText(NumOfRoom);

            var element5 = driver.FindElement(AdultField);
            var selectdropdown5 = new SelectElement(element5);
            selectdropdown.SelectByText(Adult);

            var element6 = driver.FindElement(ChildField);
            var selectdropdown6 = new SelectElement(element6);
            selectdropdown.SelectByText(Child);

            driver.FindElement(SearchBtn).Click();

            driver.FindElement(ResetBtn).Click();
        }

        #endregion
    }
}
