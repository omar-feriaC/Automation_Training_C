using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Test_Cases
{
    class Test_PHPTravels_Account : BaseTest
    {
        clsPHPTravels_AccountPage objAccount;
        clsPHPTravels_DashboardPage objDashboard;



        [Test, Order(0)]
        public void Test_M9Exercise_Account_Admins_Column_Order_First_Name()
        {
            //Init objects
            objAccount = new clsPHPTravels_AccountPage(objDriver);
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_AccountPage.fnEnterEmail(strEmail);
            clsPHPTravels_AccountPage.fnEnterPassword(strPass);
            clsPHPTravels_AccountPage.fnClickLoginButton();
            clsPHPTravels_AccountPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            
            //Select Submenu
            clsPHPTravels_DashboardPage.fnSidebar("accounts", "admins");

            //Validate the column
            clsPHPTravels_AccountPage.fnSortColumnVerification("first name");

            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "Test_M9Exercise_Account_Admins_Column_Order_First_Name.png", "Pass");
        }

        [Test, Order(1)]
        public void Test_M9Exercise_Account_Admins_Column_Order_Last_Name()
        {
            //Init objects
            objAccount = new clsPHPTravels_AccountPage(objDriver);
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_AccountPage.fnEnterEmail(strEmail);
            clsPHPTravels_AccountPage.fnEnterPassword(strPass);
            clsPHPTravels_AccountPage.fnClickLoginButton();
            clsPHPTravels_AccountPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Select Submenu
            clsPHPTravels_DashboardPage.fnSidebar("accounts", "admins");

            //Validate the column
            clsPHPTravels_AccountPage.fnSortColumnVerification("last name");


            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "Test_M9Exercise_Account_Admins_Column_Order_Last_Name.png", "Pass");
        }

        [Test, Order(2)]
        public void Test_M9Exercise_Account_Admins_Column_Order_Email()
        {
            //Init objects
            objAccount = new clsPHPTravels_AccountPage(objDriver);
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_AccountPage.fnEnterEmail(strEmail);
            clsPHPTravels_AccountPage.fnEnterPassword(strPass);
            clsPHPTravels_AccountPage.fnClickLoginButton();
            clsPHPTravels_AccountPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Select Submenu
            clsPHPTravels_DashboardPage.fnSidebar("accounts", "admins");

            //Validate the column
            clsPHPTravels_AccountPage.fnSortColumnVerification("email");

            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "Test_M9Exercise_Account_Admins_Column_Order_Email.png", "Pass");
        }

        [Test, Order(3)]
        public void Test_M9Exercise_Account_Suppliers_Column_Order_First_Name()
        {
            //Init objects
            objAccount = new clsPHPTravels_AccountPage(objDriver);
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_AccountPage.fnEnterEmail(strEmail);
            clsPHPTravels_AccountPage.fnEnterPassword(strPass);
            clsPHPTravels_AccountPage.fnClickLoginButton();
            clsPHPTravels_AccountPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Select Submenu
            clsPHPTravels_DashboardPage.fnSidebar("accounts", "suppliers");

            //Validate the column
            clsPHPTravels_AccountPage.fnSortColumnVerification("first name");

            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "Test_M9Exercise_Account_Suppliers_Column_Order_First_Name.png", "Pass");
        }

        [Test, Order(4)]
        public void Test_M9Exercise_Account_Suppliers_Column_Order_Last_Name()
        {
            //Init objects
            objAccount = new clsPHPTravels_AccountPage(objDriver);
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_AccountPage.fnEnterEmail(strEmail);
            clsPHPTravels_AccountPage.fnEnterPassword(strPass);
            clsPHPTravels_AccountPage.fnClickLoginButton();
            clsPHPTravels_AccountPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Select Submenu
            clsPHPTravels_DashboardPage.fnSidebar("accounts", "suppliers");

            //Validate the column
            clsPHPTravels_AccountPage.fnSortColumnVerification("last name");


            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "Test_M9Exercise_Account_Suppliers_Column_Order_Last_Name.png", "Pass");
        }

        [Test, Order(5)]
        public void Test_M9Exercise_Account_Suppliers_Column_Order_Email()
        {
            //Init objects
            objAccount = new clsPHPTravels_AccountPage(objDriver);
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_AccountPage.fnEnterEmail(strEmail);
            clsPHPTravels_AccountPage.fnEnterPassword(strPass);
            clsPHPTravels_AccountPage.fnClickLoginButton();
            clsPHPTravels_AccountPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Select Submenu
            clsPHPTravels_DashboardPage.fnSidebar("accounts", "suppliers");

            //Validate the column
            clsPHPTravels_AccountPage.fnSortColumnVerification("email");

            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "Test_M9Exercise_Account_Suppliers_Column_Order_Email.png", "Pass");
        }

        [Test, Order(6)]
        public void Test_M9Exercise_Account_Customers_Column_Order_First_Name()
        {
            //Init objects
            objAccount = new clsPHPTravels_AccountPage(objDriver);
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_AccountPage.fnEnterEmail(strEmail);
            clsPHPTravels_AccountPage.fnEnterPassword(strPass);
            clsPHPTravels_AccountPage.fnClickLoginButton();
            clsPHPTravels_AccountPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Select Submenu
            clsPHPTravels_DashboardPage.fnSidebar("accounts", "customers");

            //Validate the column
            clsPHPTravels_AccountPage.fnSortColumnVerification("first name");

            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "Test_M9Exercise_Account_Customers_Column_Order_First_Name.png", "Pass");
        }

        [Test, Order(7)]
        public void Test_M9Exercise_Account_Customers_Column_Order_Last_Name()
        {
            //Init objects
            objAccount = new clsPHPTravels_AccountPage(objDriver);
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_AccountPage.fnEnterEmail(strEmail);
            clsPHPTravels_AccountPage.fnEnterPassword(strPass);
            clsPHPTravels_AccountPage.fnClickLoginButton();
            clsPHPTravels_AccountPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Select Submenu
            clsPHPTravels_DashboardPage.fnSidebar("accounts", "customers");

            //Validate the column
            clsPHPTravels_AccountPage.fnSortColumnVerification("last name");


            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "Test_M9Exercise_Account_Customers_Column_Order_Last_Name.png", "Pass");
        }

        [Test, Order(8)]
        public void Test_M9Exercise_Account_Customers_Column_Order_Email()
        {
            //Init objects
            objAccount = new clsPHPTravels_AccountPage(objDriver);
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_AccountPage.fnEnterEmail(strEmail);
            clsPHPTravels_AccountPage.fnEnterPassword(strPass);
            clsPHPTravels_AccountPage.fnClickLoginButton();
            clsPHPTravels_AccountPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Select Submenu
            clsPHPTravels_DashboardPage.fnSidebar("accounts", "customers");

            //Validate the column
            clsPHPTravels_AccountPage.fnSortColumnVerification("email");

            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "Test_M9Exercise_Account_Customers_Column_Order_Email.png", "Pass");
        }

        [Test, Order(9)]
        public void Test_M9Exercise_Account_GuestCustomers_Column_Order_First_Name()
        {
            //Init objects
            objAccount = new clsPHPTravels_AccountPage(objDriver);
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_AccountPage.fnEnterEmail(strEmail);
            clsPHPTravels_AccountPage.fnEnterPassword(strPass);
            clsPHPTravels_AccountPage.fnClickLoginButton();
            clsPHPTravels_AccountPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Select Submenu
            clsPHPTravels_DashboardPage.fnSidebar("accounts", "guestcustomers");

            //Validate the column
            clsPHPTravels_AccountPage.fnSortColumnVerification("first name");

            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "Test_M9Exercise_Account_GuestCustomers_Column_Order_First_Name.png", "Pass");
        }

        [Test, Order(10)]
        public void Test_M9Exercise_Account_GuestCustomers_Column_Order_Last_Name()
        {
            //Init objects
            objAccount = new clsPHPTravels_AccountPage(objDriver);
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_AccountPage.fnEnterEmail(strEmail);
            clsPHPTravels_AccountPage.fnEnterPassword(strPass);
            clsPHPTravels_AccountPage.fnClickLoginButton();
            clsPHPTravels_AccountPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Select Submenu
            clsPHPTravels_DashboardPage.fnSidebar("accounts", "guestcustomers");

            //Validate the column
            clsPHPTravels_AccountPage.fnSortColumnVerification("last name");


            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "Test_M9Exercise_Account_GuestCustomers_Column_Order_Last_Name.png", "Pass");
        }

        [Test, Order(11)]
        public void Test_M9Exercise_Account_GuestCustomers_Column_Order_Email()
        {
            //Init objects
            objAccount = new clsPHPTravels_AccountPage(objDriver);
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_AccountPage.fnEnterEmail(strEmail);
            clsPHPTravels_AccountPage.fnEnterPassword(strPass);
            clsPHPTravels_AccountPage.fnClickLoginButton();
            clsPHPTravels_AccountPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Select Submenu
            clsPHPTravels_DashboardPage.fnSidebar("accounts", "guestcustomers");

            //Validate the column
            clsPHPTravels_AccountPage.fnSortColumnVerification("email");

            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "Test_M9Exercise_Account_GuestCustomers_Column_Order_Email.png", "Pass");
        }

    }
}
