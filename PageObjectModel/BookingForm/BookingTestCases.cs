using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectModel.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.BookingForm
{
    [TestClass]
    public class BookingTestCases
    {
    
        [TestMethod]
        public void ValidData()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/SearchHotel.php";
            BookingForm bookingForm = new BookingForm();
            bookingForm.BookingSteps(driver, "Sydeny", "Hotel Creek", "Double", "1 - One", "1 - One", "0 - None");
            driver.Close();
        }
    }
}
