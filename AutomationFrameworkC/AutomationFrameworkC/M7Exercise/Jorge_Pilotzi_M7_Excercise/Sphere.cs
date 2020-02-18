using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.M7Exercise.Jorge_Pilotzi_M7_Excercise
{
    class Sphere : _3DShape , IShape
    {
        // Atributes
        string strName = "Sphere";
        double dblRadio { get; set; }
        double dblPI = 3.141592;
        double dblVolume;
        double dblArea;

        //Constructors
        public Sphere() 
     {
        strName = "Sphere";
        dblRadio = 0;

     }

    public Sphere(double pdblRadio)
    {
        strName = "Sphere";
        dblRadio = pdblRadio;
    }

        //Method
        private double CalcArea()
        {
            dblArea = 4 * dblPI * dblRadio * dblRadio;
            return dblArea;
        }

        private double CalcVolume()
        {
            dblVolume = (4.0 / 3) * dblPI * dblRadio * dblRadio * dblRadio;
            return dblVolume;
        }

        public void DisplayInfoSphere()
        {
            Console.WriteLine("Name: " + strName);
            Console.WriteLine("Area: " + CalcArea());
            Console.WriteLine("Volume: " + CalcVolume());

        }

    }
}
