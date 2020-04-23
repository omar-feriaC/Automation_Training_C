using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.BaseFiles;

namespace AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.Page_Objects
{
    class LinkedIn_Search : BaseTest 
    {
        private static IWebDriver _objSrchDriver;
        //Locators for all the elements
        readonly static string STR_SRCH_TEXT = "//*[@class='nav-search-bar']//input";
        readonly static string STR_SRCH_BTN = "//div[@class='search-global-typeahead__controls']";
        readonly static string STR_PEOPLE_BTN = "//span[text()='People' or text()='Gente']";
        readonly static string STR_ALLFILTERS_BTN = "//span[text()='All Filters' or text()='Todos los filtros']";
        readonly static string STR_REGIONMEXICO_CHECKBOX = "//label[text()='Mexico' or text()='México']";
        readonly static string STR_APPLY_BTN = "//button[@data-control-name='all_filters_apply']";
        readonly static string STR_ADDCOUNTTRY_TEXT = "//input[@aria-label='Add a country/region' or @aria-label='Añadir un país o región']";
        readonly static string STR_SELECT_ITALY_DROPDOWN = "//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy' or 'Italia']";
        //Constructor
        public LinkedIn_Search(IWebDriver pobjSrchDriver)
        {
            WebDriverWait Wait;
            Wait = new WebDriverWait(driver, new TimeSpan(0, 1, 20));
            _objSrchDriver = pobjSrchDriver;
        }
        private static IWebElement objSrchText => _objSrchDriver.FindElement(By.XPath(STR_SRCH_TEXT));
        private static IWebElement objSrchBtn => _objSrchDriver.FindElement(By.XPath(STR_SRCH_BTN));
        private static IWebElement objPeopleBtn => _objSrchDriver.FindElement(By.XPath(STR_PEOPLE_BTN));
        private static IWebElement objAllFiltersBtn => _objSrchDriver.FindElement(By.XPath(STR_ALLFILTERS_BTN));
        private static IWebElement objRegionMexicoCheckBox => _objSrchDriver.FindElement(By.XPath(STR_REGIONMEXICO_CHECKBOX));
        private static IWebElement objApplyBtn => _objSrchDriver.FindElement(By.XPath(STR_APPLY_BTN));
        private static IWebElement objAddCountryTxt => _objSrchDriver.FindElement(By.XPath(STR_ADDCOUNTTRY_TEXT));
        private static IWebElement objSelectITalyDropDown => _objSrchDriver.FindElement(By.XPath(STR_SELECT_ITALY_DROPDOWN));
        private static IWebElement objItalyDropDown => _objSrchDriver.FindElement(By.XPath("//div[@class='basic-typeahead__triggered-content search-s-add-facet__typeahead-tray']"));
        //Methods
        //Search Text
        private IWebElement GetSearchFld()
        {
            return objSrchText;
        }
        public static void fnGetSrchFld(string pstrSrchFld)
        {
            objSrchText.Clear();
            objSrchText.SendKeys(pstrSrchFld);
            objSrchText.SendKeys(Keys.Enter);
        }
        //Search Btn
        private IWebElement GetSrchBtn()
        {
            return objSrchBtn;
        }
        public static void fnGetSrchBtn()
        {
            objSrchBtn.Click();
        }
        //People Checkbox
        private IWebElement GetPeopleCheckBox()
        {
            return objPeopleBtn;
        }
        public static void fnSelectPeopleCheckbox()
        {
            WebDriverWait Wait;
            Wait = new WebDriverWait(driver, new TimeSpan(0, 1, 20));
            Wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='People' or text()='Gente']")));
            Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='People' or text()='Gente']")));
            objPeopleBtn.Click();
        }
        //All Filters
        private IWebElement GetAllFiltersBtn()
        {
            return objAllFiltersBtn;
        }
        public static void fnGetAllFiltersBtn ()
        {
            objAllFiltersBtn.Click();
        }
        //Region Mexico
        private IWebElement GetRegionMexico()
        {
            return objRegionMexicoCheckBox;
        }
        public static void fnGetRegionMexico()
        {
            objRegionMexicoCheckBox.Click();
        }
        //Language spanish
        public static void fnGetLanguageSpanish()
        {
            IWebElement objLangEspCheckBox = _objSrchDriver.FindElement(By.XPath($"//label[text()='Spanish' or text()='Español']"));
            objLangEspCheckBox.Click();
        }
        public static void fnGetLanguageEnglish()
        {
            IWebElement objLangEngCheckBox = _objSrchDriver.FindElement(By.XPath($"//label[text()='English' or text()='Inglés']"));
            objLangEngCheckBox.Click();
        }
        //Filters Apply
        private IWebElement GetApplyBtn()
        {
            return objApplyBtn;
        }
        public static void fnGetApplyBtn()
        {
            objApplyBtn.Click();
        }
        // Add Country
        private IWebElement GetAddCountry()
        {
            return objAddCountryTxt;
        }
        public static void fnGetAddCountry(string pstrAddCountry)
        {
            objAddCountryTxt.Clear();
            objAddCountryTxt.Click();
            objAddCountryTxt.SendKeys(pstrAddCountry);
        }
        // Select italy
        private IWebElement GetItaly()
        {
            return objSelectITalyDropDown;
        }
        public static void fnGetItaly()
        {
            objSelectITalyDropDown.Click();
        }
        public static void fnSelectLanguages()
        {
            IWebElement objSelectLanguages = _objSrchDriver.FindElement(By.XPath($"//label[text()='Spanish' or text()='Español']"));
            objSelectLanguages.Click();
        }
        public static IWebElement GetItalyDropDown()
        {
            return objItalyDropDown;
        }
        //Select TEchnology
        public static void fnGetTechnology()
        {
            IList<IWebElement> objName = _objSrchDriver.FindElements(By.XPath("//span[@class='actor-name']"));
            IList<IWebElement> objRole = _objSrchDriver.FindElements(By.XPath("//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']"));
            IList<IWebElement> objURL = _objSrchDriver.FindElements(By.XPath("//div[@class='search-result__info pt3 pb4 ph0']//a[@href]"));
            for (int i = 0; i < objName.Count; i++ )
            {
                Console.WriteLine("Name: " + objName[i].Text);
                Console.WriteLine("Role: " + objRole[i].Text);
                Console.WriteLine("URL: " + objURL[i].GetAttribute("href"));
                Console.WriteLine();
            }
        }
    }
}
