using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AutomationFrameworkC.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AutomationFrameworkC.Page_Objects
{
    class LinkedIn_SearchPage
    {
        private static IWebDriver _objDriver;

        public LinkedIn_SearchPage(IWebDriver driver)
        {
            _objDriver = driver;
        }

        //ELEMENT LOCATOR//
        private static readonly string str_search_textfield_Xpath = "//input[@class='search-global-typeahead__input always-show-placeholder']";
        private static readonly string str_people_button_Xpath = "//span[text()='Todos los filtros' or text()='All Filters']";
        private static readonly string str_allFilters_button_Xpath = "//button[@class='search-filters-bar__all-filters flex-shrink-zero mr3 artdeco-button artdeco-button--muted artdeco-button--2 artdeco-button--tertiary ember-view']";
        private static readonly string str_Location_textbox_Xpath = "//input[@placeholder='Add a country/region']";
        private static readonly string str_Mexico_checkbox_Xpath = "//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'México' or 'Mexico']";
        private static readonly string str_Italy_checkbox_Xpath = "//*[@class='basic-typeahead__selectable ember-view']//span[text()= 'México' or 'Mexico']";
        // private static readonly string str_Italy_ListOption_Xpath = "//div/id[contains(@id, 'triggered-expanded-ember')][text()='Italia']";
        private static readonly string str_ApplyFilters_button_Xpath = "//button[@class='search-advanced-facets__button--apply ml4 mr2 artdeco-button artdeco-button--3 artdeco-button--primary ember-view']//following::span[1][text()='Apply']";
        private static readonly string str_member_name_Xpath = "//span[@class='actor-name']";
        private static readonly string str_member_roles_Xpath = "//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']";
        private static readonly string str_member_urls_Xpath = "//div[@class='search-result__info pt3 pb4 ph0']//a[@href]";

        /*PAGE ELEMENT OBJECTS*/
        private static IWebElement objSearchTextField => _objDriver.FindElement(By.XPath(str_search_textfield_Xpath));
        private static IWebElement objPeopleButton => _objDriver.FindElement(By.XPath(str_people_button_Xpath));
        private static IWebElement objAllFiltersButton => _objDriver.FindElement(By.XPath(str_allFilters_button_Xpath));
        private static IWebElement objMexicoCheckbox => _objDriver.FindElement(By.XPath(str_Mexico_checkbox_Xpath));
        private static IWebElement objItalyCheckbox => _objDriver.FindElement(By.XPath(str_Italy_checkbox_Xpath));
        //private static IWebElement objItalyListOption => _objDriver.FindElement(By.XPath(str_Italy_ListOption_Xpath));
        private static IWebElement objLocationTextbox => _objDriver.FindElement(By.XPath(str_Location_textbox_Xpath));
        private static IWebElement objApplyFiltersButton => _objDriver.FindElement(By.XPath(str_ApplyFilters_button_Xpath));
        private static IList<IWebElement> objMemberNames;
        private static IList<IWebElement> objMemberRoles;
        private static IList<IWebElement> objMemberUrls;

        /*GET ELEMENT METHODS*/
        public IWebElement GetSearchTextField()
        {
            return objSearchTextField;
        }

        public IWebElement GetPeopleButton()
        {
            return objPeopleButton;
        }

        public IWebElement GetAllFiltersButton()
        {
            return objAllFiltersButton;
        }

        public IWebElement GetLocationTextBox()
        {
            return objLocationTextbox;
        }

        public IWebElement GetMexicoCheckbox()
        {
            return objMexicoCheckbox;
        }

        public IWebElement GetItalyCheckbox()
        {
            return objItalyCheckbox;
        }

        //public IWebElement GetItalyListOption()
        //{
        //    return objItalyListOption;
        //}

        public IWebElement GetApplyAllFiltersButton()
        {
            return objApplyFiltersButton;
        }

        public IList<IWebElement> GetMemberNames()
        {
            return objMemberNames;
        }

        public IList<IWebElement> GetMemberRoles()
        {
            return objMemberRoles;
        }

        public IList<IWebElement> GetMemberURLs()
        {
            return objMemberUrls;
        }

        /*ELEMENT ACTIONS*/
        public void fnEnterDataInSearchTextField(string pstrSearchFieldData)
        {
            objSearchTextField.Clear();
            objSearchTextField.SendKeys(pstrSearchFieldData);
            objSearchTextField.SendKeys(Keys.Enter);
        }

        public void fnClickPeopleButton()
        {
            objPeopleButton.Click();
        }

        public void fnClickAllFiltersButton()
        {
            objAllFiltersButton.Click();
        }

        public void fnSelectMexicoCheckBox()
        {
            objMexicoCheckbox.Click();
        }

        public void fnSelectItalyCheckBox()
        {
            objItalyCheckbox.Click();
        }

        //public void fnSelectItalyListOption()
        //{
        //    objItalyListOption.Click();
        //}

        public void fnAddValueToLocationTextBox(string pstrLocationTextBox)
        {
            objLocationTextbox.SendKeys(pstrLocationTextBox);
            Thread.Sleep(500);
            objLocationTextbox.SendKeys(Keys.ArrowDown);
            objLocationTextbox.SendKeys(Keys.Enter);
        }

        public void fnClickApplyAllFiltersButton()
        {
            objApplyFiltersButton.Click();
        }



    }    
}
