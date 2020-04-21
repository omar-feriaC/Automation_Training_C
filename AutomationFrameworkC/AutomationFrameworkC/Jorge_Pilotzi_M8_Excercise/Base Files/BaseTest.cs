using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.Page_Objects;
using AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.Test_Cases;
using AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.BaseFiles;


namespace AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.BaseFiles
{
    class BaseTest
    {
        // Variables

        // WebDriver
        public static IWebDriver driver;
        private static string strBrowserName = ConfigurationManager.AppSettings.Get("url");

        // Methods

        [SetUp]
        // SetUp Instructions
            public static void SetUp()
            {
                driver = new ChromeDriver();
                driver.Url = strBrowserName;
            }
        [TearDown]
        // TearDown Instructions
            public static void AfterTest()
            {
                driver.Close();
                driver.Quit();
            }

        // Clear and Send Text to each field.
            public static void FnSendKeyAndClear(By by, string pstrText)
            {
                driver.FindElement(by).Clear();
                driver.FindElement(by).SendKeys(pstrText);
            }
        
    }
}
