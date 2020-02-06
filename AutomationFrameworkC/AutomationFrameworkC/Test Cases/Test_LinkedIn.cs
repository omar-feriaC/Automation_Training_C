using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;

namespace AutomationFrameworkC.Test_Cases
{
    class Test_LinkedIn : BaseTest
    {
        public static LinkedIn_LoginPage objLogin;
        WebDriverWait _objDriverWait;

        [Test]
        public void LinkedIn_Login()
        {
            try
            {
                _objDriverWait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 10));
                objLogin = new LinkedIn_LoginPage(objDriver);

                objDriver.Manage().Window.Maximize();
                objLogin.FnEnterUsername(strUser);
                objLogin.FnEnterPassword(strPass);
                objLogin.FnClickSignInButton();
                _objDriverWait.Until(ExpectedConditions.UrlContains("feed"));
                Assert.AreEqual("https://www.linkedin.com/feed/", objDriver.Url);
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Test Case Failed.");
                
            }
            
            finally
            {
                Console.WriteLine("Test case successfully executed");
            }
        }
    }
}
  
