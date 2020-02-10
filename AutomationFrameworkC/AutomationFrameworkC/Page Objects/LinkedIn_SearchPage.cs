using AutomationFrameworkC.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Page_Objects
{
    class LinkedIn_SearchPage : BaseTest
    {
       
        //Variables
        private static IWebDriver _objDriver;

        //Constructor
        public LinkedIn_SearchPage(IWebDriver driver)
        {
            _objDriver = driver;
        }

        //Locators Definitions
        private static readonly string STR_SEARCH_TEXTFIELD = "search-global-typeahead__input";
        private static readonly string STR_SEARCH_BUTTON = "search-global-typeahead__controls";
        private static readonly string STR_PEOPLE_BUTTON = "//button[span[text()='Gente' or text()='People']]";
        private static readonly string STR_ALLFILTER_BUTTON = "//button[span[text()='All Filters' or text()='Todos los filtros']]";
        private static readonly string STR_APPLY_BUTTON = "//button[span[text()='Apply' or text()='Aplicar']]";
        private static readonly string STR_MEX_OPT = "//*[label[text()='Mexico' or text()='México']]";
        private static readonly string STR_ITA_OPT = "//*[label[text()='Italy']]";
        private static readonly string STR_ENG_OPT = "//*[label[text()='Inglés' or text()='English']]";
        private static readonly string STR_SPA_OPT = "//*[label[text()='Español' or text()='Spanish']]";


        
        //Web Elements Definitions
        private static IWebElement objSearchTextField => _objDriver.FindElement(By.ClassName(STR_SEARCH_TEXTFIELD));
        private static IWebElement objSearchButton => _objDriver.FindElement(By.ClassName(STR_SEARCH_BUTTON));
        private static IWebElement objPeopleButton => _objDriver.FindElement(By.XPath(STR_PEOPLE_BUTTON));
        private static IWebElement objAllFiltersButton => _objDriver.FindElement(By.XPath(STR_ALLFILTER_BUTTON));
        private static IWebElement objMxOpt => _objDriver.FindElement(By.XPath(STR_MEX_OPT));
        private static IWebElement objItOpt => _objDriver.FindElement(By.XPath(STR_ITA_OPT));
        private static IWebElement objEngOpt => _objDriver.FindElement(By.XPath(STR_ENG_OPT));
        private static IWebElement objSpOpt => _objDriver.FindElement(By.XPath(STR_SPA_OPT));
        private static IWebElement objApplyButton => _objDriver.FindElement(By.XPath(STR_APPLY_BUTTON));

        //Methods
        //Search Text Field
        public IWebElement GetSearchTextField()
        {
            return objSearchTextField;
        }

        //Searcg Button
        public IWebElement GetSearchButton()
        {
            return objSearchButton;
        }

        //People or Gente button
        public IWebElement GetPeopleButton()
        {
            return objPeopleButton;
        }

        //All Filters Button
        public IWebElement GetAllFiltersButton()
        {
            return objAllFiltersButton;
        }

        //Mexico Option
        public IWebElement getMxOpt()
        {
            return objMxOpt;
        }

        //Italy Option
        public IWebElement getItOpt()
        {
            return objMxOpt;
        }

        //English Option
        public IWebElement getEngOpt()
        {
            return objEngOpt;
        }

        //Spanish Option 
        public IWebElement getSpOpt()
        {
            return objSpOpt;
        }

        //Apply button
        public IWebElement GetAplyButton()
        {
            return objApplyButton;
        }

        //Actions
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
            objMxOpt.Click();
        }

        public void fnItalyOpt()
        {
            objItOpt.Click();
        }

        public void fnEnglishOpt()
        {
            objEngOpt.Click();
        }

        public void fnSpanishOpt()
        {
            objSpOpt.Click();
        }

        public void fnApplyButton()
        {
            objApplyButton.Click();
        }


    }
}
