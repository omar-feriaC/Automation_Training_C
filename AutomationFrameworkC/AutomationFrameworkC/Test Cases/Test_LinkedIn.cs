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
        public clsLinkedIn_LoginPage objLogin;

        [Test, Order(1)]
        public void fnLogin_LinkedIn()
        {
            objLogin = new clsLinkedIn_LoginPage(objDriver); //we use the objDriver from BaseTest
            objDriver.Url = "https://www.linkedin.com/login?";
            clsLinkedIn_LoginPage.fnLoginPage(strUser, strPass);
        }
    }
}
