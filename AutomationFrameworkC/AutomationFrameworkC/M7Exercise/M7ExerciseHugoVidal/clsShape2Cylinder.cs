using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.M7ExerciseHugoVidal
{
    class clsShape2Cylinder : clsShape3D
    {
        //Attributes specificallt for Cilinder
        public double dblRadio { get; set; }
        public double dblAltura { get; set; }
        private double dblPi = 3.1416;

        //Constructor
        public clsShape2Cylinder() { }

        public clsShape2Cylinder(string pstrName, double pdblRadio, double pdblAltura)
        {
            dblRadio = pdblRadio;
            dblAltura = pdblAltura;
            strName = pstrName;
        }

        //Methods
        public double fnCalculateCylinderVolume()
        {
            dblVolume = (((dblPi) * ((dblRadio) * (dblRadio))) * (dblAltura)) ;  // 
            return dblVolume;
        }

        // here i am reusing the method to display the info
        // but since i am modifying the method, i am using "new"
        public new void fnDisplayInfo()
        {
            Console.WriteLine("We are displaying the info for Shape2");
            Console.WriteLine("the Name of Shape2 is: " + strName);
            Console.WriteLine("the Value of the Radio is: " + dblRadio);
            Console.WriteLine("the Value of the Height is: " + dblAltura);
            Console.WriteLine("the Volume is: " + dblVolume);
        }

    }
}
