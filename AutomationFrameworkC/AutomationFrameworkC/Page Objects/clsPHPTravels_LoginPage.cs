using AutomationFrameworkC.Base_Files;
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
    class clsPHPTravels_LoginPage : BaseTest
    {
        
        /*ATTRIBUTES*/
        public static WebDriverWait _objDriverWait;
        private static clsDriver objClsDriver = new clsDriver(objDriver); // initializing this object

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            objDriver = pobjDriver;
            _objDriverWait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 40));
        }

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "//input[@name='email']";
        readonly static string STR_PASSWORD_TXT = "//input[@name='password']";
        readonly static string STRREMEMBERME_LNK = "///label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt => objDriver.FindElement(By.XPath(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => objDriver.FindElement(By.XPath(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk => objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk => objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => objDriver.FindElement(By.XPath(STR_LOGIN_BTN));

        /*METHODS/FUNCTIONS*/
        //Email
        public static void fnEnterEmail(string pstrEmail)
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_TXT));
            objEmailTxt.Clear();
            objEmailTxt.SendKeys(pstrEmail);
        }
        public static void fnEnterPassword(string pstrPass)
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_PASSWORD_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_PASSWORD_TXT));
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPass);
        }

        //Login Button
        private IWebElement GetLoginButton()
        {
            return objRememberMeLnk;
        }

        public static void fnClickLoginButton()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LOGIN_BTN));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_LOGIN_BTN));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LOGIN_BTN));
            objLoginBtn.Click();
        }

        /*Hamburger Button*/
        public static void fnWaitHamburgerMenu()
        {
            _objDriverWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            _objDriverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            _objDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }


        public static void fnCounTheElements()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_LOGIN_BTN));
            clsDriver.fnWaitForElementToBeClickable(By.XPath(STR_LOGIN_BTN));
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LOGIN_BTN));
            objLoginBtn.Click();
        }

    }
}
