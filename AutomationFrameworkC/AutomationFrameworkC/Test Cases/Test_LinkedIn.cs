using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Test_Cases
{
    class Test_LinkedIn : BaseTest
    {
        clsLinkedIn_LoginPage objLogin;

        [Test, Order(0)]
        public void fnLinkedIn_Login()
        {
            try
            {
            objLogin = new clsLinkedIn_LoginPage(objDriver);
            clsLinkedIn_LoginPage.fnLinkedIn_LoginPage(strUser, strPass);
            }
            catch (Exception e)
            {
                Console.WriteLine("Login failed : " + e.Message);
                Assert.Fail();
            }
            //Console.WriteLine("Test");
            //Assert.Fail();
        }

    }
}