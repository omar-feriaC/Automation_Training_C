
using AutomationFrameworkC.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Page_Objects
{
    class clsMercury_LoginPage : BaseTest
    {
        //Variales
        private static WebDriverWait _objWait;
        private static IWebDriver _objDriver;

        //Constructor
        public clsMercury_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _objWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 30));
        }

        //Locators Definitions
        readonly static string STR_USERNAME = "userName";
        readonly static string STR_PASSWORD = "password";
        readonly static string STR_SIGNIN = "login";

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
                Console.WriteLine("The element username not exist: " + e.Message);
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
                Console.WriteLine("The element password not exist: " + e.Message);
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
                Console.WriteLine("The element sign in not exist: " + e.Message);
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
            }
            catch (Exception e)
            {
                Console.WriteLine("Login process fail: " + e.Message);
                Assert.Fail();
            }
        }


    }


}
