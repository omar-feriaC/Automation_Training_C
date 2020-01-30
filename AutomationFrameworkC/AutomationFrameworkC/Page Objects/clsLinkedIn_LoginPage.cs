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
        private static WebDriverWait objWait;
        private static IWebDriver _objDriver;

        //Constructor
        public clsLinkedIn_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver; //we are receiving the value from outside
            objWait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 30));
        }

        //Element Definitions
        readonly static string STR_USERNAME = "//input[@id='username']";
        readonly static string STR_PASSWORD = "//input[@id='password']";
        readonly static string STR_SIGNIN = "//button[@class='btn__primary--large from__button--floating']";

        //WebElements Definition
        private static IWebElement objUserNameTxt => _objDriver.FindElement(By.XPath(STR_USERNAME));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.XPath(STR_PASSWORD));
        private static IWebElement objSignInBtn => _objDriver.FindElement(By.XPath(STR_SIGNIN));

        //Methods
        //locate the fields in order to work with them
        private IWebElement fnGetUserNameField()
        {
            return objUserNameTxt;
        }
        private IWebElement fnGetPasswordField()
        {
            return objPasswordTxt;
        }
        private IWebElement fnGetSignInButton()
        {
            return objSignInBtn;
        }

        //Once Located validate that those are visible and clean the fields by erasing any text in those
        public static void fnFillUserName(string pUserName)
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_USERNAME))); 
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_USERNAME)));
                objUserNameTxt.Clear();
                objUserNameTxt.SendKeys(pUserName);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element UserName does not appear: " + e.Message);
                Assert.Fail();
            }
        }

        public static void fnFillPassword(string pPassword)
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_PASSWORD)));
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_PASSWORD)));
                objPasswordTxt.Clear();
                objPasswordTxt.SendKeys(pPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element Password does not appear: " + e.Message);
                Assert.Fail();
            }
        }

        public static void fnClickSignIn()
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SIGNIN)));
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SIGNIN)));
                objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_SIGNIN)));
                objSignInBtn.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element SignIn Button does not exist: " + e.Message);
                Assert.Fail();
            }
        }

        public static void fnLoginLinkedIn(string pstrUser, string pstrPass)
        {
            try
            {
                fnFillUserName(pstrUser);
                fnFillPassword(pstrPass);
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
