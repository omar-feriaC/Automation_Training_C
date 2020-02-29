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
        #region VARIABLES
        string[] arrMenu = { "ACCOUNTS" };
        string[] arrSubMenu = { "ADMINS", "SUPPLIERS", "CUSTOMERS", "GUESTCUSTOMERS"};
        string[] arrWebsiteTitles = { "Admins Management", "Suppliers Management", "Customers Management", "Guest Management" };

        
        clsPHPTravels_LoginPage objPHP; //Initialization to use it as an object of PHPLogin class
        #endregion VARIABLES

        [Test, Order(0)]
        public void Test_M9ExercisePart1_Login()
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
        #region 1
        //public void XTest_M9ExercisePart2_MenuSubMenu_OrderBy()
        //{
        //    //Init objects
        //    objPHP = new clsPHPTravels_LoginPage(objDriver);
        //    objPHP.fnCompleteLogin(strUser, strPass); //Login Before start the test
        //    objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
        //    objRM.fnAddStepLog(objTest, "After Login.", "Pass");
        //    int intAmountOfMenu = objPHP.fnAmountofSubmenus(arrMenu); //Amount of MENUS to test
        //    for (int i = 0; i < intAmountOfMenu; i++) //Do based on the Amount of MENUS
        //    {
        //        int intAmountOfSubMenu = objPHP.fnAmountofSubmenus(arrSubMenu); //Amount of SUBMENUS specified 
        //        for (int j = 0; j < intAmountOfSubMenu; j++) //Do based on the Amount of SUBMENUS
        //        {
        //            objPHP.fnEnterAtMenuSubMenu(arrMenu[j], arrSubMenu, arrWebsiteTitles, j);
        //            int intAmountOfHeaders = objPHP.fnAmountofHeaders();//Amount of headers in the table 
        //            for (int e = 0; e < objPHP.fnAmountofHeaders(); e++)//Manipulate the headers of the tables
        //            {
        //                int a = e + 1;
        //                string strNameIndex = arrMenu[j] + "_" + arrSubMenu + "_" + a;
        //                objPHP.fnClickTheHeader(a);//Check each of the headers
        //                objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "Ascendent."+ strNameIndex, "ASC_" + strNameIndex + ".png", "Pass");
        //                objPHP.fnAscOrder();
        //                objDriver.SwitchTo().DefaultContent();
        //                objPHP.fnClickTheHeader(a);
        //                objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "Descentent." + strNameIndex, "DESC_" + strNameIndex + ".png", "Pass");
        //                objPHP.fnDescOrder();
        //                objDriver.SwitchTo().DefaultContent();
        //            }
        //        }
        //    }
        //}
        #endregion 1
        public void Test_M9ExercisePart2_MenuSubMenu_OrderBy()
        {
            //Init objects
            objPHP = new clsPHPTravels_LoginPage(objDriver);
            objPHP.fnCompleteLogin(strUser, strPass); //Login Before start the test
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objRM.fnAddStepLog(objTest, "After Login.", "Pass");

            int intAmountOfMenu = arrMenu.Length;
            
            int intAmountOfHeaders = objPHP.fnAmountofHeaders();//Amount of headers in the table 

            for (int i = 0; i < intAmountOfMenu; i++) //Do based on the Amount of MENUS
            {

                objPHP.fnEnterAtMenu(arrMenu[i]);// Click in the Menu
                objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Click in Menu" + arrMenu[i], "Menu_" + arrMenu[i] + ".png", "Pass");

                int intAmountOfSubMenu = arrSubMenu.Length;

                for (int j = 0; j < intAmountOfSubMenu; j++) //Do based on the Amount of SUBMENUS
                {
                    objPHP.fnEnterAtSubMenu(arrSubMenu[j], arrWebsiteTitles[j]);
                    objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Click in SubMenu" + arrSubMenu[j], "SubMenu_" + arrSubMenu[j] + ".png", "Pass");
                    for (int e = 0; e < objPHP.fnAmountofHeaders(); e++)//Manipulate the headers of the tables
                    {
                        int a = e + 1;
                        string strNameIndex = arrMenu[i] + "_" + arrSubMenu[j] + "_" + a;
                        objPHP.fnClickTheHeader(a);//Check each of the headers
                        objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "Ascendent." + strNameIndex, "ASC_" + strNameIndex + ".png", "Pass");
                        objPHP.fnValidateAscOrder();
                        objDriver.SwitchTo().DefaultContent();
                        objPHP.fnClickTheHeader(a);
                        objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "Descendent." + strNameIndex, "DESC_" + strNameIndex + ".png", "Pass");
                        objPHP.fnValidateDescOrder();
                        objDriver.SwitchTo().DefaultContent();
                    }
                    objPHP.fnEnterAtMenu(arrMenu[i]);
                }
            }
        }
    }
}