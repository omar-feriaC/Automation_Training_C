using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
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
        clsPHPTravels_DashboardPage objDash;


        [Test]
        public void Test_M9Exercise()
        {
            /*Init Nunit Test*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(objDriver);
           // objDash = new clsPHPTravels_DashboardPage(objDriver);
            //Login Action
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            clsPHPTravels_LoginPage.fnEnterEmail(strUser);
            clsPHPTravels_LoginPage.fnEnterPassword(strPassword);
            clsPHPTravels_LoginPage.fnClickLoginButton();
            clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
            
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");

            //clsPHPTravels_DashboardPage.fnSaveTotals();

            //Print Elements List
            IList<IWebElement> TotalsList = objDriver.FindElements(By.XPath("//ul[@class='serverHeader__statsList']/li"));
            foreach (IWebElement t in TotalsList)
            {
                Console.WriteLine(t.Text);
                objTest.Log(Status.Info, t.Text);
            }

            clsPHPTravels_LoginPage.fnClickMenu("UPDATES");
            Assert.AreEqual(true, objDriver.Title.Contains("Updates"), "The Updates page was not loaded correctly.");
            //Check menús


            //Console.ReadKey();

        }


    }
}
