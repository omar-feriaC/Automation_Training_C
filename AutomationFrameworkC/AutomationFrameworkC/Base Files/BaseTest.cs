using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Base_Files
{
    class BaseTest
    {
        // Variables
        public static IWebDriver objDriver; // if this has an I -- it is an interfaze
        //private static readonly string strUrl = ConfigurationManager.AppSettings.Get("url"); //readonly in order to not modify
        protected static readonly string strUrl = ConfigurationManager.AppSettings.Get("url"); //readonly in order to not modify
        //protected  is another type of variable
        // the protected allows to use it only when it is inhenerit
        public static readonly string strUser = ConfigurationManager.AppSettings.Get("user");
        public static readonly string strPass = ConfigurationManager.AppSettings.Get("password");

        //Functions
        [SetUp]
        public static void fnSetup()  // normally visual studio expects to have this with capital letters
        {
            objDriver = new ChromeDriver();
            objDriver.Url = strUrl; // this is the way to obtain the URL
        }

        [TearDown]
        public static void fnTearDown()
        {
            objDriver.Close();
            objDriver.Quit();
        }
    }
}
