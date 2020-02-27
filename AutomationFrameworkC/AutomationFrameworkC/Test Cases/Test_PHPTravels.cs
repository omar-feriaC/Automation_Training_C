using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationFrameworkC.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
      public static clsPHPTravels_LoginPage objPHP;

        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(objDriver);
            objTest = objTest.CreateNode("PHPTRAVELS", "Login");
            //Login Action
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail(strUserName);
            clsPHPTravels_LoginPage.fnEnterPassword(strPassword);
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            clsPHPTravels_LoginPage.fnArray();
            objTest.Pass("Dashboard results are displayed correctly.");
            objTest = objTest.CreateNode("PHPTRAVELS", "Menu & Sorting");
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            clsPHPTravels_LoginPage.fnSubMenu("ACCOUNTS.ADMINS", "Admins Management");
            Assert.AreEqual(true, objDriver.Title.Contains("Admins Management"), "The Admins Management was not loaded correctly.");      
            clsPHPTravels_LoginPage.fnSubMenu("ACCOUNTS.SUPPLIERS", "Suppliers Management");
            Assert.AreEqual(true, objDriver.Title.Contains("Suppliers Management"), "The Suppliers Management was not loaded correctly.");
            clsPHPTravels_LoginPage.fnSubMenu("ACCOUNTS.CUSTOMERS", "Customers Management");
            Assert.AreEqual(true, objDriver.Title.Contains("Customers Management"), "The Customers Management was not loaded correctly.");
            clsPHPTravels_LoginPage.fnSubMenu("ACCOUNTS.GUESTCUSTOMERS", "Guest Management");
            Assert.AreEqual(true, objDriver.Title.Contains("Guest Management"), "The Guest Management was not loaded correctly.");
            objTest.Pass("Menu & Sorting results are displayed correctly.");
        }
    }
}
