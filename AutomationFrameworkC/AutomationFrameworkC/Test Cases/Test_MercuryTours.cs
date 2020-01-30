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
            objLogin = new clsMercury_LoginPage(objDriver);
            clsMercury_LoginPage.fnLoginPage(strUser, strPass);

        }
    }
}
