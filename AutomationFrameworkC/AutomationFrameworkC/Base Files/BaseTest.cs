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
    public class BaseTest
    {
        //Variables
        public static IWebDriver objDriver;
        private static readonly string strUrl = ConfigurationManager.AppSettings.Get("url");
        public static readonly string strUser = ConfigurationManager.AppSettings.Get("user");
        public static readonly string strPass = ConfigurationManager.AppSettings.Get("password");
        public static readonly string strSearch = ConfigurationManager.AppSettings.Get("search");
        public static readonly string strCountryRegion0 = ConfigurationManager.AppSettings.Get("countryRegion0");
        public static readonly string strCountryRegion1 = ConfigurationManager.AppSettings.Get("countryRegion1");
        public static readonly List<string> listCountries = new List<string> { strCountryRegion0, strCountryRegion1 };
        //Functions
        [SetUp]
        public static void fnSetUp()
        {
            objDriver = new ChromeDriver();
            objDriver.Url = strUrl;
        }

        [TearDown]
        public static void fnTearDown()
        {
            objDriver.Close();
            objDriver.Quit();
        }

    }
}
