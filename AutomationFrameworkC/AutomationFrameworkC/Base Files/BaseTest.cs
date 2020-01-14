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
        //Variables
        public static IWebDriver objDriver;
        private static readonly string strUrl = ConfigurationManager.AppSettings.Get("url");


        //Functions
        public static void fnSetUp()
        {
            objDriver = new ChromeDriver();
            objDriver.Url = strUrl;
        }

        public static void fnTearDown()
        {
            objDriver.Close();
            objDriver.Quit();
        }


    }
}
