using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace AutomationFrameworkC.Test_Cases
{
    class Test_LinkedInSearch : Test_LinkedIn
    {
        private WebDriverWait _objDriverWait;
        LinkedIn_SearchPage objSearch;

        private IWebElement objFindTx;

        public void fnInsertSearch(string pstrInsertSearch)
        {
            objFindTx.Clear();
            objFindTx.SendKeys(pstrInsertSearch);
            objFindTx.SendKeys(Keys.Enter);
        }


        [Test]
        public void LinkedIn_SearchPage()
        {

            try
            { 
            _objDriverWait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 30));
            objSearch = new LinkedIn_SearchPage(objDriver);
            fnTestLoginLinkedIn();
            objSearch.fnDataSearch("QA");
           _objDriverWait.Until(ExpectedConditions.UrlContains("results"));
            objSearch.fnClickPpl();
            _objDriverWait.Until(ExpectedConditions.UrlContains("people"));
            objSearch.fnClickAllFilters();
            objSearch.fnLocation("Mexico");
            objSearch.fnMexicoOpt();
            objSearch.fnLocation("Italy");
            objSearch.fnItalyOpt();
             objSearch.fnApplyFilters();
             objSearch.fnTechnologies();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Not Found" + ex.Message);
                Assert.Fail();
            }
        }
    }
}
