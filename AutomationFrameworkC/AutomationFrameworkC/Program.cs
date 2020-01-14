
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {
            BaseTest.fnSetUp();
            clsMercury_LoginPage objLogin = new clsMercury_LoginPage(objDriver);


            BaseTest.fnTearDown();
        }
    }
}
