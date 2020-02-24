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
    class Test_PHPTravels_Dashboard : BaseTest
    {
        clsPHPTravels_DashboardPage objDashboard;



        [Test, Order(0)]
        public void Test_M9Exercise_Dashboard()
        {
            //Init objects
            objDashboard = new clsPHPTravels_DashboardPage(objDriver);

            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);

            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_DashboardPage.fnEnterEmail(strEmail);
            clsPHPTravels_DashboardPage.fnEnterPassword(strPass);
            clsPHPTravels_DashboardPage.fnClickLoginButton();
            clsPHPTravels_DashboardPage.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            clsPHPTravels_DashboardPage.fnObtaintotalLinks();            
            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "LoginEvidence.png", "Pass");


        }  


    }
}
