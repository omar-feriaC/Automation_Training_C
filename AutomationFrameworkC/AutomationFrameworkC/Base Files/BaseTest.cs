using AutomationFrameworkC.Reporting;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
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
        /*Webdriver instances*/
        public static IWebDriver objDriver;
        
        
        /*Variables*/
        private static string strUrl = ConfigurationManager.AppSettings.Get("url");
        public static string strUserName = ConfigurationManager.AppSettings.Get("email");
        public static string strPassword = ConfigurationManager.AppSettings.Get("password");

        /*Extent Reports Instances*/
        public static clsReportManager objRM = new clsReportManager();
        public static ExtentHtmlReporter objHtmlReporter;
        
        //public static ExtentV3HtmlReporter objHtmlReporter;
        public static ExtentReports objExtent;
        public static ExtentTest objTest;


        //**************************************************
        //                  M E T H O D S 
        //**************************************************
        //OneTimeSetUp before each class test
        [OneTimeSetUp]
        public static void fnBeforeClass()
        {
            /*Init ExtentHTML*/
            if (objHtmlReporter == null)
            {
                objHtmlReporter = new ExtentHtmlReporter(objRM.fnReportPath());
                //objHtmlReporter = new ExtentV3HtmlReporter(objRM.fnReportPath());
            }
            /*Init ExtentReports*/
            if (objExtent == null)
            {
                objExtent = new ExtentReports();
                objRM.fnReportSetUp(objHtmlReporter, objExtent);
            }
        }

        //OneTimeTearDown after each class test
        [OneTimeTearDown]
        public static void fnAfterClass()
        {
            objExtent.Flush();
        }

        //SetUp Before each test case
        [SetUp]
        public static void fnSetUp()
        {
            objDriver = new ChromeDriver();
            objDriver.Url = strUrl;
            objDriver.Manage().Window.Maximize();
        }
        
        //TearDown After each test case
        [TearDown]
        public static void fnTearDown()
        {
            objRM.fnTestCaseResult(objTest, objExtent, objDriver);
            objDriver.Close();
            objDriver.Quit();
        }


    }
}
