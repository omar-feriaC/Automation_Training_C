using AutomationFrameworkC.Base_Files;
using AutomationFrameworkC.M7Exercise.M7Exercise_SaulGarcia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.M7Exercise_SaulGarcia
{
    class clsTetraedrom : cls3D_Shape
    {
        
        //Attributes
        public string StrName { get; set; }
        public double DblVolume { get; set; }
        public double DblBaseArea { get; set; }
        public double DblPerimeter { get; set; }


        //Constructor
        public clsTetraedrom() { }

        public clsTetraedrom(string pstrName, double pdblVolume, double pdblBaseArea, double pdblPerimeter)
        {
            StrName = pstrName;
            DblVolume = pdblVolume;
            DblBaseArea = pdblBaseArea;
            DblPerimeter = pdblPerimeter;
         }

        //Methods
        public void FnDisplayInfo()
        {
            Console.WriteLine("strName: " + StrName);
            Console.WriteLine("dblVolume: " + DblVolume);
            Console.WriteLine("dblBaseArea: " + DblBaseArea);
            Console.WriteLine("dblPerimeter: " + DblPerimeter);
        }
    }
}
