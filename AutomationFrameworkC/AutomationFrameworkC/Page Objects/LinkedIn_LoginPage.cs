using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Page_Objects
{
    class LinkedIn_LoginPage
    {
        //Variales
        private static WebDriverWait _objWait;
        private static IWebDriver _objDriver;

        //Constructor
        public LinkedIn_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _objWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 30));
        }

        //Locators Definitions
        readonly static string STR_USERNAME = "username";
        readonly static string STR_PASSWORD = "password";
        readonly static string STR_SIGNIN = "submit";

        //WebElements Definition
        private static IWebElement objUserNameTxt => _objDriver.FindElement(By.Name(STR_USERNAME));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Name(STR_PASSWORD));
        private static IWebElement objSignInBtn => _objDriver.FindElement(By.Name(STR_SIGNIN));

        //Methods
        //UserName
        private IWebElement fnGetUserName()
        {
            return objUserNameTxt;
        }

        private static void fnEnterUserName(string pstrUserName)
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.Name(STR_USERNAME)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_USERNAME)));
                objUserNameTxt.Clear();
                objUserNameTxt.SendKeys(pstrUserName);
            }
            catch (Exception e)
            {
                Console.WriteLine("The username is incorrect: " + e.Message);
                Assert.Fail();
            }
        }

        //Password
        private IWebElement fnGetPassword()
        {
            return objPasswordTxt;
        }

        private static void fnEnterPassword(string pstrPassword)
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.Name(STR_PASSWORD)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_PASSWORD)));
                objPasswordTxt.Clear();
                objPasswordTxt.SendKeys(pstrPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine("The password  is incorrect: " + e.Message);
                Assert.Fail();
            }
        }

        //Sign In
        private IWebElement fnGetSignIn()
        {
            return objSignInBtn;
        }

        private static void fnClickSignIn()
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.Name(STR_SIGNIN)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_SIGNIN)));
                _objWait.Until(ExpectedConditions.ElementToBeClickable(By.Name(STR_SIGNIN)));
                objSignInBtn.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("It was a problem with the Sign In button: " + e.Message);
                Assert.Fail();
            }
        }

        //Login Mehtod
        public static void fnLoginPage(string pstrUser, string pstrPass)
        {
            try
            {
                fnEnterUserName(pstrUser);
                fnEnterPassword(pstrPass);
                fnClickSignIn();
                Console.WriteLine("Login Succesfull");
            }
            catch (Exception e)
            {
                Console.WriteLine("Login was not succesfull: " + e.Message);
                Assert.Fail();
            }
        }

    }
}
