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
    class Test_MercuryTours : BaseTest
    {
        //Init Objects
        clsMercury_LoginPage objLogin;


        //Test
        [Test, Order(0)]
        public void fnLogin_MercuryTours()
        {
            /*Take Nunit Test Name*/
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            /*Init Login Page*/
            objLogin = new clsMercury_LoginPage(objDriver);
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            clsMercury_LoginPage.fnLoginPage("sdsada", "sadasd");
            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "LoginEvidence.png", "Pass");


        }
    }
}
