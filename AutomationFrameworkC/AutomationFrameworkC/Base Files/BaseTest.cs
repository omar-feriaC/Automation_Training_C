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
        //**************************************************
        //*                V A R I A B L E S
        //**************************************************

        /*Webdriver Intance*/
        public static IWebDriver objDriver;
        /*browser, URL, email and pass */
        public static readonly string strBrowserName = ConfigurationManager.AppSettings.Get("browser");
        public static readonly string strUrl = ConfigurationManager.AppSettings.Get("url");
        public static readonly string strEmail = ConfigurationManager.AppSettings.Get("email");
        public static readonly string strPass = ConfigurationManager.AppSettings.Get("password");
        /*Extent Reports Framework*/
        public static clsReportManager objRM = new clsReportManager();
        public static ExtentV3HtmlReporter objHtmlReporter;
        public static ExtentReports objExtent;
        public static ExtentTest objTest;

        //**************************************************
        //                  M E T H O D S 
        //**************************************************
        //OneTimeSetUp before each class test
        [OneTimeSetUp]
        public static void fnBeforeClass()
        {
            /*Init ExtentHtmlReporter object*/
            if (objHtmlReporter == null)
            {
                objHtmlReporter = new ExtentV3HtmlReporter(objRM.fnReportPath());
                //objHtmlReporter = new ExtentHtmlReporter(objRM.fnReportPath());
            }
            /*Init ExtentReports object*/
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

        [SetUp]
        //SetUp Before each test case
        public static void SetUp()
        {
            objDriver = new ChromeDriver();
            objDriver.Url = strUrl;
            objDriver.Manage().Window.Maximize();

        }

        [TearDown]
        //TearDown After each test case
        public static void AfterTest()
        {
            objRM.fnTestCaseResult(objTest, objExtent, objDriver);
            objDriver.Close();
            objDriver.Quit();
        }
    }
}
