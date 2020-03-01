using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkC.Base_Files;

namespace AutomationFrameworkC.Page_Objects
{
    class clsPHPTravels_LoginPage 
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;
        private static clsDriver objClsDriver;

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
            objClsDriver = new clsDriver(_objDriver);
        }

        /*LOCATORS*/
        readonly static string STR_EMAIL_TXT = "//input[@name='email']";
        readonly static string STR_PASSWORD_TXT = "//input[@name='password']";
        readonly static string STRREMEMBERME_LNK = "//label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";

        //Dashboard//
        readonly static string STR_STATS_LIST = "//div/ul[@class='serverHeader__statsList']/li/a";


        /*PAGE ELEMENT OBJECTS*/
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.XPath(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.XPath(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk => _objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk => _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));

        //Dashboard//
        private static IList<IWebElement> objStatsList => _objDriver.FindElements(By.XPath(STR_STATS_LIST));

        /*METHOD/ FUNCTIONS*/
       
        //Enter Email
        public static void fnEnterEmail(string pstrEmail)
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_TXT));
            objEmailTxt.Clear();
            objEmailTxt.SendKeys(pstrEmail);
        }

        //Enter Password
        public static void fnEnterPassword(string pstrPass)
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_PASSWORD_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_PASSWORD_TXT));
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPass);
        }

     
        //Clicking Login Button
        public static void fnClickLoginButton()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LOGIN_BTN));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LOGIN_BTN));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_LOGIN_BTN));
            objLoginBtn.Click();
        }

        /*Hamburger Button*/
        public static void fnWaitHamburgerMenu()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }

        //Dashboard//
        public static void fnCheckStatsList()
        {
            for (int j = 0; j < objStatsList.Count; j++)
            {
                Console.WriteLine(objStatsList[j].Text);
            }
        }


    }
}
