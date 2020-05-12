using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AutomationFrameworkC.Page_Objects
{
    class clsPHPTravels_LoginPage : BaseTest
    {
        /*VARIABLES*/
        private static WebDriverWait _objWait;
        private static IWebDriver _objDriver;

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _objWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*LOCATORS DEFINITION*/
        readonly static string STR_EMAIL_TXT = "email";
        readonly static string STR_PASSWORD_TXT = "password";
        readonly static string STR_REMEMBERME_CHK = "remember";
        readonly static string STR_FORGETPASS_LNK = "//*[text()='Forget Password']";
        readonly static string STR_LOGIN_BTN = "//button[@type='submit']//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";
        readonly static string STR_DASHBOARD_LST = "//div[@class='serverHeader']//div[@class='serverHeader__stats']//ul[@class='serverHeader__statsList']//li";
        readonly static string STR_SIDEBAR_DISPLAYED = "//div[@class='container-fluid go_left']//a[@id='sidebarCollapse']";
        readonly static string STR_SIDEBAR_HIDEN = "//div[@class='container-fluid']//a[@id='sidebarCollapse' and @class='hideSidebar navbar-brand']";
        readonly static string STR_ACCOUNTS_LST = "//ul[@id='ACCOUNTS' and @aria-expanded='true']//li";
        readonly static string STR_ACCOUNT_HIDEN = "//a[@aria-expanded='false' and text()[contains(., 'Accounts')]]";
        readonly static string STR_COLUMNS_LST = "//tr[@class='xcrud-th']//th[contains(@class,'xcrud-column xcrud-action')]";
        
        /*WEBELEMENTS DEFINITION*/
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt => _objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeChk => _objDriver.FindElement(By.Name(STR_REMEMBERME_CHK));
        private static IWebElement objForgetPassLnk => _objDriver.FindElement(By.XPath(STR_FORGETPASS_LNK));
        private static IWebElement objLoginBtn => _objDriver.FindElement(By.XPath(STR_LOGIN_BTN));
        private static IWebElement objHamburgerBtn => _objDriver.FindElement(By.Id(STR_HAMBURGER_BTN));
        private static IList<IWebElement> objDashLst => _objDriver.FindElements(By.XPath(STR_DASHBOARD_LST));
        private static IWebElement objSidebarDisp => _objDriver.FindElement(By.XPath(STR_SIDEBAR_DISPLAYED));
        private static IWebElement objSidebarHid => _objDriver.FindElement(By.XPath(STR_SIDEBAR_HIDEN));
        private static IList<IWebElement> objAccountsLst => _objDriver.FindElements(By.XPath(STR_ACCOUNTS_LST));
        private static IWebElement objAccountsHid => _objDriver.FindElement(By.XPath(STR_ACCOUNT_HIDEN));
        private static IList<IWebElement> objColumnsLst => _objDriver.FindElements(By.XPath(STR_COLUMNS_LST));
              
        /*METHODS/FUNCTIONS*/

        //Email
        private IWebElement fnGetEmailField()
        {
            return objEmailTxt;
        }

        private static void fnEnterEmail(string pstrEmail)
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.Name(STR_EMAIL_TXT)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_EMAIL_TXT)));
                objEmailTxt.Clear();
                objEmailTxt.SendKeys(pstrEmail);
                //Assert.Equals(pstrEmail, objEmailTxt.GetProperty("Value"));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:  " + e.Message);
                Assert.Fail();
            }

        }

        //Password
        private IWebElement fnGetPasswordField()
        {
            return objPasswordTxt;
        }

        private IWebElement fnGetRememberMeChk()
        {
            return objRememberMeChk;
        }

        public static void fnEnterPassword(string pstrPass)
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.Name(STR_PASSWORD_TXT)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_PASSWORD_TXT)));
                objPasswordTxt.Clear();
                objPasswordTxt.SendKeys(pstrPass);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:  " + e.Message);
                Assert.Fail();
            }
        }

        public static void fnClickRememberMe()
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.Name(STR_REMEMBERME_CHK)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.Name(STR_REMEMBERME_CHK)));
                objRememberMeChk.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:  " + e.Message);
                Assert.Fail();
            }
        }

        //Login Button    
        private IWebElement GetLoginButton()
        {
            return objLoginBtn;
        }

        public static void fnClickLogin()
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOGIN_BTN)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOGIN_BTN)));
                _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOGIN_BTN)));
                objLoginBtn.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:  " + e.Message);
                Assert.Fail();
            }
        }

        //Sign In
        public static void fnSignInPage(string pstrEmail, string pstrPass)
        {
            try
            {
                fnEnterEmail(pstrEmail);
                fnEnterPassword(pstrPass);              
                fnClickLogin();                
            }
            catch (Exception e)
            {
                Console.WriteLine("SignIn process fail: " + e.Message);
                Assert.Fail();
            }
        }

        public static void fnWaitAfterSignIn()
        {
            _objDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _objWait.Until(ExpectedConditions.TitleContains("Dashboard"));
            _objWait.Until(ExpectedConditions.UrlContains("phptravels.net/admin"));                     
        }

        //Dashboard 
        public IList<IWebElement> GetDashboardList()
        {
            return objDashLst;
        }

        public static void fnDashboardTotals()
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_DASHBOARD_LST)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_DASHBOARD_LST)));

                for (int i = 0; i < objDashLst.Count; i++)
                {
                    Console.WriteLine(objDashLst[i].Text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:  " + e.Message);
                Assert.Fail();
            }
        }

        /*Hamburger Button*/
        private IWebElement fnGetHamburgerMenu()
        {
            return objHamburgerBtn;
        }

        public static void fnClickHamburgerMenu()
        {
            _objWait.Until(ExpectedConditions.ElementExists(By.Id(STR_HAMBURGER_BTN)));
            _objWait.Until(ExpectedConditions.ElementIsVisible(By.Id(STR_HAMBURGER_BTN)));
            _objWait.Until(ExpectedConditions.ElementToBeClickable(By.Id(STR_HAMBURGER_BTN)));
            objHamburgerBtn.Click();
        }

        //Verify if SideBar is visible
        private IWebElement fnGetSidebarHidden()
        {
            return objSidebarHid;
        }

        private IWebElement fnGetSidebarDisplayed()
        {
            return objSidebarDisp;
        }

        public static void fnSideBarVisibleChk()
        {
            try
            {
                
                if (!(objSidebarHid.Displayed))
                {
                    fnClickHamburgerMenu();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:  " + e.Message);
                Assert.Fail();
            }
        }

        //Verify if ACCOUNTS is Displayed
        private IWebElement fnGetAccountHidden()
        {
            return objAccountsHid;
        }

        public static void fnAccountDisplayed()
        {
            try
            {
                _objDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                if (objAccountsHid.Displayed)
                {
                    objAccountsHid.Click();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:  " + e.Message);
                Assert.Fail();
            }
        }

        //Accounts Submenus click         
        public IList<IWebElement> fnGetAccountsList()
        {
            return objAccountsLst;
        }
              
        public static void fnSubMenus()
        {
            try
            {
                _objDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ACCOUNTS_LST)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ACCOUNTS_LST)));

                for (int j = 0; j < objAccountsLst.Count; j++)
                {
                    string SubMenu = objAccountsLst[j].Text;

                    objAccountsLst[j].Click();
                    _objDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    fnSort();
                    Console.WriteLine("The columns in the " + SubMenu + " sub menu of the Accounts Menu have been validated.");
                    objRM.fnAddStepLog(objTest, "The columns in the " + SubMenu + " sub menu of the Accounts Menu have been validated.", "Pass");
                    fnAccountDisplayed();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error:  " + e.Message);
                Assert.Fail();
            }
        }

        //Sort of each column
        public IList<IWebElement> fnGetColumnsList()
        {
            return objColumnsLst;
        }
               
        public static void fnSort()
        {
            _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_COLUMNS_LST)));
            _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_COLUMNS_LST)));
            _objDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _objWait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(STR_COLUMNS_LST)));
            
            for (int k = 0; k < objColumnsLst.Count; k++)
            {
                try
                {
                    //  Thread.Sleep(5000);                   
                    // _objDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    //_objWait.PollingInterval = TimeSpan.FromSeconds(20);
                    _objWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("xcrud-overlay")));                                      


                    string DataOrder = objColumnsLst[k].GetAttribute("data-order");
                    string ColumnName = objColumnsLst[k].Text;                                       

                    if (DataOrder == "desc") 
                    {
                        Console.WriteLine("Column " + ColumnName + " orders Desc properly");
                        objRM.fnAddStepLog(objTest, "Column " + ColumnName + " orders Desc properly", "Pass");
                    }
                    objColumnsLst[k].Click();
                                        
                    string DataOrder2 = objColumnsLst[k].GetAttribute("data-order");
                    if (DataOrder2 == "asc")
                    {
                        Console.WriteLine("Column " + ColumnName + " orders Asc properly");
                        objRM.fnAddStepLog(objTest, "Column " + ColumnName + " orders Asc properly", "Pass");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error:  " + e.Message);
                    Assert.Fail();
                }
            }
        }
    }
}
