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
    class clsPHPTravels_DashboardPage : BaseTest
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
        readonly static string STR_TOTAL_LABEL = "//*[starts-with (text(),' Total ')]";
        readonly static string STR_TOTAL_NUMBER = "//b";
        readonly static string STR_SIDE_OPTION = "//ul[@id='social-sidebar-menu']//li";


        /*CONSTRUCTOR*/
        public clsPHPTravels_DashboardPage(IWebDriver pobjDriver)
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
        private static IList<IWebElement> objTotalLabelTxt => _objDriver.FindElements(By.XPath(STR_TOTAL_LABEL));
        private static IList<IWebElement> objSideOptionBtn => _objDriver.FindElements(By.XPath(STR_SIDE_OPTION));


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

        /*Total Links*/
        public static void fnObtaintotalLinks()
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_TOTAL_LABEL)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_TOTAL_LABEL)));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("->"+ objTotalLabelTxt[i].Text );
            }            

        }

        /*Side Option*/
        public static void fnSidebar(string pstrMenu)
        {
            int intMenu = 0;
            Dictionary<string,int> dctMenu = new Dictionary<string, int>();
            dctMenu.Add("dashboard", 0);
            dctMenu.Add("updates", 1);
            dctMenu.Add("modules", 2);
            dctMenu.Add("general",3);
            dctMenu.Add("accounts", 14);
            dctMenu.Add("cms",19);
            dctMenu.Add("travelhope hotels",22);
            dctMenu.Add("travelhope flights",25);
            dctMenu.Add("viator", 28); 
            dctMenu.Add("cartrawler", 30);
            dctMenu.Add("visa", 32);
            dctMenu.Add("blog", 35);
            dctMenu.Add("locations", 39);
            dctMenu.Add("offers", 41);
            dctMenu.Add("coupons", 44);
            dctMenu.Add("newsletter", 45);
            dctMenu.Add("bookings", 46);
            if (dctMenu.ContainsKey(pstrMenu.ToLower()))
            {
                intMenu=dctMenu[pstrMenu.ToLower()];                
                objSideOptionBtn[intMenu].Click();
            }
            else
            {
                Assert.IsFalse(true, "The menu option selected is not found");
            }
            

        }

        public static void fnSidebar(string pstrMenu, string pstrSubmenu)
        {
            int intMenu = 0;
            int intSubMenu = 0;
            Dictionary<string, int> dctMenu = new Dictionary<string, int>();
            dctMenu.Add("dashboard", 0);
            dctMenu.Add("updates", 1);
            dctMenu.Add("modules", 2);
            dctMenu.Add("general", 3);
            dctMenu.Add("accounts", 14);
            dctMenu.Add("cms", 19);
            dctMenu.Add("travelhope hotels", 22);
            dctMenu.Add("travelhope flights", 25);
            dctMenu.Add("viator", 28);
            dctMenu.Add("cartrawler", 30);
            dctMenu.Add("visa", 32);
            dctMenu.Add("blog", 35);
            dctMenu.Add("locations", 39);
            dctMenu.Add("offers", 41);
            dctMenu.Add("coupons", 44);
            dctMenu.Add("newsletter", 45);
            dctMenu.Add("bookings", 46);

            //Validate menu
            if (dctMenu.ContainsKey(pstrMenu.ToLower()))
            {
                intMenu = dctMenu[pstrMenu.ToLower()];
                objSideOptionBtn[intMenu].Click();
                switch (intMenu)
                {
                    case 3:
                        switch (pstrSubmenu.ToLower())
                        {
                            case "settings":
                                intSubMenu = intMenu + 1;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "currencies":
                                intSubMenu = intMenu + 2;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "payment gateways":
                                intSubMenu = intMenu + 3;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "social connections":
                                intSubMenu = intMenu + 4;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "widgets":
                                intSubMenu = intMenu + 5;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "homepage sliders":
                                intSubMenu = intMenu + 6;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "email templates":
                                intSubMenu = intMenu + 7;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "sms api settings":
                                intSubMenu = intMenu + 8;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "backup":
                                intSubMenu = intMenu + 9;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "ban ip":
                                intSubMenu = intMenu + 10;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            default:
                                Assert.IsFalse(true, "The sub menu option selected is not found");
                                break;
                        }
                        break;
                    case 14:                        
                        switch (pstrSubmenu.ToLower())
                        {
                            case "admins":
                                intSubMenu = intMenu + 1;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "suppliers":
                                intSubMenu = intMenu + 2;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "customers":
                                intSubMenu = intMenu + 3;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "guestcustomers":
                                intSubMenu = intMenu + 4;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            default:
                                Assert.IsFalse(true, "The sub menu option selected is not found");
                                break;
                        }
                        break;
                    case 19:
                        switch (pstrSubmenu.ToLower())
                        {
                            case "pages":
                                intSubMenu = intMenu + 1;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "menu":
                                intSubMenu = intMenu + 2;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break; 
                            default:
                                Assert.IsFalse(true, "The sub menu option selected is not found");
                                break;
                        }
                        break;
                    case 22:
                        switch (pstrSubmenu.ToLower())
                        {
                            case "bookings":
                                intSubMenu = intMenu + 1;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "settings":
                                intSubMenu = intMenu + 2;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            default:
                                Assert.IsFalse(true, "The sub menu option selected is not found");
                                break;
                        }
                        break;
                    case 25:
                        switch (pstrSubmenu.ToLower())
                        {
                            case "bookings":
                                intSubMenu = intMenu + 1;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "settings":
                                intSubMenu = intMenu + 2;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            default:
                                Assert.IsFalse(true, "The sub menu option selected is not found");
                                break;
                        }
                        break;
                    case 28:
                        switch (pstrSubmenu.ToLower())
                        {
                            case "viator settings":
                                intSubMenu = intMenu + 1;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            default:
                                Assert.IsFalse(true, "The sub menu option selected is not found");
                                break;
                        }
                        break;
                    case 30:
                        switch (pstrSubmenu.ToLower())
                        {
                            case "cartrawler":
                                intSubMenu = intMenu + 1;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            default:
                                Assert.IsFalse(true, "The sub menu option selected is not found");
                                break;
                        }
                        break;
                    case 32:
                        switch (pstrSubmenu.ToLower())
                        {
                            case "settings":
                                intSubMenu = intMenu + 1;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "bookings":
                                intSubMenu = intMenu + 2;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            default:
                                Assert.IsFalse(true, "The sub menu option selected is not found");
                                break;
                        }
                        break;
                    case 35:
                        switch (pstrSubmenu.ToLower())
                        {
                            case "posts":
                                intSubMenu = intMenu + 1;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "blog categories":
                                intSubMenu = intMenu + 2;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "blog settings":
                                intSubMenu = intMenu + 3;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            default:
                                Assert.IsFalse(true, "The sub menu option selected is not found");
                                break;
                        }
                        break;
                    case 39:
                        switch (pstrSubmenu.ToLower())
                        {
                            case "locations":
                                intSubMenu = intMenu + 1;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            default:
                                Assert.IsFalse(true, "The sub menu option selected is not found");
                                break;
                        }
                        break;
                    case 41:
                        switch (pstrSubmenu.ToLower())
                        {
                            case "manage offers":
                                intSubMenu = intMenu + 1;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            case "offers settings":
                                intSubMenu = intMenu + 2;
                                fnWaitHamburgerMenu();
                                objSideOptionBtn[intSubMenu].Click();
                                break;
                            default:
                                Assert.IsFalse(true, "The sub menu option selected is not found");
                                break;
                        }
                        break;
                    default:
                        Assert.IsFalse(true, "The sub menu option selected is not found");
                        break;
                }
            }
            else
            {
                Assert.IsFalse(true, "The menu option selected is not found");
            }


        }

    }
}
