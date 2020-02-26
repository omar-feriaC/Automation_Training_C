using AutomationFrameworkC.Base_Files;
using AventStack.ExtentReports;
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
    class clsPHPTravels_DashboardPage : BaseTest
    {
        /*ATTRIBUTES*/
        public static WebDriverWait _driverWait;
        private static IWebDriver _objDriver;
        //IList<IWebElement> TotalsList = objDriver.FindElements(By.XPath(STR_TOTALSLIST_LST));

        /*LOCATORS DESCRIPTION*/
        readonly static string STR_TADMINS_LNK = "//a[contains(text(), 'Total Admins')]";
        readonly static string STR_TSUPPLIERS_LNK = "//a[contains(text(), 'Total Suppliers')]";
        readonly static string STR_TCUSTOMERS_LNK = "//a[contains(text(), 'Total Customers')]";
        readonly static string STR_TGUESTS_LNK = "//a[contains(text(), 'Total Guests')]";
        readonly static string STR_TBOOKINGS_LNK = "//a[contains(text(), 'Total Bookings')]";

        readonly static string STR_TOTALSLIST_LST = "//ul[@class='serverHeader__statsList']/li";


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
        public clsPHPTravels_DashboardPage(IWebDriver pobjDriverDash)
        {
            _objDriver = pobjDriverDash;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objTAdminsLnk = _objDriver.FindElement(By.XPath(STR_TADMINS_LNK));
        private static IWebElement objTSuppliersLnk = _objDriver.FindElement(By.XPath(STR_TSUPPLIERS_LNK));
        private static IWebElement objTCustomersLnk = _objDriver.FindElement(By.XPath(STR_TCUSTOMERS_LNK));
        private static IWebElement objTGuestsLnk = _objDriver.FindElement(By.XPath(STR_TGUESTS_LNK));
        private static IWebElement objTBookingsLnk = _objDriver.FindElement(By.XPath(STR_TBOOKINGS_LNK));

        private static IWebElement objTotalsListLst = _objDriver.FindElement(By.XPath(STR_TOTALSLIST_LST));

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

        /*METHODS/FUNCTIONS*/

        //Get Totals List
        private IWebElement GetTotalsList()
        {
            return objTotalsListLst;
        }

        //public static void fnSaveTotals()
        //{
        //    IList<IWebElement> TotalsList = objDriver.FindElements(By.XPath(STR_TOTALSLIST_LST));
        //    foreach (IWebElement t in TotalsList)
        //    {
        //        Console.WriteLine(t.Text);
        //        objTest.Log(Status.Info, t.Text);
        //    }
        //}

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

        //Find Total Admins
        private IWebElement GetTotalAdmins()
        {
            return objTAdminsLnk;
        }

        //public static void fnEnterEmail(string pstrEmail)
        //{
        //    clsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_TXT));
        //    //clsDriver.fnWaitForElementToExist(By.objEmailTxt);
        //    clsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_TXT));
        //    objEmailTxt.Clear();
        //    objEmailTxt.SendKeys(pstrEmail);
        //}

        //Find Total Suppliers
        private IWebElement GetTotalSuppliers()
        {
            return objTSuppliersLnk;
        }

        //Find Total Customers
        private IWebElement GetTotalCustomers()
        {
            return objTCustomersLnk;
        }

        //Find Total Guests
        private IWebElement GetTotalGuests()
        {
            return objTGuestsLnk;
        }

        //Find Total Bookings
        private IWebElement GetTotalBookings()
        {
            return objTBookingsLnk;
        }

    }
}
