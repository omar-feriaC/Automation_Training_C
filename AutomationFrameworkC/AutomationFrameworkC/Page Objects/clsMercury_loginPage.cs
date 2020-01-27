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
    class clsMercury_loginPage : BaseTest  // this is the way to inherit
    {
        //Variables
        private static WebDriverWait objWait;
        private static IWebDriver _objDriver;

        //Constructor
        // the constructor must have the same name of the class and MUST BE ALWAYS PUBLIC
        public clsMercury_loginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver; //we are receiving the value from outside
            objWait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 30));
        }

        //Element Definitions
        readonly static string STR_USERNAME = "userName";
        readonly static string STR_PASSWORD = "password";
        readonly static string STR_SIGNIN = "login";

        //WebElements Definition
        private static IWebElement objUserNameTxt => _objDriver.FindElement(By.Name(STR_USERNAME)); //lambda expression, assign something to an object
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Name(STR_PASSWORD));
        private static IWebElement objSignInBtn => _objDriver.FindElement(By.Name(STR_SIGNIN));

        //Methods
        //Username
        private IWebElement fnGetUserName()
        {
            return objUserNameTxt;
        }
        public static void fnUserName (string pstrUserName)
        {
            try
            {
            objWait.Until(ExpectedConditions.ElementExists(By.Name(STR_USERNAME)));
            objWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_USERNAME)));
            objUserNameTxt.Clear();
            objUserNameTxt.SendKeys(pstrUserName);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element username does not exist: " + e.Message);
                Assert.Fail();
            }
            //finally 
            //{

            //}
        }

            //Password
            private IWebElement fnGetPassowrd()
        {
            return objPasswordTxt;
        }

        public static void fnPassword(string pstrPassword)
        {
            try
            {
            objWait.Until(ExpectedConditions.ElementExists(By.Name(STR_PASSWORD)));
            objWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_PASSWORD)));
            objWait.Until(ExpectedConditions.ElementToBeClickable(By.Name(STR_PASSWORD)));
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element Password does not exist: " + e.Message);
                Assert.Fail();
            }
        }

        //Sign In Button
        private IWebElement fnGetSignIn()
        {
            return objSignInBtn;
        }

        public static void fnClickSignIn()
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.Name(STR_SIGNIN)));
                objWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_SIGNIN)));
                objWait.Until(ExpectedConditions.ElementToBeClickable(By.Name(STR_SIGNIN)));
                objSignInBtn.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element SignIn Button does not exist: " + e.Message);
                Assert.Fail();
            }
        }

        public static void fnLoginPage(string pstrUser, string pstrPass)
        {
            try
            {
                fnUserName(pstrUser);
                fnPassword(pstrPass);
                fnClickSignIn();
            }
            catch (Exception e)
            {
                Console.WriteLine("The Error ");
                Assert.Fail();
            }
        }
    }
}
