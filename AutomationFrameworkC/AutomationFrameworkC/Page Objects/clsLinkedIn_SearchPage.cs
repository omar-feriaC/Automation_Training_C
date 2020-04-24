using AutomationFrameworkC.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        //Locators Definitions
        readonly static string STR_SEARCH = "//input[@class='search-global-typeahead__input always-show-placeholder']";
        readonly static string STR_PEOPLE = "//span[text()='Gente' or text()='People']";
        readonly static string STR_FILTERS = "//span[@class='artdeco-button__text' and text()='Todos los filtros' or text()='All Filters']";
        readonly static string STR_LOCATIONS = "(//input[@aria-label='Añadir un país o región'])[1]";
        readonly static string STR_MEXICO = "//*[text()='México' or text()='Mexico']";
        readonly static string STR_ITALY = "(//div[@role='option']//span[starts-with(text(), 'Ital')])[1]";
        readonly static string STR_APPLY = "//button[@data-control-name='all_filters_apply' and span[text()='Aplicar' or text()='Apply']]";
        readonly static string STR_NAME = "//span[@class='name actor-name']";
        readonly static string STR_ROLE = "//*[@class = 'subline-level-1 t-14 t-black t-normal search-result__truncate']";
        readonly static string STR_URL = "//div[starts-with(@class, 'search-result__info')]//a[@data-control-name='search_srp_result']";

        //WebElements Definition
        //como, de
        private static IWebElement objSearchBtnTxt => _objDriver.FindElement(By.XPath(STR_SEARCH));
        private static IWebElement objPeopleBtnTxt => _objDriver.FindElement(By.XPath(STR_PEOPLE));
        private static IWebElement objFiltersBtnTxt => _objDriver.FindElement(By.XPath(STR_FILTERS));
        private static IWebElement objLocationsBtnTxt => _objDriver.FindElement(By.XPath(STR_LOCATIONS));
        private static IWebElement objMexicoChk => _objDriver.FindElement(By.XPath(STR_MEXICO));
        private static IWebElement objItalyChk => _objDriver.FindElement(By.XPath(STR_ITALY));
        private static IWebElement objApplyBtnTxt => _objDriver.FindElement(By.XPath(STR_APPLY));
        private static IList<IWebElement> objNameTxt => _objDriver.FindElements(By.XPath(STR_NAME));
        private static IList<IWebElement> objRoleTxt => _objDriver.FindElements(By.XPath(STR_ROLE));
        private static IList<IWebElement> objUrlTxt => _objDriver.FindElements(By.XPath(STR_URL));

       
        //METHODS

        //Search 
        private IWebElement GetSearchBtn()
        {
            return objSearchBtnTxt;
        }

        public static void fnSearchBtn(string pSearch)
        {
            _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_SEARCH)));
            _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_SEARCH)));
            _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_SEARCH)));
            objSearchBtnTxt.Click();
            objSearchBtnTxt.Clear();
            objSearchBtnTxt.SendKeys(pSearch);
            objSearchBtnTxt.Click();
            objSearchBtnTxt.SendKeys(Keys.Enter);
        }

        //People
        public IWebElement GetPeopleBtn()
        {
            return objPeopleBtnTxt;
        }

        public static void fnPeopleBtn()
        {
            _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_PEOPLE)));
            _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_PEOPLE)));
            _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_PEOPLE)));
            objPeopleBtnTxt.Click();
        }

        //Filters
        public IWebElement GetFiltersBtn()
        {
            return objFiltersBtnTxt;
        }

        public static void fnFiltersBtn()
        {
            _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FILTERS)));
            _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_FILTERS)));
            _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_FILTERS)));
            objFiltersBtnTxt.Click();
        }

        //Locations 
        public IWebElement GetLocationsBtn()
        {
            return objLocationsBtnTxt;
        }

        //Mexico 
        public IWebElement GetMexicoChk()
        {
            return objMexicoChk;
        }

        public static void fnMexicoChk()
        {
            _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MEXICO)));
            _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_MEXICO)));
            _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_MEXICO)));
            objMexicoChk.Click();
        }

        //Italy 
        public IWebElement GetItalyChk()
        {
            return objItalyChk;
        }

        public static void fnItalyChk()
        {
            _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOCATIONS)));
            _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOCATIONS)));
            _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOCATIONS)));

            objLocationsBtnTxt.Click();
            objLocationsBtnTxt.Clear();
            objLocationsBtnTxt.SendKeys("Italia");

            _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ITALY)));
            _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ITALY)));
            _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ITALY)));
            objItalyChk.Click();
        }

        //Apply 
        public IWebElement GetApplyBtn()
        {
            return objApplyBtnTxt;
        }

        public static void fnApplyBtn()
        {
            _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_APPLY)));
            _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_APPLY)));
            objApplyBtnTxt.Click();
        }

        //Name
        public IList<IWebElement> GetNameList()
        {
            return objNameTxt;
        }

        //Role
        public IList<IWebElement> GetRoleList()
        {
            return objRoleTxt;
        }

        //URL
        public IList<IWebElement> GetUrlList()
        {
            return objUrlTxt;
        }


        //fnTable
        public static void fnTableInfo()
        {
            string[] arrTechnologies = { "Java", "Pega", "C", "Phyton", "C#" };

            foreach (string item in arrTechnologies)
            {
                fnSearchBtn(item);
              //  fnPeopleBtn();
                //fnMexicoChk();
                //fnItalyChk();
               // fnApplyBtn();

                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_NAME)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_NAME)));
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ROLE)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ROLE)));
                _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_URL)));
                _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_URL)));

                for (int i = 0; i < objNameTxt.Count; i++)
                {
                    Console.WriteLine("Name: " + objNameTxt[i].Text);
                    Console.WriteLine("Role: " + objRoleTxt[i].Text);
                    Console.WriteLine("URL: " + objUrlTxt[i].GetAttribute("href"));
                }

            }
                                    }

    }
}

// Console.WriteLine(objNameTxt.ToString);

/*
       public static void fnItalyChk()
        {
            _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_ITALY)));
            _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_ITALY)));
            _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_ITALY)));
            objItalyChk.Click();            
        }

        //Mexico 
        public IWebElement GetMexicoChk()
        {
            return objMexicoChk;
        }

        public static void fnMexicoChk()
        {
            _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_MEXICO)));
            _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_MEXICO)));
            _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_MEXICO)));
            objMexicoChk.Click();
        }
        */

/*  public static void fnLocationsBtn(string pLocation)
{
  _objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LOCATIONS))); 
  _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOCATIONS)));
  _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOCATIONS)));

  objLocationsBtnTxt.Click();
  objLocationsBtnTxt.Clear();
  objLocationsBtnTxt.SendKeys(pLocation);

  _objWait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='"+ pLocation + "']")));
  _objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LOCATIONS)));
  _objWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(STR_LOCATIONS)));
}*/

//foreach (IList<IWebElement> element in objNameTxt) // Una por cada lista
//{
//    Console.WriteLine("Value: " + element.ToString());
//    Console.WriteLine("Name: " + element.ToString( ));
//    Console.WriteLine("Role: " + element.ToString());
//    Console.WriteLine("URL: " + element.ToString());
//}

// for (int i=0, i<= objNameTxt.si) { } // otra forma por indices

//estructura de un item de varias listas (como imprimir varias listas a la par)
//variable, lista y parametros de cada uno
