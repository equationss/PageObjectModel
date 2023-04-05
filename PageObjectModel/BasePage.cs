using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public class BasePage
    {

        public static IWebDriver driver;
        public static void SeleniumInit(string browser)
        {
            driver = new ChromeDriver();
        }
        public static void CloseDriver()
        {
            driver.Close();
        }
    }
}
