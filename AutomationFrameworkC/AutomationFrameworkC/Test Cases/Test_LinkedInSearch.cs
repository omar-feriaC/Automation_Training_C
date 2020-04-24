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
    class Test_LinkedInSearch : BaseTest
    {
        //Init Object
        clsLinkedIn_SearchPage objSearch;
        clsLinkedIn_LoginPage objLogin;
                        
        //Test
        [Test, Order(1)]
        public void fnSearchPage()
        {
            objLogin = new clsLinkedIn_LoginPage(objDriver);
            clsLinkedIn_LoginPage.fnSignInPage(strUser, strPass);
            Console.WriteLine("Testing Login");
            objSearch = new clsLinkedIn_SearchPage(objDriver);
           // objDriver.Url = "https://www.linkedin.com/feed/"; //cambiar Url
           // objDriver.Navigate().GoToUrl("https://www.linkedin.com/feed/");

            clsLinkedIn_SearchPage.fnSearchBtn("Java");
            clsLinkedIn_SearchPage.fnPeopleBtn();
            clsLinkedIn_SearchPage.fnFiltersBtn();
            clsLinkedIn_SearchPage.fnMexicoChk();          
            clsLinkedIn_SearchPage.fnItalyChk();
            clsLinkedIn_SearchPage.fnApplyBtn();
            clsLinkedIn_SearchPage.fnTableInfo();
        }

    }
}
