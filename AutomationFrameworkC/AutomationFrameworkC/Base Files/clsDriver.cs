using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
namespace AutomationFrameworkC.Base_Files
{
    class clsDriver
    {
        #region ATTRIBUTES
        private static IWebDriver _objDriver; //Used for our constructor and used in all the class
        private static WebDriverWait _driverWait; //Used for our constructor and used in all the class
        private static IWebElement objElement; //Used to return one Element
        private IList<IWebElement> objElements; //Used to return a List of Elements
        #endregion ATTRIBUTES
        #region CONSTRUCTOR
        public clsDriver(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver;
            _driverWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 40));
        }
        #endregion CONSTRUCTOR
        #region METHODS
            #region WAITERS
                #region WAITERS RETURNING OBJECT
                public IWebElement fnWaitForElementToExist(By by)//This waits an element to exist
                {
                    objElement = _driverWait.Until(ExpectedConditions.ElementExists(by));
                    return objElement;
                }
                public IWebElement fnWaitForElementToBeVisible(By by)//This waits and element to be visible
                {
                    objElement = _driverWait.Until(ExpectedConditions.ElementIsVisible(by));
                    return objElement;
                }
                public IWebElement fnWaitForElementToBeClickable(By by)//This waits the element to be clickable
                {
                    objElement = _driverWait.Until(ExpectedConditions.ElementToBeClickable(by));
                    return objElement;
                }
                public IWebElement fnFindElementThatExist(By by)//This wait one element to exist
                {
                    objElement = _driverWait.Until(ExpectedConditions.ElementExists(by));
                    return objElement;
                }
                public void fnWaitExistVisibleClickable(By by)//This method wait element to exist, be visible and Clickable
                        {
                            fnWaitForElementToExist(by);
                            fnWaitForElementToBeVisible(by);
                            fnWaitForElementToBeClickable(by);
                        }
                #endregion WAITERS RETURNING OBJECT
                #region BOOLEAN WAITERS
                public bool fnWaitWebSiteTitleContains(string pstrUrlExpected)//returns true if the website title contains the text specified
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
                public bool fnWaitURLContains(string pstrUrlExpected)//returns true if the URL contains the text specified
                {
                    {
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
                public bool fnWaitForElementToBeSelected(By by)//returns true if element is selected
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
                public bool fnIsElementPresent(By by)//returns true if the element is in the page
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
                #endregion BOOLEAN WAITERS
            #endregion WAITERS
            #region FINDELEMENTS
            public IWebElement fnFindElement(By by)//This find one element
                {
                    objElement = _objDriver.FindElement(by);
                    return objElement;
                }
            public IList<IWebElement> fnFindElements(By by)//This find a list of elements
            {
                objElements = _objDriver.FindElements(by);
                return objElements;
            }
            #endregion FINDELEMENTS
            #region MANIPULATE ELEMENTS
            public string fnPrintTxtElement(By by)//This turns the element into a string
            {
                objElement = _objDriver.FindElement(by);
                return objElement.Text;
            }
            public int fnCountElements(By by)//This returns into an int the amount of elements
            {
                int myCount = _objDriver.FindElements(by).Count;
                return myCount;
            }
            public void fnClickTheElement(By by)//This clicks the element
            {
                objElement = fnFindElement(by);
                objElement.Click();
            }
            public void fnWaitFindAndClick(By by)//This clicks the element
            {
                fnWaitExistVisibleClickable(by);
                objElement = fnFindElement(by);
                objElement.Click();
            }
        #endregion MANIPULATE ELEMENTS
        #endregion METHODS
    }
}