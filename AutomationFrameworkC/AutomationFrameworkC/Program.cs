using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Reporting;
using System;

namespace AutomationFrameworkC
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {
            clsReportManager objReport = new clsReportManager();
            objReport.fnReportPath();
            Console.ReadKey();
        }
    }
}