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
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;
        

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "///label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";

        readonly static string STR_MINIMIZE_CHAT_BTN = "e1mwfyk10 lc-4rgplc e1m5b1js0";
        readonly static string STR_TOTALADMIN_TXT = "//a[text()= ' Total Admins ']";
        readonly static string STR_TOTALSUPPLIERS_TXT = "//a[text()= ' Total Suppliers ']";
        readonly static string STR_TOTALCUSTOMERS_TXT = "//a[text()= ' Total Customers ']";
        readonly static string STR_TOTALGUESTS_TXT = "//a[text()= ' Total Guests ']";
        readonly static string STR_TOTALBOOKINGS_TXT = "//a[text()= ' Total Bookings ']";

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt = objDriver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt = objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk = objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk = objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn = objDriver.FindElement(By.XPath(STR_LOGIN_BTN));

        private static IWebElement objMinChat => objDriver.FindElement(By.ClassName(STR_MINIMIZE_CHAT_BTN));
        private static IWebElement objTotalAdminTXT => objDriver.FindElement(By.XPath(STR_TOTALADMIN_TXT));
        private static IWebElement objTotalSuppiersTXT => objDriver.FindElement(By.XPath(STR_TOTALSUPPLIERS_TXT));
        private static IWebElement objTotalCustomersTXT => objDriver.FindElement(By.XPath(STR_TOTALCUSTOMERS_TXT));
        private static IWebElement objTotalGuestsTXT => objDriver.FindElement(By.XPath(STR_TOTALGUESTS_TXT));
        private static IWebElement objTotalBookingsTXT => objDriver.FindElement(By.XPath(STR_TOTALBOOKINGS_TXT));

        /*METHODS/FUNCTIONS*/

        //Email
        private IWebElement GetEmailField()
        {
            return objEmailTxt;
        }

        public static void fnEnterEmail(string pstrEmail)
        {
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
            return objLoginBtn;
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

        //Print stats
        public static void fnPrintStats()
        {
            Console.WriteLine(objTotalAdminTXT.Text);
            objRM.fnAddStepLog(objTest, objTotalAdminTXT.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotalSuppiersTXT.Text);
            objRM.fnAddStepLog(objTest, objTotalSuppiersTXT.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotalCustomersTXT.Text);
            objRM.fnAddStepLog(objTest, objTotalGuestsTXT.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotalGuestsTXT.Text);
            objRM.fnAddStepLog(objTest, objTotalGuestsTXT.Text, "Pass");
            Console.WriteLine("");
            Console.WriteLine(objTotalBookingsTXT.Text);
            objRM.fnAddStepLog(objTest, objTotalBookingsTXT.Text, "Pass");
        }

    }
}
