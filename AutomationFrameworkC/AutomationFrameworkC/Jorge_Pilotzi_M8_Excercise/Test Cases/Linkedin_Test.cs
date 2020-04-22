using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.BaseFiles;
using AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.Test_Cases
{
    class Linkedin_Test : BaseTest 
    {
        Linkedin_Login objLoginPage;
        
        [Test]
        public void Linkedin_LoginPage()
        {
            driver.Manage().Window.Maximize();
            objLoginPage = new Linkedin_Login(driver);
            Assert.AreEqual(true, driver.Title.Contains("Login"), "Title Don't mach");
            Linkedin_Login.FnGetUserNameField(ConfigurationManager.AppSettings.Get("username"));
            Linkedin_Login.FnGetPassword(ConfigurationManager.AppSettings.Get("password"));
            Linkedin_Login.FnGetSignInBtn();

        }
    }
}
