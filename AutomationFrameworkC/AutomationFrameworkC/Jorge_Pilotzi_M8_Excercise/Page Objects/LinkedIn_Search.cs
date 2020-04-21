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
        private static IWebDriver _ObjSrchDriver;
        
        //Locators for all the elements

        readonly static string STR_SRCH_TEXT = "//*[@class='nav-search-bar']//input";
        readonly static string STR_SRCH_BTN = "//div[@class='search-global-typeahead__controls']";
        readonly static string STR_PEOPLE_BTN = "//span[text()='People' or text()='Gente']";
        readonly static string STR_ALLFILTERS_BTN = "//span[text()='All Filters' or text()='Todos los filtros']";
        readonly static string STR_REGIONMEXICO_CHECKBOX = "//label[text()='Mexico' or text()='México']";
        readonly static string STR_LANGUAGE_ENG_CHECKBOX = "//label[text()='English' or text()='Ingles']";
        readonly static string STR_LANGUAGE_ESP_CHECKBOX = "//label[text()='Spanish' or text()='Español']";
        readonly static string STR_APPLY_BTN = "//button[@data-control-name='all_filters_apply']";
        readonly static string STR_ADDCOUNTTRY_TEXT = "//input[@aria-label='Add a country/region' or @aria-label='Añadir un país o región']";
        readonly static string STR_SELECT_ITALY_DROPDOWN = "//*[@class='search-basic-typeahead search-vertical-typeahead ember-view']//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'Italy' or 'Italia']";

        //Constructor

        public LinkedIn_Search(IWebDriver pobjSrchDriver)
        {
            _ObjSrchDriver = pobjSrchDriver;
        }
        private static IWebElement objSrchText => _ObjSrchDriver.FindElement(By.XPath(STR_SRCH_TEXT));
        private static IWebElement objSrchBtn => _ObjSrchDriver.FindElement(By.XPath(STR_SRCH_BTN));
        private static IWebElement objPeopleBtn => _ObjSrchDriver.FindElement(By.XPath(STR_PEOPLE_BTN));
        private static IWebElement objAllFiltersBtn => _ObjSrchDriver.FindElement(By.XPath(STR_ALLFILTERS_BTN));
        private static IWebElement objRegionMexicoCheckBox => _ObjSrchDriver.FindElement(By.XPath(STR_REGIONMEXICO_CHECKBOX));
        private static IWebElement objLangEngCheckBox => _ObjSrchDriver.FindElement(By.XPath(STR_LANGUAGE_ENG_CHECKBOX));
        private static IWebElement objLangEspCheckBox => _ObjSrchDriver.FindElement(By.XPath(STR_LANGUAGE_ESP_CHECKBOX));
        private static IWebElement objApplyBtn => _ObjSrchDriver.FindElement(By.XPath(STR_APPLY_BTN));
        private static IWebElement objAddCountryTxt => _ObjSrchDriver.FindElement(By.XPath(STR_ADDCOUNTTRY_TEXT));
        private static IWebElement objSelectITalyDropDown => _ObjSrchDriver.FindElement(By.XPath(STR_SELECT_ITALY_DROPDOWN));
        private static IWebElement objItalyDropDown => _ObjSrchDriver.FindElement(By.XPath("//div[@class='basic-typeahead__triggered-content search-s-add-facet__typeahead-tray']"));

        //Methods

        //Search Text

        private IWebElement GetSearchFld()
        {
            return objSrchText;
        }

        public static void FnGetSrchFld(string pstrSrchFld)
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

        public static void FnGetSrchBtn()
        {
            objSrchBtn.Click();
        }

        //People Checkbox
        private IWebElement GetPeopleCheckBox()
        {
            return objPeopleBtn;
        }

        public static void FnSelectPeopleCheckbox()
        {
            objPeopleBtn.Click();
        }

        //All Filters

        private IWebElement GetAllFiltersBtn()
        {
            return objAllFiltersBtn;
        }

        public static void FnGetAllFiltersBtn ()
        {
            objAllFiltersBtn.Click();
        }

        //Region Mexico

        private IWebElement GetRegionMexico()
        {
            return objRegionMexicoCheckBox;
        }

        public static void FnGetRegionMexico()
        {
            objRegionMexicoCheckBox.Click();
        }

        //Language spanish

        private IWebElement GetLanguageSpanish()
        {
            return objLangEspCheckBox;
        }

        public static void FnGetLanguageSpanish()
        {
            objLangEspCheckBox.Click();
        }

        //Filters Apply

        private IWebElement GetApplyBtn()
        {
            return objApplyBtn;
        }

        public static void FnGetApplyBtn()
        {
            objApplyBtn.Click();
        }

        // Add Country

        private IWebElement GetAddCountry()
        {
            return objAddCountryTxt;
        }

        public static void FnGetAddCountry(string pstrAddCountry)
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

        public static void FnGetItaly()
        {
            objSelectITalyDropDown.Click();
        }

        public static void FnSelectLanguages()
        {
            IWebElement objSelectLanguages = _ObjSrchDriver.FindElement(By.XPath($"//label[text()='Spanish' or text()='Español']"));
            objSelectLanguages.Click();
        }

        public static IWebElement GetItalyDropDown()
        {
            return objItalyDropDown;
        }

        //Select TEchnology

        public static void FnGetTechnology()
        {
            IList<IWebElement> objName = _ObjSrchDriver.FindElements(By.XPath("//span[@class='actor-name']"));
            IList<IWebElement> objRole = _ObjSrchDriver.FindElements(By.XPath("//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']"));
            IList<IWebElement> objURL = _ObjSrchDriver.FindElements(By.XPath("//div[@class='search-result__info pt3 pb4 ph0']//a[@href]"));

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
