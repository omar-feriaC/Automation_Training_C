using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace AutomationFrameworkC.Test_Cases
{
    class Test_PHPTravels : BaseTest
    {
        //VARIABLES
        string[] arrSubMenu = { "ADMINS", "SUPPLIERS", "CUSTOMERS", "GUESTCUSTOMERS"};
        string[] arrWebsiteTitles = { "Admins Management", "Suppliers Management", "Customers Management", "Guest Management" };
        clsPHPTravels_LoginPage objPHP;
        [Test, Order(0)]
        public void Test_M9ExercisePart1()
        {
            //Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objPHP = new clsPHPTravels_LoginPage(objDriver);
            //Login Action
            objRM.fnAddStepLog(objTest, "Before Login.", "Pass");
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            objPHP.fnEnterEmail(strUser);
            objPHP.fnEnterPassword(strPass);
            objPHP.fnClickLoginButton();
            objPHP.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            //Printing in the Report the List Value
            for (int j = 0; j < objPHP.fnCountStatsList(); j++)
            {
                objRM.fnAddStepLog(objTest, objPHP.fnCheckStatsList(j), "Pass");
            }
            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "LoginEvidence.png", "Pass");
        }
        [Test, Order(1)]
        public void Test_M9ExercisePart2()
        {
            //Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objPHP = new clsPHPTravels_LoginPage(objDriver);

            objPHP.fnEnterEmail(strUser);
            objPHP.fnEnterPassword(strPass);
            objPHP.fnClickLoginButton();
            objPHP.fnWaitHamburgerMenu();
            //Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            int intAmountOfSubMenu = objPHP.fnAmountofSubmenus(arrSubMenu); //Amount of submenus specified 
            int intAmountOfHeaders = objPHP.fnAmountofHeaders();//Amount of headers in the table 
            objPHP.fnActivateTheMenu();
            objRM.fnAddStepLog(objTest, "After Login.", "Pass");
            for (int i = 0; i < intAmountOfSubMenu; i++) //Manipulate the Menu
            {
                objPHP.fnEnterAtMenuSubMenu(strMenu, arrSubMenu, arrWebsiteTitles, i);
                for (int e = 0; e < objPHP.fnAmountofHeaders(); e++)//Manipulate the headers of the tables
                {
                    int a = e + 1;
                    string strNameIndex = strMenu + "_" + arrSubMenu + "_" + a;
                    objPHP.fnClickTheHeader(a);//Check each of the headers
                    objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "Ascendent."+ strNameIndex, "ASC_" + strNameIndex + ".png", "Pass");
                    objPHP.fnAscOrder();
                    objDriver.SwitchTo().DefaultContent();
                    objPHP.fnClickTheHeader(a);
                    objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "Descentent." + strNameIndex, "DESC_" + strNameIndex + ".png", "Pass");
                    objPHP.fnDescOrder();
                    objDriver.SwitchTo().DefaultContent();
                }
            }
        }
    }
}