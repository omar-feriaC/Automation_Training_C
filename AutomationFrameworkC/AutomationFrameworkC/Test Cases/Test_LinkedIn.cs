using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;

namespace AutomationFrameworkC.Test_Cases
{
    class Test_LinkedIn : BaseTest
    {

        LinkedIn_LoginPage objLogin;

        [Test, Order(0)]
        public void fnTestLoginLinkedIn()
        {
           
            objLogin = new LinkedIn_LoginPage(objDriver);
            LinkedIn_LoginPage.fnLoginPage(strUser, strPass);
            
        }
    }
}
