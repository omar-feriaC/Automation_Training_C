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
    class clsPHPTravels_LoginPage
    {
        #region variables
        /*ATTRIBUTES*/
        public static WebDriverWait _objDriverWait;
        private static IWebDriver _objDriver;
        private static IWebElement _objElement;
        //Initialization of clsDriver to re use elements
        private static clsDriver objClsDriver = new clsDriver(_objDriver);
        #endregion variables
        #region Constructor
        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _objDriverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }
        #endregion Constructor
        #region Elements
        /*LOCATORS FOR LOGIN PAGE*/
        readonly static string STR_EMAIL_TXT = "//input[@name='email']";
        readonly static string STR_PASSWORD_TXT = "//input[@name='password']";
        readonly static string STRREMEMBERME_LNK = "///label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        /*LOCATORS FOR DASHBOARD PAGE*/
        readonly static string STR_STATS_LIST = "//div/ul[@class='serverHeader__statsList']/li/a";
        readonly static string STR_THEMENU = "//div[contains(@class, 'container-fluid')]";
        readonly static string STR_MENUCLOSED = "//div[@class='container-fluid go_left']/div/a[@id='sidebarCollapse']";
        readonly static string STR_MENUOPENED = "//div[@class='container-fluid']/div/a[@id='sidebarCollapse']";
        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.XPath(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.XPath(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk => _objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private static IWebElement objForgotPassLnk => _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
        /*OBJECT DEFINITION*/
        private static IList<IWebElement> objStatsList => _objDriver.FindElements(By.XPath(STR_STATS_LIST));
        private static IWebElement objTheMenuTxt => _objDriver.FindElement(By.XPath(STR_THEMENU));
        private static IWebElement objMenuClosedTxt => _objDriver.FindElement(By.XPath(STR_MENUCLOSED));
        private static IWebElement objMenuOpenedTxt => _objDriver.FindElement(By.XPath(STR_MENUOPENED));
        #endregion Elements
        #region Methods
        /*METHODS/FUNCTIONS*/
        #region Methods for Login
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
        #endregion Methods for Login
        #region Methods after login - Dashboard
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
        /*METHODS/FUNCTIONS - FOR DASHBOARD PAGE*/
        public static void fnCheckStatsList()
        {
            for (int j = 0; j < objStatsList.Count; j++)
            {
                Console.WriteLine(objStatsList[j].Text);
            }
        }
        /*This function allows to check if the Menu is expanded or Not*/
        public static void fnActivateTheMenu()
        {
            clsDriver.fnWaitForElementToExist(By.XPath(STR_THEMENU));
            int a = _objDriver.FindElements(By.XPath(STR_MENUCLOSED)).Count;
            if (a == 1)/*If the Menu is closed, this part will make it open*/
            {
                objMenuClosedTxt.Click();
            }
            else
            {
                Console.WriteLine("This is already opened");
            }
        }


        /*This function obtains the xpath for the menu under consideration*/
        public static string fnXpathOfTheMenu(string pstrMenulable)
        {
            string strXpathMenuToFind = "//div/ul/li/a[@href='#" + pstrMenulable.ToUpper() + "']";
            return strXpathMenuToFind;
        }


        public static void fnEnterAtMenuSubMenu(string pstrMenulable, string pstrSubMenuLable, string pstrUrlExpected)
        {
            clsDriver.fnFindElement(By.LinkText(pstrMenulable));
            clsDriver.fnFindElement(By.LinkText(pstrMenulable)).Click();
            //_objElement = _objDriver.FindElement(By.LinkText(pstrMenulable));
            //_objElement.Click();
            clsDriver.fnWaitForElementToExist(By.Id("social-sidebar-menu"));
            clsDriver.fnWaitForElementToExist(By.TagName("li"));
            clsDriver.fnWaitForElementToExist(By.TagName("a"));
            clsDriver.fnWaitForElementToExist(By.LinkText(pstrSubMenuLable));
            _objDriverWait.Until(ExpectedConditions.TitleContains(pstrUrlExpected));
        }





        #endregion Methods after login - Dashboard
        #endregion Methods
    }
}