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
    class clsLinkedIn_LoginPage : BaseTest
    {
        //Variables
        private static WebDriverWait _objWait;
        private static IWebDriver _objDriver;

        //Constructor
        public clsLinkedIn_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _objWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 30));
        }

        //Locators Definitions
        readonly static string STR_USERNAME = "//input[@id='username']";
        readonly static string STR_PASSWORD = "//input[@id='password']";
        readonly static string STR_SIGNIN = "//button[@data-litms-control-urn='login-submit']";

        //WebElements Definition
        private static IWebElement objUserNameTxt => _objDriver.FindElement(By.XPath(STR_USERNAME));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.XPath(STR_PASSWORD));
        private static IWebElement objSignInBtn => _objDriver.FindElement(By.XPath(STR_SIGNIN));

        //METHODS
        //User Method
        private IWebElement fnGetUserName()
        {
            return objUserNameTxt;
        }
        public static void fnFillUserName(string pstrUserName)
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_USERNAME)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_USERNAME)));
                objUserNameTxt.Clear();
                objUserNameTxt.SendKeys(pstrUserName);
            }
            catch (Exception e)
            {
                Console.WriteLine("The element LastName does not exists: " + e.Message);
                Assert.Fail();
            }
        }

        //Password Method
        private IWebElement fnGetPassword()
        {
            return objPasswordTxt;
        }
        public static void fnFillPassword(string pstrPassword)
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_PASSWORD)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_PASSWORD)));
                objPasswordTxt.Clear();
                objPasswordTxt.SendKeys(pstrPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine("The element Password does not exists: " + e.Message);
                Assert.Fail();
            }
        }

        //Password Method
        private IWebElement fnGetSignIn()
        {
            return objSignInBtn;
        }

        private static void fnClickSignIn()
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SIGNIN)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SIGNIN)));
                _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_SIGNIN)));
                objSignInBtn.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("Sign In button error. " + e.Message);
                Assert.Fail();
            }
        }

        //SignIn Method
        public static void fnSignInPage(string pstrUser, string pstrPass)
        {
            try
            {
                fnFillUserName(pstrUser);
                fnFillPassword(pstrPass);
                fnClickSignIn();
            }
            catch (Exception e)
            {
                Console.WriteLine("SignIn process fail: " + e.Message);
                Assert.Fail();

            }
        }

    }
}
