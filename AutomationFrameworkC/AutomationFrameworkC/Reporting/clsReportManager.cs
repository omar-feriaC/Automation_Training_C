using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Configuration;
using System.IO;

namespace AutomationFrameworkC.Reporting
{
    class clsReportManager
    {
        //Variables
        private DateTime time = DateTime.Now;

        //Method to get report path
        public string fnReportPath()
        {
            //Get Directory using 
            var strPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strActualPath = strPath.Substring(0, strPath.LastIndexOf("bin"));
            var strProjectPath = new Uri(strActualPath).LocalPath;
            //Create directory
            Directory.CreateDirectory(strProjectPath.ToString() + "ExtentReports");
            var strReportPath = strProjectPath + "ExtentReports\\ExtentReport_" + time.ToString("MMddyyyy_HHmmss") + ".html";
            return strReportPath;
        }

        //Method to set up the report
        public void fnReportSetUp(ExtentV3HtmlReporter phtmlReporter, ExtentReports pExtent)
        {
            phtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            phtmlReporter.Config.DocumentTitle = "Automation Framework Report";
            pExtent.AttachReporter(phtmlReporter);
            pExtent.AddSystemInfo("Project Name:", "Automation Framework");
            pExtent.AddSystemInfo("Application:", "PHP Travels");
            pExtent.AddSystemInfo("Environment:", "QA");
            pExtent.AddSystemInfo("Browser:", ConfigurationManager.AppSettings.Get("browser"));
            pExtent.AddSystemInfo("Date:", time.ToShortDateString());
            pExtent.AddSystemInfo("Version:", "v1.0");
        }

        //Method to take image and returns screen path
        public string fnCaptureImage(IWebDriver pobjDriver, string pstrScreenName)
        {
            ITakesScreenshot objITake = (ITakesScreenshot)pobjDriver;
            Screenshot objSS = objITake.GetScreenshot();
            var strSSPath = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var strActualPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin"));
            var strReportPath = new Uri(strActualPath).LocalPath;
            Directory.CreateDirectory(strReportPath.ToString() + "ExtentReports\\Screenshots");
            var strFullPath = strSSPath.Substring(0, strSSPath.LastIndexOf("bin")) + "ExtentReports\\Screenshots\\" + pstrScreenName;
            var strLocalPath = new Uri(strFullPath).LocalPath;
            objSS.SaveAsFile(strLocalPath, ScreenshotImageFormat.Png);
            return strLocalPath;
        }

        //Method to take Nunit Results
        public void fnTestCaseResult(ExtentTest pobjTest, ExtentReports pobjExtent, IWebDriver pobjDriver)
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
           ? "" : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logStatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logStatus = Status.Fail;
                    string strFileName = "Screenshot_" + time.ToString("hh_mm_ss") + ".png";
                    var strImagePath = fnCaptureImage(pobjDriver, strFileName);
                    pobjTest.Log(Status.Fail, "Fail ");
                    pobjTest.Fail("Snapshot below: ", MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case TestStatus.Skipped:
                    logStatus = Status.Skip;
                    break;
                case TestStatus.Passed:
                    logStatus = Status.Pass;
                    break;
                default:
                    logStatus = Status.Warning;
                    Console.WriteLine("The status: " + status + " is not supported.");
                    break;
            }
            pobjTest.Log(logStatus, "Test ended with " + logStatus + stacktrace);
            pobjExtent.Flush();
        }

        //Method to add log step
        public void fnAddStepLog(ExtentTest pobjTest, string pstrMessage, string pStatus)
        {
            switch (pStatus.ToUpper())
            {
                case "PASS":
                    pobjTest.Log(Status.Pass, pstrMessage);
                    break;
                case "ERROR":
                    pobjTest.Log(Status.Error, pstrMessage);
                    break;
                case "SKIPT":
                    pobjTest.Log(Status.Skip, pstrMessage);
                    break;
                case "WARNING":
                    pobjTest.Log(Status.Warning, pstrMessage);
                    break;
                case "INFO":
                    pobjTest.Log(Status.Info, pstrMessage);
                    break;
                case "FAIL":
                    pobjTest.Log(Status.Fail, pstrMessage);
                    break;
                case "FATAL":
                    pobjTest.Log(Status.Fatal, pstrMessage);
                    break;
                case "DEBUG":
                    pobjTest.Log(Status.Debug, pstrMessage);
                    break;
                default:
                    pobjTest.Log(Status.Info, pstrMessage);
                    break;
            }
        }

        //Method to add log step with image
        public void fnAddStepLogWithSnapshot(ExtentTest pobjTest, IWebDriver pobjDriver, string pstrMessage, string pstrImageName, string pStatus)
        {
            var strImagePath = fnCaptureImage(pobjDriver, pstrImageName);
            switch (pStatus.ToUpper())
            {
                case "PASS":
                    pobjTest.Pass(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "ERROR":
                    pobjTest.Error(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "SKIPT":
                    pobjTest.Skip(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "WARNING":
                    pobjTest.Warning(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "INFO":
                    pobjTest.Info(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "FAIL":
                    pobjTest.Fail(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "FATAL":
                    pobjTest.Fatal(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                case "DEBUG":
                    pobjTest.Debug(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
                default:
                    pobjTest.Info(pstrMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(strImagePath).Build());
                    break;
            }
        }
    }
}
