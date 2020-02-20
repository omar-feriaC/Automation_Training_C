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
            try
            {
                //Init objects
                objPHP = new clsPHPTravels_LoginPage(objDriver);
                objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
                //Login Action
                Assert.AreEqual(true, objDriver.Title.Contains("Administrador Login."), "The Login Page was not loaded correctly.");
                clsPHPTravels_LoginPage.fnEnterEmail(strUserName);
                clsPHPTravels_LoginPage.fnEnterPassword(strPassword);
                clsPHPTravels_LoginPage.fnClickLoginButton();
                clsPHPTravels_LoginPage.fnWaitHamburgerMenu();
                Assert.AreEqual(true, objDriver.Title.Contains("Dashboard."), "The Dashboard was not loaded correctly.");
            }

            catch 
            {
                Console.WriteLine("It was an error");
                Assert.Fail();

            }
        }


    }
}
