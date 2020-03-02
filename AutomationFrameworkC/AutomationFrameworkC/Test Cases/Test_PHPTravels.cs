using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;


        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objPHP = new clsPHPTravels_LoginPage(objDriver);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Url.Contains("https://www.phptravels.net/admin"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail(strUserName);
            clsPHPTravels_LoginPage.fnEnterPassword(strPassword);
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Dashboard//
            objRM.fnAddStepLog(objTest, "Report Information", "Pass");
            clsPHPTravels_LoginPage.fnCheckStatsList();

            //SubMenu Navigation//
            objRM.fnAddStepLog(objTest, "Menu Navigation", "Pass");
            clsPHPTravels_LoginPage.fnNavMenu("ACCOUNTS.ADMINS", "Admins Management");
            Assert.AreEqual(true, objDriver.Title.Contains("Admins Management"), "The Admins Management fail");
            clsPHPTravels_LoginPage.fnNavMenu("ACCOUNTS.SUPPLIERS", "Suppliers Management");
            Assert.AreEqual(true, objDriver.Title.Contains("Suppliers Management"), "The Suppliers Management fail");
            clsPHPTravels_LoginPage.fnNavMenu("ACCOUNTS.CUSTOMERS", "Customers Management");
            Assert.AreEqual(true, objDriver.Title.Contains("Customers Management"), "The Customers Management fail");
            clsPHPTravels_LoginPage.fnNavMenu("ACCOUNTS.GUESTCUSTOMERS", "Guest Management");
            Assert.AreEqual(true, objDriver.Title.Contains("Guest Management"), "The Guest Management fail.");
            objTest.Pass("Test Passed");
        }

    }
}
