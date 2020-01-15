using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkC.Exercise
{
    class clsClassicCar : ICar
    {
        //Attributes
        public string strEngine { get; set; }
        public string strTires { get; set; }
        public string strColor { get; set; }
        public string strModel { get; set; }
        public string strPlate { get; set; }

        //Constructor
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
            strTires = pstrTires;
            strColor = pstrColor;
            strModel = pstrModel;
            strPlate = pstrPlate;
        }

        //Methods
        public void fnBrake()
        {
            Console.WriteLine("ClassicCar_fnBrake: ");
        }

        public void fnCalculateKM()
        {
            Console.WriteLine("ClassicCar_fnCalculateKM");
        }

        public void fnParking()
        {
            Console.WriteLine("ClassicCar_fnParking");
        }

        public void fnStart()
        {
            Console.WriteLine("ClassicCar_fnStart");
        }

        public void fnDisplayInfo()
        {
            Console.WriteLine("ClassicCar_fnDisplayInfo");
            Console.WriteLine("strEngine: " + strEngine);
            Console.WriteLine("strTires: " + strTires);
            Console.WriteLine("strColor: " + strColor);
            Console.WriteLine("strModel: " + strModel);
            Console.WriteLine("strPlate: " + strPlate);
        }


    }
}
