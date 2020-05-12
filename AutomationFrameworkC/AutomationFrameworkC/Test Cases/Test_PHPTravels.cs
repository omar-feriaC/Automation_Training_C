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
        //Init Object
        clsPHPTravels_LoginPage objPHPLogin;


        [Test, Order(0)]
        public void Test_M9Exercise()
        {
            //Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objPHPLogin = new clsPHPTravels_LoginPage(objDriver);
            //Login Action          
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnSignInPage(strEmail, strPass);
            clsPHPTravels_LoginPage.fnWaitAfterSignIn();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            clsPHPTravels_LoginPage.fnDashboardTotals();
            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "Dashboard Totals", "DashboardTotals.png", "Pass");
            clsPHPTravels_LoginPage.fnSideBarVisibleChk();
            clsPHPTravels_LoginPage.fnAccountDisplayed();
            clsPHPTravels_LoginPage.fnSubMenus();

        }
    }
}
