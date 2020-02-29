using NUnit.Framework;
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
    class clsDriver //: BaseTest
    {
        #region variables
        /*ATTRIBUTES*/
        private static IWebDriver _objDriver;
        private static WebDriverWait _driverWait;
        private static IWebElement objElement;
        private IList<IWebElement> objElements;
        #endregion variables
        #region Constructor
        /*CONSTRUCTOR*/
        public clsDriver(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }
        #endregion Constructor
        #region Methods
        /*METHODS*/
        private IWebElement fnWaitForElementThread(IWebDriver pobjDriver, By by, string pstrDesc)
        {
            objElement = pobjDriver.FindElement(by);
            return objElement;
        }
        private IWebElement fnWaitForElementDriver(IWebDriver pobjDriver, By by)
        {
            objElement = _driverWait.Until(ExpectedConditions.ElementExists(by));
            objElement = _driverWait.Until(ExpectedConditions.ElementIsVisible(by));
            return objElement;
        }
        private IWebElement fnWaitForElementDriverFluent(IWebDriver pobjDriver, By by)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(_objDriver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.Id("search_result")));
            return objElement;
        }
        public void fnWaitExistVisibleClickable (By by)
        {
            fnWaitForElementToExist(by);
            fnWaitForElementToBeVisible(by);
            fnWaitForElementToBeClickable(by);
        }
        public IWebElement fnFindElement(By by)
        {
            objElement = _objDriver.FindElement(by);
            return objElement;
        }
        public IList<IWebElement> fnFindElements(By by)
        {
            objElements = _objDriver.FindElements(by);
            return objElements;
        }
        public string fnPrintTxtElement(By by)
        {
            objElement = _objDriver.FindElement(by);
            return objElement.Text;
        }
        public int fnCountElements(By by)
        {
            int myCount = _objDriver.FindElements(by).Count;
            return myCount;
        }
        public IWebElement fnFindElementThatExist(By by)
        {
            objElement = _driverWait.Until(ExpectedConditions.ElementExists(by));
            return objElement;
        }
        /*Wait for to check the title of the website*/
        public bool fnWaitWebSiteTitleContains(string pstrUrlExpected)
        {
            {
                if (_driverWait.Until(ExpectedConditions.TitleContains(pstrUrlExpected)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /*Wait for to check the url contains*/
        public bool fnWaitURLContains(string pstrUrlExpected)
        {
            {
                //if (_driverWait.Until(ExpectedConditions.TitleContains(pstrUrlExpected)))
                if (_driverWait.Until(ExpectedConditions.UrlContains(pstrUrlExpected)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /*Wait for element to Exist*/
        public IWebElement fnWaitForElementToExist(By by)
        {
            objElement = _driverWait.Until(ExpectedConditions.ElementExists(by));
            return objElement;
        }
        /*Wait for element to be visible*/
        public IWebElement fnWaitForElementToBeVisible(By by)
        {
            objElement = _driverWait.Until(ExpectedConditions.ElementIsVisible(by));
            return objElement;
        }
        /*Wait for element to be clickable*/
        public IWebElement fnWaitForElementToBeClickable(By by)
        {
            objElement = _driverWait.Until(ExpectedConditions.ElementToBeClickable(by));
            return objElement;
        }
        /*Click the element*/
        public void fnClickTheElement(By by)
        {
            objElement = fnFindElement(by);
            objElement.Click();
        }

        /*Wait for element to be selected*/
        public bool fnWaitForElementToBeSelected(By by)
        {
            if (_driverWait.Until(ExpectedConditions.ElementToBeSelected(by)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*return true or false if element is in the page*/
        public bool fnIsElementPresent(By by)
        {
            try
            {
                _objDriver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        /*staleness*/
        public bool fnStalenessElement(By by)
        {
            _driverWait.Until(ExpectedConditions.StalenessOf(fnFindElement(by)));
            return true;
        }
        #endregion Methods
    }
}