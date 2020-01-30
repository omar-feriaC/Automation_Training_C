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
    class clsMercury_RegisterPage : BaseTest
    {
        //Identify all the objects of the sections

        //Variables
        private static WebDriverWait objWait;
        private static IWebDriver _objDriver; // we are going to use this specifically for this class

        //Constructor
        public clsMercury_RegisterPage(IWebDriver pobjDriver)
        {
            _objDriver = pobjDriver; //we are receiving the value from outside
            objWait = new WebDriverWait(_objDriver, new TimeSpan(0, 0, 30));
        }

        //Element Definitions
        // $x("//input[@name='firstName']")
        readonly static string STR_FIRSTNAME = "//input[@name='firstName']";
        readonly static string STR_LASTNAME = "//input[@name='lastName']";
        readonly static string STR_PHONE = "//input[@name='phone']";
        readonly static string STR_EMAIL = "//input[@name='userName']";
        readonly static string STR_ADDRESS1 = "//input[@name='address1']";
        readonly static string STR_ADDRESS2 = "//input[@name='address2']";
        readonly static string STR_CITY = "//input[@name='city']";
        readonly static string STR_STATE = "//input[@name='state']";
        readonly static string STR_POSTALCODE = "//input[@name='postalCode']"; 
        readonly static string STR_COUNTRY = "//input[@name='country']";
        readonly static string STR_USEREMAIL = "//input[@name='email']";
        readonly static string STR_USERPASS = "//input[@name='password']";
        readonly static string STR_CONFIRMPASS = "//input[@name='confirmPassword']";

        //WebElements Definition
        //We are using this to identify the object by Xpath
        private static IWebElement objFirstNameTxt => _objDriver.FindElement(By.XPath(STR_FIRSTNAME)); //lambda expression, assign something to an object
        private static IWebElement objLastNameTxt => _objDriver.FindElement(By.XPath(STR_LASTNAME));
        private static IWebElement objPhoneTxt => _objDriver.FindElement(By.XPath(STR_PHONE));
        private static IWebElement objEmailTxt => _objDriver.FindElement(By.XPath(STR_EMAIL));
        private static IWebElement objAddress1Txt => _objDriver.FindElement(By.XPath(STR_ADDRESS1));
        private static IWebElement objAddress2Txt => _objDriver.FindElement(By.XPath(STR_ADDRESS2));
        private static IWebElement objCityTxt => _objDriver.FindElement(By.XPath(STR_CITY));
        private static IWebElement objStateTxt => _objDriver.FindElement(By.XPath(STR_STATE));
        private static IWebElement objPostalCodeTxt => _objDriver.FindElement(By.XPath(STR_POSTALCODE));
        private static IWebElement objCountryTxt => _objDriver.FindElement(By.XPath(STR_COUNTRY));
        private static IWebElement objUserEmailTxt => _objDriver.FindElement(By.XPath(STR_USEREMAIL));
        private static IWebElement objUserPassTxt => _objDriver.FindElement(By.XPath(STR_USERPASS));
        private static IWebElement objConfirmPassTxt => _objDriver.FindElement(By.XPath(STR_CONFIRMPASS));

        //Methods

        //First Name Methods    
        private IWebElement fnGetFirstName()
        {
            return objFirstNameTxt;
        }

        public static void fnFillFirstName(string pstrFirstName)
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_FIRSTNAME))); //review that element exist
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_FIRSTNAME))); // review that we can see the element
                objFirstNameTxt.Clear();
                objFirstNameTxt.SendKeys(pstrFirstName);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element firstname does not exist: " + e.Message);
                Assert.Fail();
            }
        }

        //Last Name Methods    
        private IWebElement fnGetLastName()
        {
            return objLastNameTxt;
        }

        public static void fnFillLastName(string pstrLasttName)
        {
            try
            {
                objWait.Until(ExpectedConditions.ElementExists(By.XPath(STR_LASTNAME))); //review that element exist
                objWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(STR_LASTNAME))); // review that we can see the element
                objLastNameTxt.Clear();
                objLastNameTxt.SendKeys(pstrLasttName);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Element LastName does not exist: " + e.Message);
                Assert.Fail();
            }
        }


        //All fills
        public static void fnRegisterPage(string pstrFirstName, string pstrLasttName)
        {
            try
            {
                fnFillFirstName(pstrFirstName);
                fnFillLastName(pstrLasttName);
                //fnClickSignIn();
            }
            catch (Exception e)
            {
                Console.WriteLine("The Error ");
                Assert.Fail();
            }
        }

        public static void fnRegisterPageList(List <string> pListformRegisterPage)
        {
            try
            {
                fnFillFirstName(pListformRegisterPage[0]);
                fnFillLastName(pListformRegisterPage[1]);
                //fnClickSignIn();
            }
            catch (Exception e)
            {
                Console.WriteLine("The Error ");
                Assert.Fail();
            }
        }


    }
}
