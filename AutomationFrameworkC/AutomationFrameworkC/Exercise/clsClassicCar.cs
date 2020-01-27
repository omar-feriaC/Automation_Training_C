using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise
{
    class clsClassicCar : ICar
    {
        //ATTRIBUTES
        public string strEngine { get; set; }
        public string strTires { get; set; }
        public string strColor { get; set; }
        public string strModel { get; set; }
        //
        public string strPlate { get; set; } // this is specifically of this class

        //CONSTRUCTOR -- this should be named equal as the class
        // la sobrecarga es tener dos constructores con el mismo nombre, uno con y otro sin parametros
        public clsClassicCar()
        {
            strEngine = "";
            strTires = "";
            strColor = "";
            strModel = "";
            strPlate = "";
        }

        public clsClassicCar(string pstrEngine, string pstrTires, string pstrColor, string pstrModel, string pstrPlate)
        {
            strEngine = pstrEngine;
            strTires = pstrEngine;
            strColor = pstrColor;
            strModel = pstrModel;
            strPlate = pstrPlate;
        }


        //METHODS
        public void fnBrake()
        {
            Console.WriteLine("This is ClassicCar_fnBrake");
        }

        public void fnCalculateKM()
        {
            Console.WriteLine("This is ClassicCar_fnCalculateKM");
        }

        public void fnParking()
        {
            Console.WriteLine("This is ClassicCar_fnParking");
        }

        public void fnStart()
        {
            Console.WriteLine("This is ClassicCar_fnStart");
        }

        // SPECIFIC METHOD FOR clsClassicCar
        public void fnDisplayInfo()
        {
            Console.WriteLine("strEngine " + strEngine);
            Console.WriteLine("strEngine " + strTires);
            Console.WriteLine("strEngine " + strColor);
            Console.WriteLine("strEngine " + strModel);
            Console.WriteLine("strEngine " + strPlate);
        }
    }
}
