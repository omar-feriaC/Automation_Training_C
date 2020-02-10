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
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationFrameworkC.Page_Objects
{
    class LinkedIn_SearchPage :BaseTest
    {
        private static IWebDriver _objDriver;
        WebDriverWait  _objwait;

        public LinkedIn_SearchPage(IWebDriver driver)
        {
            _objDriver = driver;
            _objwait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 30));
        }

        //ELEMENT LOCATOR//
        private static readonly string str_search_textfield_Xpath = "//input[@class='search-global-typeahead__input always-show-placeholder']";
        private static readonly string str_people_button_Xpath = "//span[text()='Gente' or text()='People']";
        private static readonly string str_allFilters_button_Xpath = "//span[text()='Todos los filtros' or text()='All Filters']";
        private static readonly string str_Location_textbox_Xpath = "(//input[@placeholder='Añadir un país o región'])[1]"; // English one : Add a country/region
        private static readonly string str_Mexico_checkbox_Xpath = "//span[starts-with(@class, 'search-typeahead') and (text()='México' or text()='Mexico')]";
        private static readonly string str_Italy_checkbox_Xpath = "//span[starts-with(@class, 'search-typeahead') and (text()='Italia' or text()='Italy')]";
        private static readonly string str_ApplyFilters_button_Xpath = "//span[text()='Apply' or text()='Aplicar'][1]";
        private static readonly string str_member_name_Xpath = "//span[@class='actor-name']";
        private static readonly string str_member_roles_Xpath = "//p[@class='subline-level-1 t-14 t-black t-normal search-result__truncate']";
        private static readonly string str_member_urls_Xpath = "//div[@class='search-result__info pt3 pb4 ph0']//a[@href]";

        /*PAGE ELEMENT OBJECTS*/
        private static IWebElement objSearchTextField => _objDriver.FindElement(By.XPath(str_search_textfield_Xpath));
        private static IWebElement objPeopleButton => _objDriver.FindElement(By.XPath(str_people_button_Xpath));
        private static IWebElement objAllFiltersButton => _objDriver.FindElement(By.XPath(str_allFilters_button_Xpath));
        private static IWebElement objMexicoCheckbox => _objDriver.FindElement(By.XPath(str_Mexico_checkbox_Xpath));
        private static IWebElement objItalyCheckbox => _objDriver.FindElement(By.XPath(str_Italy_checkbox_Xpath));
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

       
        public IWebElement GetApplyAllFiltersButton()
        {
            return objApplyFiltersButton;
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
            _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(str_people_button_Xpath)));
            objPeopleButton.Click();
        }

        public void fnClickAllFiltersButton()
        {
            _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(str_allFilters_button_Xpath)));
            objAllFiltersButton.Click();
        }

        public void fnSelectMexicoCheckBox()
        {
            _objwait.Until(ExpectedConditions.ElementExists(By.XPath(str_Mexico_checkbox_Xpath)));
            _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(str_Mexico_checkbox_Xpath)));
            _objwait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(str_Mexico_checkbox_Xpath)));
            objMexicoCheckbox.Click();
        }

        public void fnSelectItalyCheckBox()
        {
            _objwait.Until(ExpectedConditions.ElementExists(By.XPath(str_Italy_checkbox_Xpath)));
            _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(str_Italy_checkbox_Xpath)));
            _objwait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(str_Italy_checkbox_Xpath)));
            objItalyCheckbox.Click();
        }


        public void fnLocationTextBox(string pstrLocationTextBox)
        {
            _objwait.Until(ExpectedConditions.ElementExists(By.XPath(str_Location_textbox_Xpath)));
            _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(str_Location_textbox_Xpath)));
            objLocationTextbox.Clear();
            objLocationTextbox.SendKeys(pstrLocationTextBox);           ;          
        }

        public void fnClickApplyAllFiltersButton()
        {
            _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(str_ApplyFilters_button_Xpath)));
            objApplyFiltersButton.Click();
            _objwait.Until(ExpectedConditions.UrlContains("facetGeoRegion"));
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
        public void fnMultipleSearch()
        {
            string[] arrTechnologies = { "Java", "C", "Phyton", "Pega", "C#" };

            for (int i = 0; i < arrTechnologies.Length; i++)
            {
                fnEnterDataInSearchTextField(arrTechnologies[i]);

                _objwait.Until(ExpectedConditions.ElementExists(By.XPath(str_member_name_Xpath)));
                _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(str_member_name_Xpath)));
                _objwait.Until(ExpectedConditions.ElementExists(By.XPath(str_member_roles_Xpath)));
                _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(str_member_roles_Xpath)));
                _objwait.Until(ExpectedConditions.ElementExists(By.XPath(str_member_urls_Xpath)));
                _objwait.Until(ExpectedConditions.ElementIsVisible(By.XPath(str_member_urls_Xpath)));
                _objwait.Until(ExpectedConditions.StalenessOf(_objDriver.FindElement(By.XPath(str_member_urls_Xpath))));

                objMemberNames = _objDriver.FindElements(By.XPath(str_member_name_Xpath));
                objMemberRoles = _objDriver.FindElements(By.XPath(str_member_roles_Xpath));
                objMemberUrls = _objDriver.FindElements(By.XPath(str_member_urls_Xpath));

                for (int j = 0; j < objMemberNames.Count; j++)
                {
                    Console.WriteLine("Name: {0}", objMemberNames[j].Text);
                    Console.WriteLine("Role: {0}", objMemberRoles[j].Text);
                    Console.WriteLine("URL: {0}", objMemberUrls[j].GetAttribute("href"));
                    Console.WriteLine();
                }
            }

        }
    }
}
