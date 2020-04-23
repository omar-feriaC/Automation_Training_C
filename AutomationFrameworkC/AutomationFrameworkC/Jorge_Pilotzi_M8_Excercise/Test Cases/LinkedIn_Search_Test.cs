using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.Page_Objects;
using AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.BaseFiles;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.Test_Cases
{
   class LinkedIn_Search_Test : Linkedin_Test
    {
        LinkedIn_Search objLinkedInSrch;
        [Test]
        public void LinkedIn_SearchPageTest()
        {
            //Variables
            WebDriverWait Wait;
            Wait = new WebDriverWait(driver, new TimeSpan(0, 1, 20));
            string [] arrTechnologies = { "Java", "Python", "Pega", "C#", "C Language" };
            // Step 1 - Login
            driver.Manage().Window.Maximize();
            Linkedin_LoginPage();
            // Step 2 - Search
            objLinkedInSrch = new LinkedIn_Search(driver);
            LinkedIn_Search.fnGetSrchFld("Java");
            LinkedIn_Search.fnGetSrchBtn();
            Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='People' or text()='Gente']")));
            //Step 3 - Select People
            LinkedIn_Search.fnSelectPeopleCheckbox();
            Wait.Until(ExpectedConditions.UrlContains("people"));
            // Step 4 - Select Location
            LinkedIn_Search.fnGetAllFiltersBtn();
            Wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@aria-label='Add a country/region' or @aria-label='Añadir un país o región']")));
            Wait.Until(ExpectedConditions.ElementExists(By.XPath("//label[text()='Mexico' or text()='México']")));
            LinkedIn_Search.fnGetRegionMexico();
            LinkedIn_Search.fnGetAddCountry("Italy");
            Wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@class='basic-typeahead__triggered-content search-s-add-facet__typeahead-tray']")));
            Wait.Until(ExpectedConditions.TextToBePresentInElement(LinkedIn_Search.GetItalyDropDown(), "Italy"));
            LinkedIn_Search.fnGetItaly();
            // Step 5- Select Languages
            LinkedIn_Search.fnGetLanguageEnglish();
            LinkedIn_Search.fnSelectLanguages();
            // Step 6 - Apply Filters
            LinkedIn_Search.fnGetApplyBtn();
            // Step 7 - Look for Technologies & Print
            foreach (string Technologies in arrTechnologies)
            {
                LinkedIn_Search.fnGetSrchFld(Technologies);
                Wait.Until(ExpectedConditions.ElementExists(By.XPath("//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']")));
                LinkedIn_Search.fnGetTechnology();
            }
        }
    }
}