﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkC.Base_Files;
using NUnit.Framework;

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
        readonly static string STRREMEMBERME_LNK = "//label[@class='checkbox']";
        readonly static string STR_FORGOTPASS_LNK = "//*[text()='Forget Password']";
        readonly static string  STR_LOGIN_BTN = "//span[text()='Login']";
        readonly static string STR_HAMBURGER_BTN = "sidebarCollapse";

        /*CONSTRUCTOR*/
        public clsPHPTravels_LoginPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0,0,40));
            Base_Files.clsDriver clsDriver = new clsDriver(objDriver);
        }

        /*OBJECT DEFINITION*/
        private static IWebElement objEmailTxt = objDriver.FindElement(By.Name(STR_EMAIL_TXT));
        private static IWebElement objPasswordTxt = objDriver.FindElement(By.Name(STR_PASSWORD_TXT));
        private static IWebElement objRememberMeLnk = objDriver.FindElement(By.XPath(STRREMEMBERME_LNK)); 
        private static IWebElement objForgotPassLnk = objDriver.FindElement(By.XPath(STR_FORGOTPASS_LNK));
        private static IWebElement objLoginBtn = objDriver.FindElement(By.XPath(STR_LOGIN_BTN));


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

        public static void fnArray()
        {
            IWebElement ul = objDriver.FindElement(By.ClassName("serverHeader__statsList"));
            Console.WriteLine(ul.Text);
        }

        public static void fnSubMenu(String submenu,String title)
        {
            String[] array = submenu.Split('.');
            IWebElement menu = objDriver.FindElement(By.LinkText(array[0]));
            menu.Click();
            _driverWait.Until(ExpectedConditions.ElementExists(By.Id("social-sidebar-menu")));
            _driverWait.Until(ExpectedConditions.ElementExists(By.TagName("li")));
            _driverWait.Until(ExpectedConditions.ElementExists(By.TagName("a")));
            _driverWait.Until(ExpectedConditions.ElementExists(By.LinkText(array[1])));
            IWebElement subMenu= objDriver.FindElement(By.LinkText(array[1]));
            subMenu.Click();
            _driverWait.Until(ExpectedConditions.TitleContains(title));
            fnOrder("//th[@data-orderby='pt_accounts.ai_first_name']");
            _driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("xcrud-overlay")));
            fnOrder("//th[@data-orderby='pt_accounts.ai_last_name']");
            _driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("xcrud-overlay")));
            fnOrder("//th[@data-orderby='pt_accounts.accounts_email']");
            _driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("xcrud-overlay")));
            fnOrder("//th[@data-orderby='pt_accounts.accounts_status']");
            _driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("xcrud-overlay")));
            fnOrder("//th[@data-orderby='pt_accounts.accounts_last_login']");
        }

        public static void fnOrder(String path)
        {
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(path)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(path)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            IWebElement order = objDriver.FindElement(By.XPath(path));
            order.Click();

         
            _driverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("xcrud-overlay")));
            _driverWait.Until(ExpectedConditions.ElementExists(By.XPath(path)));
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(path)));
            _driverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path)));
            IWebElement order1 = objDriver.FindElement(By.XPath(path));
            order1.Click();

        }
     
    }
}
