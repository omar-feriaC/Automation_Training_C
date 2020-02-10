using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationFrameworkC.Test_Cases
{
    class Test_LinkedInSearch : BaseTest
    {
        public static LinkedIn_LoginPage objLogin;
        public static LinkedIn_SearchPage objSearch;
        WebDriverWait _objDriverWait;


        [Test]
        public void LinkedIn_SearchPage()
        {
            try
            {
                _objDriverWait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 15));
                objLogin = new LinkedIn_LoginPage(objDriver);
                objSearch = new LinkedIn_SearchPage(objDriver);


                objDriver.Manage().Window.Maximize();
                objLogin.FnEnterUsername(strUser);
                objLogin.FnEnterPassword(strPass);
                objLogin.FnClickSignInButton();
                _objDriverWait.Until(ExpectedConditions.UrlContains("feed"));

                Assert.AreEqual("https://www.linkedin.com/feed/", objDriver.Url);
                objSearch.fnEnterDataInSearchTextField("4th Source");
                _objDriverWait.Until(ExpectedConditions.UrlContains("results"));
                objSearch.fnClickPeopleButton();
                _objDriverWait.Until(ExpectedConditions.UrlContains("people"));
                objSearch.fnClickAllFiltersButton();
                _objDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h2[@class='t-20 t-20--open t-black--light t-normal']")));
                objSearch.fnSelectMexicoCheckBox();
                objSearch.fnAddValueToLocationTextBox("Italy");
                objSearch.fnSelectItalyCheckBox();
                _objDriverWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='search-advanced-facets__button--apply ml4 mr2 artdeco-button artdeco-button--3 artdeco-button--primary ember-view']")));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.Fail("Test Fail");
            }            

            finally
            {
                Console.WriteLine("Test Complete");
            }
        }
    }
}
