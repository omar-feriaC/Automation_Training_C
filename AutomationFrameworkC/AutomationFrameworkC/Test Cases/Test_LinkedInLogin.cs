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
    class Test_LinkedInLogin : BaseTest
    {
        //Init Object
        clsLinkedIn_LoginPage objLogin;

        //Test
        [Test, Order(0)]
        public void fnSignInPage()
        {
            objLogin = new clsLinkedIn_LoginPage(objDriver);
            clsLinkedIn_LoginPage.fnSignInPage(strUser, strPass);
            Console.WriteLine("Testing Login");
        }

    }
}
