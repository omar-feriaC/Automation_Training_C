using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Test_Cases
{
    class Test_MercuryTours : BaseTest
    {
       
        //Init Objects
        clsMercury_loginPage objLogin;// = new clsMercury_loginPage(objDriver);  //since we inheret from BaseTest objDriver is reused
        clsMercury_RegisterPage objRegister;

        //Test
        //[Test, Order(0)]
        //public void fnLogin_MercuryTours()
        //{
        //    objLogin = new clsMercury_loginPage(objDriver);
        //    clsMercury_loginPage.fnUserName("user");
        //    clsMercury_loginPage.fnPassword("pass");
        //    clsMercury_loginPage.fnClickSignIn();
        //    Console.WriteLine("Test The text");
        //    Assert.Fail();
        //}

        //public void fnLogin_MercuryTours()
        //{
        //    objLogin = new clsMercury_loginPage(objDriver); //Initialization of Driver
        //    clsMercury_loginPage.fnLoginPage(strUser, strPass); // i can use those strUser, strPass because i inherenit
        //}

        [Test, Order(1)]
        public void fnRegister_MercuryTours ()
        {
            objRegister = new clsMercury_RegisterPage(objDriver); //we use the objDriver from BaseTest
            objDriver.Url = "http://newtours.demoaut.com/mercuryregister.php";
            clsMercury_RegisterPage.fnRegisterPage(strUser, strPass);
        }

        [Test, Order(1)]
        public void fnRegister_MercuryTours2()
        {
            objRegister = new clsMercury_RegisterPage(objDriver); //we use the objDriver from BaseTest
            objDriver.Url = "http://newtours.demoaut.com/mercuryregister.php";
            var plist = new List<string> { "value1","value2"}; //creating an object of list type
            clsMercury_RegisterPage.fnRegisterPageList(plist);
        }
    }
}
