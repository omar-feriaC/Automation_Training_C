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
    class clsPHPTravels_AccountPage : BaseTest
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;



        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "///label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        readonly static string STR_COLUMNFIRSTNAME_BTN = "//th[text()='First Name']";
        readonly static string STR_COLUMNFIRSTNAMEASC_BTN = "//th[text()='↓ First Name']";
        readonly static string STR_COLUMNFIRSTNAMEDESC_BTN = "//th[text()='↑ First Name']";
        readonly static string STR_COLUMNLASTNAME_BTN = "//th[text()='Last Name']";
        readonly static string STR_COLUMNLASTNAMEASC_BTN = "//th[text()='↓ Last Name']";
        readonly static string STR_COLUMNLASTNAMEDESC_BTN = "//th[text()='↑ Last Name']";
        readonly static string STR_COLUMNEMAIL_BTN = "//th[text()='Email']";
        readonly static string STR_COLUMNEMAILASC_BTN = "//th[text()='↓ Email']";
        readonly static string STR_COLUMNEMAILDESC_BTN = "//th[text()='↑ Email']";



        /*CONSTRUCTOR*/
        public clsPHPTravels_AccountPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk => _objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk => _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
        private static IWebElement objColumnFirstNameTxt => _objDriver.FindElement(By.XPath(STR_COLUMNFIRSTNAME_BTN));
        private static IWebElement objColumnFirstNameAscTxt => _objDriver.FindElement(By.XPath(STR_COLUMNFIRSTNAMEASC_BTN));
        private static IWebElement objColumnFirstNameDescTxt => _objDriver.FindElement(By.XPath(STR_COLUMNFIRSTNAMEDESC_BTN));
        private static IWebElement objColumnLastNameTxt => _objDriver.FindElement(By.XPath(STR_COLUMNLASTNAME_BTN));
        private static IWebElement objColumnLastNameAscTxt => _objDriver.FindElement(By.XPath(STR_COLUMNLASTNAMEASC_BTN));
        private static IWebElement objColumnLastNameDescTxt => _objDriver.FindElement(By.XPath(STR_COLUMNLASTNAMEDESC_BTN));
        private static IWebElement objColumnEmailTxt => _objDriver.FindElement(By.XPath(STR_COLUMNEMAIL_BTN));
        private static IWebElement objColumnEmailAscTxt => _objDriver.FindElement(By.XPath(STR_COLUMNEMAILASC_BTN));
        private static IWebElement objColumnEmailDescTxt => _objDriver.FindElement(By.XPath(STR_COLUMNEMAILDESC_BTN));



        /*METHODS/FUNCTIONS*/

        //Email
        private IWebElement GetEmailField()
        {
            return objEmailTxt;
        }

        public static void fnEnterEmail(string pstrEmail)
        {
            clsDriver objclsDriver;
            objclsDriver = new clsDriver(_objDriver);
            clsDriver.fnWaitForElementToExist(By.Name(STR_EMAIL_TXT));
            clsDriver.fnWaitForElementToBeVisible(By.Name(STR_EMAIL_TXT));

            objEmailTxt.Clear();
            objEmailTxt.SendKeys(pstrEmail);
        }

        //Password
        private IWebElement GetPasswordField()
        {
            return objPasswordTxt;
        }

        public static void fnEnterPassword(string pstrPass)
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Name(STR_PASSWORD_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_PASSWORD_TXT)));
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
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOGIN_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOGIN_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOGIN_BTN)));
            objLoginBtn.Click();
        }

        /*Hamburger Button*/
        public static void fnWaitHamburgerMenu()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }

        /*Sort Column Verification method*/
        public static void fnSortColumnVerification(string pstrColumnName)
        {
            switch (pstrColumnName.ToLower())
            {
                case "first name":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_COLUMNFIRSTNAME_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_COLUMNFIRSTNAME_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_COLUMNFIRSTNAME_BTN)));
                    objColumnFirstNameTxt.Click();
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_COLUMNFIRSTNAMEASC_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_COLUMNFIRSTNAMEASC_BTN)));
                    Assert.AreEqual("↓ First Name", objColumnFirstNameAscTxt.Text, "The row order is not working correctly");
                    objColumnFirstNameAscTxt.Click();
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_COLUMNFIRSTNAMEDESC_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_COLUMNFIRSTNAMEDESC_BTN)));
                    Assert.AreEqual("↑ First Name", objColumnFirstNameDescTxt.Text, "The row order is not working correctly");


                    break;
                case "last name":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_COLUMNLASTNAME_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_COLUMNLASTNAME_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_COLUMNLASTNAME_BTN)));
                    objColumnLastNameTxt.Click();
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_COLUMNLASTNAMEASC_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_COLUMNLASTNAMEASC_BTN)));
                    Assert.AreEqual("↓ Last Name", objColumnLastNameAscTxt.Text, "The row order is not working correctly");
                    objColumnLastNameAscTxt.Click();
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_COLUMNLASTNAMEDESC_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_COLUMNLASTNAMEDESC_BTN)));
                    Assert.AreEqual("↑ Last Name", objColumnLastNameDescTxt.Text, "The row order is not working correctly");
                    break;
                case "email":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_COLUMNEMAIL_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_COLUMNEMAIL_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_COLUMNEMAIL_BTN)));
                    objColumnEmailTxt.Click();
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_COLUMNEMAILASC_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_COLUMNEMAILASC_BTN)));
                    Assert.AreEqual("↓ Email", objColumnEmailAscTxt.Text, "The row order is not working correctly");
                    objColumnEmailAscTxt.Click();
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_COLUMNEMAILDESC_BTN)));
                    _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_COLUMNEMAILDESC_BTN)));
                    Assert.AreEqual("↑ Email", objColumnEmailDescTxt.Text, "The row order is not working correctly");
                    break;

            }
           

        }

    }


    
}
