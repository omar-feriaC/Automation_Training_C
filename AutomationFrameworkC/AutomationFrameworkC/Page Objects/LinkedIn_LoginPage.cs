using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Configuration;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using AutomationFrameworkC.Base_Files;

namespace AutomationFrameworkC.Page_Objects
{
    class LinkedIn_LoginPage : BaseTest
    {
        private static IWebDriver _objDriver;

        public LinkedIn_LoginPage(IWebDriver driver)
        {
            _objDriver = driver;
        }

        /*ELEMENT LOCATORS*/
        private static readonly string str_username_textfield_Id = "username";
        private static readonly string str_password_textfield_Id = "password";
        private static readonly string str_login_button_Xpath = "//button[@class='btn__primary--large from__button--floating']";

        /*PAGE ELEMENT OBJECTS*/
        private static IWebElement objUsernameText => _objDriver.FindElement(By.Id(str_username_textfield_Id));
        private static IWebElement objPasswordText => _objDriver.FindElement(By.Id(str_password_textfield_Id));
        private static IWebElement objLoginButton => _objDriver.FindElement(By.XPath(str_login_button_Xpath));

        /*GET ELEMENT METHODS*/
        public IWebElement GetUsernameField()
        {
            return objUsernameText;
        }

        public IWebElement GetPasswordField()
        {
            return objPasswordText;
        }

        public IWebElement GetLoginButton()
        {
            return objLoginButton;
        }

        /*ELEMENT ACTIONS*/
        public void FnEnterUsername(string pstrUsername)
        {
            objUsernameText.Clear();
            objUsernameText.SendKeys(pstrUsername);
        }

        public void FnEnterPassword(string pstrPassword)
        {
            objPasswordText.Clear();
            objPasswordText.SendKeys(pstrPassword);
        }

        public void FnClickSignInButton()
        {
            objLoginButton.Click();
        }

    }
}

