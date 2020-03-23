using AutomationFrameworkC.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Page_Objects
{
    class clsLinkedIn_SearchPage : BaseTest
    {
        #region variables
        //Variables
        private static WebDriverWait objWait;
        private static IWebDriver _objDriver;
        //private static clsLinkedIn_LoginPage objLogin; 
        #endregion variables
        #region Constructor
        public clsLinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            objWait = new WebDriverWait(objDriver, new TimeSpan (0, 0, 30));
        }
        #endregion Constructor
        #region Elements

        readonly static string SRT_SEARCH = "//input[@class='search-global-typeahead__input always-show-placeholder']";
        readonly static string STR_PEOPLE = "//span[text()='Gente' or text()='People']";
        readonly static string STR_ALLFILTERS = "//span[text()='Todos los filtros' or text()='All Filters']";
        readonly static string STR_ALLFILTERSOPTIONS = "//div[@class='artdeco-modal__content search-advanced-facets__content-container artdeco-modal__content ember-view']";
        readonly static string STR_ADDCOUNTRYREGION = "(//input[(@placeholder='Add a country/region' or 'Añadir un país o región') and (@aria-autocomplete='list') and (@role='combobox') and (@type='text')])[3]";
        readonly static string STR_SELECTMEXICO = "//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'México' or 'Mexico']";
        readonly static string STR_SELECTITALIA = "//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy' or 'Italia']";
        readonly static string STR_APPLYFILTERS = "//span[text()='Apply' or text()='Aplicar'][1]";
        public static readonly string STR_MEMBER_NAMES = "//span[@class='actor-name']";
        public static readonly string STR_MEMBER_ROLES = "//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']";
        public static readonly string STR_MEMBER_URLS = "//div[@class='search-result__info pt3 pb4 ph0']//a[@href]";
        public static readonly string STR_MEMBER_RESULTS = "//div[@class='search-results-container']";
        
        private static IWebElement objSearchTxt => _objDriver.FindElement(By.XPath(SRT_SEARCH));
        private static IWebElement objPeopleBtn => _objDriver.FindElement(By.XPath(STR_PEOPLE));
        private static IWebElement objAllFiltersBtn => _objDriver.FindElement(By.XPath(STR_ALLFILTERS));
        private static IWebElement objAllFiltersOptionTxt => _objDriver.FindElement(By.XPath(STR_ALLFILTERSOPTIONS));
        private static IWebElement objAddCountryRegionTxt => _objDriver.FindElement(By.XPath(STR_ADDCOUNTRYREGION));
        private static IWebElement objSelectMexicoBtn => _objDriver.FindElement(By.XPath(STR_SELECTMEXICO));
        private static IWebElement objSelectItalyBtn => _objDriver.FindElement(By.XPath(STR_SELECTITALIA));
        private static IWebElement objApplyFilters => _objDriver.FindElement(By.XPath(STR_APPLYFILTERS));
        private static IList<IWebElement> objMemberNamesTxt;
        private static IList<IWebElement> objMemberRolesTxt;
        private static IList<IWebElement> objMemberURLsTxt;
        private static IWebElement objMemberResultsTxt => _objDriver.FindElement(By.XPath(STR_MEMBER_RESULTS));
        #endregion Elements
        #region Methods
        #region Search field
        
        private IWebElement fnGetSearchField()
        {
            return objSearchTxt;
        }
        public static void fnSearchData(string pstrSearchValue)
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(SRT_SEARCH)));
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(SRT_SEARCH)));
                objSearchTxt.Clear();
                objSearchTxt.SendKeys(pstrSearchValue);
                objSearchTxt.SendKeys(Keys.Enter);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element to input a search does not exist: " + e.Message);
                Assert.Fail();
            }
        }
        #endregion Search field
        #region People Button
       
        private IWebElement fnGetPeopleBtn()
        {
            return objPeopleBtn;
        }
        public static void fnClickPeopleBtn()
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_PEOPLE)));
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_PEOPLE)));
                objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_PEOPLE)));
                objPeopleBtn.Click();
                objWait.Until(ExpectedConditions.UrlContains("people"));
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element People Button does not exist: " + e.Message);
                Assert.Fail();
            }
        }
        #endregion People Button
        #region All filters Button
        
        private IWebElement fnGetAllFiltersBtn()
        {
            return objAllFiltersBtn;
        }
        private IWebElement fnGetAllFiltersOptionTxt()
        {
            return objAllFiltersOptionTxt;
        }
        public static void fnClickAllFiltersBtn()
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ALLFILTERS)));
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ALLFILTERS)));
                objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ALLFILTERS)));
                objAllFiltersBtn.Click();
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ALLFILTERSOPTIONS)));
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element All Filters Button does not exist: " + e.Message);
                Assert.Fail();
            }
        }
        #endregion All filters Button
        #region Search Locations
      
        private IWebElement fnGetAddCountryRegionField()
        {
            return objAddCountryRegionTxt;
        }
        private IWebElement fnGetSelectMexicoBtn()
        {
            return objSelectMexicoBtn;
        }
        private IWebElement fnGetSelectItalyBtn()
        {
            return objSelectItalyBtn;
        }
        public static void fnAddCountryRegion(List<string> plistcountries)
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ADDCOUNTRYREGION)));
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ADDCOUNTRYREGION)));
                objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ADDCOUNTRYREGION)));
                objAddCountryRegionTxt.Clear();
                objAddCountryRegionTxt.SendKeys(plistcountries[0]);
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SELECTITALIA)));
                objSelectItalyBtn.Click();
                objAddCountryRegionTxt.SendKeys(plistcountries[1]);
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SELECTMEXICO)));
                objSelectMexicoBtn.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element Add a country/region does not exist: " + e.Message);
                Assert.Fail();
            }
        }
        #endregion Search Locations
        #region Apply Filters
        
        private IWebElement fnGetApplyFiltersBtn()
        {
            return objApplyFilters;
        }
        public static void fnClickApplyFilters()
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_APPLYFILTERS)));
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_APPLYFILTERS)));
                objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_APPLYFILTERS)));
                objApplyFilters.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element Apply Filters does not exist: " + e.Message);
                Assert.Fail();
            }
        }
        #endregion Apply Filters
        #region Search 5 technologies
      
        private IWebElement fnGetMemberResults()
        {
            return objMemberResultsTxt;
        }
        public static void fnMultipleSearch(string[] pstringArrTechnologies)
        {
            try
            {
                
                objWait.Until(ExpectedConditions.UrlContains("facetGeoRegion"));
                for (int i = 0; i < pstringArrTechnologies.Length; i++)
                {
                    fnSearchData(pstringArrTechnologies[i]);
                    objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MEMBER_RESULTS)));
                    objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_MEMBER_RESULTS)));
                    objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MEMBER_NAMES)));
                    objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_MEMBER_NAMES)));
                    objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MEMBER_ROLES)));
                    objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_MEMBER_ROLES)));
                    objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MEMBER_URLS)));
                    objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_MEMBER_URLS)));
                    objWait.Until(ExpectedConditions.StalenessOf(_objDriver.FindElement(By.XPath(STR_MEMBER_URLS))));
                    
                    objMemberNamesTxt = _objDriver.FindElements(By.XPath(STR_MEMBER_NAMES));
                    objMemberRolesTxt = _objDriver.FindElements(By.XPath(STR_MEMBER_ROLES));
                    objMemberURLsTxt = _objDriver.FindElements(By.XPath(STR_MEMBER_URLS));

                    for (int j = 0; j < objMemberNamesTxt.Count; j++)
                    {
                        Console.WriteLine("=================================================");
                        Console.WriteLine("Tech: {0}", pstringArrTechnologies[i]);
                        Console.WriteLine("Full Name: {0}", objMemberNamesTxt[j].Text);
                        Console.WriteLine("Role: {0}", objMemberRolesTxt[j].Text);
                        Console.WriteLine("URL profile: {0}", objMemberURLsTxt[j].GetAttribute("href"));
                        Console.WriteLine();
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The Search of the technology is not possible " + e.Message);
                Assert.Fail();
            }
        }
        #endregion Search 5 technologies        
        #endregion Methods
    }

}