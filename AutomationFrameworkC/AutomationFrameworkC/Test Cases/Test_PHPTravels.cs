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
            #region STEP [0] - PRE REQUIRED Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);
            objPHP = new clsPHPTravels_LoginPage(objDriver);
            #endregion STEP [0] - PRE REQUIRED Init objects
            #region STEP [1] - Open the Website to Login
            Assert.AreEqual(true, objDriver.Title.Contains("Administator Login"), "The Login Page was not loaded correctly.");
            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "STEP [1] - Open the Website to Login", "PageToLogin.png", "Pass");
            #endregion STEP [1] - Open the Website to Login
            #region STEP [2] - Provide Username and Password in the Input fields
            objPHP.fnEnterEmail(strUser);
            objPHP.fnEnterPassword(strPass);
            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "STEP [2] - Provide Username and Password in the Input fields", "UserNameAndPassword.png", "Pass");
            objPHP.fnClickLoginButton();
            objPHP.fnWaitHamburgerMenu();
            Assert.AreEqual(true, objDriver.Title.Contains("Dashboard"), "The Dashboard was not loaded correctly.");
            #endregion STEP [2] - Provide Username and Password in the Input fields
            #region STEP [3] - Verify the Login Page is the one expected
            objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "STEP [3] - Verify the Login Page is the one expected", "LoginPageEvidence.png", "Pass");
            #endregion STEP [3] - Verify the Login Page is the one expected
            #region STEP [4] - Get the Values of the Stats
            string strListOfStats = objPHP.fnPrintTheListOfStatus();
            objRM.fnAddStepLog(objTest, "STEP [4] Get the Values of the Stats: <br/>\r\n" + strListOfStats, "Pass");
            #endregion STEP [4] - Get the Values of the Stats
        }
        [Test, Order(1)]
        public void Test_M9ExercisePart2_MenuSubMenu_OrderBy()
        {
            #region STEP [0] - PRE REQUIRED Init objects
            objTest = objExtent.CreateTest(TestContext.CurrentContext.Test.Name);//We Specify the name of the test case
            objPHP = new clsPHPTravels_LoginPage(objDriver); //Initialization of an OBJECT of the PHPTravelLogin  class
            int intAmountOfMenu = arrMenu.Length; //Get amount of values in the array "arrMenu"
            int intAmountOfSubMenu = arrSubMenu.Length; //Get amount of values in the array "arrSubMenu"
            #endregion STEP [0] - PRE REQUIRED Init objects
            #region STEP [1] - Complete Login
            objPHP.fnCompleteLogin(strUser, strPass);
            objRM.fnAddStepLog(objTest, "STEP [1] Success Login.", "Pass");
            #endregion STEP [1] - Complete Login
            #region  STEP [2, 3, 4, 5] - Click on Menu/ SubMenu/ Manipulate The Table
            for (int i = 0; i < intAmountOfMenu; i++) //this will be done based on the amount of the SubMenus in the array "arrMenu"
            {
                objPHP.fnEnterAtMenu(arrMenu[i]);// Click on the Menu Specified in the array "arrMenu"
                objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "STEP [2] Click in Menu " + arrMenu[i], "Menu_" + arrMenu[i] + ".png", "Pass");
                #region STEP [3, 4, 5] - Click on SubMenu 
                for (int j = 0; j < intAmountOfSubMenu; j++) //this will be done based on the amount of the SubMenus in the array "arrSubMenu"
                {
                    objPHP.fnEnterAtSubMenu(arrSubMenu[j], arrWebsiteTitles[j]);// Click on the Menu Specified in the array "arrSubMenu"
                    objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "STEP [3] Click in SubMenu " + arrSubMenu[j], "SubMenu_" + arrSubMenu[j] + ".png", "Pass");
                    #region STEP [4, 5] - HEADERS OF TABLE
                    for (int e = 0; e < objPHP.fnAmountofHeaders(); e++)
                    {
                        #region Elements to run NEXT STEPS
                        int a = e + 1;
                        string strHeaderLable;
                        string strNameIndex = arrMenu[i] + "_" + arrSubMenu[j] + "_" + a; // Concatenate to generate the title of the Test Step
                        strHeaderLable = objPHP.fnGetTheHeaderName(a); // Obtain the Text at the Table Header
                        #endregion Elements to run NEXT STEPS
                        #region STEP [4] - Validate the Ascendant Order
                        objPHP.fnClickTheHeader(a); //Click the Header 
                        objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "STEP [4]_" + strNameIndex + " Ascendent " + strHeaderLable, "ASC_" + strNameIndex + strHeaderLable + ".png", "Pass");
                        objPHP.fnValidateAscOrder(); //Validate if the Order is Ascendant
                        objDriver.SwitchTo().DefaultContent();
                        #endregion STEP [4] - Validate the Ascendant Order
                        #region STEP [5] - Validate the Descendant Order
                        objPHP.fnClickTheHeader(a);
                        objRM.fnAddStepLogWithSnapshot(objTest, objDriver, "STEP [5]_" + strNameIndex + " Descendent " + strHeaderLable, "DESC_" + strNameIndex + strHeaderLable + ".png", "Pass");
                        objPHP.fnValidateDescOrder();
                        objDriver.SwitchTo().DefaultContent();
                        #endregion STEP [5] - Validate the Descendant Order
                    }
                    #endregion STEP [4, 5] - HEADERS OF TABLE
                    objPHP.fnEnterAtMenu(arrMenu[i]);//We need to re click the Menu where we are, so we can access to next SubMenu
                }
                #endregion STEP [3, 4, 5] - Click on SubMenu 
            }
            #endregion STEP [2, 3, 4, 5] - Click on Menu/ SubMenu/ Manipulate The Table
        }
    }
}