using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Test_Cases
{
    class M8LinkedIn_Test2 : BaseTest
    {
        clsLinkedIn_SearchPage objSearch;
        Test_LinkedIn objTestLogin = new Test_LinkedIn();
        string[] arrTechnologies = { "Java", "C", "Phyton","C#", "Pega" };
        string[] arrLanguages = { "Spanish", "English" };

        [Test, Order(1)]
        public void fnSearch_LinkedIn()
        {
            objTestLogin.fnLogin_LinkedIn();
            objSearch = new clsLinkedIn_SearchPage(objDriver);
            clsLinkedIn_SearchPage.fnSearchData(strSearch);
            clsLinkedIn_SearchPage.fnClickPeopleBtn();
            clsLinkedIn_SearchPage.fnClickAllFiltersBtn();
            clsLinkedIn_SearchPage.fnAddCountryRegion(listCountries);
            clsLinkedIn_SearchPage.fnClickApplyFilters();
            clsLinkedIn_SearchPage.fnMultipleSearch(arrTechnologies);
        }
    }
}
