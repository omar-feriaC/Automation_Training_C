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
        #region variables
        //Variables
        private static WebDriverWait objWait;
        private static IWebDriver _objDriver;
        #endregion variables
        #region Constructor
        //Constructor
        public clsLinkedIn_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            objWait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 30));
        }
        #endregion Constructor
        #region Elements
        //Elements, we are identifying the elements to fill and the errors that could be triggered
        readonly static string STR_USERNAME = "//input[@id='username']";
        readonly static string STR_PASSWORD = "//input[@id='password']";
        readonly static string STR_SIGNIN = "//button[@class='btn__primary--large from__button--floating']";
        readonly static string STR_ERRORUSERNAME = "//div[@id='error-for-username']";
        readonly static string STR_ERRORPASSWORD = "//div[@id='error-for-password']";
         //WebElements Definition
        private static IWebElement objUserNameTxt => _objDriver.FindElement(By.XPath(STR_USERNAME));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.XPath(STR_PASSWORD));
        private static IWebElement objSignInBtn => _objDriver.FindElement(By.XPath(STR_SIGNIN));
        private static IWebElement objUserNameErrorTxt => _objDriver.FindElement(By.XPath(STR_ERRORUSERNAME));
        private static IWebElement objPasswordErrorTxt => _objDriver.FindElement(By.XPath(STR_ERRORPASSWORD));
        #endregion Elements
        #region Methods
        //Methods
        #region UserName Methods
        private IWebElement fnGetUserName()
        {
            return objUserNameTxt;
        }
        public static void fnUserName(string pstrUserName)
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_USERNAME)));
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_USERNAME)));
                objUserNameTxt.Clear();
                objUserNameTxt.SendKeys(pstrUserName);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element username does not exist: " + e.Message);
                Assert.Fail();
            }
        }
        #endregion UserName Methods
        #region Password Methods
        //Password
        private IWebElement fnGetPassowrd()
            {
                return objPasswordTxt;
            }
        public static void fnPassword(string pstrPassword)
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_PASSWORD)));
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_PASSWORD)));
                objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_PASSWORD)));
                objPasswordTxt.Clear();
                objPasswordTxt.SendKeys(pstrPassword);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element Password does not exist: " + e.Message);
                Assert.Fail();
            }
        }
        #endregion Password Methods
        #region SignIn Buton Methods
        //Sign In Button, this allows to identify the element and click it
        private IWebElement fnGetSignIn()
                {
                    return objSignInBtn;
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
        #endregion SignIn Buton Methods
        #region Confirm the login in feed page
        // this verify that the URL has changed after the login and is the one expected
        public static void fnConfirmFeedPage()
        {
            if (_objDriver.Url.Contains("feed"))
            {
                Console.WriteLine($"The Login was done as expected");
            }
            else
            {
                Assert.Fail("The page is not the one expected");
            }
        }
        #endregion Confirm the login in feed page
        #region MergeMethods
        //Function to compile/merge all involved in a login
        public static void fnLoginPage(string pstrUser, string pstrPass)
        {
            try
            {
                fnUserName(pstrUser);
                fnPassword(pstrPass);
                fnClickSignIn();
                fnConfirmFeedPage();
            }
            catch (SuccessException e)
            {
                Console.WriteLine($"The Login was done as expected");
            }
            catch (Exception e)
            {
                Assert.Fail($"There is an error {e.Message}");
            }
        }
        #endregion MergeMethods
        #endregion Methods
    }
}
