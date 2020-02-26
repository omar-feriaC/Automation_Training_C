using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
using System;
using AventStack.ExtentReports;

namespace AutomationFrameworkC.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        clsPHPTravels_LoginPage objPHP;
        string sreenPath;

        [Test]
        public void Test_M9Exercise()
        {
            try
            {
                //Init objects
                objPHP = new clsPHPTravels_LoginPage(objDriver);
                //Login Action
                Assert.AreEqual(true, objDriver.Title.Contains("Administrador Login."), "The Login Page was not loaded correctly.");
                clsPHPTravels_LoginPage.fnEnterEmail(strUserName);
                clsPHPTravels_LoginPage.fnEnterPassword(strPassword);
                clsPHPTravels_LoginPage.fnClickLoginButton();
                clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
                objPHP.fnDashboardRedBox();
                sreenPath = objRM.fnCaptureImage(objDriver, "Screenshot.png");
                objTest.Log(AventStack.ExtentReports.Status.Pass, "Step ScreenShot :", MediaEntityBuilder.CreateScreenCaptureFromPath(sreenPath).Build());
            }
            catch
            {
                Assert.AreEqual(true, objDriver.Title.Contains("Dashboard."), "The Dashboard was not loaded correctly.");
                sreenPath = objRM.fnCaptureImage(objDriver, "Screenshot.png");
                objTest.Log(AventStack.ExtentReports.Status.Error, "Step has failed with SS", MediaEntityBuilder.CreateScreenCaptureFromPath(sreenPath).Build());
                Console.WriteLine("It was an error");
                Assert.Fail();
            }
        }
        public void Test_SortAccountsOption()
        {
            Test_M9Exercise();
            try
            {
                objPHP = new clsPHPTravels_LoginPage(objDriver);
                objPHP.fnSortAccountSubMenu();
                sreenPath = objRM.fnCaptureImage(objDriver, "Menu.png");
                objTest.Log(AventStack.ExtentReports.Status.Pass, "Step ScreenShot :", MediaEntityBuilder.CreateScreenCaptureFromPath(sreenPath).Build());
            }
            catch
            {
                Assert.AreEqual(true, objDriver.Title.Contains("Customer Management"), "Customer Management was not loaded correctly.");
                objTest.Log(AventStack.ExtentReports.Status.Error, "Step has failed with SS", MediaEntityBuilder.CreateScreenCaptureFromPath(sreenPath).Build());
                Console.WriteLine("Test Case Failed");
                Assert.Fail();
            }
        }
    }
}