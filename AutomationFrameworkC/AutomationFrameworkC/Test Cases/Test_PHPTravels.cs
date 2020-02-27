using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;

        [Test, Order (0)]
        public void Test_M9Exercise()
        {
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(objDriver);

            /*Init Nunit Test*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            
            //Login Action
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");

            
            clsPHPTravels_LoginPage.fnEnterEmail(strUser);
            clsPHPTravels_LoginPage.fnEnterPassword(strPassword);
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //Print Elements List
            IList<IWebElement> TotalsList = objDriver.FindElements(By.XPath("//ul[@class='serverHeader__statsList']/li"));
            foreach (IWebElement t in TotalsList)
            {
                Console.WriteLine(t.Text);
                objTest.Log(Status.Info, t.Text);
            }

            clsPHPTravels_LoginPage.fnClickMenu("UPDATES");
            Thread.Sleep(1000);

            clsPHPTravels_LoginPage.fnClickMenu("ACCOUNTS");
            Thread.Sleep(1000);

            clsPHPTravels_LoginPage.fnClickAccountSubMenus("ADMINS");
            clsPHPTravels_LoginPage.fnSortFirstName();
            clsPHPTravels_LoginPage.fnSortLastName();
            clsPHPTravels_LoginPage.fnSortEmail();
            clsPHPTravels_LoginPage.fnSortActive();
            clsPHPTravels_LoginPage.fnSortLastLogin();
            Thread.Sleep(1000);

            clsPHPTravels_LoginPage.fnClickMenu("ACCOUNTS");
            Thread.Sleep(1000);
            clsPHPTravels_LoginPage.fnClickAccountSubMenus("SUPPLIERS");
            clsPHPTravels_LoginPage.fnSortFirstName();
            clsPHPTravels_LoginPage.fnSortLastName();
            clsPHPTravels_LoginPage.fnSortEmail();
            clsPHPTravels_LoginPage.fnSortActive();
            clsPHPTravels_LoginPage.fnSortLastLogin();
            Thread.Sleep(1000);

            clsPHPTravels_LoginPage.fnClickMenu("ACCOUNTS");
            Thread.Sleep(1000);
            clsPHPTravels_LoginPage.fnClickAccountSubMenus("CUSTOMERS");
            clsPHPTravels_LoginPage.fnSortFirstName();
            clsPHPTravels_LoginPage.fnSortLastName();
            clsPHPTravels_LoginPage.fnSortEmail();
            clsPHPTravels_LoginPage.fnSortActive();
            clsPHPTravels_LoginPage.fnSortLastLogin();
            Thread.Sleep(1000);

            clsPHPTravels_LoginPage.fnClickMenu("ACCOUNTS");
            Thread.Sleep(1000);
            clsPHPTravels_LoginPage.fnClickAccountSubMenus("GUESTCUSTOMERS");
            clsPHPTravels_LoginPage.fnSortFirstName();
            clsPHPTravels_LoginPage.fnSortLastName();
            clsPHPTravels_LoginPage.fnSortEmail();
            clsPHPTravels_LoginPage.fnSortActive();
            clsPHPTravels_LoginPage.fnSortLastLogin();
            Thread.Sleep(1000);
        }


    }
}
