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
        public static IWebDriver objDriver; //object type IWebDriver (interface)
        private static readonly string strUrl = ConfigurationManager.AppSettings.Get("url"); //Get("key")


        //Functions
        public static void fnSetUp() //to open a web browser with a URL
        {
            objDriver = new ChromeDriver(); //
            objDriver.Url = strUrl;
        }

    }
}
