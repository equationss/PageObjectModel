using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Login
{
    [TestClass]
    public class LoginTestCases
    {
        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "validusername", DataAccessMethod.Sequential)]

        public void ValidLogin()
        {
            string user = TestContext.DataRow["User"].ToString();
            string pass = TestContext.DataRow["pass"].ToString();
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://adactinhotelapp.com/";
            LoginPage loginForm = new LoginPage();
            loginForm.LoginSteps(driver, "JunaidJarral", "ABC@123");
            driver.Close();
        }

    }
}
