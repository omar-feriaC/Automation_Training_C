using AutomationFrameworkC.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
namespace AutomationFrameworkC.Page_Objects
{
    class clsPHPTravels_LoginPage
    {
        #region ATTRIBUTES
        private static IWebDriver _objDriver; //"_objDriver" used only to intizialize the clsDriver in the constructor
        private clsDriver objClsDriver; //Initialization of clsDriver to re use elements
        #endregion ATTRIBUTES
        #region CONSTRUCTOR
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            objClsDriver = new clsDriver(_objDriver);
        }
        #endregion CONSTRUCTOR
        #region ELEMENTS
            #region LOCATORS FOR LOGIN PAGE
            readonly static string STR_EMAIL_TXT = "//input[@name='email']";
            readonly static string STR_PASSWORD_TXT = "//input[@name='password']";
            readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
            readonly static string STR_LOGIN_BTN = "//span[text()='Login']";
            readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
            #endregion LOCATORS FOR LOGIN PAGE
            #region LOCATORS FOR DASHBOARD PAGE
            readonly static string STR_STATS_LIST = "//div/ul[@class='serverHeader__statsList']/li/a";
            readonly static string STR_THEMENU = "//div[contains(@class, 'container-fluid')]";
            readonly static string STR_MENUCLOSED = "//div[@class='container-fluid go_left']/div/a[@id='sidebarCollapse']";
            readonly static string STR_MENUOPENED = "//div[@class='container-fluid']/div/a[@id='sidebarCollapse']";
            #endregion LOCATORS FOR DASHBOARD PAGE
            #region LOCATORS FOR MENU PAGES
            readonly static string STR_ACCOUNTS = "ACCOUNTS";
            readonly static string STR_PANELHEADERS = "//table[@class='xcrud-list table table-striped table-hover']/thead/tr/th[contains(@data-orderby, 'pt_accounts')]";
            readonly static string STR_PANELBODY = "//table[@class='xcrud-list table table-striped table-hover']/tbody";
            readonly static string STR_HEADERSASC = "//table[@class='xcrud-list table table-striped table-hover']/thead/tr/th[contains(@data-orderby, 'pt_accounts')and (@data-order='asc')]";
            readonly static string STR_HEADERSDESC = "//table[@class='xcrud-list table table-striped table-hover']/thead/tr/th[contains(@data-orderby, 'pt_accounts')and (@data-order='desc')]";
            #endregion LOCATORS FOR MENU PAGES
            # region LOCATORS FOR HEADERS
            readonly static string STR_FIRSTNAME_TABLE = "//th[contains(@data-orderby, 'pt_accounts.ai_first_name')]";
            readonly static string STR_LASTNAME_TABLE = "//th[contains(@data-orderby, 'pt_accounts.ai_last_name')]";
            readonly static string STR_EMAIL_TABLE = "//th[contains(@data-orderby, 'pt_accounts.accounts_email')]";
            readonly static string STR_ACTIVE_TABLE = "//th[contains(@data-orderby, 'pt_accounts.accounts_status')]";
            readonly static string STR_LASTLOGIN_TABLE = "//th[contains(@data-orderby, 'pt_accounts.accounts_last_login')]";
            readonly static string[] arrHeadersXpaths = { STR_FIRSTNAME_TABLE, STR_LASTNAME_TABLE, STR_EMAIL_TABLE, STR_ACTIVE_TABLE, STR_LASTLOGIN_TABLE };
        #endregion LOCATORS FOR HEADERS
            #region OBJECT DEFINITION FOR LOGIN PAGE
            private IWebElement objEmailTxt => objClsDriver.fnFindElement(By.XPath(STR_EMAIL_TXT));
            private IWebElement objPasswordTxt => objClsDriver.fnFindElement(By.XPath(STR_PASSWORD_TXT));
            private IWebElement objForgotPassLnk => objClsDriver.fnFindElement(By.XPath(STR_FORGOTPASS_LNK));
            private IWebElement objLoginBtn => objClsDriver.fnFindElement(By.XPath(STR_LOGIN_BTN));
            #endregion OBJECT DEFINITION FOR LOGIN PAGE
            #region OBJECT DEFINITION FOR MENU
            private IList<IWebElement> objStatsList => objClsDriver.fnFindElements(By.XPath(STR_STATS_LIST));
            private IWebElement objTheMenuTxt => objClsDriver.fnFindElement(By.XPath(STR_THEMENU));
            private IWebElement objMenuClosedTxt => objClsDriver.fnFindElement(By.XPath(STR_MENUCLOSED));
            private IWebElement objMenuOpenedTxt => objClsDriver.fnFindElement(By.XPath(STR_MENUOPENED));
            private IWebElement objMenuClicked => objClsDriver.fnFindElement(By.LinkText(STR_ACCOUNTS));
            private IList<IWebElement> objHeaders => objClsDriver.fnFindElements(By.XPath(STR_PANELHEADERS));
            private IList<IWebElement> objHeadersIndex => objClsDriver.fnFindElements(By.XPath(STR_PANELHEADERS + "[" + fnAmountofHeaders() + "]"));
            #endregion OBJECT DEFINITION FOR MENU
            #region DEFINITION FOR HEADERS
            private IWebElement objFirstNameTableTxt => objClsDriver.fnFindElement(By.XPath(STR_FIRSTNAME_TABLE));
            private IWebElement objLastNameTableTxt => objClsDriver.fnFindElement(By.XPath(STR_LASTNAME_TABLE));
            private IWebElement objEmailTableTxt => objClsDriver.fnFindElement(By.XPath(STR_EMAIL_TABLE));
            private IWebElement objActiveTableTxt => objClsDriver.fnFindElement(By.XPath(STR_ACTIVE_TABLE));
            private IWebElement objLastLoginTableTxt => objClsDriver.fnFindElement(By.XPath(STR_LASTLOGIN_TABLE));
        #endregion DEFINITION FOR HEADER
        #endregion ELEMENTS
        #region METHODS/FUNCTIONS
        #region Methods for Login
        public void fnEnterEmail(string pstrEmail)//This function waits for the username field and provide the email
        {
            try
            {
                objClsDriver.fnWaitExistVisibleClickable(By.XPath(STR_EMAIL_TXT));
                objEmailTxt.Clear();
                objEmailTxt.SendKeys(pstrEmail);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Email Field is not available - " + e.Message);
                Assert.Fail();
            }
        }
        public void fnEnterPassword(string pstrPass)//This function waits for the password field and provide the password
        {
            try
            {
                objClsDriver.fnWaitExistVisibleClickable(By.XPath(STR_PASSWORD_TXT));
                objPasswordTxt.Clear();
                objPasswordTxt.SendKeys(pstrPass);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Password Field is not available - " + e.Message);
                Assert.Fail();
            }
        }
        public void fnClickLoginButton()//This function waits for the Login Button and Clicks on it
        {
            try
            {
                objClsDriver.fnWaitExistVisibleClickable(By.XPath(STR_LOGIN_BTN));
                objLoginBtn.Click();
            }
            catch(Exception e)
            {
                Console.WriteLine("The Login Button is not available - " + e.Message);
                Assert.Fail();
            }
        }
        public void fnWaitHamburgerMenu() //This function validates that login has been success
        {
            try
            {
                objClsDriver.fnWaitExistVisibleClickable(By.Id(STR_HAMBURGER_BTN));
            }
            catch (Exception e)
            {
                Console.WriteLine("The Hamburger Menu is not available - " + e.Message);
                Assert.Fail();
            }
        }
        public void fnCompleteLogin(string pstrEmail, string pstrPass) // This function Does a complete Login
        { // This function does not need a try catch, because each of those already have one
            fnEnterEmail(pstrEmail);
            fnEnterPassword(pstrPass);
            fnClickLoginButton();
            fnWaitHamburgerMenu();
        }
        public string fnPrintTheListOfStatus()//This function print the values of the Satuses List
        {
            objClsDriver.fnWaitExistVisibleClickable(By.XPath(STR_STATS_LIST));//Wait to confirm that the stats panel exist
            int i;
            int intArraySize = objStatsList.Count; //We check the amoun of the elements in the stats panel exist
            string[] arrResult = new string[intArraySize];
            for (i = 0; i < intArraySize; i++)
            {
                arrResult[i] = objStatsList.ToArray()[i].Text; // Printing the string of the List
            }
            return "The result of the Dashboard Statistics is <br/>\r\n" + string.Join("<br/>\r\n", arrResult);
        }
        #endregion Methods for Login
        #region Methods after login - Dashboard
        #region Methods for Menu and Submenu
        public void fnActivateTheMenu()//This function check if Menu is Expanded or Not
            {
                objClsDriver.fnWaitExistVisibleClickable(By.XPath(STR_THEMENU));
                if (objClsDriver.fnCountElements(By.XPath(STR_MENUCLOSED)) == 1)
                {
                    objMenuClosedTxt.Click();
                }
                else
                {
                    Console.WriteLine("This is already opened");
                }
            }
            public void fnEnterAtMenu(string pstrMenulable)//This method allows to get into Menu
            {
                try
                {
                    objClsDriver.fnWaitExistVisibleClickable(By.LinkText(pstrMenulable));
                    objClsDriver.fnFindElementThatExist(By.LinkText(pstrMenulable));
                    objClsDriver.fnClickTheElement(By.LinkText(pstrMenulable));
                    objClsDriver.fnWaitForElementToExist(By.Id("social-sidebar-menu"));
                    objClsDriver.fnWaitForElementToExist(By.TagName("li"));
                    objClsDriver.fnWaitForElementToExist(By.TagName("a"));
                    objClsDriver.fnWaitURLContains(pstrMenulable);
                }
                catch (Exception e)
                {
                    Assert.Fail("The Menu is not elegible " + e.Message);
                }
            }
            public void fnEnterAtSubMenu(string pstrSubMenuLable, string pstrUrlExpected)//This method wait for the headers
            {
                try
                {
                    objClsDriver.fnWaitExistVisibleClickable(By.LinkText(pstrSubMenuLable));
                    objClsDriver.fnClickTheElement(By.LinkText(pstrSubMenuLable));
                    objClsDriver.fnWaitWebSiteTitleContains(pstrUrlExpected);
                }
                catch (Exception e)
                {
                    Assert.Fail("The SubMenu is not elegible " + e.Message);
                }
            }
            public int fnAmountofHeaders()//return number Headers in the table
            {
                int numberOfHeaders = objHeaders.Count();
                return numberOfHeaders;
            }
            #endregion Methods for Menu and Submenu
            #region Methods for Tables
            public void fnCheckTheManagementTablesExist()//This function Confirms that the Account Table exist
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
            public void fnValidateHeadersExist()//This method waits all the headers in the account tables
            {
                try
                {
                    for (int j = 0; j < arrHeadersXpaths.Length; j++)
                    {
                        objClsDriver.fnWaitExistVisibleClickable(By.XPath(arrHeadersXpaths[j]));
                    }
                }
                catch (Exception e)
                {
                    Assert.Fail("The header is not elegible " + e.Message);
                }
            }
            public string fnIndexForHeader(int pintIndex)//This function add an index for each header in account tables
            {
                string pstrHeaderIndex = STR_PANELHEADERS + "["+ pintIndex + "]";
                return pstrHeaderIndex;
            }
            public void fnClickTheHeader(int pintIndex)//This function Clicks the Headers
            {
                try
                {
                    fnValidateHeadersExist();
                    objClsDriver.fnWaitExistVisibleClickable(By.XPath(fnIndexForHeader(pintIndex)));
                    objClsDriver.fnFindElement(By.XPath(fnIndexForHeader(pintIndex)));
                    objClsDriver.fnClickTheElement(By.XPath(fnIndexForHeader(pintIndex)));
                    objClsDriver.fnWaitForElementToExist(By.XPath(STR_PANELBODY));
                }
                catch (StaleElementReferenceException)
                {
                    fnValidateHeadersExist();
                    objClsDriver.fnFindElement(By.XPath(fnIndexForHeader(pintIndex)));
                    objClsDriver.fnClickTheElement(By.XPath(fnIndexForHeader(pintIndex)));
                    objClsDriver.fnWaitForElementToExist(By.XPath(STR_PANELBODY));
                }
                catch (Exception e)
                {
                    Console.WriteLine("The Header is not elegible in page " + e.Message);
                    Assert.Fail();
                }
            }
            public void fnValidateAscOrder()//This function validates if the order is Ascendent
            {
                try
                {
                    if (objClsDriver.fnIsElementPresent(By.XPath(STR_HEADERSASC)) == true)
                    {
                        objClsDriver.fnWaitForElementToExist(By.XPath(STR_HEADERSASC));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error " + e.Message);
                    Assert.Fail();
                }
            }
            public void fnValidateDescOrder()//This function validates if the order is Descendent
            {
                try
                {
                    if (objClsDriver.fnIsElementPresent(By.XPath(STR_HEADERSDESC)) == true)
                    {
                        objClsDriver.fnWaitForElementToExist(By.XPath(STR_HEADERSDESC));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error " + e.Message);
                    Assert.Fail();
                }
            }
            #endregion Methods for Tables
        #endregion Methods after login - Dashboard
        #endregion METHODS/FUNCTIONS
    }
}