using AutomationFrameworkC.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace AutomationFrameworkC.Page_Objects
{
    class clsPHPTravels_LoginPage 
    {
        #region variables
        /*ATTRIBUTES*/
        public WebDriverWait _objDriverWait;
        private IWebDriver _objDriver;
        private static IWebElement _objElement;
        private clsDriver objClsDriver; //Initialization of clsDriver to re use elements
        #endregion variables
        #region Constructor
        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _objDriverWait = new WebDriverWait(pobjDriver, new TimeSpan(0, 0, 40));
            objClsDriver = new clsDriver(_objDriver);
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
        /*LOCATORS FOR MENU PAGES*/
        readonly static string STR_ACCOUNTS = "ACCOUNTS";
        readonly static string STR_PANELHEADERS = "//table[@class='xcrud-list table table-striped table-hover']/thead/tr/th[contains(@data-orderby, 'pt_accounts')]";
        readonly static string STR_HEADERSASC = "//table[@class='xcrud-list table table-striped table-hover']/thead/tr/th[contains(@data-orderby, 'pt_accounts')and (@data-order='asc')]";
        readonly static string STR_HEADERSDESC = "//table[@class='xcrud-list table table-striped table-hover']/thead/tr/th[contains(@data-orderby, 'pt_accounts')and (@data-order='desc')]";
        /*OBJECT DEFINITION FOR LOGIN PAGE*/
        private IWebElement objEmailTxt => _objDriver.FindElement(By.XPath(STR_EMAIL_TXT));
        private IWebElement objPasswordTxt => _objDriver.FindElement(By.XPath(STR_PASSWORD_TXT));
        private IWebElement objRememberMeLnk => _objDriver.FindElement(By.XPath(STRREMEMBERME_LNK));
        private IWebElement objForgotPassLnk => _objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
        /*OBJECT DEFINITION FOR MENU*/
        private IList<IWebElement> objStatsList => _objDriver.FindElements(By.XPath(STR_STATS_LIST));
        private IWebElement objTheMenuTxt => _objDriver.FindElement(By.XPath(STR_THEMENU));
        private IWebElement objMenuClosedTxt => _objDriver.FindElement(By.XPath(STR_MENUCLOSED));
        private IWebElement objMenuOpenedTxt => _objDriver.FindElement(By.XPath(STR_MENUOPENED));
        private IWebElement objMenuClicked => _objDriver.FindElement(By.LinkText(STR_ACCOUNTS));
        private IList<IWebElement> objHeaders => _objDriver.FindElements(By.XPath(STR_PANELHEADERS));
        #endregion Elements
        #region Methods
        /*METHODS/FUNCTIONS*/
        #region Methods for Login
        //Email
        public void fnEnterEmail(string pstrEmail)
        {
            objClsDriver.fnWaitForElementToExist(By.XPath(STR_EMAIL_TXT));
            objClsDriver.fnWaitForElementToBeVisible(By.XPath(STR_EMAIL_TXT));
            objEmailTxt.Clear();
            objEmailTxt.SendKeys(pstrEmail);
        }
        public void fnEnterPassword(string pstrPass)
        {
            objClsDriver.fnWaitForElementToExist(By.XPath(STR_PASSWORD_TXT));
            objClsDriver.fnWaitForElementToBeVisible(By.XPath(STR_PASSWORD_TXT));
            objPasswordTxt.Clear();
            objPasswordTxt.SendKeys(pstrPass);
        }
        //Login Button
        private IWebElement GetLoginButton()
        {
            return objRememberMeLnk;
        }
        public void fnClickLoginButton()
        {
            objClsDriver.fnWaitForElementToExist(By.XPath(STR_LOGIN_BTN));
            objClsDriver.fnWaitForElementToBeClickable(By.XPath(STR_LOGIN_BTN));
            objClsDriver.fnWaitForElementToBeVisible(By.XPath(STR_LOGIN_BTN));
            objLoginBtn.Click();
        }
        /*Hamburger Button*/
        public void fnWaitHamburgerMenu()
        {
            _objDriverWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            _objDriverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            _objDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
        }
        #endregion Methods for Login
        #region Methods after login - Dashboard
        /*METHODS/FUNCTIONS - FOR DASHBOARD PAGE*/
        /*This function allows to check if the Menu is expanded or Not*/
        public void fnActivateTheMenu()
        {
            objClsDriver.fnWaitForElementToExist(By.XPath(STR_THEMENU));
            /*If the Menu is closed, this part will make it open*/
            if (_objDriver.FindElements(By.XPath(STR_MENUCLOSED)).Count == 1)
            {
                objMenuClosedTxt.Click();
            }
            else
            {
                Console.WriteLine("This is already opened");
            }
        }
        public void fnCheckStatsList()
        {
            for (int j = 0; j < objStatsList.Count; j++)
            {
                Console.WriteLine(objStatsList[j].Text);
            }
        }

        /*This function confirm that the Account tables exist*/
        public void fnCheckTheManagementTablesExist()
        {
            try
            {
                objClsDriver.fnWaitForElementToExist(By.XPath(STR_PANELHEADERS));
            }
            catch (Exception e)
            {
                Console.WriteLine("The Panel Body does not exist: " + e.Message);
                Assert.Fail();
            }
        }
        /*NUMBER of submenus provided*/
        public int fnAmountofSubmenus(string[] pstrSubMenuLable)
        {
            int numberOfSubmenus = pstrSubMenuLable.Length;
            return numberOfSubmenus;
        }
        /*NUMBER of Headers in the table*/
        public int fnAmountofHeaders()
        {
            int numberOfHeaders = objHeaders.Count();
            return numberOfHeaders;
        }
        /*This function add an index for each header in account tables*/
        public string fnIndexForHeader(int pintIndex)
        {
            string pstrHeaderIndex = STR_PANELHEADERS + "["+ pintIndex + "]";
            return pstrHeaderIndex;
        }
        public void fnClickTheHeader(int pintIndex)
        {
            IWebElement objHeaderElement;
            try
            {
                objHeaderElement = _objDriver.FindElement(By.XPath(fnIndexForHeader(pintIndex)));
                objHeaderElement.Click();
            }
            catch(StaleElementReferenceException)
            {
                //_objDriverWait.Until(ExpectedConditions.StalenessOf(_objDriver.FindElement(By.XPath(fnIndexForHeader(pintIndex)))));
                objHeaderElement = _objDriver.FindElement(By.XPath(fnIndexForHeader(pintIndex)));
                objHeaderElement.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("The Header is not elegible in page " + _objDriver.Title + " " + e.Message);
                Assert.Fail();
            }
        }
        public void fnAscOrder()
        {
            try
            {
                if (objClsDriver.fnIsElementPresent(By.XPath(STR_HEADERSASC)) == true)
                {
                    objClsDriver.fnWaitForElementToExist(By.XPath(STR_HEADERSASC));
                    Console.WriteLine("Asc " + objClsDriver.fnPrintTxtElement(By.XPath(STR_HEADERSASC)) + " In " + _objDriver.Title);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
                Assert.Fail();
            }
        }
        public void fnDescOrder()
        {
            try
            {
                if (objClsDriver.fnIsElementPresent(By.XPath(STR_HEADERSDESC)) == true)
                {
                    objClsDriver.fnWaitForElementToExist(By.XPath(STR_HEADERSDESC));
                    Console.WriteLine("Desc " + objClsDriver.fnPrintTxtElement(By.XPath(STR_HEADERSDESC)) + " In " + _objDriver.Title);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
                Assert.Fail();
            }
        }
        //This method allows to get into Menu and SubMenu
        public void fnEnterAtMenuSubMenu(string pstrMenulable, string[] pstrSubMenuLable, string[] pstrUrlExpected, int pintIndex)
        {
            try
            {
                objClsDriver.fnFindElementThatExist(By.LinkText(pstrMenulable));
                objClsDriver.fnFindElementThatExist(By.LinkText(pstrMenulable)).Click();
                objClsDriver.fnWaitForElementToExist(By.Id("social-sidebar-menu"));
                objClsDriver.fnWaitForElementToExist(By.TagName("li"));
                objClsDriver.fnWaitForElementToExist(By.TagName("a"));
                objClsDriver.fnWaitForElementToExist(By.LinkText(pstrSubMenuLable[pintIndex]));
                objClsDriver.fnWaitForElementToExist(By.LinkText(pstrSubMenuLable[pintIndex])).Click();
                objClsDriver.fnWaitWebSiteTitleContains(pstrUrlExpected[pintIndex]);
            }
            catch(Exception e)
            {
                //Console.WriteLine("The Menu is not elegible " + e.Message);
                Assert.Fail("The Menu is not elegible " + e.Message);
            }
        }
        #endregion Methods after login - Dashboard
        #endregion Methods
    }
}