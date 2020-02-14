using AutomationFrameworkC.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationFrameworkC.Page_Objects
{
    class LinkedIn_LoginPage : BaseTest
    {

        

        private static WebDriverWait _objWait;
        private static IWebDriver _objDriver;

        public LinkedIn_LoginPage(IWebDriver pobjDriver)

        {
            _objDriver = pobjDriver;
            _objWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 60));
        }

        readonly static string STR_USERNAME = "username";
        readonly static string STR_PASSWORD = "password";
        readonly static string STR_SIGNIN = "btn__primary--large";

        private static IWebElement objUserNameTxt => _objDriver.FindElement(By.Id(STR_USERNAME));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Id(STR_PASSWORD));
        private static IWebElement objSignInBtn => _objDriver.FindElement(By.ClassName(STR_SIGNIN));

        private IWebElement fnGetUserName()
        {
            return objUserNameTxt;
        }

        private static void fnEnterUserName(string pstrUserName)
        {
            try
            {
              
                    objUserNameTxt.SendKeys(pstrUserName);
                
         
            }
            catch (Exception e)
            {
                Console.WriteLine("The username is incorrect: " + e.Message);
                Assert.Fail();
            }
           
        }

        private IWebElement fnGetPassword()
        {
            return objPasswordTxt;
        }

        private static void fnEnterPassword(string pstrPassword)
        {
            try
            {
              
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
 
                    objSignInBtn.Submit();
                  
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem with the Sign In button: " + e.Message);
                Assert.Fail();
            }
        }

        
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
                Console.WriteLine("Login was not succesfull: "+ e.Message);
                Assert.Fail();
            }
        }
    }
}