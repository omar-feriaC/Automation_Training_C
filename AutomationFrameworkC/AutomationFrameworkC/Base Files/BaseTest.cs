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
        /*ATTRIBUTES*/
        public static IWebDriver objDriver;
        protected static string strUserName = ConfigurationManager.AppSettings.Get("username");
        protected static string strPassword = ConfigurationManager.AppSettings.Get("password");
        protected static string strUrl = ConfigurationManager.AppSettings.Get("url");

        /*METHOD/FUNCTIONS*/

        [SetUp]
        public static void SetupDriver()
        {
            objDriver = new ChromeDriver();
            objDriver.Url = strUrl;
            objDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public static void ExitDriver()
        {
            objDriver.Close();
            objDriver.Quit();
        }



    }
}
