using AutomationFrameworkC.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Page_Objects
{
    class clsPHPTravels_DashboardPage : BaseTest
    {
        #region variables
        /*ATTRIBUTES*/
        public static WebDriverWait _objDriverWait;
        private static clsDriver objClsDriver = new clsDriver(objDriver); // initializing this object
        #endregion variables
        #region Constructor
        /*CONSTRUCTOR*/
        public clsPHPTravels_DashboardPage(IWebDriver pobjDriver)
        {
            objDriver = pobjDriver;
            _objDriverWait = new WebDriverWait(objDriver, new TimeSpan(0, 0, 40));
        }
        #endregion Constructor
        #region Elements
        /*LOCATORS DESCRIPTION*/
        readonly static string STR_STATS_LIST = "//div/ul[@class='serverHeader__statsList']/li/a";
        /*OBJECT DEFINITION*/
        private static IList<IWebElement> objStatsList => objDriver.FindElements(By.XPath(STR_STATS_LIST));
        #endregion Elements
        #region Methods
        /*METHODS/FUNCTIONS*/
        public static void fnCheckStatsList()
        {
            for (int j = 0; j < objStatsList.Count; j++)
            {
                Console.WriteLine(objStatsList[j].Text);
            }
        }
        

        #endregion Methods
    }
}
