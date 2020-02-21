using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Test_Cases
{
    class M8LinkedIn_Test2 : M8LinkedIn_Test
    {
        WebDriverWait wait;


        [Test]

        public void M8LinkedIn_SearchPage()
        {
            M8LinkedIn_Login();
            try
            {
                M8LinkedIn_SearchPage objSearchPage = new M8LinkedIn_SearchPage(objDriver);
                wait = new WebDriverWait(objDriver, new TimeSpan(0, 1, 0));
                string[] arrTechnologies = { "Java", "C", "Phyton", "Pega", "C#" };


                for (int i = 0; i < arrTechnologies.Length; i++)
                {
                    objSearchPage.fnSearchText(arrTechnologies[i]);
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ember8")));
                    objSearchPage.fnSearchButton();
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='Gente' or text()='People']]")));
                    objSearchPage.fnPeopleButton();
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[span[text()='Ubicaciones' or text()='Locations']]")));
                    objSearchPage.fnAllFiltersButton();
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[label[text()='Mexico' or text()='México']]")));
                    objSearchPage.fnMexicoOpt();
                    objSearchPage.fnEnglishOpt();
                    objSearchPage.fnSpanishOpt();
                    objSearchPage.fnApplyButton(); ;

                }

            }

            catch (Exception x)
            {
                Console.WriteLine("Failed on: ");
                Console.WriteLine(x.Message);
                Assert.Fail();
            }

            finally
            {

            }
        }
    }
}
