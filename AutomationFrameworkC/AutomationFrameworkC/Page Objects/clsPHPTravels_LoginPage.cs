using AutomationFrameworkC.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

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
        readonly static string STR_TOTALADMIN_TXT = "//div[@id='content']/div[2]/div[3]/ul[1]/li[1]/a[1]";
        readonly static string STR_TOTALSUPPLIERS_TXT = "//div[@id='content']/div[2]/div[3]/ul[1]/li[2]/a[1]";
        readonly static string STR_TOTALCUSTOMERS_TXT = "//div[@id='content']/div[2]/div[3]/ul[1]/li[3]/a[1]";
        readonly static string STR_TOTALGUESTS_TXT = "//div[@id='content']/div[2]/div[3]/ul[1]/li[4]/a[1]";
        readonly static string STR_TOTALBOOKINGS_TXT = "//div[@id='content']/div[2]/div[3]/ul[1]/li[5]/a[1]";
        readonly static string STR_DASHBOARD_LB_BTN = "//ul[@id='social-sidebar-menu']/li[1]/a[1]";
        readonly static string STR_ACCOUNT_BTN = "//*[@class='ink animate']";
        readonly static string STR_ADMINS_BTN = "//a[@href='https://www.phptravels.net/admin/accounts/admins/']";
        readonly static string STR_SUPPLIERS_BTN = "//a[@href='https://www.phptravels.net/admin/accounts/suppliers/']";
        readonly static string STR_CUSTOMERS_BTN = "//a[@href='https://www.phptravels.net/admin/accounts/customers/']";
        readonly static string STR_GUEST_CUST_BTN = "//a[@href='https://www.phptravels.net/admin/accounts/guest/']";
        readonly static string STR_ACCOUNT_OPTION_BTN = "//a[@href='#ACCOUNTS']";
        readonly static string STR_ACCOUNT_CUSTOMER_OPTION_BTN = "//ul[@id='ACCOUNTS']/li[3]/a[1]";
        readonly static string STR_FIRST_NAME_SORT_BTN = "(//th[contains(@class,'xcrud-column xcrud-action')])[1]";
        readonly static string STR_FIRST_NAME_TXT = "//th[text()='First Name']";
        readonly static string STR_SORT_FN_STATUS_DESC_ASC_BTN = "//th[@data-orderby='pt_accounts.ai_first_name']";


        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt = _objDriver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt = _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk = _objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk = _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn = _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));

        private static IWebElement objMinChat => _objDriver.FindElement(By.ClassName(STR_MINIMIZE_CHAT_BTN));
        private static IWebElement objTotalAminsAcc => _objDriver.FindElement(By.XPath(STR_TOTALADMIN_TXT));
        private static IWebElement objTotalSuppliersAcc => _objDriver.FindElement(By.XPath(STR_TOTALSUPPLIERS_TXT));
        private static IWebElement objTotalCustomersAcc => _objDriver.FindElement(By.XPath(STR_TOTALCUSTOMERS_TXT));
        private static IWebElement objTotalGuestAcc => _objDriver.FindElement(By.XPath(STR_TOTALGUESTS_TXT));
        private static IWebElement objTotalBookingsAcc => _objDriver.FindElement(By.XPath(STR_TOTALBOOKINGS_TXT));
        private static IWebElement objDashboardLabelBtn => _objDriver.FindElement(By.XPath(STR_DASHBOARD_LB_BTN));
        private static IWebElement objAccountDropDownBtn => _objDriver.FindElement(By.XPath(STR_ACCOUNT_BTN));
        private static IWebElement objAdminBtn => _objDriver.FindElement(By.XPath(STR_ADMINS_BTN));
        private static IWebElement objSupplierBtn => _objDriver.FindElement(By.XPath(STR_SUPPLIERS_BTN));
        private static IWebElement objCustomerBtn => _objDriver.FindElement(By.XPath(STR_CUSTOMERS_BTN));
        private static IWebElement objGuestBtn => _objDriver.FindElement(By.XPath(STR_GUEST_CUST_BTN));
        private static IWebElement objAccountBtn => _objDriver.FindElement(By.XPath(STR_ACCOUNT_OPTION_BTN));
        private static IWebElement objAccountCustomerBtn => _objDriver.FindElement(By.XPath(STR_ACCOUNT_CUSTOMER_OPTION_BTN));
        private static IWebElement objFirstNameSortBtn => _objDriver.FindElement(By.XPath(STR_FIRST_NAME_SORT_BTN));
        private static IWebElement objFirstNameTxt => _objDriver.FindElement(By.XPath(STR_FIRST_NAME_TXT));
        private static IWebElement objSortStatusDescAscBtn => _objDriver.FindElement(By.XPath(STR_SORT_FN_STATUS_DESC_ASC_BTN));

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

        public IWebElement GetTotalAminsTxt()
        {
            return objTotalAminsAcc;
        }
        public IWebElement GetTotalSuppliersTxt()
        {
            return objTotalSuppliersAcc;
        }
        public IWebElement GetTotalCustomersTxt()
        {
            return objTotalCustomersAcc;
        }
        public IWebElement GetTotalGuest()
        {
            return objTotalGuestAcc;
        }
        public IWebElement GetTotalBookings()
        {
            return objTotalBookingsAcc;
        }
        private IWebElement GetDashboardButton()
        {
            return objDashboardLabelBtn;
        }
        private IWebElement GetAccountDropDownButton()
        {
            return objAccountDropDownBtn;
        }
        private IWebElement ClickAdminsBtn()
        {
            return objAdminBtn;
        }
        private IWebElement ClickSuppliersBtn()
        {
            return objSupplierBtn;
        }
        private IWebElement ClickCustomersBtn()
        {
            return objCustomerBtn;
        }
        private IWebElement ClickGuestCustomersBtn()
        {
            return objGuestBtn;
        }
        private IWebElement GetAccountButton()
        {
            return objAccountBtn;
        }
        private IWebElement GetAccountCustomerButton()
        {
            return objAccountCustomerBtn;
        }
        private IWebElement GetFirstNameSortButton()
        {
            return objFirstNameSortBtn;
        }
        private IWebElement GetFirstNameTxt()
        {
            return objFirstNameTxt;
        }
        private IWebElement GetSortDescAscStatusButton()
        {
            return objSortStatusDescAscBtn;
        }
        public void fnFirstNameTxt()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRST_NAME_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_FIRST_NAME_TXT)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_FIRST_NAME_TXT)));
        }
        public void fnFindFirstNameBtn()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRST_NAME_SORT_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_FIRST_NAME_SORT_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_FIRST_NAME_SORT_BTN)));
        }
        public void fnSortAccountSubMenu()
        {
            _driverWait.Until(ExpectedConditions.UrlContains("ACCOUNTS"));
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACCOUNT_OPTION_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACCOUNT_OPTION_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACCOUNT_OPTION_BTN)));
            objAccountBtn.Click();
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACCOUNT_CUSTOMER_OPTION_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACCOUNT_CUSTOMER_OPTION_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACCOUNT_CUSTOMER_OPTION_BTN)));
            objAccountCustomerBtn.Click();
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRST_NAME_SORT_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_FIRST_NAME_SORT_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_FIRST_NAME_SORT_BTN)));
            fnFindFirstNameBtn();

            string strFirstNameStatus = objSortStatusDescAscBtn.GetAttribute("innerHTML").ToString();
            if (strFirstNameStatus == "First Name")
            {
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRST_NAME_SORT_BTN)));
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_FIRST_NAME_SORT_BTN)));
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_FIRST_NAME_SORT_BTN)));
                objFirstNameSortBtn.Click();
                _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SORT_FN_STATUS_DESC_ASC_BTN)));
                _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SORT_FN_STATUS_DESC_ASC_BTN)));
                _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_SORT_FN_STATUS_DESC_ASC_BTN)));
                objFirstNameSortBtn.Click();
            }

            GetSortDescAscStatusButton();
            string strFirstNameStatusAfterClick = objSortStatusDescAscBtn.GetAttribute("innerHTML").ToString();
            if (strFirstNameStatusAfterClick == "Desc to Asc First Name")
            {
                objTest.Log(AventStack.ExtentReports.Status.Info, "First Name Desc");
                objTest.Log(AventStack.ExtentReports.Status.Info, "Desc : " + strFirstNameStatusAfterClick);
            }
        }

        public void fnDashboardRedBox()
        {
            DashboardElements();

            string strTotalAdmins = objTotalAminsAcc.GetAttribute("innerHTML").ToString();
            string strTotalupplier = objTotalSuppliersAcc.GetAttribute("innerHTML").ToString();
            string strTotalCustomers = objTotalCustomersAcc.GetAttribute("innerHTML").ToString();
            string strTotalGuest = objTotalGuestAcc.GetAttribute("innerHTML").ToString();
            string strTotalBookings = objTotalBookingsAcc.GetAttribute("innerHTML").ToString();

            objTest.Log(AventStack.ExtentReports.Status.Info, "" + strTotalAdmins);
            objTest.Log(AventStack.ExtentReports.Status.Info, "" + strTotalupplier);
            objTest.Log(AventStack.ExtentReports.Status.Info, "" + strTotalCustomers);
            objTest.Log(AventStack.ExtentReports.Status.Info, "" + strTotalGuest);
            objTest.Log(AventStack.ExtentReports.Status.Info, "" + strTotalBookings);
        }

        public void fnDashboardElementButton()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_DASHBOARD_LB_BTN)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_DASHBOARD_LB_BTN)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_DASHBOARD_LB_BTN)));
        }
        public void DashboardElements()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_TOTALADMIN_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_TOTALADMIN_TXT)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_TOTALADMIN_TXT)));
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_TOTALSUPPLIERS_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_TOTALSUPPLIERS_TXT)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_TOTALSUPPLIERS_TXT)));
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_TOTALCUSTOMERS_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_TOTALCUSTOMERS_TXT)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_TOTALCUSTOMERS_TXT)));
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_TOTALGUESTS_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_TOTALGUESTS_TXT)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_TOTALGUESTS_TXT)));
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_TOTALBOOKINGS_TXT)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_TOTALBOOKINGS_TXT)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_TOTALBOOKINGS_TXT)));
        }
        public void fnSideBarElements()
        {
            fnDashboardElementButton();
        }
    }
}