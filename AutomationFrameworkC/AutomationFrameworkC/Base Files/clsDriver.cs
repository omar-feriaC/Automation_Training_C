using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Base_Files
{
    class clsDriver : BaseTest
    {
        /*ATTRIBUTES*/
        private static IWebDriver _objDriver;
        private static WebDriverWait _driverWait;
        private static IWebElement objElement;

        /*CONSTRUCTOR*/
        public clsDriver(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }

        /*METHODS*/
        private static IWebElement WaitForElementThread(IWebDriver pobjDriver, By pby, string pstrDesc)
        {
            Thread.Sleep(5000);
            objElement = pobjDriver.FindElement(pby);
            return objElement;
        }

        private static IWebElement fnWaitForElementDriver(IWebDriver pobjDriver, By pby)
        {
            objElement = _driverWait.Until(ExpectedConditions.ElementExists(pby));
            objElement = _driverWait.Until(ExpectedConditions.ElementIsVisible(pby));
            return objElement;
        }

        private static IWebElement WaitForElementDriverFluent(IWebDriver pobjDriver, By pby)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(BaseTest.objDriver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.Id("search_result")));
            return objElement;
        }

        /*Wait for element to Exist*/
        public static IWebElement fnWaitForElementToExist(By pby)
        {
            objElement = _driverWait.Until(ExpectedConditions.ElementExists(pby));
            return objElement;
        }

        /*Wait for element to be visible*/
        public static IWebElement fnWaitForElementToBeVisible(By pby)
        {
            objElement = _driverWait.Until(ExpectedConditions.ElementIsVisible(pby));
            return objElement;
        }

        /*Wait for element to be clickable*/
        public static IWebElement fnWaitForElementToBeClickable(By pby)
        {
            objElement = _driverWait.Until(ExpectedConditions.ElementToBeClickable(pby));
            return objElement;
        }

        /*Wait for element to be selected*/
        public static bool fnWaitForElementToBeSelected(By pby)
        {
            if (_driverWait.Until(ExpectedConditions.ElementToBeSelected(pby)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
