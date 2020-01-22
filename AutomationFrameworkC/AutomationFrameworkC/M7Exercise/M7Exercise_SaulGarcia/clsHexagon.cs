using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.M7Exercise.M7Exercise_SaulGarcia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.M7Exercise_SaulGarcia
{
    class clsHexagon : cls2D_Shape
    {
        
        //Attributes
        public string StrName { get; set; }
        public double DblArea { get; set; }
        public double DblPerimeter { get; set; }


        //Constructor
        public clsHexagon() { }

        public clsHexagon(string pstrName, double pdblArea, double pdblPerimeter)
        {
            StrName = pstrName;
            DblArea = pdblArea;
            DblPerimeter = pdblPerimeter;
        }

        //Methods
        public void FnDisplayInfo()
        {
            Console.WriteLine("strName: " + StrName);
            Console.WriteLine("dblArea: " + DblArea);
            Console.WriteLine("dblPerimeter: " + DblPerimeter);
        }
    }
}

