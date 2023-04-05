using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Login
{
    public class LoginPage : BasePage
    {
        #region Element Locator

        By UsernameField = By.Id("username");
        By PasswordField = By.Id("password");
        By LoginBtn = By.Id("login");

        #endregion

        #region Test Steps

        public void LoginSteps(string username, string password)

        {
            driver.FindElement(UsernameField).SendKeys(username);
            driver.FindElement(PasswordField).SendKeys(password);
            driver.FindElement(LoginBtn).Click();
        }

        #endregion

    }
}
