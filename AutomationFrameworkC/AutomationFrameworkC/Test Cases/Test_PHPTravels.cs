using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.Page_Objects;
using NUnit.Framework;
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
            string strListOfStats = objPHP.fnPrintTheListOfStatus();
            objRM.fnAddStepLog(objTest, strListOfStats, "Pass");
            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "After Login.", "LoginEvidence.png", "Pass");
        }
        [Test, Order(1)]
        public void Test_M9ExercisePart2_MenuSubMenu_OrderBy()
        {
            //Init objects and elements needed before start the test
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);//We Specify the name of the test case
            objPHP = new clsPHPTravels_LoginPage(objDriver); //Initialization of an OBJECT of the PHPTravelLogin  class
            int intAmountOfMenu = arrMenu.Length; //Get amount of values in the array "arrMenu"
            int intAmountOfSubMenu = arrSubMenu.Length; //Get amount of values in the array "arrSubMenu"
            //STEP [1] - Login
            objPHP.fnCompleteLogin(strUser, strPass);
            objRM.fnAddStepLog(objTest, "After Success Login.", "Pass");
            //STEP [2] - Click on Menu, this will be done based on the amount of the SubMenus in the array "arrMenu"
            for (int i = 0; i < intAmountOfMenu; i++)
            {
                objPHP.fnEnterAtMenu(arrMenu[i]);// Click on the Menu Specified in the array "arrMenu"
                objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "Click in Menu " + arrMenu[i], "Menu_" + arrMenu[i] + ".png", "Pass");
                //STEP [3] - Click on SubMenu, this will be done based on the amount of the SubMenus in the array "arrSubMenu"
                for (int j = 0; j < intAmountOfSubMenu; j++)
                {
                    objPHP.fnEnterAtSubMenu(arrSubMenu[j], arrWebsiteTitles[j]);// Click on the Menu Specified in the array "arrSubMenu"
                    objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "Click in SubMenu " + arrSubMenu[j], "SubMenu_" + arrSubMenu[j] + ".png", "Pass");
                    //STEP [4] - Manipulate the Headers at table
                    for (int e = 0; e < objPHP.fnAmountofHeaders(); e++)
                    {
                        int a = e + 1;
                        string strNameIndex = arrMenu[i] + "_" + arrSubMenu[j] + "_" + a; // Concatenate to generate the title of the Test Step
                        //STEP [5] - Validate the Ascendant Order
                        objPHP.fnClickTheHeader(a);
                        objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "Ascendent." + strNameIndex, "ASC_" + strNameIndex + ".png", "Pass");
                        objPHP.fnValidateAscOrder();
                        objDriver.SwitchTo().DefaultContent();
                        //STEP [6] - Validate the Descendant Order
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