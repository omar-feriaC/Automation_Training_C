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
        //Variables
        private static WebDriverWait _objWait;
        private static IWebDriver _objDriver;

        //Constructor
        public clsLinkedIn_SearchPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _objWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 30));
        }

        //Locators Definition
        readonly static string STR_SEARCHBOX = "//input[@placeholder='Search']";
        readonly static string STR_SEARCHBUTTON = "//button[@class='search-typeahead-v2__button search-global-typeahead__button']";
        readonly static string STR_PEOPLEBUTTON = "//button[@aria-label='View only People results']";
        readonly static string STR_ALLFILTERSBUTTON = "//button[@data-control-name='all_filters']";
        readonly static string STR_LOCATIONS = "//input[@placeholder='Add a country/region']";
        readonly static string STR_APPLYFILTERSBUTTON = "//button[@data-control-name='all_filters_apply']";
        readonly static string STR_LOCATIONFILTERMX = "//span[starts-with(@class, 'search-typeahead') and (text()= 'Mexico' or text()='México')]";
        readonly static string STR_LOCATIONFILTERIT = "//span[starts-with(@class, 'search-typeahead') and (text()= 'Italy' or text()='Italia')]";
        readonly static string STR_GETNAME_TAG = "(//span[@class='name actor-name'])[1]";
        readonly static string STR_GETROLE_TAG = "(//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']//span[@dir='ltr'])[1]";
        readonly static string STR_GETURL_TAG = "(//a[@class=search-result__result-link loading disabled ember-view])[1]";



        //WebElements Definition
        private static IWebElement objSearchBoxTxt => _objDriver.FindElement(By.XPath(STR_SEARCHBOX));
        private static IWebElement objSearchButtonBtn => _objDriver.FindElement(By.XPath(STR_SEARCHBUTTON));
        private static IWebElement objPeopleButtonBtn => _objDriver.FindElement(By.XPath(STR_PEOPLEBUTTON));
        private static IWebElement objAllFiltersButtonBtn => _objDriver.FindElement(By.XPath(STR_ALLFILTERSBUTTON));
        private static IWebElement objLocationsTxt => _objDriver.FindElement(By.XPath(STR_LOCATIONS));
        private static IWebElement objApplyFiltersButtonBtn => _objDriver.FindElement(By.XPath(STR_APPLYFILTERSBUTTON));
        private static IWebElement objLocationFilterMxLst => _objDriver.FindElement(By.XPath(STR_LOCATIONFILTERMX));
        private static IWebElement objLocationFilterItLst => _objDriver.FindElement(By.XPath(STR_LOCATIONFILTERIT));
        public static IWebElement objGetNameTag => _objDriver.FindElement(By.XPath(STR_GETNAME_TAG));
        public static IWebElement objGetRoleTag => _objDriver.FindElement(By.XPath(STR_GETROLE_TAG));
        public static IWebElement objGetUrlTag => _objDriver.FindElement(By.XPath(STR_GETURL_TAG));


        //Methods
        //Serch box
        private IWebElement fnGetSearchBox()
        {
            return objSearchBoxTxt;
        }

        public static void fnEnterSearch(string pstrSearchBox)
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SEARCHBOX)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SEARCHBOX)));
                objSearchBoxTxt.Clear();
                objSearchBoxTxt.SendKeys(pstrSearchBox);
                objSearchBoxTxt.SendKeys(Keys.Enter);
            }
            catch (Exception e)
            {
                Console.WriteLine("The element SearchBox does not exist. Error code: " + e.Message);
                Assert.Fail();
            }

        }

        //Search button
        private IWebElement fnGetSearchButton()
        {
            return objSearchButtonBtn;
        }

        public static void fnClickSearchButton()
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SEARCHBUTTON)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SEARCHBUTTON)));
                objSearchButtonBtn.Click();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("The element searchButton does not exist. Error code: " + e.Message);
                Assert.Fail();
            }

        }

        //People button
        private IWebElement fnGetPeopleButton()
        {
            return objPeopleButtonBtn;
        }

        public static void fnClickPersonButton()
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_PEOPLEBUTTON)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_PEOPLEBUTTON)));
                objPeopleButtonBtn.Click();
                Thread.Sleep(2000);

            }
            catch (Exception e)
            {
                Console.WriteLine("The element peopleButton does not exist. Error code: " + e.Message);
                Assert.Fail();
            }

        }

        //All filters button
        private IWebElement fnGetAllFiltersButton()
        {
            return objAllFiltersButtonBtn;
        }

        public static void fnClickAllFiltersButton()
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ALLFILTERSBUTTON)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ALLFILTERSBUTTON)));
                objAllFiltersButtonBtn.Click();
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine("The element allFiltersButton does not exist. Error code: " + e.Message);
                Assert.Fail();
            }

        }

        //Locations input
        private IWebElement fnGetLocations()
        {
            return objLocationsTxt;
        }

        public static void fnEnterLocationsMx(string pstrLocationsMx)
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOCATIONS)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOCATIONS)));
                objLocationsTxt.Click();
                objLocationsTxt.Clear();
                objLocationsTxt.SendKeys(pstrLocationsMx);

                
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOCATIONFILTERMX)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOCATIONFILTERMX)));
                objLocationFilterMxLst.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("The element locations does not exist. Error code: " + e.Message);
                Assert.Fail();
            }

        }

        //Locations Italy
        private IWebElement fnGetLocationsIt()
        {
            return objLocationsTxt;
        }

        public static void fnEnterLocationsIt(string pstrLocationsIt)
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOCATIONS)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOCATIONS)));
                objLocationsTxt.Click();
                objLocationsTxt.Clear();
                objLocationsTxt.SendKeys(pstrLocationsIt);


                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOCATIONFILTERIT)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOCATIONFILTERIT)));
                objLocationFilterItLst.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("The element locations does not exist. Error code: " + e.Message);
                Assert.Fail();
            }

        }

        //Apply Filters
        private IWebElement fnGetApplyFIlters()
        {
            return objApplyFiltersButtonBtn;
        }

        public static void fnApplyFilters()
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_APPLYFILTERSBUTTON)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_APPLYFILTERSBUTTON)));
                objApplyFiltersButtonBtn.Click();
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine("The element locations does not exist. Error code: " + e.Message);
                Assert.Fail();
            }

        }

        //Get results information
        public IWebElement fnGetName()
        {
            return objGetNameTag;
            
        }

        public static void fnGetNameInfo()
        {
            try
            {
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_GETNAME_TAG)));
                //_objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_GETNAME_TAG)));
                String strGetName = _objDriver.FindElement(By.XPath(STR_GETNAME_TAG)).Text;
                Console.WriteLine("Name: " + strGetName);
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine("The element locations does not exist. Error code: " + e.Message);
                Assert.Fail();
            }

        }


        public IWebElement fnGetRole()
        {
            return objGetRoleTag;
        }

        public static void fnGetRoleInfo()
        {
            try
            {
                _objWait.Until(objGetUrlTag => _objDriver.FindElement(By.XPath(STR_GETROLE_TAG)));
                //_objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_GETROLE_TAG)));
                String strGetRole = _objDriver.FindElement(By.XPath(STR_GETROLE_TAG)).Text;
                Console.WriteLine("Role: " + strGetRole);
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine("The element locations does not exist. Error code: " + e.Message);
                Assert.Fail();
            }

        }



        public IWebElement fnGetUrl()
        {
            return objGetUrlTag;
        }

        public static void fnGetUrlInfo()
        {
            try
            {
                _objWait.Until(objGetUrlTag => _objDriver.FindElement(By.XPath(STR_GETURL_TAG)));
                //_objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_GETURL_TAG)));
                String strGetUrl = _objDriver.FindElement(By.XPath(STR_GETURL_TAG)).Text;
                Console.WriteLine("URL: " + strGetUrl);
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine("The element locations does not exist. Error code: " + e.Message);
                Assert.Fail();
            }

        }
    }
}
