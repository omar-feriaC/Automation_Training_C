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
        private static By strSideMenus;
        private static string strSideSubMenus;

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_EMAIL_TXT = "//input[@name='email' and @type='text']";
        //readonly static string STR_EMAIL_TXT2 = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STRREMEMBERME_LNK = "//label[@class='checkbox']";
        //readonly static string STRREMEMBERME_LNK2 = "//label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";

        //readonly static string STR_SIDEMENULIST_LST = "//ul[@id='social-sidebar-menu']/li";


        readonly static string STR_DASHBOARD_LNK = "//a[substring(@href, string-length(@href) -string-length('admin') +1) = 'admin']";
        readonly static string STR_UPDATES_LNK = "//a[substring(@href, string-length(@href) -string-length('updates/') +1) = 'updates/']";
        readonly static string STR_MODULES_LNK = "//a[substring(@href, string-length(@href) -string-length('modules/') +1) = 'modules/']";
        readonly static string STR_GENERAL_LNK = "//a[contains(text(), 'General')]";
        readonly static string STR_ACCOUNTS_LNK = "//a[contains(text(),'Accounts')]";
        readonly static string STR_CMS_LNK = "//a[contains(@href, 'CMS')]";
        readonly static string STR_TRAVELHOPEHOTEL_LNK = "//a[contains(text(), 'Travelhope Hotels')]";
        readonly static string STR_TRAVELHOPEFLIGHTS_LNK = "//a[contains(text(), 'Travelhope Flights')]";
        readonly static string STR_VIATOR_LNK = "//a[contains(text(), 'Viator')]";
        readonly static string STR_CARTRAWLER_LNK = "//a[contains(@href, '#Cartrawler')]";
        readonly static string STR_VISA_LNK = "//a[contains(text(), 'Visa')]";
        readonly static string STR_BLOG_LNK = "//a[contains(@href, '#Blog')]";
        readonly static string STR_LOCATIONS_LNK = "//a[contains(@href, '#Locations')]";
        readonly static string STR_OFFERS_LNK = "//a[contains(@href, '#SPECIAL_OFFERS')]";
        readonly static string STR_COUPONS_LNK = "//a[substring(@href, string-length(@href) -string-length('coupons/') +1) = 'coupons/']";
        readonly static string STR_NEWSLETTER_LNK = "//a[substring(@href, string-length(@href) -string-length('newsletter/') +1) = 'newsletter/']";
        readonly static string STR_BOOKINGS_LNK = "//a[substring(@href, string-length(@href) -string-length('bookings') +1) = 'bookings']";


        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt = objDriver.FindElement(By.XPath(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt = objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk = objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk = objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn = objDriver.FindElement(By.XPath(STR_LOGIN_BTN));

        private static IWebElement objDashboardLnk => _objDriver.FindElement(By.XPath(STR_DASHBOARD_LNK));
        private static IWebElement objUpdatesLnk => _objDriver.FindElement(By.XPath(STR_UPDATES_LNK));
        private static IWebElement objModulesLnk => _objDriver.FindElement(By.XPath(STR_MODULES_LNK));
        private static IWebElement objGeneralLnk => _objDriver.FindElement(By.XPath(STR_GENERAL_LNK));
        private static IWebElement objAccountsLnk => _objDriver.FindElement(By.XPath(STR_ACCOUNTS_LNK));
        private static IWebElement objCMSLnk => _objDriver.FindElement(By.XPath(STR_CMS_LNK));
        private static IWebElement objTravelhopeHotelLnk => _objDriver.FindElement(By.XPath(STR_TRAVELHOPEHOTEL_LNK));
        private static IWebElement objTravelhopeFlightsLnk => _objDriver.FindElement(By.XPath(STR_TRAVELHOPEFLIGHTS_LNK));
        private static IWebElement objViatorLnk => _objDriver.FindElement(By.XPath(STR_VIATOR_LNK));
        private static IWebElement objCartrawlerLnk => _objDriver.FindElement(By.XPath(STR_CARTRAWLER_LNK));
        private static IWebElement objVisaLnk => _objDriver.FindElement(By.XPath(STR_VISA_LNK));
        private static IWebElement objBlogLnk => _objDriver.FindElement(By.XPath(STR_BLOG_LNK));
        private static IWebElement objLocationsLnk => _objDriver.FindElement(By.XPath(STR_LOCATIONS_LNK));
        private static IWebElement objOffersLnk => _objDriver.FindElement(By.XPath(STR_OFFERS_LNK));
        private static IWebElement objCouponsLnk => _objDriver.FindElement(By.XPath(STR_COUPONS_LNK));
        private static IWebElement objNewsletterLnk => _objDriver.FindElement(By.XPath(STR_NEWSLETTER_LNK));
        private static IWebElement objBookingsLnk => _objDriver.FindElement(By.XPath(STR_BOOKINGS_LNK));


        //private static IList<IWebElement> objSideMenuListLst = objDriver.FindElements(By.XPath(STR_SIDEMENULIST_LST));
        //FindElements(By.XPath(STR_SIDEMENULIST_LST));


        /*METHODS/FUNCTIONS*/

        //Email
        private IWebElement GetEmailField()
        {
            return objEmailTxt;
        }

        public static void fnEnterEmail(string pstrEmail)
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_TXT));
            //clsDriver.fnWaitForElementToExist(By.objEmailTxt);
            clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_TXT));
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


        public static void fnClickMenu(string pstrSideMenuInput)
        {

            switch (pstrSideMenuInput)
            {
                case "DASHBOARD":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_DASHBOARD_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_DASHBOARD_LNK)));
                    objDashboardLnk.Click();
                    break;
                case "UPDATES":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_UPDATES_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_UPDATES_LNK)));
                    objUpdatesLnk.Click();
                    break;
                case "MODULES":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MODULES_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_MODULES_LNK)));
                    objModulesLnk.Click();
                    break;
                case "GENERAL":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_GENERAL_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_GENERAL_LNK)));
                    objGeneralLnk.Click();
                    break;
                case "ACCOUNTS":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACCOUNTS_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ACCOUNTS_LNK)));
                    objAccountsLnk.Click();
                    break;
                case "CMS":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_CMS_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_CMS_LNK)));
                    objCMSLnk.Click();
                    break;
                case "TRAVELHOPE_HOTEL":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_TRAVELHOPEHOTEL_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_TRAVELHOPEHOTEL_LNK)));
                    objTravelhopeHotelLnk.Click();
                    break;
                case "TRAVELHOPE_FLIGHTS":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_TRAVELHOPEFLIGHTS_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_TRAVELHOPEFLIGHTS_LNK)));
                    objTravelhopeFlightsLnk.Click();
                    break;
                case "VIATOR":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_VIATOR_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_VIATOR_LNK)));
                    objViatorLnk.Click();
                    break;
                case "CARTRAWLER":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_CARTRAWLER_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_CARTRAWLER_LNK)));
                    objCartrawlerLnk.Click();
                    break;
                case "VISA":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_VISA_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_VISA_LNK)));
                    objVisaLnk.Click();
                    break;
                case "BLOG":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_BLOG_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_BLOG_LNK)));
                    objBlogLnk.Click();
                    break;
                case "LOCATIONS":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOCATIONS_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOCATIONS_LNK)));
                    objLocationsLnk.Click();
                    break;
                case "OFFERS":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_OFFERS_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_OFFERS_LNK)));
                    objOffersLnk.Click();
                    break;
                case "COUPONS":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_COUPONS_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_COUPONS_LNK)));
                    objCouponsLnk.Click();
                    break;
                case "NEWSLETTER":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_NEWSLETTER_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_NEWSLETTER_LNK)));
                    objNewsletterLnk.Click();
                    break;
                case "BOOKINGS":
                    _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_BOOKINGS_LNK)));
                    _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_BOOKINGS_LNK)));
                    objBookingsLnk.Click();
                    break;
                default:
                    break;
            }
        }



    }
}
