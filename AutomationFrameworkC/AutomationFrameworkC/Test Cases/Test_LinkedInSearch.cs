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
    class Test_LinkedInSearch : LinkedIn_SearchPage 
    {

        //VARIABLES
        string[] arrTechnologies = { "Java", "C#", "C++", "Pega", "Cobol" };
        string[] arrLanguages = { "Spanish", "English" };
        private IWebElement objFindTx;
        private string strSearch;
        private static readonly string strGetName_Xpath = "//*[contains(@class,'actor-name')]";
        private static readonly string strGetRole_Xpath = "//*[contains(@class,'subline-level-1')]";
        private static readonly string strGetLink_Xpath = "//*[contains(@class,'search-result__result-link')]";

        private static IWebElement objGetName => objDriver.FindElement(By.XPath(strGetName_Xpath));
        private static IWebElement objGetRole => objDriver.FindElement(By.XPath(strGetRole_Xpath));
        private static IWebElement objGetLink => objDriver.FindElement(By.XPath(strGetLink_Xpath));

        public IWebElement GetResultName()
        {
            return objGetName;
        }

        public IWebElement GetResultRole()
        {
            return objGetRole;
        }

        public IWebElement GetResultLink()
        {
            return objGetLink;
        }

        public IWebElement GetBuscarText()
        {
            return objFindTx;
        }

        public void fnInsertSearch(string pstrInsertSearch)
        {
            objFindTx.Clear();
            objFindTx.SendKeys(pstrInsertSearch);
            objFindTx.SendKeys(Keys.Enter);
        }

        [Test]
        public void fnSearchByTechnologies()
        {
            for (int i = 0; i < arrTechnologies.Count(); i++)
            {
                strSearch = arrTechnologies.ElementAt(i);
                fnInsertSearch(strSearch);

                Console.WriteLine("Name: " + objGetName.Text.ToString());
                Console.WriteLine("Role: " + objGetRole.Text.ToString());
                Console.WriteLine("Link URL Profile: " + GetResultLink().GetAttribute("href"));
                Thread.Sleep(3000);

            }
        }
    }
}
