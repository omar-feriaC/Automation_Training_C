using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.BaseFiles;
using AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.Page_Objects;
using AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise.Test_Cases;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationFrameworkC.Jorge_Pilotzi_M8_Excercise
{
    class Program : BaseTest
{
    static void Main(string[] args)
    {
        SetUp();
        Linkedin_Login objLogin = new Linkedin_Login(driver);
        Linkedin_Login.FnGetUserNameField(ConfigurationManager.AppSettings.Get("username"));
        Linkedin_Login.FnGetPassword(ConfigurationManager.AppSettings.Get("password"));
        Linkedin_Login.FnGetSignInBtn();
        Console.ReadKey();
    }
}
}
