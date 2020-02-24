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
        clsPHPTravels_LoginPage objPHP;

        [Test]
        public void Test_M9Exercise()
        {
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(objDriver);
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            //Login Action
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail("admin@phptravels.com");
            clsPHPTravels_LoginPage.fnEnterPassword("demoadmin");
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            clsPHPTravels_LoginPage.fnArray();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            clsPHPTravels_LoginPage.fnMenuAdmins();
            Assert.AreEqual(true, objDriver.Title.Contains("Admins Management"), "The Admins Management was not loaded correctly.");
            clsPHPTravels_LoginPage.fnMenuSuppliers();
            Assert.AreEqual(true, objDriver.Title.Contains("Suppliers Management"), "The Suppliers Management was not loaded correctly.");
            clsPHPTravels_LoginPage.fnMenuCustomers();
            Assert.AreEqual(true, objDriver.Title.Contains("Customers Management"), "The Customers Management was not loaded correctly.");
            clsPHPTravels_LoginPage.fnMenuGuestCustomers();
            Assert.AreEqual(true, objDriver.Title.Contains("Guest Management"), "The Guest Management was not loaded correctly.");
        }

        
    }
}
