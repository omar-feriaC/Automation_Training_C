using AutomationFrameworkC.Base_Files;
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
    class LinkedIn_LoginPage : BaseTest 
    {
        //Variables
        private static WebDriverWait _objWait;
        private static IWebDriver _objDriver;

        //Constructor
        public LinkedIn_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _objWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 30));
        }

        //Locators Definitions
        readonly static string STR_USERNAME = "//input[@id='username']";
        readonly static string STR_PASSWORD = "//input[@id='password']";
        readonly static string STR_SIGNIN = "//button[@class='btn__primary--large from__button--floating']";

        //WebElements Definition
        private static IWebElement objUserNameTxt => _objDriver.FindElement(By.XPath(STR_USERNAME));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.XPath(STR_PASSWORD));
        private static IWebElement objSignInBtn => _objDriver.FindElement(By.XPath(STR_SIGNIN));

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
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_USERNAME)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_USERNAME)));
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
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_PASSWORD)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_PASSWORD)));
                _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_PASSWORD)));
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
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SIGNIN)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SIGNIN)));
                _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_SIGNIN)));
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
