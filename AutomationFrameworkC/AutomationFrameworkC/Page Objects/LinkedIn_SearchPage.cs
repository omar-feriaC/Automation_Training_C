using AutomationFrameworkC.Base_Files;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Page_Objects
{
    class M8LinkedIn_SearchPage : BaseTest
    {
        //DRIVER REFERENCE
        private static IWebDriver _objDriver;
        public M8LinkedIn_SearchPage(IWebDriver driver)
        {
            _objDriver = driver;
        }

        //ELEMENT LOCATORS
        private static readonly string STR_SEARCH_TEXTFIELD = "search-global-typeahead__input";
        private static readonly string STR_SEARCH_BUTTON = "search-global-typeahead__controls";
        private static readonly string STR_PEOPLE_BUTTON = "//button[span[text()='Gente' or text()='People']]";
        private static readonly string STR_ALLFILTER_BUTTON = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
        private static readonly string STR_APPLY_BUTTON = "//button[span[text()='Apply' or text()='Aplicar']]";
        private static readonly string STR_MEXICO_OPT = "//*[label[text()='Mexico' or text()='México']]";
        private static readonly string STR_ENGLISH_OPT = "//*[label[text()='Inglés' or text()='English']]";
        private static readonly string STR_SPANISH_OPT = "//*[label[text()='Español' or text()='Spanish']]";



        //PAGE ELEMENT OBJECTS
        private static IWebElement objSearchTextField => _objDriver.FindElement(By.ClassName(STR_SEARCH_TEXTFIELD));
        private static IWebElement objSearchButton => _objDriver.FindElement(By.ClassName(STR_SEARCH_BUTTON));
        private static IWebElement objPeopleButton => _objDriver.FindElement(By.XPath(STR_PEOPLE_BUTTON));
        private static IWebElement objAllFiltersButton => _objDriver.FindElement(By.XPath(STR_ALLFILTER_BUTTON));
        private static IWebElement objMexicoOpt => _objDriver.FindElement(By.XPath(STR_MEXICO_OPT));
        private static IWebElement objEnglishOpt => _objDriver.FindElement(By.XPath(STR_ENGLISH_OPT));
        private static IWebElement objSpanishOpt => _objDriver.FindElement(By.XPath(STR_SPANISH_OPT));
        private static IWebElement objApplyButton => _objDriver.FindElement(By.XPath(STR_APPLY_BUTTON));

        //GET ELEMENT METHODS
        public IWebElement GetSearchTextField()
        {
            return objSearchTextField;
        }
        public IWebElement GetSearchButton()
        {
            return objSearchButton;
        }
        public IWebElement GetPeopleButton()
        {
            return objPeopleButton;
        }
        public IWebElement GetAllFiltersButton()
        {

            return objAllFiltersButton;
        }
        public IWebElement getMexicoOpt()
        {

            return objMexicoOpt;
        }
        public IWebElement getEnglishOpt()
        {

            return objEnglishOpt;
        }
        public IWebElement getSpanishOpt()
        {

            return objSpanishOpt;
        }
        public IWebElement GetAplyButton()
        {

            return objApplyButton;
        }

        //PAGE ELEMENT ACTIONS
        public void fnSearchText(string pstrSearchString)
        {
            objSearchTextField.Clear();
            objSearchTextField.SendKeys(pstrSearchString);
        }

        public void fnSearchButton()
        {
            objSearchButton.Click();
        }

        public void fnPeopleButton()
        {
            objPeopleButton.Click();
        }

        public void fnAllFiltersButton()
        {
            objAllFiltersButton.Click();
        }

        public void fnMexicoOpt()
        {
            objMexicoOpt.Click();
        }

        public void fnEnglishOpt()
        {
            objEnglishOpt.Click();
        }

        public void fnSpanishOpt()
        {
            objSpanishOpt.Click();
        }

        public void fnApplyButton()
        {
            objApplyButton.Click();
        }

    }
}
