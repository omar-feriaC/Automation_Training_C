using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise2
{
    class clsDogs : clsAnimals
    {
        //Attributes
        public string strEnvironment {get; set;}
        public string strDogCategory {get; set;}
        public int intAvgAge {get; set; }

        //Constructor
        public clsDogs() { }

        public clsDogs(string pstrType, string pstrName, string pstrSound, string pstrSize, string pstrGender, string pstrEnvironment, string pstrDogCategory, int pintAvgAge)
        {
            strType = pstrType;
            strName = pstrName;
            strSound = pstrSound;
            strSize = pstrSize;
            strGender = pstrGender;
            strEnvironment = pstrEnvironment;
            strDogCategory = pstrDogCategory;
            intAvgAge = pintAvgAge;
        }

        //Methods
        public void fnDisplayInfo()
        {
            Console.WriteLine("strType: " + strType); 
            Console.WriteLine("strName: " + strName);
            Console.WriteLine("strSound: " + strSound);
            Console.WriteLine("strSize: " + strSize);
            Console.WriteLine("strGender: " + strGender);
            Console.WriteLine("strEnvironment: " + strEnvironment);
            Console.WriteLine("strDogCategory: " + strDogCategory);
            Console.WriteLine("intAvgAge: " + intAvgAge);
        }


    }
}
