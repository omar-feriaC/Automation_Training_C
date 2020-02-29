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
namespace AutomationFrameworkC.Base_Files
{
    class BaseTest
    {
        #region ATTRIBUTES
        public IWebDriver objDriver;//This is actually the Driver that is used in all other classes
        //Elements to Login
        private static string strUrl = ConfigurationManager.AppSettings.Get("url");
        public static readonly string strUser = ConfigurationManager.AppSettings.Get("email");
        public static readonly string strPass = ConfigurationManager.AppSettings.Get("password");
        public static readonly string strApplication = ConfigurationManager.AppSettings.Get("application");
        //Extent Reports Instances
        public static clsReportManager objRM = new clsReportManager();
        public static ExtentHtmlReporter objHtmlReporter;
        //public static ExtentV3HtmlReporter objHtmlReporter;
        public static ExtentReports objExtent;
        public static ExtentTest objTest;
        #endregion ATTRIBUTES
        #region METHODS
        [OneTimeSetUp] //OneTimeSetUp before each class test
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
        [OneTimeTearDown] //OneTimeTearDown after each class test
        public static void fnAfterClass()
        {
            objExtent.Flush();
        }
        [SetUp] //SetUp Before each test case
        public void fnSetUp()
        {
            objDriver = new ChromeDriver();
            objDriver.Url = strUrl;
            objDriver.Manage().Window.Maximize();
        }
        [TearDown] //TearDown After each test case
        public void fnTearDown()
        {
            objRM.fnTestCaseResult(objTest, objExtent, objDriver);
            objDriver.Close();
            objDriver.Quit();
        }
        #endregion METHODS
    }
}
