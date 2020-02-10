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
    class Test_LinkedInSearch : Test_LinkedIn
    {
        clsLinkedIn_SearchPage objSearch;

        //VARIABLES
        string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
        string[] arrLanguages = { "Spanish", "English" };

        [Test, Order(0)]
        public void fnLinkedIn_Search()
        {
            try
            {
                fnLinkedIn_Login();
                objSearch = new clsLinkedIn_SearchPage(objDriver);
                clsLinkedIn_SearchPage.fnEnterSearch("QA Automation");
                //clsLinkedIn_SearchPage.fnClickSearchButton();
                clsLinkedIn_SearchPage.fnClickPersonButton();
                clsLinkedIn_SearchPage.fnClickAllFiltersButton();
                clsLinkedIn_SearchPage.fnEnterLocationsMx("Mexico");
                clsLinkedIn_SearchPage.fnEnterLocationsIt("Italy");
                clsLinkedIn_SearchPage.fnApplyFilters();
                //Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Search Test failed : " + e.Message);
                Assert.Fail();
            }
        }

        [Test, Order(0)]
        public void fnLinkedIn_SearchTech()
        {
            try
            {
                fnLinkedIn_Search();

                objSearch = new clsLinkedIn_SearchPage(objDriver);

                for (int i = 0; i < arrTechnologies.Length; i++)
                {
                    string strTech = arrTechnologies[i];
                    clsLinkedIn_SearchPage.fnEnterSearch(strTech);
                    //clsLinkedIn_SearchPage.fnClickSearchButton();
                    clsLinkedIn_SearchPage.fnGetNameInfo();
                    clsLinkedIn_SearchPage.fnGetRoleInfo();
                    clsLinkedIn_SearchPage.fnGetUrlInfo();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Search Test failed : " + e.Message);
                Assert.Fail();
            }
        }

    }
}
