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
    class Test_LinkedInSearch : BaseTest 
    {
        private WebDriverWait _objDriverWait;
        LinkedIn_SearchPage objSearch;

        //VARIABLES
        string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
        string[] arrLanguages = { "Spanish", "English" };
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
            _objDriverWait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 30));
            objSearch = new LinkedIn_SearchPage(objDriver);

            objSearch.fnDataSearch("PMI");
            _objDriverWait.Until(ExpectedConditions.UrlContains("results"));
            objSearch.fnClickPpl();
            _objDriverWait.Until(ExpectedConditions.UrlContains("people"));
            objSearch.fnClickAllFilters();
            objSearch.fnLocation("Mexico");
            objSearch.fnMexicoOpt();
            objSearch.fnLocation("Italy");
            objSearch.fnItalyOpt();
            _objDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='search-advanced-facets__selected-counts mv0 m11']")));
            objSearch.fnApplyFilters();
            objSearch.fnTechno();

        }
    }
}
