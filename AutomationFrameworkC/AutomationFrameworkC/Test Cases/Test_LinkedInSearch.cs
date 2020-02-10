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
        clsLinkedIn_SearchPage objSearch;
        Test_LinkedIn objTestLogin = new Test_LinkedIn();


        //VARIABLES
        string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
        string[] arrLanguages = { "Spanish", "English" };

        //Test case
        [Test, Order(1)]
        public void fnSearch_LinkedIn()
        {
            objTestLogin.fnLogin_LinkedIn();
            objSearch = new clsLinkedIn_SearchPage(objDriver);
            //clsLinkedIn_SearchPage.fnSearch(strSearch, listCountries, arrTechnologies);
            clsLinkedIn_SearchPage.fnSearchData(strSearch);
            clsLinkedIn_SearchPage.fnClickPeopleBtn();
            clsLinkedIn_SearchPage.fnClickAllFiltersBtn();
            clsLinkedIn_SearchPage.fnAddCountryRegion(listCountries);
            //clsLinkedIn_SearchPage.fnClickApplyFilters();
            clsLinkedIn_SearchPage.fnMultipleSearch(arrTechnologies);
        }

    }
}
