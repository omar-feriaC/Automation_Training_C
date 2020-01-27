using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Animals
{
    class clsDogs : clsAnimals
    {
        //Attributes
        public string strEnvironment { get; set; }
        public string strDogCategory { get; set; }
        public int intAvAge { get; set; }

        //Constructor
        public clsDogs () {}  //empty constructor

        public clsDogs(string pstrEnvironment, string pstrDogCategory, int pintAvAge, string pstrType, string pstrName, string pstrSound, string pstrSize, string pstrGender)
        {
            strEnvironment = pstrEnvironment;
            strDogCategory = pstrDogCategory;
            intAvAge = pintAvAge;
            strType = pstrType;
            strName = pstrName;
            strSound = pstrSound;
            strSize = pstrSize;
            strGender = pstrGender;
        }

        //Functions

        public void fnDisplayInfo()
        {
            //attributes inhenerit from cslAnimals
            Console.WriteLine("clsDog inhen from clsAnimals strType " + strType);
            Console.WriteLine("clsDog inhen from clsAnimals strName " + strName);
            Console.WriteLine("clsDog inhen from clsAnimals strSound " + strSound);
            Console.WriteLine("clsDog inhen from clsAnimals strSize " + strSize);
            Console.WriteLine("clsDog inhen from clsAnimals strGender " + strGender);
            //the ones from clsDOG
            Console.WriteLine("clsDog strEnvironment " + strEnvironment);
            Console.WriteLine("clsDog strDogCategory " + strDogCategory);
            Console.WriteLine("clsDog intAvAge " + intAvAge);


        }

    }
}
