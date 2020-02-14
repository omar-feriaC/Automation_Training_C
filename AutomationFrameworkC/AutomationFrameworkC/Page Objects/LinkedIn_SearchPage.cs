using AutomationFrameworkC.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Page_Objects
{
    class LinkedIn_SearchPage : BaseTest
    {
        private static IWebDriver _objDriver;
        WebDriverWait _objwait;

        public LinkedIn_SearchPage(IWebDriver driver)
        {
            _objDriver = driver;
            _objwait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 60));
        }

        private static readonly string strSearchField = "//input[@class='search-global-typeahead__input always-show-placeholder']";
        private static readonly string strPeopleBtn = "//span[text()='Gente' or text()='People']";
        private static readonly string strAllFilters = "//span[text()='Todos los filtros' or text()='All Filters']";
        private static readonly string strLocation = "(//input[@placeholder='Añadir un país o región'])[1]";
        private static readonly string strMex = "//span[starts-with(@class, 'search-typeahead') and (text()='México' or text()='Mexico')]";
        private static readonly string strIta = "//span[starts-with(@class, 'search-typeahead') and (text()='Italia' or text()='Italy')]";
        private static readonly string strEng = "//*[label[text()='Inglés' or text()='English']]";
        private static readonly string strSpa = "//*[label[text()='Español' or text()='Spanish']]";
        private static readonly string strApplyBtn = "//span[text()='Apply' or text()='Aplicar'][1]";
        private static readonly string strNameMember = "//span[@class='actor-name']";
        private static readonly string strRolMember = "//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']";
        private static readonly string strUrlMember = "//div[@class='search-result__info pt3 pb4 ph0']//a[@href]";

   

        private static IWebElement objSearchTx => _objDriver.FindElement(By.XPath(strSearchField));
        private static IWebElement objPeople => _objDriver.FindElement(By.XPath(strPeopleBtn));
        private static IWebElement objAllFilters => _objDriver.FindElement(By.XPath(strAllFilters));
        private static IWebElement objLocationTx => _objDriver.FindElement(By.XPath(strLocation));
        private static IWebElement objMxChk => _objDriver.FindElement(By.XPath(strMex));
        private static IWebElement objItChk => _objDriver.FindElement(By.XPath(strIta));
        private static IWebElement objEngOpt => _objDriver.FindElement(By.XPath(strEng));
        private static IWebElement objSpOpt => _objDriver.FindElement(By.XPath(strSpa));
        private static IWebElement objApply => _objDriver.FindElement(By.XPath(strApplyBtn));

        private static IList<IWebElement> objMemberNames;

        private static IList<IWebElement> objMemberRoles;

        private static IList<IWebElement> objMemberUrls;

      
        public IWebElement GetSearchTx()
        {
            return objSearchTx;
        }


        public IWebElement GetPeople()
        {
            return objPeople;
        }

   
        public IWebElement GetAllFlt()
        {
            return objAllFilters;
        }

      
        public IWebElement GetLocation()
        {
            return objLocationTx;
        }

 
        public IWebElement GetMex()
        {
            return objMxChk;
        }

   
        public IWebElement GetIta()
        {
            return objItChk;
        }

     
        public IWebElement getEng()
        {
            return objEngOpt;
        }

     
        public IWebElement getSpa()
        {
            return objSpOpt;
        }

     
        public IWebElement GetApplyAllFilters()
        {
            return objApply;
        }


   
        public void fnDataSearch(string pSearchData)
        {
            objSearchTx.Clear();
            objSearchTx.SendKeys(pSearchData);
            objSearchTx.SendKeys(Keys.Enter);
        }

        public void fnClickPpl()
        {
            _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(strPeopleBtn)));
            objPeople.Click();
        }

        public void fnClickAllFilters()
        {
            _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(strAllFilters)));
            objAllFilters.Click();
        }
        public void fnLocation(string pstrLocationTextBox)
        {
            _objwait.Until(ExpectedConditions.ElementExists(By.XPath(strLocation)));
            _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(strLocation)));
            objLocationTx.Clear();
            objLocationTx.SendKeys(pstrLocationTextBox); ;
        }
        public void fnMexicoOpt()
        {
            _objwait.Until(ExpectedConditions.ElementExists(By.XPath(strMex)));
            _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(strMex)));
            _objwait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(strMex)));
            objMxChk.Click();
        }

        public void fnItalyOpt()
        {
            _objwait.Until(ExpectedConditions.ElementExists(By.XPath(strIta)));
            _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(strIta)));
            _objwait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(strIta)));
            objItChk.Click();
        }

        public void fnEnglishOpt()
        {
            objEngOpt.Click();
        }

        public void fnSpanishOpt()
        {
            objSpOpt.Click();
        }
        public void fnApplyFilters()
        {
            _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(strApplyBtn)));
            objApply.Click();
            _objwait.Until(ExpectedConditions.UrlContains("facetGeoRegion"));
        }
        public IList<IWebElement> GetNames()
        {
            return objMemberNames;
        }
        public IList<IWebElement> GetRoles()
        {
            return objMemberRoles;
        }
        public IList<IWebElement> GetUrls()
        {
            return objMemberUrls;
        }

        public void fnTechnologies()
        {
            string[] arrTechnologies = { "Java","Pega", "C#", "Phyton", "SQL" };

            for (int i = 0; i < arrTechnologies.Length; i++)
            {
                fnDataSearch(arrTechnologies[i]);

               _objwait.Until(ExpectedConditions.ElementExists(By.XPath(strNameMember)));
               _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(strNameMember)));
                _objwait.Until(ExpectedConditions.ElementExists(By.XPath(strRolMember)));
                _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(strRolMember)));
                _objwait.Until(ExpectedConditions.ElementExists(By.XPath(strUrlMember)));
                _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(strUrlMember)));
                _objwait.Until(ExpectedConditions.StalenessOf(_objDriver.FindElement(By.XPath(strUrlMember))));

                objMemberNames = _objDriver.FindElements(By.XPath(strNameMember));
                objMemberRoles = _objDriver.FindElements(By.XPath(strRolMember));
                objMemberUrls = _objDriver.FindElements(By.XPath(strUrlMember));

                for (int j = 0; j < objMemberNames.Count; j++)
                {
                    Console.WriteLine("Technology: {0}", arrTechnologies[i]);
                    Console.WriteLine("Name: {0}", objMemberNames[j].Text);
                    Console.WriteLine("Role: {0}", objMemberRoles[j].Text);
                    Console.WriteLine("URL: {0}", objMemberUrls[j].GetAttribute("href"));
                   
                    
                }
            }
        }
    }
}
