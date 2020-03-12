using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationFrameworkC.Test_Cases
{

    class Test_LinkedIn : BaseTest
    {
        public LinkedIn_LoginPage objLogin;

        [Test, Order(1)]
        public void fnLogin_LinkedIn()
        {
            objLogin = new LinkedIn_LoginPage(objDriver);
            objDriver.Url = "https://www.linkedin.com/login?";
            LinkedIn_LoginPage.fnLoginPage(strUser, strPass);
        }
    }
}