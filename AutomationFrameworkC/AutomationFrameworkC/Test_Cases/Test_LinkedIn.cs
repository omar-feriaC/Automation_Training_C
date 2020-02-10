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
    class Test_LinkedIn : BaseTest
    {
        //Init Objects
        LinkedIn_LoginPage objLogin;

        //Test
        [Test, Order(0)]

        public void fnLoginPage()
        {
            objLogin = new LinkedIn_LoginPage(objDriver);
            LinkedIn_LoginPage.fnLoginPage(strUser, strPass);
            Console.WriteLine("Test Login");
            
        }
    }
}