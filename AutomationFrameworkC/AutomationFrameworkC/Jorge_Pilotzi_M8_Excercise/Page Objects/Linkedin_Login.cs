using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.BaseFiles;
using OpenQA.Selenium;


namespace AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.Page_Objects
{
    class Linkedin_Login : BaseTest
    {
        // Variables

        private static IWebDriver _objDriver;

        //Locators Definitions
        readonly static string STR_USERNAME = "username";
        readonly static string STR_PASSWORD = "password";
        readonly static string STR_SIGNIN = "//button[text()='Sign in']";

        // CONSTRUCTOR

        public Linkedin_Login(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
        }

        //WebElements Definition

        private static IWebElement objUserNameTxt => _objDriver.FindElement(By.Id(STR_USERNAME));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Id(STR_PASSWORD));
        private static IWebElement objSignInBtn => _objDriver.FindElement(By.XPath(STR_SIGNIN));
                
        //METHODS
        //UserName
        private IWebElement FnGetUserNameField()
        {
            return objUserNameTxt;
        }
        //UserName Field.
        public static void FnGetUserNameField(string pstrUserName)
        {
            objUserNameTxt.Clear();
            objUserNameTxt.SendKeys(pstrUserName);
        }

        //Passeord Field.
        private IWebElement FnGetPassword()
        {
            return objPasswordTxt;
        }
        public static void FnGetPassword(string pstrPassword)
        {
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPassword);
        }

        //SignIn Button
        private IWebElement FnGetSignIn()
        {
            return objSignInBtn;
        }

        public static void FnGetSignInBtn()
        {
            objSignInBtn.Click();
        }

    }
}
