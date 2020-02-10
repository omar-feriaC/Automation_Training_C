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

        //Locators Definition
        readonly static string STR_USERNAME = "username";
        readonly static string STR_PASSWORD = "password";
        readonly static string STR_SIGNIN = "//button[@aria-label='Sign in']";

        //WebElements Definition
        private static IWebElement objUserNameTxt => _objDriver.FindElement(By.Id(STR_USERNAME));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Id(STR_PASSWORD));
        private static IWebElement objSignInBtn => _objDriver.FindElement(By.XPath(STR_SIGNIN));

        //Methods

        //User name text box
        private IWebElement fnGetUserName()
        {
            return objUserNameTxt;
        }

        public static void fnEnterUserName(string pstrUserName)
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.Id(STR_USERNAME)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_USERNAME)));
                objUserNameTxt.Clear();
                objUserNameTxt.SendKeys(pstrUserName);
            }
            catch (Exception e)
            {
                Console.WriteLine("The element username does not exist. Error code: " + e.Message);
                Assert.Fail();
            }

        }

        //Password text box
        private IWebElement fnGetPassword()
        {
            return objPasswordTxt;
        }

        public static void fnEnterPassword(string pstrPassword)
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.Id(STR_PASSWORD)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_PASSWORD)));
                objPasswordTxt.Clear();
                objPasswordTxt.SendKeys(pstrPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine("The element password does not exist. Error code: " + e.Message);
                Assert.Fail();
            }
        }

        //Sign in button
        private IWebElement fnGetSignIn()
        {
            return objSignInBtn;
        }

        public static void fnClickSignIn()
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SIGNIN)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SIGNIN)));
                objSignInBtn.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("The element signIn does not exist. Error code: " + e.Message);
                Assert.Fail();
            }
        }

        //Login to LinkedIn
        public static void fnLinkedIn_LoginPage(string pstrUserName, string pstrPassword)
        {
            try
            {
                fnEnterUserName(pstrUserName);
                fnEnterPassword(pstrPassword);
                fnClickSignIn();
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@data-control-name='identity_welcome_message']")));
            }
            catch (Exception e)
            {
                Console.WriteLine("Login test failed: " + e.Message);
                Assert.Fail();
            }
        }

    }
}
