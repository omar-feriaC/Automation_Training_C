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
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";

        //Dashboard//
        readonly static string STR_STATS_LIST = "//div/ul[@class='serverHeader__statsList']/li/a";

        //Sub Menu Navigation//
        readonly static string STR_SIDE_BAR = "social-sidebar-menu";
        readonly static string STR_TOP_BAR = "xcrud-overlay";
        readonly static string STR_FIRST_NAME = "//th[@data-orderby='pt_accounts.ai_first_name']";
        readonly static string STR_LAST_NAME = "//th[@data-orderby='pt_accounts.ai_last_name']";
        readonly static string STR_EMAIL_ACCOUNT = "//th[@data-orderby='pt_accounts.accounts_email']";
        readonly static string STR_ACCOUNT_STATUS = "//th[@data-orderby='pt_accounts.accounts_status']";
        readonly static string STR_ACCOUNT_LASTLOGIN = "//th[@data-orderby='pt_accounts.accounts_last_login']";


        /*PAGE ELEMENT OBJECTS*/
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.XPath(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.XPath(STR_PASSWORD_TXT));
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

        //Menu Navigation//
        public static void fnNavMenu(String submenu, String title)
        {
            String[] array = submenu.Split('.');
            IWebElement objMenu = _objDriver.FindElement(By.LinkText(array[0]));
            objMenu.Click();
            clsDriver.fnWaitForElementToExist(By.Id(STR_SIDE_BAR));
            clsDriver.fnWaitForElementToExist(By.TagName("li"));
            clsDriver.fnWaitForElementToExist(By.TagName("a"));
            clsDriver.fnWaitForElementToExist(By.LinkText(array[1]));
            IWebElement objSubMenu = _objDriver.FindElement(By.LinkText(array[1]));
            objSubMenu.Click();
            _driverWait.Until(ExpectedConditions.TitleContains(title));
            FnSort(STR_FIRST_NAME);
            _driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName(STR_TOP_BAR)));
            FnSort(STR_LAST_NAME);
            _driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName(STR_TOP_BAR)));
            FnSort(STR_EMAIL_ACCOUNT);
            _driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName(STR_TOP_BAR)));
            FnSort(STR_ACCOUNT_STATUS);
            _driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName(STR_TOP_BAR)));
            FnSort(STR_ACCOUNT_LASTLOGIN);
        }

        public static void FnSort(String path)
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(path)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(path)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            IWebElement orderasc = _objDriver.FindElement(By.XPath(path));
            orderasc.Click();


            _driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName(STR_TOP_BAR)));
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(path)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(path)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            IWebElement orderdsc = _objDriver.FindElement(By.XPath(path));
            orderdsc.Click();

        }

    }
}
